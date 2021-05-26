using System;
using System.Collections.Generic;
using System.Text;

namespace Masini
{
    public class masina
    {
        public int id { get; set; }
        public string Fabricant { get; set; }
        public string Model { get; set; }
        public int Kilometraj { get; set; }
        public string Echipare { get; set; }
        public int Pret { get; set; }
        public int anFabricatie { get; set; }
        public masina(string input)
        {
            string[] date = input.Split(";");
            id = Convert.ToInt32(date[0]);
            Fabricant = date[1];
            Model = date[2];
            anFabricatie= Convert.ToInt32(date[3]);
            Echipare = date[4];
            Kilometraj = Convert.ToInt32(date[5]);
            Pret = Convert.ToInt32(date[6]);
            
        }
        public masina()
        {

        }
        public string afisare()
        {
            return $"{id}   {Fabricant}\t{Model}\t{anFabricatie}\t\t{Echipare}\t\t{Kilometraj} KM \t{Pret} EUR";
        }
        public string scriere_inFisier()
        {
            return $"{id};{Fabricant};{Model};{anFabricatie};{Echipare};{Kilometraj};{Pret};";
        }
    }
}
