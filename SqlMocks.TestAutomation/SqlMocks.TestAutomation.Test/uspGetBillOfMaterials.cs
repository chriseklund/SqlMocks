using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
//using SqlMocks;
using SqlMocks.DAL.Core.DbContexts;
using System.Configuration;

namespace SqlMocks.TestAutomation.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ReturnsBillOfMaterials()
        {

            //Arrange
            var cnString = ConfigurationManager.ConnectionStrings["ConnectionString.LocalDb"].ConnectionString;

            var dbContextOptionBuilder = new DbContextOptionBuilder<AutomationDbContext>();
            var dbContextOptions = dbContextOptionBuilder.GetDbContextOptions(cnString);

            var dbContext = new AutomationDbContext(dbContextOptions);

            var mock = new Mock(cnString);

            mock.MockObject("Production", "BillOfMaterials");
            mock.MockObject("Production", "Product");

            //GetProductRecord();
            //Act


            //Assert

            Assert.Pass();
        }


    }
}