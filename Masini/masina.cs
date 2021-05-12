using System;
using System.Collections.Generic;
using System.Text;

namespace Masini
{
    class masina
    {
        public int id { get; set; }
        public string Fabricant { get; set; }
        public string Model { get; set; }
        public int Kilometraj { get; set; }
        public string Echipare { get; set; }
        public int Pret { get; set; }
        public int anFabricatie { get; set; }
        public masina(string[] date)
        {
            id = Convert.ToInt32(date[0]);
            Fabricant = date[1];
            Model = date[2];
            Kilometraj = Convert.ToInt32(date[3]);
            Echipare = date[4];
            Pret = Convert.ToInt32(date[5]);
            anFabricatie= Convert.ToInt32(date[6]);
        }
        public masina()
        {
            Console.Write("Ce marca este masina ?\nR:");
            Fabricant = Console.ReadLine();
            Console.Write("Ce Model este ?\nR:");
            Model = Console.ReadLine();
            Console.Write("Ce echipare este ?\nR:");
            Echipare = Console.ReadLine();
            Console.Write("Cati kilometrii are masina ?\nR:");
            Kilometraj = Convert.ToInt32(Console.ReadLine());
            Console.Write("Din ce an este masina ?\nR:");
            anFabricatie = Convert.ToInt32(Console.ReadLine());
            Console.Write("Care este pretul masinii(in euro) ?\nR:");
            Pret = Convert.ToInt32(Console.ReadLine());
        }
        public string afisare()
        {
            return $"{id}   {Fabricant}\t{Model}\t{anFabricatie}\t\t{Echipare}\t\t{Kilometraj} KM \t{Pret} EUR";
        }
    }
}
