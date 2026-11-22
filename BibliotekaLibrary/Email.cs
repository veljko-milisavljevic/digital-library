using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Text;


namespace BibliotekaLibrary
{
    
    public static class Email
    {
        // SMTP account (e.g. a Gmail address + app password) is read from environment variables
        // so that no credentials are stored in the source code.
        private static readonly string mojaEmailAdresa = Environment.GetEnvironmentVariable("BIBLIOTEKA_EMAIL") ?? "";
        private static readonly string emailLozinka = Environment.GetEnvironmentVariable("BIBLIOTEKA_EMAIL_PASSWORD") ?? "";
        private const string emailIme = "Biblioteka gimnazije Sveti Sava";
        //static readonly Bitmap logo = new Bitmap($"C:/DigitalnaBiblioteka/BibliotekaUI/bin/Debug/net6.0-windows/Logo.png");


        public static void PosaljiEmail(string to, string naslov, string teloPoruke)
        {
            if (string.IsNullOrEmpty(mojaEmailAdresa)) return; // e-mail not configured

            NetworkCredential login;
            SmtpClient client;
            MailMessage msg;

            login = new NetworkCredential(mojaEmailAdresa, emailLozinka);
            client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = login;
            msg = new MailMessage { From = new MailAddress(mojaEmailAdresa, emailIme, Encoding.UTF8) };
            msg.To.Add(new MailAddress(to));
            msg.Subject = naslov;
            
            msg.Body = teloPoruke;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;

            msg.Attachments.Add(new Attachment($"C:/DigitalnaBiblioteka/BibliotekaUI/bin/Debug/net6.0-windows/Logo.png"));

            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            //client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
            string userstate = "Slanje...";
            client.SendAsync(msg, userstate);
        }

        public static void PosaljiEmail(string to, string naslov, string teloPoruke, string qrKodPath)
        {
            if (string.IsNullOrEmpty(mojaEmailAdresa)) return; // e-mail not configured

            NetworkCredential login;
            SmtpClient client;
            MailMessage msg;

            login = new NetworkCredential(mojaEmailAdresa, emailLozinka);
            client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = login;
            msg = new MailMessage { From = new MailAddress(mojaEmailAdresa, emailIme, Encoding.UTF8) };
            msg.To.Add(new MailAddress(to));
            msg.Subject = naslov;

            msg.Body = teloPoruke;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;

            msg.Attachments.Add(new Attachment(qrKodPath));

            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            //client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
            string userstate = "Slanje...";
            client.SendAsync(msg, userstate);
        }

        public static void PosaljiBackup(string uceniciPath, string profesoriPath, string zaduzenjaPath, string knjigePath)
        {
            if (string.IsNullOrEmpty(mojaEmailAdresa)) return; // e-mail not configured

            NetworkCredential login;
            SmtpClient client;
            MailMessage msg;

            login = new NetworkCredential(mojaEmailAdresa, emailLozinka);
            client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = login;
            msg = new MailMessage { From = new MailAddress(mojaEmailAdresa, emailIme, Encoding.UTF8) };
            msg.To.Add(new MailAddress(mojaEmailAdresa));
            msg.Subject = "Rezerna kopija podataka";

            msg.Body = "U prilogu se nalaze svi potrebni fajlovi ukoliko dođe do eventualnog gubitka podataka.";
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;

            msg.Attachments.Add(new Attachment(uceniciPath));
            msg.Attachments.Add(new Attachment(profesoriPath));
            msg.Attachments.Add(new Attachment(zaduzenjaPath));
            msg.Attachments.Add(new Attachment(knjigePath));

            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            //client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
            string userstate = "Slanje...";
            client.SendAsync(msg, userstate);
        }

        public static void ObavestiKorisnikaOZaduzenju(IKorisnik korisnik, Knjiga knjiga, Zaduzenje zaduzenje)
        {
            StringBuilder telo = new StringBuilder();
            telo.AppendLine("<h1>Novo zaduženje: </h1>");
            telo.Append("<h3><strong>Knjiga: </strong>");
            telo.Append(knjiga.Naziv);
            telo.Append(", ");
            telo.Append(knjiga.Pisac);
            telo.AppendLine("</h3>");
            telo.Append("<strong>Datum uzimanja knjige: </strong>");
            telo.Append(zaduzenje.DatumUzimanja.ToShortDateString());
            telo.AppendLine("<br/>");
            telo.Append("<strong>Rok za vraćanje knjige: </strong>");
            telo.Append(zaduzenje.DatumVracanja.ToShortDateString());
            telo.AppendLine("<br/>~Školska biblioteka");

            PosaljiEmail(korisnik.Email, "Zadužena knjiga", telo.ToString());
        }

