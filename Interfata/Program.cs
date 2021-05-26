using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clienti;
using Masini;
using NivelAccesDate;

namespace Interfata
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            IStocareDate masiniSalvate = StocareFactory.GetAdministratorStocare(1);
            IStocareDate clientiSalvati = StocareFactory.GetAdministratorStocare(2);

            ListaMasini masini = new ListaMasini();
            masini = masiniSalvate.GetMasini();
            ListaClienti clienti = new ListaClienti();
            clienti = clientiSalvati.GetClienti();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(masini,clienti));
            masiniSalvate.SaveMasini(masini);
            clientiSalvati.SaveClienti(clienti);
        }
    }
}
