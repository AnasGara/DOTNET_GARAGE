using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryGarage
{
    public class Moto : Automobile
    {

        public Moto()
        {
        }
        public Moto(int annee, string imm, float cylinder, float vitesseMax) : base(annee, imm)
        {
            Cylinder = cylinder;
            VitesseMax = vitesseMax;
        }


        //fields
        public float Cylinder { get; set; }
        public float VitesseMax { get; set; }
        //methods

        public void Afficher()
        {
            Console.WriteLine("Cylinder: " + this.Cylinder.ToString() + "Vitesse Max: " + this.VitesseMax.ToString());
        }
        public string ToString()
        {
            return base.ToString() + "Cylinder" + this.Cylinder.ToString() + "Vitesse Max: " + this.VitesseMax.ToString();
        }
    }
}
