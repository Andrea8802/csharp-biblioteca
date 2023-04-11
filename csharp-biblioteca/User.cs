using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class User
    {
        public string Cognome { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string NumTelefono { get; set; }
        public DateTime DataInizio { get; set; }
        public DateTime DataFine { get; set; }

        public Document Document { get; set; }
        public User(string cognome, string nome, string email, string password, string numTelefono, Document document, DateTime dataFine)
        {
            Cognome = cognome;
            Nome = nome;
            Email = email;
            Password = password;
            NumTelefono = numTelefono;
            Document = document;
            DataInizio = DateTime.Today;
            DataFine = dataFine;

        }
    }
}
