using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaLibrary
{
    public class Zaduzenje
    {
        public string IDKorisnika { get; set; }

        public string IDKnjige { get; set; }

        public DateTime DatumUzimanja { get; set; }

        public DateTime DatumVracanja { get; set; }

        public Zaduzenje(string korisnik, string knjiga, DateTime datumUzimanja, DateTime datumVracanja)
        {
            IDKorisnika = korisnik;
            IDKnjige = knjiga;
            DatumUzimanja = datumUzimanja;
            DatumVracanja = datumVracanja;
        }
    }
}
