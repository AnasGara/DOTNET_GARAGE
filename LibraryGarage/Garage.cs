using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryGarage
{
    public class Garage: GarageInterface
    {
        private string autos;

        public Garage()
        {
        }

        public string Address { get; set; }

        public void addAuto(Automobile auto)
        {
            throw new NotImplementedException();
        }

        public List<Automobile> AfficherAutomobiles(SubType soustype)
        {
            throw new NotImplementedException();
        }

        public void deleteAuto(string immatriculation)
        {
            throw new NotImplementedException();
        }

        public Automobile GetAuto(string immatriculation)
        {
            throw new NotImplementedException();
        }

        public void getIndexAuto(Automobile automobile)
        {
            throw new NotImplementedException();
        }

        public void updateAuto(Automobile automobile)
        {
            throw new NotImplementedException();
        }
    }
}
