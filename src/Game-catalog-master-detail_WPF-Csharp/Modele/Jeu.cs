using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Modele
{
    [Serializable]
    public class Jeu : INotifyPropertyChanged
    {
        [field:NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;
      
        private void OnPropertyChanged(String info)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }

        private String titre;

        public String Titre
        {
            get
            {
                return titre;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    titre = "Non-renseigné";
                }
                else
                {
                    titre = value;
                }
            }
        }

        private String editeur;

        public String Editeur
        {
            get
            {
                return editeur;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    editeur = "Non-renseigné";
                }
                else
                {
                    editeur = value;
                }
            }
        }

        private String developpeur;

        public String Developpeur
        {
            get
            {
                return developpeur;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    developpeur = "Non-renseigné";
                }
                else
                {
                    developpeur = value;
                }
            }
        }

        private String description;

        public String Description
        {
            get
            {
                return description;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    description = "Non-renseignée";
                }
                else
                {
                    description = value;
                }
            }
        }

        private DateTime dateSortie;

        public DateTime DateSortie
        {
            get
            {
                return dateSortie;
            }
            set
            {
                if (value == null)
                {
                    dateSortie = new DateTime(01, 01, 2001);
                }
                else
                {
                    dateSortie = value;
                }
            }
        }

        private List<String> plateformes;

        public List<String> Plateformes
        {
            get
            {
                return plateformes;
            }
            set
            {
                plateformes = value;
            }
        }

        private String plateformes_String;

        public String Plateformes_String
        {
            get
            {
                return plateformes_String;
            }
            set
            {
                plateformes_String = value;
            }
        }


        private List<String> genres;

        public List<String> Genres
        {
            get
            {
                return genres;
            }
            set
            {
                genres = value;
            }
        }

        private String genres_String;

        public String Genres_String
        {
            get
            {
                return genres_String;
            }
            set
            {
                genres_String = value;
            }
        }

        public String Chemin_Pegi { get; set; }

        public String Nom_Image { get; set; }
        public ImageSource Source_Image
        {
            get
            {
                return new BitmapImage(new Uri(System.IO.Path.GetFullPath("../../../Ressources/Images/") + Nom_Image));
            }
        }

        public String Nom_Video { get; set; }
        public Uri Source_Video
        {
            get
            {
                return new Uri(System.IO.Path.GetFullPath("../../../Ressources/Videos/") + Nom_Video);
            }
        }
        
        private ObservableCollection<String> galerie = new ObservableCollection<String>();
        public ObservableCollection<String> Galerie
        {
            get
            {
                return galerie;
            }
            set
            {
                galerie = value;
                OnPropertyChanged("Galerie");
            }
        }
        
        public override string ToString()
        {
            return $"{Titre}";
        }

        public Jeu(String titre, String editeur, String developpeur, String description, DateTime datesortie, List<String> plateformes, String plateformes_string, List<String> genres, String genres_string, String chemin_pegi, String nom_image, String nom_video)
        {
            Titre = titre;
            Editeur = editeur;
            Developpeur = developpeur;
            Description = description;
            DateSortie = datesortie;
            Plateformes = plateformes;
            Plateformes_String = plateformes_string;
            Genres = genres;
            Genres_String = genres_string;
            Chemin_Pegi = chemin_pegi;
            Nom_Image = nom_image;
            Nom_Video = nom_video;
        }
    }
}
