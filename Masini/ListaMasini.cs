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
    }
}
