namespace BibliotekaLibrary
{
    public interface IKorisnik
    {
        string ID { get; set; }
        string Ime { get; set; }
        string Prezime { get; set; }
        string ImeRoditelja { get; set; }
        DateTime DatumRodjenja { get; set; }
        string Adresa { get; set; }
        string BrTelefona { get; set; }
        string PunoIme { get; }
        string Email { get; }
    }
}
