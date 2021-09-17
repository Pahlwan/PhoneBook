using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repository;
using Microsoft.EntityFrameworkCore;

namespace UI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string connectionString = "server=localhost; port=3306; database=phone_directory; user=root; password=3010; Persist Security Info=False; Connect Timeout=300";
            DbContextOptionsBuilder dbContextBuilder =new DbContextOptionsBuilder().UseMySql(connectionString, ServerVersion.AutoDetect(connectionString), null);
            PlutoContext plutoContext = new PlutoContext(new DbContextOptionsBuilder().UseMySql(connectionString, ServerVersion.AutoDetect(connectionString), null).Options);
            plutoContext.Database.EnsureCreated();
            UnitOfWork unitOfWork = new UnitOfWork(plutoContext);
            
            Application.Run(new PhoneDirectory(unitOfWork));
        }
    }
}
