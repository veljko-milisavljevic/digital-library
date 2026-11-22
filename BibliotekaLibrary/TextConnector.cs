using BibliotekaLibrary.TextHelpers;

namespace BibliotekaLibrary
{
    public class TextConnector : IDataConnection
    {
        public const string KnjigeFile = "Knjige.csv";
        public const string UceniciFile = "Učenici.csv";
        public const string ProfesoriFile = "Profesori.csv";
        public const string ZaduzenjaFile = "Zaduženja.csv";
        public const string PoslednjiBackUpFile = "Poslednji backup.csv";

        //Knjiga
        public void DodajKnjigu(Knjiga knjiga) //Dodaje knjigu na kraj file-a
        {
            List<Knjiga> knjige = KnjigeFile.PunaPutanja().UcitajFile().PretvoriUKnjige();
            knjige.Add(knjiga);
            knjige.SacuvajKnjigeUFile();
        }
        public List<Knjiga> NadjiKnjige_ID(string id) //Vraća listu knjiga sa zadatim ID-om
        {
            List<Knjiga> sveKnjige = KnjigeFile.PunaPutanja().UcitajFile().PretvoriUKnjige();
            List<Knjiga> izlaz = new List<Knjiga>();
            foreach (Knjiga k in sveKnjige)
            {
                if (k.ID == id) izlaz.Add(k);
            }
            return izlaz;
        }
        public List<Knjiga> NadjiKnjige_Naslov(string naslov) //Vraća listu knjiga sa zadatim naslovom
        {
            List<Knjiga> sveKnjige = KnjigeFile.PunaPutanja().UcitajFile().PretvoriUKnjige();
            List<Knjiga> izlaz = new List<Knjiga>();
            foreach (Knjiga k in sveKnjige)
            {
                if (k.Naziv.Contains(naslov)) izlaz.Add(k);
            }
            return izlaz;
        }
        public List<Knjiga> NadjiKnjige_Pisac(string pisac) //Vraća listu knjiga sa zadatim piscem
        {
            List<Knjiga> sveKnjige = KnjigeFile.PunaPutanja().UcitajFile().PretvoriUKnjige();
            List<Knjiga> izlaz = new List<Knjiga>();
            foreach (Knjiga k in sveKnjige)
            {
                if (k.Pisac.Contains(pisac)) izlaz.Add(k);
            }
            return izlaz;
        }
        public List<Knjiga> NadjiIsteKnjige(string naslov, string pisac) //Vraća listu svih istih knjiga
        {
            List<Knjiga> sveKnjige = KnjigeFile.PunaPutanja().UcitajFile().PretvoriUKnjige();
            List<Knjiga> izlaz = new List<Knjiga>();
            foreach (Knjiga k in sveKnjige)
            {
                if (k.Naziv.Contains(naslov) && k.Pisac.Contains(pisac)) izlaz.Add(k);
            }
            return izlaz;
        }
        public void DodajPrimerak(string naslov, string pisac)
        {
            List<Knjiga> sveKnjige = KnjigeFile.PunaPutanja().UcitajFile().PretvoriUKnjige();
            foreach (Knjiga k in sveKnjige)
            {
                if (k.Naziv == naslov && k.Pisac == pisac)
                {
                    k.BrPrimeraka++;
                    k.BrDostupnih++;
                }
            }
            sveKnjige.SacuvajKnjigeUFile();
        }
        public void ZaduziPrimerak(string naslov, string pisac)
        {
            List<Knjiga> sveKnjige = KnjigeFile.PunaPutanja().UcitajFile().PretvoriUKnjige();
            foreach (Knjiga k in sveKnjige)
            {
                if (k.Naziv == naslov && k.Pisac == pisac)
                {
                    k.BrDostupnih--;
                }
            }
            sveKnjige.SacuvajKnjigeUFile();
        }
        public void RazduziPrimerak(string naslov, string pisac)
        {
            List<Knjiga> sveKnjige = KnjigeFile.PunaPutanja().UcitajFile().PretvoriUKnjige();
            foreach (Knjiga k in sveKnjige)
            {
                if (k.Naziv == naslov && k.Pisac == pisac)
                {
                    k.BrDostupnih++;
                }
            }
            sveKnjige.SacuvajKnjigeUFile();
        }
        public void UkloniKnjigu(Knjiga knjiga)
        {
            List<Knjiga> sveKnjige = KnjigeFile.PunaPutanja().UcitajFile().PretvoriUKnjige();
            List<Knjiga> knjige = new List<Knjiga>();

            foreach(Knjiga k in sveKnjige)
            {
                if (k.ID != knjiga.ID) knjige.Add(k);
                if (k.Naziv == knjiga.Naziv && k.Pisac == knjiga.Pisac)
                {
                    k.BrDostupnih--;
                    k.BrPrimeraka--;                   
                }
            }
            knjige.SacuvajKnjigeUFile();
        }

