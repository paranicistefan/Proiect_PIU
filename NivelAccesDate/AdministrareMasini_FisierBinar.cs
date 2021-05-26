using System;
using Masini;
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
            throw new Exception("Optiunea AddStudent nu este implementata");
        }

        public ListaMasini GetMasini()
        {
            throw new Exception("Optiunea GetStudenti nu este implementata");
        }
    }
}
