namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Library library = new Library();

            library.createUser();

            library.showLoans();

            Console.WriteLine("Vuoi aggiungere un nuovo documento?");
            Console.WriteLine("Yes : No");

            if (Console.ReadLine() == "Yes")
            {
                library.newDocument();

                Console.WriteLine("Il tuo documento è stato creato!");
            }

        }
    }
}