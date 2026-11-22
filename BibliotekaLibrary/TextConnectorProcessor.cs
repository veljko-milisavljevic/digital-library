using System.Configuration;

namespace BibliotekaLibrary.TextHelpers
{
    public static class TextConnectorProcessor
    {
        public static string PunaPutanja(this string imeFajla)
        {
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{imeFajla}";
        }
        public static List<string> UcitajFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        //Knjige
        public static List<Knjiga> PretvoriUKnjige(this List<string> redovi)
        {
            List<Knjiga> izlaz = new List<Knjiga>();

            foreach (string red in redovi)
            {
                string[] kolone = red.Split('|');
                Knjiga k = new Knjiga(kolone[0], kolone[1], kolone[2], int.Parse(kolone[3]), int.Parse(kolone[4]));
                izlaz.Add(k);
            }
            return izlaz;
        }
        public static void SacuvajKnjigeUFile(this List<Knjiga> knjige)
        {
            List<string> redovi = new List<string>();

            foreach (Knjiga k in knjige)
            {
                redovi.Add($"{k.ID}|{k.Naziv}|{k.Pisac}|{k.BrPrimeraka}|{k.BrDostupnih}");
            }

            File.WriteAllLines(TextConnector.KnjigeFile.PunaPutanja(), redovi);
        }

        //Ucenici
        public static List<Ucenik> PretvoriUUcenike(this List<string> redovi)
        {
            List<Ucenik> izlaz = new List<Ucenik>();

            foreach (string red in redovi)
            {
                string[] kolone = red.Split('|');
                Ucenik u = new Ucenik(kolone[0], kolone[1], kolone[2], kolone[3], DateTime.Parse(kolone[4]), kolone[5], kolone[6], int.Parse(kolone[7]), int.Parse(kolone[8]));
                izlaz.Add(u);
            }
            return izlaz;
        }
        public static void SacuvajUcenikeUFile(this List<Ucenik> ucenici)
        {
            List<string> redovi = new List<string>();

            foreach (Ucenik u in ucenici)
            {
                redovi.Add($"{u.ID}|{u.Ime}|{u.Prezime}|{u.ImeRoditelja}|{u.DatumRodjenja}|{u.Adresa}|{u.BrTelefona}|{u.Razred}|{u.Odeljenje}");
            }

            File.WriteAllLines(TextConnector.UceniciFile.PunaPutanja(), redovi);
        }

        //Profesori
        public static List<Profesor> PretvoriUProfesore(this List<string> redovi)
        {
            List<Profesor> izlaz = new List<Profesor>();

            foreach (string red in redovi)
            {
                string[] kolone = red.Split('|');
                Profesor p = new Profesor(kolone[0], kolone[1], kolone[2], kolone[3], DateTime.Parse(kolone[4]), kolone[5], kolone[6]);
                izlaz.Add(p);
            }
            return izlaz;
        }
        public static void SacuvajProfesoreUFile(this List<Profesor> profesori)
        {
            List<string> redovi = new List<string>();

            foreach (Profesor p in profesori)
            {
                redovi.Add($"{p.ID}|{p.Ime}|{p.Prezime}|{p.ImeRoditelja}|{p.DatumRodjenja}|{p.Adresa}|{p.BrTelefona}");
            }

            File.WriteAllLines(TextConnector.ProfesoriFile.PunaPutanja(), redovi);
        }

        //Zaduzenja
        public static List<Zaduzenje> PretvoriUZaduzenja(this List<string> redovi)
        {
            List<Zaduzenje> izlaz = new List<Zaduzenje>();

            foreach (string red in redovi)
            {
                string[] kolone = red.Split('|');
                Zaduzenje z = new Zaduzenje(kolone[0], kolone[1], DateTime.Parse(kolone[2]), DateTime.Parse(kolone[3]));
                izlaz.Add(z);
            }
            return izlaz;
        }
        public static void SacuvajZaduzenjaUFile(this List<Zaduzenje> zaduzenja)
        {
            List<string> redovi = new List<string>();

            foreach (Zaduzenje z in zaduzenja)
            {
                redovi.Add($"{z.IDKorisnika}|{z.IDKnjige}|{z.DatumUzimanja}|{z.DatumVracanja}");
            }

            File.WriteAllLines(TextConnector.ZaduzenjaFile.PunaPutanja(), redovi);
        }

        //Backup
        public static DateTime PretvoriUDatum(this List<string> redovi)
        {
            string[] kolone = redovi.First().Split('|');
            DateTime datum = new DateTime(int.Parse(kolone[2]), int.Parse(kolone[1]), int.Parse(kolone[0]));
            return datum;
        }

        public static void SacuvajDatumBackupa()
        {
            List<string> redovi = new List<string>();
            DateTime dat = DateTime.Now;
            string s = $"{dat.Day}|{dat.Month}|{dat.Year}";
            redovi.Add(s);
            File.WriteAllLines(TextConnector.PoslednjiBackUpFile.PunaPutanja(), redovi);
        }
    }
}
