using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaLibrary
{
    public static class GlobalConfig
    {
        //public static IDataConnection Veza { get; set; }
        public static IDataConnection Veze { get; private set; }
        public static void UspostaviVezu()
        {
            TextConnector text = new TextConnector();
            Veze = text;
        }
    }
}
