using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Document
    {
        public string Codice { get; set; }
        public string Titolo { get; set; }
        public string NomeAutore { get; set; }
        public string CognomeAutore { get; set; }
        public string Anno { get; set; }
        public string Settore { get; set; }
        public string Scaffale { get; set; }

        Random rnd = new Random();

        public Document(string titolo, string nomeAutore, string cognomeAutore, string anno, string settore, string scaffale)
        {
            Codice = rnd.Next(1, 1001).ToString();
            Titolo = titolo;
            NomeAutore = nomeAutore;
            CognomeAutore = cognomeAutore;
            Anno = anno;
            Settore = settore;
            Scaffale = scaffale;
        }


        public class Dvd : Document
        {

            public int Durata { get;set; }

            public Dvd(string titolo, string nomeAutore, string cognomeAutore, string anno, string settore, string scaffale, int durata) : base(titolo, anno, nomeAutore, cognomeAutore, settore, scaffale)
            {
                Durata = durata;
            }
        }

        public class Book : Document
        {

            public int NumPagine { get; set; }

            public Book(string titolo, string nomeAutore, string cognomeAutore, string anno, string settore, string scaffale, int numPagine) : base(titolo, anno, nomeAutore, cognomeAutore, settore, scaffale)
            {
                NumPagine = numPagine;
            }

            


        }
    }
}
