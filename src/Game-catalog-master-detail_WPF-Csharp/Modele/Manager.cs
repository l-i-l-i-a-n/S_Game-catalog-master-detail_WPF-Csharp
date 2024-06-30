using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class Manager
    {
        public CatalogueJeux CatalogueJeux { get; set; }
        
        public IPersistanceManager PersistanceManager { get; set; }

        public Manager(IPersistanceManager persistanceManager)
        {
            CatalogueJeux = new CatalogueJeux();
            PersistanceManager = persistanceManager;
        }

        public void ChargerJeux()
        {
            CatalogueJeux.LesJeux = PersistanceManager.ChargerJeux();
        }

        public void SauvegarderJeux()
        {
            PersistanceManager.Sauvegarderjeux(CatalogueJeux.LesJeux);
        }

        public bool AjouterJeu(Jeu j)
        {
            return CatalogueJeux.AjouterJeu(j);
        }
    }
}
