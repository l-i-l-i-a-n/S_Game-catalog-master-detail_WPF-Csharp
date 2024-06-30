using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Modele
{
    public class CatalogueJeux
    {
        public ObservableCollection<Jeu> LesJeux { get; set; } = new ObservableCollection<Jeu>();

        public bool AjouterJeu(Jeu j)
        {
            foreach(Jeu jeu in LesJeux)
            {
                if (j.Titre.Equals(jeu.Titre))
                {
                    return false;
                }
            }
            LesJeux.Add(j);
            return true;
        }
    }
}
