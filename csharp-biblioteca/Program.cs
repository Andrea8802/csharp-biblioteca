namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();

            // Richiedi i dati dell'utente
            Console.Write("Inserisci il cognome dell'utente: ");
            string cognome = Console.ReadLine();
            Console.Write("Inserisci il nome dell'utente: ");
            string nome = Console.ReadLine();
            Console.Write("Inserisci l'email dell'utente: ");
            string email = Console.ReadLine();
            Console.Write("Inserisci la password dell'utente: ");
            string password = Console.ReadLine();
            Console.Write("Inserisci il recapito telefonico dell'utente: ");
            string recapitoTelefonico = Console.ReadLine();

            // Crea un nuovo utente e lo aggiungi alla lista degli utenti della biblioteca
            Utente utente = new Utente
            {
                Cognome = cognome,
                Nome = nome,
                Email = email,
                Password = password,
                RecapitoTelefonico = recapitoTelefonico
            };
            biblioteca.AggiungiUtente(utente);

            // Richiedi i dati del documento
            Console.Write("Inserisci il codice identificativo del documento: ");
            string codiceIdentificativo = Console.ReadLine();
            Console.Write("Inserisci il titolo del documento: ");
            string titolo = Console.ReadLine();
            Console.Write("Inserisci l'anno del documento: ");
            int anno = int.Parse(Console.ReadLine());
            Console.Write("Inserisci il settore del documento: ");
            string settore = Console.ReadLine();
            Console.Write("Inserisci lo scaffale del documento: ");
            string scaffale = Console.ReadLine();
            Console.Write("Inserisci il nome dell'autore del documento: ");
            string nomeAutore = Console.ReadLine();
            Console.Write("Inserisci il cognome dell'autore del documento: ");
            string cognomeAutore = Console.ReadLine();

            // Crea un nuovo autore e un nuovo documento (in base al tipo)
            Autore autore = new Autore
            {
                Nome = nomeAutore,
                Cognome = cognomeAutore
            };
            Documento documento;
            Console.Write("Il documento è un libro o un DVD? (L/D): ");
            string tipoDocumento = Console.ReadLine().ToUpper();
            switch (tipoDocumento)
            {
                case "L":
                    Console.Write("Inserisci il numero di pagine del libro: ");
                    int numeroPagine = int.Parse(Console.ReadLine());
                    documento = new Libro
                    {
                        CodiceIdentificativo = codiceIdentificativo,
                        Titolo = titolo,
                        Anno = anno,
                        Settore = settore,
                        Scaffale = scaffale,
                        Autore = autore,
                        NumeroPagine = numeroPagine
                    };
                    break;
                case "D":
                    Console.Write("Inserisci la durata del DVD (in minuti): ");
                    int durataMinuti = int.Parse(Console.ReadLine());
                    TimeSpan durata = TimeSpan.FromMinutes(durataMinuti);
                    documento = new DVD
                    {
                        CodiceIdentificativo = codiceIdentificativo,
                        Titolo = titolo,
                        Anno = anno,
                        Settore = settore,
                        Scaffale = scaffale,
                        Autore = autore,
                        Durata = durata
                    };
                    break;
            }
        }
    }
}