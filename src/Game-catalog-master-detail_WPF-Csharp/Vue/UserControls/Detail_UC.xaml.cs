using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using Vue.Windows;

namespace Vue.UserControls
{
    /// <summary>
    /// Logique d'interaction pour Detail_UC.xaml
    /// </summary>
    public partial class Detail_UC : UserControl
    {
        public Detail_UC()
        {
            InitializeComponent();
            Video.Pause();
            Video_Placeholder_Textblock.Text = "Regarder la bande-annonce";
        }

        private void Play_Button_Click(object sender, RoutedEventArgs e)
        {
            Video.Play();
            Video_Placeholder_Textblock.Text = String.Empty;
        }

        private void Pause_Button_Click(object sender, RoutedEventArgs e)
        {
            Video.Pause();
        }

        private void Fullscreen_Button_Click(object sender, RoutedEventArgs e)
        {
            Video.Pause();
            VideoPlayerWindow w = new VideoPlayerWindow(Video.Source, Video.Position);
            w.ShowDialog();
        }

        private void VolumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Video.Volume = (double)volumeSlider.Value;
        }

        private void MuteVolume_Button_Click(object sender, RoutedEventArgs e)
        {
            volumeSlider.Value = 0;
        }

        private void AjoutImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Sélectionner une image";
            dialog.Filter = "Toutes les extensions supportées |*.jpg;*.jpeg;*.png|" + "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" + "Portable Network Graphic (*.png)|*.png";
            if (dialog.ShowDialog() == true)
            {
                string Nom_Image = System.IO.Path.GetFileName(dialog.FileName);
                string sourcePath = System.IO.Path.GetFullPath(dialog.FileName);
                string targetPath = System.IO.Path.GetFullPath("../../../Ressources/Images/") + Nom_Image;
                if (!File.Exists(targetPath))
                {
                    try
                    {
                        System.IO.File.Copy(sourcePath, targetPath, false);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erreur lors de la copie du fichier");
                        return;
                    }
                    App.jeuSelect.Galerie.Add(System.IO.Path.GetFullPath(targetPath));
                }
                else
                {
                    MessageBox.Show("Erreur : Ce fichier est déjà utilisé par un autre jeu.");
                }
            }
            else
            {
                MessageBox.Show("Erreur : Veuillez choisir un fichier.");
            }
        }
    }
}
