using Observateur.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Observateur
{
    public class DonneesMeteo : Sujet
    {
        private List<ObservateurMeteo> _observateurs;

        private float _temperature;
        private float _humidite;
        private float _pression;

        public DonneesMeteo()
        {
            _observateurs = new List<ObservateurMeteo>();
        }

        public void EnregistrerObservateur(ObservateurMeteo observateur)
        {
            if (!_observateurs.Contains(observateur))
                _observateurs.Add(observateur);
        }

        public void SupprimerObservateur(ObservateurMeteo observateur)
        {
            if (_observateurs.Contains(observateur))
                _observateurs.Remove(observateur);
        }

        public void NotifierObservateurs()
        {
            foreach (var observateur in _observateurs)
            {
                observateur.Actualiser(_temperature, _humidite, _pression);
            }
        }

        public void ActualiserMesures()
        {
            NotifierObservateurs();
        }

        public void SetMesures(float temperature, float humidite, float pression)
        {
            _temperature = temperature;
            _humidite = humidite;
            _pression = pression;

            ActualiserMesures();
        }
    }
}