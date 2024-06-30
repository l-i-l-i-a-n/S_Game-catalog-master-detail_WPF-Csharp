using Modele;
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
using Vue.UserControls;
using Vue.Windows;

namespace Vue
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Manager LeManager
        {
            get
            {
                return (Application.Current as App).LeManager;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            LeManager.ChargerJeux();
            DataContext = LeManager.CatalogueJeux;
            tri_box.SelectedIndex = 0;
        }

        private void FilterBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            String searchedTxt = filterBar.Text.ToLower();
            if(!searchedTxt.Equals("rechercher un jeu"))
            {
                if (tri_box.SelectedIndex == 0)
                {
                    var gameFiltered = from jeu in LeManager.CatalogueJeux.LesJeux
                                       let gtitle = jeu.Titre.ToLower()
                                       where gtitle.Contains(searchedTxt)
                                       orderby gtitle
                                       select jeu;

                    CatalogueJeux_Graph.ItemsSource = gameFiltered;
                }
                else if (tri_box.SelectedIndex == 1)
                {
                    var gameFiltered = from jeu in LeManager.CatalogueJeux.LesJeux
                                       let gtitle = jeu.Titre.ToLower()
                                       let gdate = jeu.DateSortie
                                       where gtitle.Contains(searchedTxt)
                                       orderby gdate
                                       select jeu;

                    CatalogueJeux_Graph.ItemsSource = gameFiltered;
                }
            }
        }

        private void To_AddGameWindow(object sender, RoutedEventArgs e)
        {
            AddGameWindow window = new AddGameWindow();
            window.ShowDialog();
            tri_box_SelectionChanged(this, null);
        }

        private void FilterBar_GotFocus(object sender, RoutedEventArgs e)
        {
            if (filterBar.Text.Equals("Rechercher un jeu"))
            {
                filterBar.Text = "";
            }
        }

        private void FilterBar_LostFocus(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(filterBar.Text))
            {
                filterBar.Text = "Rechercher un jeu";
            }
        }

        private void tri_box_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (tri_box.SelectedIndex == 0)
            {
                var gameFiltered = from jeu in LeManager.CatalogueJeux.LesJeux
                                   let gtitle = jeu.Titre
                                   orderby gtitle
                                   select jeu;

                CatalogueJeux_Graph.ItemsSource = gameFiltered;
            }
            else if (tri_box.SelectedIndex == 1)
            {
                var gameFiltered = from jeu in LeManager.CatalogueJeux.LesJeux
                                   let gdate = jeu.DateSortie
                                   orderby gdate descending
                                   select jeu;

                CatalogueJeux_Graph.ItemsSource = gameFiltered;
            }
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LeManager.SauvegarderJeux();
        }

        private void CatalogueJeux_Graph_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            App.jeuSelect = CatalogueJeux_Graph.SelectedItem as Jeu;
        }
    }
}
