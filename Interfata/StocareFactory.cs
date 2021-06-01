using NivelAccesDate;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Text;

namespace Interfata
{
    public static class StocareFactory
    {
        public static IStocareDate GetAdministratorStocare(int tip)
        {
            var formatSalvare = ConfigurationManager.AppSettings["FormatSalvare"];
            var numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            var numeFisierC = ConfigurationManager.AppSettings["NumeFisierC"];
            var numeFisierT = ConfigurationManager.AppSettings["NumeFisierT"];
            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    default:
                    case "bin":
                        return new AdministrareMasini_FisierBinar (numeFisier + "." + formatSalvare);
                    case "txt":
                        switch(tip)
                        {
                            case 1:
                                return new AdministrareMasini_FisierText (numeFisier + "." + formatSalvare);
                            case 2:
                                return new AdministrareClienti_FisierText(numeFisierC + "." + formatSalvare);
                            case 3:
                                return new AdministrareTranzactii_FisierText(numeFisierT + "." + formatSalvare);
                            default:
                                return new AdministrareClienti_FisierText(numeFisierT + "." + formatSalvare); ;
                        }
                            
                }
            }

            return null;
        }
    }
}
