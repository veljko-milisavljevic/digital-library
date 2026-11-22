namespace BibliotekaLibrary
{
    public class Ucenik : IKorisnik
    {
        private string _id;
        private string _ime;
        private string _prezime;
        private string _imeRoditelja;
        private DateTime _datumRodjenja;
        private string _adresa;
        private string _brTelefona;
        private int _razred;
        private int _odeljenje;

        public string ID
        {
            get => _id;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _id = value;
                }
                else
                    throw new ArgumentOutOfRangeException("Korisnik mora imati identifikacioni broj!");
            }
        }
        public string Ime
        {
            get => _ime;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _ime = value;
                }
                else
                    throw new ArgumentOutOfRangeException("Korisnik mora imati ime!");
            }
        }
        public string Prezime
        {
            get => _prezime;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _prezime = value;
                }
                else
                    throw new ArgumentOutOfRangeException("Korisnik mora imati prezime!");
            }
        }
        public string ImeRoditelja
        {
            get => _imeRoditelja;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _imeRoditelja = value;
                }
                else
                    throw new ArgumentOutOfRangeException("Korisnik mora imati ime roditelja!");
            }
        }
        public string PunoIme
        {
            get => $"{Ime} ({ImeRoditelja}) {Prezime}";
        }
        public DateTime DatumRodjenja
        { 
            get => _datumRodjenja;
            set
            {
                if ((DateTime.Now.Year - value.Year) < 99 && (DateTime.Now.Year - value.Year) > 14 ) _datumRodjenja = value;
                else
                    throw new ArgumentOutOfRangeException("Pogrešan datum!");
            }
        }
        public string Adresa
        {
            get => _adresa;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _adresa = value;
                }
                else
                {
                    _adresa = "nepoznata";
                }
            }
        }
        public string BrTelefona
        {
            get => _brTelefona;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _brTelefona = value;
                }
                else
                {
                    _brTelefona = "nepoznat";
                }
            }
        }

        //Metoda koja pretvara latinicu u šišanu latinicu (š,đ,č,ć,ž -> s,dj,c,c,z)
        public string Osisaj(string s)
        {
            string izlaz = "";
            foreach (char k in s)
            {
                if (k == 'š') izlaz += 's';
                else if (k == 'đ') izlaz += "dj";
                else if (k == 'č' || k == 'ć') izlaz += 'c';
                else if (k == 'ž') izlaz += 'z';
                else izlaz += k;
            }
            return izlaz.ToLower();
        }
        
        public string Email
        {
            get
            {
                if(DatumRodjenja.Day < 10 && DatumRodjenja.Month >= 10) return $"{Osisaj(Ime)}{Osisaj(Prezime)}0{DatumRodjenja.Day}{DatumRodjenja.Month}@sveti-sava.edu.rs";
                if(DatumRodjenja.Month < 10 && DatumRodjenja.Day >= 10) return $"{Osisaj(Ime)}{Osisaj(Prezime)}{DatumRodjenja.Day}0{DatumRodjenja.Month}@sveti-sava.edu.rs";
                if(DatumRodjenja.Day < 10 && DatumRodjenja.Month < 10) return $"{Osisaj(Ime)}{Osisaj(Prezime)}0{DatumRodjenja.Day}0{DatumRodjenja.Month}@sveti-sava.edu.rs";
                return $"{Osisaj(Ime)}{Osisaj(Prezime)}{DatumRodjenja.Day}{DatumRodjenja.Month}@sveti-sava.edu.rs";
            }
        }
        public int Razred
        {
            get => _razred;
            set
            {
                if (value > 0 && value < 5) _razred = value;
                else
                    throw new ArgumentOutOfRangeException("Pogrešan razred!");
            }
        }
        public int Odeljenje
        {
            get => _odeljenje;
            set
            {
                if (value > 0 && value < 10) _odeljenje = value;
                else
                    throw new ArgumentOutOfRangeException("Pogrešno odeljenje!");
            }
        }

        public Ucenik(string id, string ime, string prezime, string imeRoditelja, DateTime datumRodjenja, string adresa, string brTelefona, int razred, int odeljenje)
        {
            ID = id;
            Ime = ime;
            Prezime = prezime;
            ImeRoditelja = imeRoditelja;
            DatumRodjenja = datumRodjenja;
            Adresa = adresa;
            BrTelefona = brTelefona;
            Razred = razred;
            Odeljenje = odeljenje;
        }
    }
}