        //Učenik
        public void DodajUcenika(Ucenik ucenik) //Dodaje korisnika na kraj file-a
        {
            List<Ucenik> ucenici = UceniciFile.PunaPutanja().UcitajFile().PretvoriUUcenike();
            ucenici.Add(ucenik);
            ucenici.SacuvajUcenikeUFile();
        }
        public void UkloniUcenika(Ucenik ucenik)
        {
            List<Ucenik> sviUcenici = UceniciFile.PunaPutanja().UcitajFile().PretvoriUUcenike();
            List<Ucenik> ucenici = new List<Ucenik>();

            foreach (Ucenik u in sviUcenici)
            {
                if (u.ID != ucenik.ID) ucenici.Add(u);                
            }
            ucenici.SacuvajUcenikeUFile();
        }
        public List<Ucenik> NadjiUcenike_ID(string id)
        {
            List<Ucenik> sviUcenici = UceniciFile.PunaPutanja().UcitajFile().PretvoriUUcenike();
            List<Ucenik> izlaz = new List<Ucenik>();
            foreach(Ucenik u in sviUcenici)
            {
                if (u.ID == id) izlaz.Add(u);
            }
            return izlaz;
        }
        public List<Ucenik> NadjiSveUcenikeSaZaduzenjem()
        {
            List<Ucenik> sviUcenici = UceniciFile.PunaPutanja().UcitajFile().PretvoriUUcenike();
            List<Ucenik> izlaz = new List<Ucenik>();
            foreach (Ucenik u in sviUcenici)
            {
                if (NadjiZaduzenja_Korisnik(u.ID).Count > 0) izlaz.Add(u);
            }
            return izlaz;
        }
        public List<Ucenik> NadjiSveUcenikeKojiKasne()
        {
            List<Ucenik> sviUcenici = NadjiSveUcenikeSaZaduzenjem();
            List<Ucenik> izlaz = new List<Ucenik>();
            foreach (Ucenik u in sviUcenici)
            {
                foreach (Zaduzenje z in NadjiZaduzenja_Korisnik(u.ID))
                {
                    if(z.DatumVracanja < DateTime.Now)
                    {
                        izlaz.Add(u);
                        break;
                    }
                }
            }
            return izlaz;
        }

        public List<Ucenik> NadjiSveUcenikeKojiKasne(int brojDana)
        {
            List<Ucenik> sviUcenici = NadjiSveUcenikeSaZaduzenjem();
            List<Ucenik> izlaz = new List<Ucenik>();
            foreach (Ucenik u in sviUcenici)
            {
                foreach (Zaduzenje z in NadjiZaduzenja_Korisnik(u.ID))
                {
                    int kasnjenje = (int)DateTime.Now.Subtract(z.DatumVracanja).TotalHours;
                    if (kasnjenje > 0 && kasnjenje / 24 + 1 >= brojDana)
                    {
                        izlaz.Add(u);
                        break;
                    }
                }
            }
            return izlaz;
        }

