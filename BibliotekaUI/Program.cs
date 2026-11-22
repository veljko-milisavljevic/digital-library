namespace BibliotekaUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            BibliotekaLibrary.GlobalConfig.UspostaviVezu(); //Povezuje se samo text file

            Application.Run(new DigitalnaBiblioteka());
        }
    }
}