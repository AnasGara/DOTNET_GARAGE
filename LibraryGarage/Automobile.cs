using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryGarage
{
    public class Automobile
    {
        //Fields
        private int annee;

        //Properties
        public int Annee
        {
            get
            {
                return annee;
            }
            set
            {
                annee = value;
            }
        }
        public string Immatriculation { get; set; }
        //Méthode 1 field privée + constructor
        //Méthode 2 direct propority
    
        //Methods
        public void afficher() {
            Console.WriteLine(" L'année est " + this.Annee.ToString() + "; L'immatriculation est "+ this.Immatriculation +";" );
        }
        public Automobile() { }

        public Automobile(int annee, string immatriculation)
        {
            Annee = annee;
            Immatriculation = immatriculation;
        }

        public string toString() { return this.Annee.ToString() + this.Immatriculation; }
    }
}
