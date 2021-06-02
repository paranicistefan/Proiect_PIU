using System;
using Clienti;
using Masini;

namespace Tranzactii
{
    public class tranzactie
    {
        public int id { get; set; }
        public DateTime dataTranzactiei { get; set; }
        public client Clientul { get; set; }
        public client Vanzator { get; set; }
        public masina Masina { get; set; }

        public tranzactie(string input, ListaMasini masini, ListaClienti clienti)
        {
            string[] date = input.Split(";");
            dataTranzactiei = Convert.ToDateTime(date[0]);
            Masina =masini.find(Convert.ToInt32(date[1]));
            Clientul = clienti.find(Convert.ToInt32(date[2]));
            Vanzator = clienti.find(Convert.ToInt32(date[3]));
        }
        public tranzactie()
        {

        }
        public string afisare()
        {
            return $"{id}   {Vanzator.Nume+" "+Vanzator.Prenume}\t{Clientul.Nume+" "+Clientul.Prenume}\t{Masina.Fabricant+" "+Masina.Model }\t\t{dataTranzactiei}\t\t{Masina.Pret} EUR";
        }
        public string scriere_inFisier()
        {
            return $"{dataTranzactiei};{Masina.id};{Clientul.id};{Vanzator.id}";
        }
    }
}
