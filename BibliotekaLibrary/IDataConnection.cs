using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaLibrary
{
    public interface IDataConnection
    {
        void DodajKnjigu(Knjiga knjiga);
        void UkloniKnjigu(Knjiga knjiga);
        void DodajPrimerak(string naslov, string pisac);
        void ZaduziPrimerak(string naslov, string pisac);
        void RazduziPrimerak (string naslov, string pisac);
        void DodajUcenika(Ucenik ucenik);
        void UkloniUcenika(Ucenik ucenik);
        void DodajProfesora(Profesor profesor);
        void UkloniProfesora(Profesor profesor);
        void DodajZaduzenje(Zaduzenje zaduzenje);
        void UkloniZaduzenje(Zaduzenje zaduzenje);
        void OznaciKrajGodine();
        void NapraviBackup();
        
        List<Knjiga> NadjiKnjige_ID(string id);
        List<Knjiga> NadjiKnjige_Naslov(string naslov);
        List<Knjiga> NadjiKnjige_Pisac(string pisac);
        List<Knjiga> NadjiIsteKnjige(string naslov, string pisac);

        List<Ucenik> NadjiUcenike_ID(string id);
        List<Ucenik> NadjiSveUcenikeSaZaduzenjem();
        List<Ucenik> NadjiSveUcenikeKojiKasne();
        List<Ucenik> NadjiSveUcenikeKojiKasne(int brojDana);

        List<Profesor> NadjiProfesore_ID(string id);
        List<Profesor> NadjiSveProfesoreSaZaduzenjem();
        List<Profesor> NadjiSveProfesoreKojiKasne(int brojDana);

        List<Zaduzenje> NadjiZaduzenja_Korisnik(string id);
        Zaduzenje NadjiZaduzenje(string korisnik, string naslov);
    }
}
