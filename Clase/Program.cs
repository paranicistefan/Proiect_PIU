using System;
using Clienti;
using Masini;
using NivelAccesDate;
using System.Collections.Generic;

namespace Clase
{
    class Program
    {        
        static void Main(string[] args)
        {
            int x;

            IStocareDate masiniSalvate = StocareFactory.GetAdministratorStocare();

            ListaMasini masini = new ListaMasini();
            masini = masiniSalvate.GetMasini();
            ListaClienti clienti = new ListaClienti();
            while(true)
            {
                Console.Clear();
                Meniu m =new Meniu();
                x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        masiniSalvate.AddMasina(masini.add());
                        break;
                    case 2:
                        masini.show();
                        Console.ReadKey();
                        break;
                    case 3:
                        clienti.add();
                        break;
                    case 4:
                        clienti.show();
                        Console.ReadKey();
                        break;
                    case 5:
                        masini.compare();
                        Console.ReadKey();
                        break;
                    case 6:
                        clienti.compare();
                        Console.ReadKey();
                        break;
                    case 7:
                        return;
                    default:
                        Console.WriteLine("A-ti gresit optiunea");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