        //Profesor
        public void DodajProfesora(Profesor profesor)
        {
            List<Profesor> profesori = ProfesoriFile.PunaPutanja().UcitajFile().PretvoriUProfesore();
            profesori.Add(profesor);
            profesori.SacuvajProfesoreUFile();
        }
        public void UkloniProfesora(Profesor profesor)
        {
            List<Profesor> sviProfesori = ProfesoriFile.PunaPutanja().UcitajFile().PretvoriUProfesore();
            List<Profesor> profesori = new List<Profesor>();
            foreach (Profesor p in sviProfesori)
            {
                if (p.ID != profesor.ID) profesori.Add(p);
            }
            profesori.SacuvajProfesoreUFile();
        }
        public List<Profesor> NadjiProfesore_ID(string id)
        {
            List<Profesor> sviProfesori = ProfesoriFile.PunaPutanja().UcitajFile().PretvoriUProfesore();
            List<Profesor> izlaz = new List<Profesor>();
            foreach(Profesor p in sviProfesori)
            {
                if (p.ID == id) izlaz.Add(p);
            }
            return izlaz;
        }
        public List<Profesor> NadjiSveProfesoreSaZaduzenjem()
        {
            List<Profesor> sviProfesori = ProfesoriFile.PunaPutanja().UcitajFile().PretvoriUProfesore();
            List<Profesor> izlaz = new List<Profesor>();
            foreach (Profesor p in sviProfesori)
            {
                if (NadjiZaduzenja_Korisnik(p.ID).Count > 0) izlaz.Add(p);
            }
            return izlaz;
        }
        public List<Profesor> NadjiSveProfesoreKojiKasne(int brojDana)
        {
            List<Profesor> sviProfesori = ProfesoriFile.PunaPutanja().UcitajFile().PretvoriUProfesore();
            List<Profesor> izlaz = new List<Profesor>();
            foreach (Profesor p in sviProfesori)
            {
                foreach (Zaduzenje z in NadjiZaduzenja_Korisnik(p.ID))
                {
                    int kasnjenje = (int)DateTime.Now.Subtract(z.DatumVracanja).TotalHours;
                    if (kasnjenje > 0 && kasnjenje / 24 + 1 >= brojDana)
                    {
                        izlaz.Add(p);
                        break;
                    }
                }
            }
            return izlaz;
        }

        //Zaduzenje
        public void DodajZaduzenje(Zaduzenje zaduzenje)
        {
            List<Zaduzenje> zaduzenja = ZaduzenjaFile.PunaPutanja().UcitajFile().PretvoriUZaduzenja();
            zaduzenja.Add(zaduzenje);
            zaduzenja.SacuvajZaduzenjaUFile();
        }
        public List<Zaduzenje> NadjiZaduzenja_Korisnik(string id)
        {
            List<Zaduzenje> svaZaduzenja = ZaduzenjaFile.PunaPutanja().UcitajFile().PretvoriUZaduzenja();
            List<Zaduzenje> izlaz = new List<Zaduzenje>();
            foreach(Zaduzenje z in svaZaduzenja)
            {
                if (z.IDKorisnika == id) izlaz.Add(z);
            }
            return izlaz;
        }
        public void UkloniZaduzenje(Zaduzenje zaduzenje)
        {
            List<Zaduzenje> svaZaduzenja = ZaduzenjaFile.PunaPutanja().UcitajFile().PretvoriUZaduzenja();
            List<Zaduzenje> izlaz = new List<Zaduzenje>();
            foreach (Zaduzenje z in svaZaduzenja)
            {
                if(!(z.IDKorisnika == zaduzenje.IDKorisnika && z.IDKnjige == zaduzenje.IDKnjige)) izlaz.Add(z);
            }
            izlaz.SacuvajZaduzenjaUFile();
        }

        public Zaduzenje NadjiZaduzenje(string korisnik, string knjiga)
        {
            List<Zaduzenje> svaZaduzenja = ZaduzenjaFile.PunaPutanja().UcitajFile().PretvoriUZaduzenja();
            foreach (Zaduzenje z in svaZaduzenja)
            {
                if (z.IDKorisnika == korisnik && z.IDKnjige == knjiga) return z;
            }
            return new Zaduzenje(korisnik,knjiga,DateTime.Now, DateTime.Now);
        }

        //Ostalo
        public void OznaciKrajGodine()
        {
            List<Ucenik> sviUcenici = UceniciFile.PunaPutanja().UcitajFile().PretvoriUUcenike();
            List<Ucenik> ucenici = new List<Ucenik>();

            foreach (Ucenik u in sviUcenici)
            {
                if (u.Razred != 4) 
                {
                    u.Razred++;
                    ucenici.Add(u);
                }
            }
            ucenici.SacuvajUcenikeUFile();
        }

        public void NapraviBackup()
        {
            DateTime dat = PoslednjiBackUpFile.PunaPutanja().UcitajFile().PretvoriUDatum();

            if(DateTime.Now.Subtract(dat).TotalDays > 1)
            {
                //Posalji backup na mail
                Email.PosaljiBackup(UceniciFile.PunaPutanja(), ProfesoriFile.PunaPutanja(), ZaduzenjaFile.PunaPutanja(), KnjigeFile.PunaPutanja());

                TextConnectorProcessor.SacuvajDatumBackupa();
            }
        }
    }
}
