using Observateur.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Observateur
{
    public abstract class AffichageMeteo : ObservateurMeteo, Affichage
    {
        public abstract void Actualiser(float temperature, float humidite, float pression);

        public abstract void Afficher();

    }

    public class AffichageDirect : AffichageMeteo
    {
        public float _temp { get; set; }
        public float _humi { get; set; }
        public float _pres { get; set; }

        public AffichageDirect()
        {
        }

        public override void Actualiser(float temperature, float humidite, float pression)
        {
            _temp = temperature;
            _humi = humidite;
            _pres = pression;

            Afficher();
        }

        public override void Afficher()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(@"température : {0}
humidité : {1}
préssion : {2}
", _temp, _humi, _pres);

            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    public class AffichageMoyenne : AffichageMeteo
    {
        public IList<float> _temps { get; set; }
        public IList<float> _humis { get; set; }
        public IList<float> _press { get; set; }

        public AffichageMoyenne()
        {
            _temps = new List<float>();
            _humis = new List<float>();
            _press = new List<float>();
        }

        public override void Actualiser(float temperature, float humidite, float pression)
        {
            _temps.Add(temperature);
            _humis.Add(humidite);
            _press.Add(pression);

            Afficher();
        }

        public override void Afficher()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine(@"température moyenne : {0}
humidité moyenne : {1}
préssion moyenne : {2}
", _temps.Average(), _humis.Average(), _press.Average());

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}