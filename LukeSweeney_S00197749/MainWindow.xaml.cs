using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LukeSweeney_S00197749
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //create lists
        List<Game> filteredGames = new List<Game>();
        List<Game> allGames = new List<Game>();

        //link to database
        GameData db = new GameData();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //get all games in db
            var query = from g in db.Games
                        select g;

            //put all games into allGames list and display in listbox
            allGames = query.ToList();
            lbxGames.ItemsSource = allGames;

            //create list of all platforms and display in combo box
            List<string> allPlatforms = new List<string> {"All", "PC", "PS", "Xbox", "Switch"};
            cbxPlatform.ItemsSource = allPlatforms;
            cbxPlatform.SelectedIndex = 0;
        }
        private void lbxGames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //get selected game
            Game selectedGame = lbxGames.SelectedItem as Game;

            //if a game is selected, show details
            if(selectedGame != null)
            {
                tblkGameDetails.Text = $"{selectedGame.Name}\nPlatform: {selectedGame.Platform}\n{selectedGame.Price:C}";
                tbxGameDescription.Text = $"Description:\n\n{selectedGame.Description}";
            }
        }

        private void cbxPlatform_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //get selected platform 
            string selectedPlatform = cbxPlatform.SelectedItem.ToString();

            //switch statement to determine which games to display
            switch (selectedPlatform)
            {
                case "All":
                    lbxGames.ItemsSource = allGames;
                    break;
                case "PC":
                case "PS":
                case "Xbox":
                case "Switch":
                    var query = from g in db.Games
                                where g.Platform.Contains(selectedPlatform)
                                select g;
                    filteredGames = query.ToList();
                    break;
            }
            if(selectedPlatform != "All")
                lbxGames.ItemsSource = filteredGames;
        }
    }
}
