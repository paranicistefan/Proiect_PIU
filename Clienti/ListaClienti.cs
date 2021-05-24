using System;
using System.Collections.Generic;
using System.Text;

namespace Clienti
{
    public class ListaClienti
    {
        List<client> Clienti = new List<client>();
        public ListaClienti()
        {

        }
        public void add()
        {
            Clienti.Add(new client());
            Clienti[Clienti.Count - 1].id = Clienti.Count;
        }
        public bool show()
        {
            if (Clienti.Count == 0)
            {
                Console.WriteLine("Nu ai nici-un client introdus");
                return false;
            }
            Console.WriteLine($"ID   Nume\tPrenume\tCNP\tAdresa\t\tVenit anual[EUR]   \tBuget");
            foreach (client curent in Clienti)
            {
                Console.WriteLine(curent.afisare());
            }
            return true;
        }
        public void compare()
        {
            bool verificare;
            int client1 = 0, client2 = 0;
            verificare = show();
            if (verificare == false)
                return;
            Console.WriteLine("Introduceti id-ul primului Client\nR:");
            client1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduceti id-ul  Clientului nr 2\nR:");
            client2 = Convert.ToInt32(Console.ReadLine());
            Clienti[client1 - 1].afisare();
            Clienti[client1 - 1].afisare();
        }
    }
}
