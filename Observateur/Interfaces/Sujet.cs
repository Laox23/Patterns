namespace Observateur.Interfaces
{
    public interface Sujet
    {
        void EnregistrerObservateur(ObservateurMeteo observateur);
        void SupprimerObservateur(ObservateurMeteo observateur);
        void NotifierObservateurs();
    }
}