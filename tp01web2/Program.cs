using Microsoft.AspNetCore.Hosting;
using System;
using System.Threading;
using tp01web2;

namespace tp01web2
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebHost host = new WebHostBuilder()
            .UseKestrel()
            .UseStartup<Startup>()
            .Build();
            host.Run();

            Author[] at = new Author[2];
            Author a = new Author("Autor 1", "Autor1@gmail.com", 'f');
            Author a1 = new Author("Autora 2", "Autora2@gmail.com", 'f');
            at.SetValue(a, 0);
            at.SetValue(a1, 1);
            Book b = new Book("Livro Teste",at,25.00,2);
            Console.WriteLine(b.ToString());
            Console.WriteLine();
            Console.WriteLine(b.getAuthorNames());            

            Console.ReadKey();
        }
    }
}
