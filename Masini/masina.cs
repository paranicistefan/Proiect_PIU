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
        public Culoare culoare { get; set; }
        public AerConditionat aer { get; set; }
        public Combustibili fuel { get; set; }
        public Caroserii caroserie { get; set; }
        public CutiiViteze cv { get; set; }
        public GeamuriElectrice geamuri { get; set; }
        public bool OglinziElectrice = false;
        public bool ScauneElectrice = false;
        public bool PachetSport = false;
        public bool CriuseControl = false;
        public bool SenzoriParcare = false;
        public bool FariuriAutomate = false;

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
            culoare = (Culoare)Enum.Parse(typeof(Culoare),date[7]);
            aer = (AerConditionat)Enum.Parse(typeof(AerConditionat), date[8]);
            fuel = (Combustibili)Enum.Parse(typeof(Combustibili), date[9]);
            caroserie = (Caroserii)Enum.Parse(typeof(Caroserii), date[10]);
            cv = (CutiiViteze)Enum.Parse(typeof(CutiiViteze), date[11]);
            geamuri = (GeamuriElectrice)Enum.Parse(typeof(GeamuriElectrice), date[12]);
            OglinziElectrice =Convert.ToBoolean(date[13]);
            ScauneElectrice = Convert.ToBoolean(date[14]);
            PachetSport = Convert.ToBoolean(date[15]);
            CriuseControl = Convert.ToBoolean(date[16]);
            SenzoriParcare = Convert.ToBoolean(date[17]);
            FariuriAutomate = Convert.ToBoolean(date[18]);

        }
        public masina()
        {
            culoare = Culoare.Invalid;
            aer = AerConditionat.Invalid;
            fuel = Combustibili.Invalid;
            caroserie = Caroserii.Invalid;
            cv = CutiiViteze.Invalid;
            geamuri = GeamuriElectrice.Invalid;

        }
        public string afisare()
        {
            return $"{id}   {Fabricant}\t{Model}\t{anFabricatie}\t\t{Echipare}\t\t{Kilometraj} KM \t{Pret} EUR";
        }
        public string scriere_inFisier()
        {
            return $"{id};{Fabricant};{Model};{anFabricatie};{Echipare};{Kilometraj};{Pret};" +
                $"{culoare};{aer};{fuel};{caroserie};{cv};{geamuri};" +
                $"{OglinziElectrice};{ScauneElectrice};{PachetSport};{CriuseControl};{SenzoriParcare};{FariuriAutomate}";
        }
    }
}
