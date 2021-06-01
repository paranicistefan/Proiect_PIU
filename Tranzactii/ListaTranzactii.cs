using System;
using System.Collections.Generic;
using System.Text;

namespace Tranzactii
{
    public class ListaTranzactii
    {
        List<tranzactie> tranzactii = new List<tranzactie>();

        public ListaTranzactii()
        {

        }
        public void add(tranzactie noua)
        {
            tranzactii.Add(noua);
            tranzactii[tranzactii.Count - 1].id = tranzactii.Count;
            noua.id = tranzactii.Count;
        }
        public void addFile(tranzactie T)
        {
            tranzactii.Add(T);
        }
        public List<tranzactie> show()
        {
            return tranzactii;
        }
        public tranzactie find(int id)
        {
            return tranzactii.Find(x => x.id == id);
        }
        public void modify(tranzactie Modificat, int id)
        {
            tranzactii[id - 1] = Modificat;
        }
    }
}
