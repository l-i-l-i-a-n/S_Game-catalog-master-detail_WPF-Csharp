using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public interface IPersistanceManager
    {
        ObservableCollection<Jeu> ChargerJeux();
        void Sauvegarderjeux(ObservableCollection<Jeu> catalogue);
    }
}
