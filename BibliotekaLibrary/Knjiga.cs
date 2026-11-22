namespace BibliotekaLibrary
{
    public class Knjiga
    {
        private string _id;

        private string _naziv;

        private string _pisac;

        private int _brPrimeraka;

        private int _brDostupnih;

        public string ID //Inventarni broj knjige
        {
            get => _id;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _id = value;
                }
                else
                {
                    _id = "Nepoznat!!!";
                }
            }
        }

        public string Naziv //Naslov knjige
        {
            get => _naziv;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _naziv = value;
                }
                else
                {
                    _naziv = "naslov nepoznat";
                }
            }
        }

        public string Pisac //U slučaju više pisaca za istu knjigu odvajati ih zarezom
        {
            get => _pisac;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _pisac = value;
                }
                else
                {
                    _pisac = "nepoznat autor";
                }
            }
        }

        public int BrPrimeraka //Ukupan broj primeraka koji biblioteka poseduje
        {
            get => _brPrimeraka;
            set
            {
                if (value >= 0) _brPrimeraka = value;
                else throw new ArgumentOutOfRangeException("Broj primeraka ne može biti negativan!");
            }
        }

        public int BrDostupnih //Broj primeraka koji je moguće izdati trenutno
        {
            get => _brDostupnih;
            set
            {
                if (value >= 0) _brDostupnih = value;
                else _brDostupnih = 0;
            }
        }

        public Knjiga(string id, string naziv, string pisac, int brPrimeraka, int brDostupnih)
        {
            _id = id;
            _naziv = naziv;
            _pisac = pisac;
            _brPrimeraka = brPrimeraka;
            _brDostupnih = brDostupnih;
        }

        public Knjiga(string id, string naziv, string pisac, int brPrimeraka)
        {
            _id = id;
            _naziv = naziv;
            _pisac = pisac;
            _brPrimeraka = brPrimeraka;
            _brDostupnih = brPrimeraka;
        }
    }
}
