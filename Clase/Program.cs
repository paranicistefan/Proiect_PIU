using System;

namespace Clase
{
    class Program
    {

        static void meniu()
        {
            Console.WriteLine("1. Adauga un client");
            Console.WriteLine("2. Adauga o masina");
            Console.WriteLine("3. Compara 2 masini");
            Console.WriteLine("4. Exit");
        }
        
        static void Main(string[] args)
        {
            int x;
            
            while(true)
            {
                Console.Clear();
                meniu();
                Console.WriteLine("Ce facem ?\nR:");
                x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        {
                            masina a= new masina(new string[] {"1","Volvo","S60","2011","D3","279000","1968","9500"});
                            // Nu pot folosi constructorul cu parametrii
                        }
                        break;
                    case 4:
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
