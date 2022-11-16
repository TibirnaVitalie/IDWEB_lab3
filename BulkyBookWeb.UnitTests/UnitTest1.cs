using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BulkyBookWeb.Controllers;
using BulkyBookWeb.Data;

namespace BulkyBookWeb.UnitTests
{
     [TestClass]
     public class UnitTest1
     {
          [TestMethod]
          public void TestMethod1()
          {
               var connectionstring = "Server=TIBIRNA;Database=Bulky;Trusted_Connection=True;";

               var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
               optionsBuilder.UseSqlServer(connectionstring);

               using (var dbContext = new ApplicationDbContext(optionsBuilder.Options))
               {
                    var categoryController = new CategoryController(dbContext);

                    Assert.AreEqual(2, categoryController.GetCategoryById(2).Id);
               }

          }

          [TestMethod]
          public void TestMethod2()
          {
               var connectionstring = "Server=TIBIRNA;Database=Bulky;Trusted_Connection=True;";

               var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
               optionsBuilder.UseSqlServer(connectionstring);

               using (var dbContext = new ApplicationDbContext(optionsBuilder.Options))
               {
                    var categoryController = new CategoryController(dbContext);

                    Assert.AreEqual("Shoes", categoryController.GetCategoryByName("Shoes").Name);
               }

          }

          [TestMethod]
          public void TestMethod3()
          {
               var connectionstring = "Server=TIBIRNA;Database=Bulky;Trusted_Connection=True;";

               var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
               optionsBuilder.UseSqlServer(connectionstring);

               using (var dbContext = new ApplicationDbContext(optionsBuilder.Options))
               {
                    var categoryController = new CategoryController(dbContext);

                    Assert.AreEqual(444, categoryController.GetCategoryByPrice(444).Price);
               }

          }
     }
}