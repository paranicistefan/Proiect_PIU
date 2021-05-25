using System;
using System.Collections.Generic;
using System.Text;

namespace Masini
{
    public class ListaMasini
    {
        List<masina> masini = new List<masina>();
        public ListaMasini()
        {

        }
        public masina add()
        {
            masina noua = new masina();
            masini.Add(noua);
            masini[masini.Count - 1].id = masini.Count;
            noua.id = masini.Count;
            return noua;
        }
        public void addFile(masina M)
        {
            masini.Add(M);
        }
        public bool show()
        {
            if(masini.Count==0)
            {
                Console.WriteLine("Nu ai nici-o masina introdusa");
                return false;
            }
            Console.WriteLine($"ID   Fabricant\tModel\tanFabricatie\tEchipare\t\tkilometri   \tpret");
            foreach (masina curent in masini)
            {
                Console.WriteLine(curent.afisare());
            }
            return true;
        }
        public void compare()
        {
            bool verificare;
            int masina1=0, masina2=0;
            verificare=show();
            if (verificare == false)
                return;
            Console.WriteLine("Introduceti id-ul primei masini\nR:");
            masina1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduceti id-ul  masinei nr 2\nR:");
            masina2 = Convert.ToInt32(Console.ReadLine());
            masini[masina1 - 1].afisare();
            masini[masina1 - 1].afisare();
        }
    }
}
