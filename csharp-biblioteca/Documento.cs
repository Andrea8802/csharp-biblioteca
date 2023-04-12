using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    abstract class Documento
    {
        public string CodiceIdentificativo { get; set; }
        public string Titolo { get; set; }
        public int Anno { get; set; }
        public string Settore { get; set; }
        public string Scaffale { get; set; }
        public Autore Autore { get; set; }
    }

    class Libro : Documento
    {
        public int NumeroPagine { get; set; }
    }

    class DVD : Documento
    {
        public TimeSpan Durata { get; set; }
    }
}
