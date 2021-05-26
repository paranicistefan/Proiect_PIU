using Masini;
using System;
using System.Collections.Generic;
using System.Text;

namespace NivelAccesDate
{
    public interface IStocareDate
    {
        void SaveMasini(ListaMasini lista);
        public ListaMasini GetMasini();

    }
}
