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
        public void add(masina noua)
        { 
            masini.Add(noua);
            masini[masini.Count - 1].id = masini.Count;
            noua.id = masini.Count;
        }
        public void addFile(masina M)
        {
            masini.Add(M);
        }
        public List<masina> show()
        {
            return masini;
        }
        public masina find (int id)
        {
            return masini.Find(x => x.id == id);
        }
        public void modify(masina Modificat, int id)
        {
            masini[id - 1] = Modificat;
        }
        public void compare()
        {
            //bool verificare;
            int masina1=0, masina2=0;
            //verificare=show();
           // if (verificare == false)
              //  return;
            Console.WriteLine("Introduceti id-ul primei masini\nR:");
            masina1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduceti id-ul  masinei nr 2\nR:");
            masina2 = Convert.ToInt32(Console.ReadLine());
            masini[masina1 - 1].afisare();
            masini[masina1 - 1].afisare();
        }
    }
}
