using Microsoft.EntityFrameworkCore;
using Repository;
using System;

namespace MainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string connectionstring = "server=localhost; port=3306; database=paper_trader; user=root; password=3010; Persist Security Info=False; Connect Timeout=300";
            DbContextOptionsBuilder dbContextOptionsBuilder = new DbContextOptionsBuilder();
            DbContextOptions options = dbContextOptionsBuilder.UseMySql(connectionstring, ServerVersion.AutoDetect(connectionstring), null).Options;

            PlutoContext plutoContext = new PlutoContext(options);
            plutoContext.Database.EnsureCreated();
            if(plutoContext!=null)
            {
                plutoContext.people.Add(new Repository.Models.Person() { id = 1,name = "Mukesh", phoneNumber = "7737713067", address = "63a mahendra nager" });
                plutoContext.SaveChanges();
                Console.WriteLine("Connected.");
            }
        }
    }
}
