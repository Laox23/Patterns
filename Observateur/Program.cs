using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observateur
{
    class Program
    {
        static void Main(string[] args)
        {
            var affichageDirect = new AffichageDirect();
            var affichageMoyenne = new AffichageMoyenne();

            var meteoStation = new DonneesMeteo();

            meteoStation.EnregistrerObservateur(affichageDirect);
            meteoStation.EnregistrerObservateur(affichageMoyenne);

            meteoStation.SetMesures(12.5f, 80f, 100f);
            meteoStation.SetMesures(13.5f, 82, 110);
            meteoStation.SetMesures(14.5f, 93, 120);
            meteoStation.SetMesures(16f, 50, 150);

            meteoStation.SupprimerObservateur(affichageMoyenne);

            meteoStation.SetMesures(20, 65, 120);
            meteoStation.SetMesures(18, 62, 130);

            Console.ReadLine();
        }
    }
}
