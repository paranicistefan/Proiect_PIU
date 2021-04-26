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
        public int CNP { get; set; }
        public string Adresa { get; set; }
        public int venitAnual { get; set; }
        public int Buget { get; set; }
        public client(string[] date)
        {
            id = Convert.ToInt32(date[0]);
            Nume = date[1];
            Prenume = date[2];
            CNP = Convert.ToInt32(date[3]);
            Adresa = date[4];
            venitAnual = Convert.ToInt32(date[5]);
            Buget = Convert.ToInt32(date[6]);
        }
        public client()
        {
            Console.Write("Ce Nume are Clientul ?\nR:");
            Nume = Console.ReadLine();
            Console.Write("Ce Prenume are Clientul ?\nR:");
            Prenume = Console.ReadLine();
            Console.Write("Care este CNP-ul clientului ?\nR:");
            CNP = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ce adresa are clientul ?\nR:");
            Adresa = Console.ReadLine();
            Console.Write("Care este venitul anual al clientului ?\nR:");
            venitAnual = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ce buget are clientul, pentru achizitia unei masini ?\nR:");
            Buget= Convert.ToInt32(Console.ReadLine());
        }
    }
}
