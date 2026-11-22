using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaLibrary
{
    public class Profesor : IKorisnik
    {
        private string _id;
        private string _ime;
        private string _prezime;
        private string _imeRoditelja;
        private DateTime _datumRodjenja;
        private string _adresa;
        private string _brTelefona;

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
                    _imeRoditelja = "nepoznato";
            }
        }
        public string PunoIme
        {
            get
            {
                if(ImeRoditelja != "nepoznato") return $"{Ime} ({ImeRoditelja}) {Prezime}";
                else return $"{Ime} {Prezime}";
            }
        }
        public DateTime DatumRodjenja
        {
            get => _datumRodjenja;
            set
            {
                if ((DateTime.Now.Year - value.Year) < 99 && (DateTime.Now.Year - value.Year) > 18) _datumRodjenja = value;
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
            get => $"{Osisaj(Ime)}{Osisaj(Prezime)}@sveti-sava.edu.rs";
        }

        public Profesor(string id, string ime, string prezime, string imeRoditelja, DateTime datumRodjenja, string adresa, string brTelefona)
        {
            ID = id;
            Ime = ime;
            Prezime = prezime;
            ImeRoditelja = imeRoditelja;
            DatumRodjenja = datumRodjenja;
            Adresa = adresa;
            BrTelefona = brTelefona;
        }
    }
}
