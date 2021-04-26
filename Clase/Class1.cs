using System;
using System.Collections.Generic;

namespace Clase
{
    public class masina
    {
        public masina(string[] date)
        {
            id = Convert.ToInt32(date[0]);
            Fabricant = date[1];
            Model = date[2];
            anFabricatie = Convert.ToInt32(date[3]);
            Echipare = date[4];
            kilometri = Convert.ToInt32(date[5]);
            cilindree = Convert.ToInt32(date[6]);
            pret = Convert.ToInt32(date[6]);
        }
        List<string> Dotari = new List<string>()
        {
            "Aer Conditionat","Climatronic","Geamuri electice fata","Geamuri electice spate","Pilot automat",
            "Pilot automat adaptiv"
            //... Mai urmeaza
        };
        string Fabricant, Model, Echipare;
        int kilometri, anFabricatie, cilindree, pret,id;
    }

    public class client
    {
        public client(string[] date)
        {
            id = Convert.ToInt32(date[0]);
            Nume = date[1];
            Prenume = date[2];
            CNP = Convert.ToInt32(date[3]);
            adresa = date[4];
            venitAnual = Convert.ToInt32(date[5]);
            buget = Convert.ToInt32(date[6]);
        }
        string Nume, Prenume, adresa;
        int CNP, venitAnual,buget,id;
    }
}
