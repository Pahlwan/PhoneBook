using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Repository;

namespace RepositoryTests
{
    [TestClass]
    class PersonRepositoryTest
    {
        [TestMethod]
        public void TestConnection()
        {
            string connectionstring = "server=localhost; port=3306; database=paper_trader; user=root; password=3010; Persist Security Info=False; Connect Timeout=300";
            Microsoft.EntityFrameworkCore.DbContextOptionsBuilder dbContextOptionsBuilder = new DbContextOptionsBuilder();
            DbContextOptions options = dbContextOptionsBuilder.UseMySql(connectionstring, ServerVersion.Parse("8.0.26.0"), null).Options;

            PlutoContext plutoContext = new PlutoContext(options);
            string error = null;
            try
            {
                plutoContext.Database.OpenConnection();
            }
            catch(Exception ex)
            {
                error = $"{ex.Message}";
            }
            Assert.IsNull(error,error);
            
        }
    }
}