        public static void ObavestiUcenikaOKasnjenju(IKorisnik ucenik, Knjiga knjiga, Zaduzenje zaduzenje)
        {
            int kasnjenje = ((int)DateTime.Now.Subtract(zaduzenje.DatumVracanja).TotalHours) / 24 + 1;


            StringBuilder telo = new StringBuilder();
            telo.AppendLine("<h1>Podsetnik za vraćanje knjige</h1>");
            telo.Append("<h3><strong>Knjiga: </strong>");
            telo.Append(knjiga.Naziv);
            telo.Append(", ");
            telo.Append(knjiga.Pisac);
            telo.AppendLine("</h3>");
            telo.Append("<strong>Datum uzimanja knjige: </strong>");
            telo.Append(zaduzenje.DatumUzimanja.ToShortDateString());
            telo.AppendLine("<br/>");
            telo.Append("<strong>Rok za vraćanje knjige: </strong>");
            telo.Append(zaduzenje.DatumVracanja.ToShortDateString());
            telo.AppendLine("<br/>");

            if(kasnjenje > 30)
            {
                telo.Append("Tvoje trenutno zaduženje iznosi: ");
                telo.Append((kasnjenje-30)*10);
                telo.AppendLine(" dinara.");
            }

            telo.AppendLine("<br/>Svako kašnjenje preko 30 dana se naplaćuje 10 dinara po danu!");
            telo.AppendLine("</br>Podsećamo te da je neophodno da vratiš sve uzete knjige do kraja školske godine, jer u suprotnom ne možeš dobiti svedočanstvo.");
            telo.AppendLine("</br>Ako ne možeš da nađeš knjigu ili je oštećena možeš da nabaviš novu u dogovoru sa bibliotekarom.");
            telo.AppendLine("<br/><br/>~Školska biblioteka");

            PosaljiEmail(ucenik.Email, "Kašnjenje", telo.ToString());
        }

        public static void ObavestiProfesoraOKasnjenju(IKorisnik profesor, Knjiga knjiga, Zaduzenje zaduzenje)
        {
            StringBuilder telo = new StringBuilder();
            telo.AppendLine("<h1>Podsetnik za vraćanje knjige</h1>");
            telo.Append("<h3><strong>Knjiga: </strong>");
            telo.Append(knjiga.Naziv);
            telo.Append(", ");
            telo.Append(knjiga.Pisac);
            telo.AppendLine("</h3>");
            telo.Append("<strong>Datum uzimanja knjige: </strong>");
            telo.Append(zaduzenje.DatumUzimanja.ToShortDateString());
            telo.AppendLine("<br/>");
            telo.Append("<strong>Rok za vraćanje knjige: </strong>");
            telo.Append(zaduzenje.DatumVracanja.ToShortDateString());
            telo.AppendLine("<br/>");

            telo.AppendLine("</br>Poštovani,\nPodsećamo Vas da je istekao rok za vraćanje knjiga u školsku biblioteku, pa Vas molimo da izmirite Vaša zaduženja.");
            telo.AppendLine("<br/><br/>~Školska biblioteka");

            PosaljiEmail(profesor.Email, "Kašnjenje", telo.ToString());
        }

        public static void ObavestiUcenikaOUclanjenju(Ucenik ucenik, string path)
        {
            StringBuilder telo = new StringBuilder();
            telo.AppendLine("<h1>Dobrodošli u školsku biblioteku!</h1>");
            telo.AppendLine("</br>U školskoj biblioteci možeš pozajmljivati knjige i koristiti čitaonicu. Sve usluge školske biblioteke su besplatne.");
            telo.AppendLine("<br/>U prilogu se nalazi tvoja članska karta (QR kod). Pri uzimanju i vraćanju knjiga možeš ga samo pokazati bibliotekaru na svom telefonu ili ga odštampati.");
            
            telo.AppendLine("<br/><br/>~Školska biblioteka");

            PosaljiEmail(ucenik.Email, "Učlanjenje u školsku biblioteku", telo.ToString(), path);
        }
    }
}
