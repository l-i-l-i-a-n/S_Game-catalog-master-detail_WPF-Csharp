using Modele;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Donnees
{
    public class Deserializer : IPersistanceManager
    {
        private BinaryFormatter formatter;

        public ObservableCollection<Jeu> ChargerJeux()
        {
            ObservableCollection<Jeu> jeux = new ObservableCollection<Jeu>();
            formatter = new BinaryFormatter();

            if (File.Exists("../../../Donnees/donnees.bin"))
            {
                try
                {
                    FileStream fe = new FileStream("../../../Donnees/donnees.bin", FileMode.Open, FileAccess.Read);
                    jeux = (ObservableCollection<Jeu>)formatter.Deserialize(fe);
                    fe.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erreur de chargement des données.");
                }
            }
            else
            {
                MessageBox.Show("Erreur de chargement des données. Fichier non-trouvé.");
            }

            return jeux;
        }

        public void Sauvegarderjeux(ObservableCollection<Jeu> catalogue)
        {
            formatter = new BinaryFormatter();

            try
            {
                FileStream fs = new FileStream("../../../Donnees/donnees.bin", FileMode.OpenOrCreate, FileAccess.Write);
                formatter.Serialize(fs, catalogue);
                fs.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de la sauvegarde des données.");
            }
        }
    }
}
