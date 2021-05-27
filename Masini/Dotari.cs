using System;
using System.Collections.Generic;
using System.Text;

namespace Masini
{
        public enum Culoare { 
        Invalid = 0,
        Negru = 1,
        Alb = 2,
        Gri = 3,
        Arginiu = 4,
        Albastru = 5,
        Rosu = 6,
        Verde = 7,
        galben = 8,
        maro = 9
        }
        public enum Caroserii
        {
            Invalid = 0,
            Hatchback = 1, 
            Sedan = 2,
            Coupe = 3,
            SUV = 4,
            Cabrio = 5,
            Break = 6,
            Monovolum = 7
        }
        public enum Combustibili
        {
            Invalid = 0,
            Benzina = 1,
            Diesel = 2,
            Hybrid = 3,
            Electric = 4,
        }
    public enum CutiiViteze
        {
            Invalid = 0,
            Manuala = 1, 
            Automata = 2
        }
        public enum AerConditionat
        {
            Invalid = 0,
            Manual = 1,
            Climiatronic = 2,
            Climatronic_2_Zone = 3, 
            Climatronic_3_Zone = 4,
            Climatronic_4_Zone = 5
        }
        public enum GeamuriElectrice
        {
            Invalid = 0,
            Nope = 1, 
            Fata = 2, 
            Fata_Spate = 3
        }
}
