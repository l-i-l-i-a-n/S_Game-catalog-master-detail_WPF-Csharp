using Microsoft.Win32;
using System.IO;
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
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace Vue.Windows
{
    /// <summary>
    /// Logique d'interaction pour AddGameWindow.xaml
    /// </summary>
    public partial class AddGameWindow : Window
    {
        public bool Action { get; set; }
        public bool Combat { get; set; }
        public bool Strategie { get; set; }
        public bool Simulation { get; set; }
        public bool JeuDeRole { get; set; }
        public bool Multijoueur { get; set; }

        public bool XboxOne { get; set; }
        public bool PS4 { get; set; }
        public bool Switch { get; set; }
        public bool PC { get; set; }
        public bool IOS { get; set; }
        public bool Android { get; set; }

        public bool Pegi3 { get; set; } = true;
        public bool Pegi7 { get; set; }
        public bool Pegi12 { get; set; }
        public bool Pegi16 { get; set; }
        public bool Pegi18 { get; set; }

        public String img_sourcePath = String.Empty;
        public String img_targetPath = String.Empty;

        public String video_sourcePath = String.Empty;
        public String video_targetPath = String.Empty;

        public String Nom_Image { get; set; }
        public String Nom_Video { get; set; }

        public AddGameWindow()
        {
            InitializeComponent();
            DataContext = this;
            Import_Image.Content = "Importer une image";
            Video_Button.Content = "Importer une vidéo";
        }

        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            List<String> genres = new List<string>();
            String genres_String = Construire_Genres_String(genres);
            String chemin_Pegi = Construire_Pegi();

            List<String> plateformes = new List<string>();
            String plateformes_String = Construire_Plateformes_String(plateformes);

            if (date.SelectedDate.HasValue && !String.IsNullOrWhiteSpace(titre.Text) && !String.IsNullOrWhiteSpace(editeur.Text) && !String.IsNullOrWhiteSpace(dev.Text) && !String.IsNullOrWhiteSpace(descrip.Text) && !String.IsNullOrWhiteSpace(genres_String) && !String.IsNullOrWhiteSpace(plateformes_String) && !String.IsNullOrWhiteSpace(Nom_Image) && !String.IsNullOrWhiteSpace(Nom_Video))
            {
                if (!File.Exists(img_targetPath) && !File.Exists(video_targetPath))
                {
                    System.IO.File.Copy(img_sourcePath, img_targetPath, false);
                    System.IO.File.Copy(video_sourcePath, video_targetPath, false);
                }

                Jeu jeu = new Jeu(titre.Text, editeur.Text, dev.Text, descrip.Text, date.SelectedDate.Value, plateformes, plateformes_String, genres, genres_String,  chemin_Pegi, Nom_Image, Nom_Video);

                if ((App.Current as App).LeManager.AjouterJeu(jeu))
                {
                    MessageBox.Show("Le jeu a été ajouté");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Le jeu est déjà dans la liste");
                }
            }
            else
            {
                MessageBox.Show("Tous les champs ne sont pas remplis");
            }
        }

        private String Construire_Genres_String(List<String> genres)
        {
            String genres_String = "";

            if (Action)
            {
                genres.Add("Action");
                if (genres_String == "") genres_String += "Action";
                else genres_String += " - Action";
            }
            if (Combat)
            {
                genres.Add("Combat");
                if (genres_String == "") genres_String += "Combat";
                else genres_String += " - Combat";
            }
            if (Strategie)
            {
                genres.Add("Stratégie");
                if (genres_String == "") genres_String += "Stratégie";
                else genres_String += " - Stratégie";
            }
            if (Simulation)
            {
                genres.Add("Simulation");
                if (genres_String == "") genres_String += "Simulation";
                else genres_String += " - Simulation";
            }
            if (JeuDeRole)
            {
                genres.Add("Jeu de rôle");
                if (genres_String == "") genres_String += "Jeu de rôle";
                else genres_String += " - Jeu de rôle";
            }
            if (Multijoueur)
            {
                genres.Add("Multijoueur");
                if (genres_String == "") genres_String += "Multijoueur";
                else genres_String += " - Multijoueur";
            }
            return genres_String;
        }

        private String Construire_Plateformes_String(List<String> plateformes)
        {
            String plateformes_String = "";

            if (XboxOne)
            {
                plateformes.Add("Xbox One");
                if (plateformes_String == "") plateformes_String += "Xbox One";
                else plateformes_String += " - Xbox One";
            }
            if (PS4)
            {
                plateformes.Add("PlayStation 4");
                if (plateformes_String == "") plateformes_String += "PlayStation 4";
                else plateformes_String += " - PlayStation 4";
            }
            if (Switch)
            {
                plateformes.Add("Nintendo Switch");
                if (plateformes_String == "") plateformes_String += "Nintendo Switch";
                else plateformes_String += " - Nintendo Switch";
            }
            if (PC)
            {
                plateformes.Add("PC");
                if (plateformes_String == "") plateformes_String += "PC";
                else plateformes_String += " - PC";
            }
            if (IOS)
            {
                plateformes.Add("iOS");
                if (plateformes_String == "") plateformes_String += "iOS";
                else plateformes_String += " - iOS";
            }
            if (Android)
            {
                plateformes.Add("Android");
                if (plateformes_String == "") plateformes_String += "Android";
                else plateformes_String += " - Android";
            }
            return plateformes_String;
        }

        private String Construire_Pegi()
        {
            String chemin_pegi = "";
            if (Pegi3)
            {
                chemin_pegi = "/Ressources;Component/Images/pegi3.png";
            }
            if (Pegi7)
            {
                chemin_pegi = "/Ressources;Component/Images/pegi7.png";
            }
            if (Pegi12)
            {
                chemin_pegi = "/Ressources;Component/Images/pegi12.png";
            }
            if (Pegi16)
            {
                chemin_pegi = "/Ressources;Component/Images/pegi16.png";
            }
            if (Pegi18)
            {
                chemin_pegi = "/Ressources;Component/Images/pegi18.png";
            }
            return chemin_pegi;
        }

        private void Import_Image_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Sélectionner une image";
            dialog.Filter = "Toutes les extensions supportées |*.jpg;*.jpeg;*.png|" + "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" + "Portable Network Graphic (*.png)|*.png";
            if (dialog.ShowDialog() == true)
            {
                Import_Image.Content = String.Empty;
                image.Source = new BitmapImage(new Uri(dialog.FileName));
                Nom_Image = System.IO.Path.GetFileName(dialog.FileName);
                img_sourcePath = System.IO.Path.GetFullPath(dialog.FileName);
                img_targetPath = System.IO.Path.GetFullPath("../../../Ressources/Images/") + Nom_Image;
            }
            else
            {
                MessageBox.Show("Erreur : Veuillez choisir un fichier.");
            }
        }

        private void Import_Video_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Sélectionner une vidéo";
            dialog.Filter = "Toutes les extensions supportées |*.mp4";
            if (dialog.ShowDialog() == true)
            {
                Video_Button.Content = dialog.FileName;
                Nom_Video = System.IO.Path.GetFileName(dialog.FileName);
                video_sourcePath = System.IO.Path.GetFullPath(dialog.FileName);
                video_targetPath = System.IO.Path.GetFullPath("../../../Ressources/Videos/") + Nom_Video;
            }
            else
            {
                MessageBox.Show("Erreur : Veuillez choisir un fichier.");
            }
        }

        private void Exit_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
