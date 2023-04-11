using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Library
    {
        public List<Document> DocumentsList { get; set; }
        public List<User> Users { get; set; }

        public Library()
        {
            Users = new List<User>();

            Document[] documents = new Document[]{
                new Document.Dvd("Dvd1", "2020", "Autore1", "CognomeAutore1", "settore1", "2", 120),
                new Document.Dvd("Dvd2", "2023", "Autore2", "CognomeAutore2", "settore2", "3", 90),
                new Document.Dvd("Dvd3", "2012", "Autore3", "CognomeAutore3", "settore3", "6", 60),
                new Document.Book("Libro1", "2023","Autore4", "CognomeAutore4", "settore5", "7", 350),
                new Document.Book("Libro2", "2022", "Autore5", "CognomeAutore5", "settore1", "2",500),
            };

            List<Document> documentList = new List<Document>();


            for (int i = 0; i < documents.Length; i++)
            {
                documentList.Add(documents[i]);
            }

            DocumentsList = documentList;

        }

        public void createUser()
        {
            Console.WriteLine("Ciao! Registrati!");
            Console.WriteLine("Inserisci il tuo Cognome...");
            string cognome = Console.ReadLine();

            Console.WriteLine("Inserisci il tuo nome...");
            string nome = Console.ReadLine();

            Console.WriteLine("Inserisci il tuo Email...");
            string email = Console.ReadLine();

            Console.WriteLine("Inserisci il tuo Password...");
            string password = Console.ReadLine();

            Console.WriteLine("Inserisci il tuo Numero di telefono...");
            string numTelefono = Console.ReadLine();

            Console.WriteLine("Data consegna...");
            DateTime dataFine = DateTime.Parse(Console.ReadLine());

            Document docSelezionato = this.searchDocument();
            Console.WriteLine($"Hai selezionato: {docSelezionato.Titolo}");

            Users.Add(new User(cognome, nome, email, password, numTelefono, docSelezionato, dataFine));
        }

        public Document? searchDocument()
        {
            Console.WriteLine("Cerca un documento: ");

            return DocumentsList.Find(document => Console.ReadLine() == document.Titolo);

        }

        public void showLoans()
        {
            Console.WriteLine("I prestiti sono");
            for (int i = 0; i < Users.Count; i++)
            {
                Console.WriteLine($"{i + 1}) Utente: {Users[i].Nome} {Users[i].Cognome} con il documento: {Users[i].Document.Titolo} fino al {Users[i].DataFine}");
            }
        }

        public void newDocument()
        {
            Console.WriteLine("Inserisci Titolo");
            string titolo = Console.ReadLine();

            Console.WriteLine("Inserisci Nome Autore");
            string nomeAutore = Console.ReadLine();

            Console.WriteLine("Inserisci Cognome Autore");
            string cognomeAutore = Console.ReadLine();

            Console.WriteLine("Inserisci Anno");
            string anno = Console.ReadLine();

            Console.WriteLine("Inserisci Settore");
            string settore = Console.ReadLine();

            Console.WriteLine("Inserisci Scaffale");
            string scaffale = Console.ReadLine();

            Console.WriteLine("Inserisci tipologia:");
            Console.WriteLine("1)DVD");
            Console.WriteLine("2)Libro");
            string tipo = Console.ReadLine();

            if (tipo == "1")
            {
                Console.WriteLine("Inserisci Durata:");
                int durata = int.Parse(Console.ReadLine());
                DocumentsList.Add(new Document.Dvd(titolo, nomeAutore, cognomeAutore, anno, settore, scaffale, durata));
            }

            else
            {
                Console.WriteLine("Inserisci Pagine:");
                int pagine = int.Parse(Console.ReadLine());
                DocumentsList.Add(new Document.Dvd(titolo, nomeAutore, cognomeAutore, anno, settore, scaffale, pagine));

            }

        }
    }
}
