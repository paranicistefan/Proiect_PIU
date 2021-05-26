using System;
using System.Collections.Generic;
using System.Text;

namespace Clienti
{
    
    public class client
    {
        public int id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string CNP { get; set; }
        public string Adresa { get; set; }
        public string Serie { get; set; }
        public string Telefon { get; set; }
        public client(string input)
        {
            string[] date = input.Split(";");
            id = Convert.ToInt32(date[0]);
            Nume = date[1];
            Prenume = date[2];
            CNP = date[3];
            Serie = date[4];
            Adresa = date[5];
            Telefon = date[6];

        }
        public client()
        {

        }
        public string afisare()
        {
            return $"{id}   {Nume}\t{Prenume}\t{CNP}\t\t{Serie}\t\t{Adresa}\t{Telefon}";
        }
        public string scriere_inFisier()
        {
            return $"{id};{Nume};{Prenume};{CNP};{Serie};{Adresa};{Telefon};";
        }
    }
}
