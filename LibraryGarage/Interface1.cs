using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryGarage
{
    public enum SubType { voiture,moto};
    public interface GarageInterface
    {
        void addAuto(Automobile auto);
        void deleteAuto(string immatriculation);
        void updateAuto(Automobile automobile);
        void getIndexAuto(Automobile automobile);
        Automobile GetAuto(string immatriculation);
        List<Automobile> AfficherAutomobiles(SubType soustype);

    }
}
