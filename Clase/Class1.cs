using System;
using System.Collections.Generic;

namespace Clase
{
    public class masina
    {
    List<string> Dotari = new List<string>()
    {
        "Aer Conditionat","Climatronic","Geamuri electice fata","Geamuri electice spate","Pilot automat",
        "Pilot automat adaptiv"
        //... Mai urmeaza
    };
    string Fabricant, Model, Echipare;
    int kilometri, anFabricatie, cilindree, pret;
    }

    public class client
    {
        string Nume, Prenume, adresa, judet;
        int CNP, venitAnual,buget;
    }
}
