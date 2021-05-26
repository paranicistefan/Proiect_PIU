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
            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    default:
                    case "bin":
                        return new AdministrareMasini_FisierBinar (numeFisier + "." + formatSalvare);
                    case "txt":
                        if(tip==1)
                            return new AdministrareMasini_FisierText (numeFisier + "." + formatSalvare);
                        else
                            return new AdministrareClienti_FisierText(numeFisierC + "." + formatSalvare);
                }
            }

            return null;
        }
    }
}
