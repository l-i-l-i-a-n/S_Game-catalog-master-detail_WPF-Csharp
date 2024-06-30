using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele;

namespace Donnees
{
    public class Stub : IPersistanceManager
    {
        public ObservableCollection<Jeu> ChargerJeux()
        {
            List<String> genres_overwatch = new List<String>();
            genres_overwatch.Add("Action");
            genres_overwatch.Add("Multijoueur");
            List<String> plateformes_overwatch = new List<String>();
            plateformes_overwatch.Add("Xbox One");
            plateformes_overwatch.Add("PlayStation 4");
            plateformes_overwatch.Add("PC");

            List<String> genres_wow = new List<String>();
            genres_wow.Add("Jeu de rôle");
            genres_wow.Add("Multijoueur");
            List<String> plateformes_wow = new List<String>();
            plateformes_wow.Add("PC");

            List<String> genres_diablo = new List<String>();
            genres_diablo.Add("Action");
            List<String> plateformes_diablo = new List<String>();
            plateformes_diablo.Add("Xbox One");
            plateformes_diablo.Add("PlayStation 4");
            plateformes_diablo.Add("Nintendo Switch");
            plateformes_diablo.Add("PC");

            return new ObservableCollection<Jeu>()
            {
                new Jeu("Overwatch", "Blizzard Entertainment", "Blizzard Entertainment", "Overwatch est un jeu vidéo de tir en vue subjective, en équipes, en ligne, développé et publié par Blizzard Entertainment. Le jeu a été annoncé le 7 novembre 2014 à la BlizzCon, et a été commercialisé le 24 mai 2016 sur Windows, PlayStation 4 et Xbox One.", new DateTime(2016, 05, 24), plateformes_overwatch, "Xbox One - PlayStation 4 - PC", genres_overwatch, "Action - Multijoueur", "/Ressources;Component/Images/pegi12.png", "pegi3.png", "overwatch.mp4"),
                new Jeu("World of Warcraft", "Blizzard Entertainment", "Blizzard Entertainment", "World of Warcraft (abrégé WoW) est un jeu vidéo de type MMORPG (jeu de rôle en ligne massivement multijoueur) développé par la société Blizzard Entertainment. C'est le 4e jeu de l'univers médiéval-fantastique Warcraft, introduit par Warcraft: Orcs and Humans en 1994. World of Warcraft prend place en Azeroth, près de quatre ans après les événements de la fin du jeu précédent, Warcraft III: The Frozen Throne1 Blizzard Entertainment annonce World of Warcraft le 2 septembre 20012. Le jeu est sorti en Amérique du Nord le 23 novembre 2004, pour les 10 ans de la franchise Warcraft.", new DateTime(2004, 11, 23), plateformes_wow, "PC", genres_wow, "Jeu de rôle - Multijoueur", "/Ressources;Component/Images/pegi12.png", "pegi3.png", "wow.mp4"),
                new Jeu("Diablo III", "Activision Blizzard", "Blizzard Entertainment", "Diablo III est un jeu vidéo d'action et de rôle de type hack and slash développé par Blizzard Entertainment. Il constitue le troisième opus de la série, succédant à Diablo et à Diablo II. Publié par Activision Blizzard, le jeu a bénéficié d'une sortie mondiale le 15 mai 2012. Comme ses prédécesseurs, il se déroule dans un monde imaginaire de type médiéval-fantastique dans lequel le joueur peut choisir d’incarner un sorcier, un barbare, un féticheur, un chasseur de démon ou un moine. À sa sortie, il est bien accueilli par les critiques et il connaît un important succès commercial. Le jeu s’écoule ainsi à 4,7 millions d’exemplaires le jour de sa sortie, ce qui constitue un record pour l’époque, et il a depuis dépassé les quinze millions de titres vendus. Depuis le 3 septembre 2013, le jeu est également disponible sur PlayStation 3 et Xbox 360. Le jeu a bénéficié de l'extension Reaper of Souls publiée le 25 mars 2014, qui inclut notamment une nouvelle classe de personnage (le croisé), un nouvel acte et un nouveau mode de jeu. Une compilation, baptisé Diablo III: Ultimate Evil Edition, qui regroupe le jeu original et son extension est également disponible depuis le 19 août 2014 sur PlayStation 3, PlayStation 4, Xbox 360, Xbox One, PC et MAC.", new DateTime(2012, 05, 15), plateformes_diablo, "Xbox One - PlayStation 4 - Nintendo Switch - PC", genres_diablo, "Jeu de rôle - Multijoueur", "/Ressources;Component/Images/pegi16.png", "pegi3.png", "diablo.mp4"),
            };
        }

        public void Sauvegarderjeux(ObservableCollection<Jeu> catalogue)
        {
             throw new NotImplementedException();
        }
    }
}
