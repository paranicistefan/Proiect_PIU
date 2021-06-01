using System;
using Masini;
using Clienti;
using Tranzactii;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace NivelAccesDate
{
    public class AdministrareMasini_FisierBinar : IStocareDate
    {
        string NumeFisier { get; set; }
        public AdministrareMasini_FisierBinar(string numeFisiser)
        {
            this.NumeFisier = NumeFisier;
        }

        public void SaveMasini(ListaMasini lista)
        {
            throw new Exception("Optiunea SaveMasini nu este implementata");
        }

        public ListaMasini GetMasini()
        {
            throw new Exception("Optiunea GetMasini nu este implementata");
        }

        public ListaClienti GetClienti()
        {
            throw new Exception("Optiunea GetMasini nu este implementata");
        }
        public void SaveClienti(ListaClienti lista)
        {
            throw new Exception("Optiunea SaveMasini nu este implementata");
        }
        public ListaTranzactii GetTranzactii(ListaMasini masini, ListaClienti clienti)
        {
            throw new Exception("Optiunea GetMasini nu este implementata");
        }
        public void SaveTranzactii(ListaTranzactii lista)
        {
            throw new Exception("Optiunea SaveMasini nu este implementata");
        }
    }
}
