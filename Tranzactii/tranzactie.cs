using System;
using Clienti;
using Masini;

namespace Tranzactii
{
    public class tranzactie
    {
        public DateTime dataTranzactiei { get; set; }
        public client Clientul { get; set; }
        public masina Masina { get; set; }

        public tranzactie(string input, ListaMasini masini, ListaClienti clienti)
        {
            string[] date = input.Split(";");
            dataTranzactiei = Convert.ToDateTime(date[0]);
            Masina =masini.find(Convert.ToInt32(date[1]));
            Clientul = clienti.find(Convert.ToInt32(date[2]));
        }
        public tranzactie(ListaMasini masini, ListaClienti clienti)
        {
            int x;
            Console.WriteLine("Introducem data de astazi, sau alta data ?");
            Console.Write("0 - Data de azi\n1 - Alta Data\nR:");
            x =Convert.ToInt32(Console.ReadLine());
            if(x==1)
            {
                Console.Write("Introduceti data sub forma:DD/MM/YYYY");
                string data = Console.ReadLine();
            }
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
    }
}
