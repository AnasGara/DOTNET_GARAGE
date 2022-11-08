using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryGarage
{
    public class Voiture:Automobile
    {
        
        public string Couleur { get; set; }
        public string Marque { get; set; }
        public string TypeV { get; set; }

        public Voiture()
        {
        }

        public Voiture(int annee, string imm, string couleur, string marque, string typeV):base(annee,imm)
        {

            Couleur = couleur;
            Marque = marque;
            TypeV = typeV;
        }
        public void Afficher()
        {
            Console.WriteLine("Couleur: " + this.Couleur + "Marque: " + this.Marque + "typeV" + this.TypeV);
        }
        //override
        public override String ToString()
        {
            return base.ToString() + "Couleur: " + this.Couleur + "Marque: " + this.Marque + "typeV" + this.TypeV;
        }
    }
}
