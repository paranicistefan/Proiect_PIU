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
        public void add(client nou)
        {
            Clienti.Add(nou);
            Clienti[Clienti.Count - 1].id = Clienti.Count;
            nou.id = Clienti.Count;
        }
        public void addFile(client C)
        {
            Clienti.Add(C);
        }
        public List<client> show()
        {
            return Clienti;
        }
        public client find(int id)
        {
            return Clienti.Find(x => x.id == id);
        }
        public void compare()
        {
            /*
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
            */
        }
    }
}
