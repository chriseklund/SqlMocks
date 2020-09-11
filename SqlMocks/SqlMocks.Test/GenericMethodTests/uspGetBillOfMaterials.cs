using NUnit.Framework;
using System.Configuration;

using SqlMocks.AdventureWorksDb.DAL.Helpers;
using SqlMocks.AdventureWorksDb.DAL.DbContexts;
using SqlMocks.DAL.Core.Entities;
using System;

using System.Data;
using System.Transactions;

namespace SqlMocks.Test.GenericMethodTests
{
    public class uspGetBillOfMaterials
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void uspGetBillOfMaterialsReturnCorrectValues()
        {
            var a = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
                    .FilePath;

            using (TransactionScope scope = new TransactionScope())
            {
                //Arrange
                var cnString = ConfigurationManager.ConnectionStrings["ConnectionString.LocalDb"].ConnectionString;
                var mock = new Mock(cnString);
                var dbContextOptionBuilder = new DbContextOptionBuilder<AutomationDbContext>();
                var dbContextOptions = dbContextOptionBuilder.GetDbContextOptions(mock.SqlCn);

                mock.MockObject("Production", "BillOfMaterials");
                mock.RemoveDependencies("Production", "Product");
                mock.MockObject("Production", "Product");

                var dbContext = new AutomationDbContext(dbContextOptions);

                Product product2 = new Product
                {
                    ProductID = 2,
                    Name = "Bearing Ball",
                    ProductNumber = "BA-8327",
                    MakeFlag = false,
                    FinishedGoodsFlag = false,
                    Color = null,
                    SafetyStockLevel = 1000,
                    ReorderPoint = 750,
                    StandardCost = 0,
                    ListPrice = 0,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null,
                    DaysToManufacture = 0,
                    ProductLine = null,
                    Class = null,
                    Style = null,
                    ProductSubcategoryID = null,
                    ProductModelID = null,
                    SellStartDate = DateTime.Parse("2008-04-30 00:00:00.000"),
                    SellEndDate = null,
                    DiscontinuedDate = null,
                    ModifiedDate = DateTime.Parse("2014-02-08 10:01:36.827")

                };

                Product product461 = new Product
                {
                    ProductID = 461,
                    Name = "Lock Ring",
                    ProductNumber = "LR-2398",
                    MakeFlag = false,
                    FinishedGoodsFlag = false,
                    Color = "Silver",
                    SafetyStockLevel = 1000,
                    ReorderPoint = 750,
                    StandardCost = 0,
                    ListPrice = 0,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null,
                    DaysToManufacture = 0,
                    ProductLine = null,
                    Class = null,
                    Style = null,
                    ProductSubcategoryID = null,
                    ProductModelID = null,
                    SellStartDate = DateTime.Parse("2008-04-30 00:00:00.000"),
                    SellEndDate = null,
                    DiscontinuedDate = null,
                    ModifiedDate = DateTime.Parse("2014-02-08 10:01:36.827")

                };

                Product product504 = new Product
                {
                    ProductID = 504,
                    Name = "Cup-Shaped Race",
                    ProductNumber = "RA-2345",
                    MakeFlag = false,
                    FinishedGoodsFlag = false,
                    Color = null,
                    SafetyStockLevel = 1000,
                    ReorderPoint = 750,
                    StandardCost = 0,
                    ListPrice = 0,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null,
                    DaysToManufacture = 0,
                    ProductLine = null,
                    Class = null,
                    Style = null,
                    ProductSubcategoryID = null,
                    ProductModelID = null,
                    SellStartDate = DateTime.Parse("2008-04-30 00:00:00.000"),
                    SellEndDate = null,
                    DiscontinuedDate = null,
                    ModifiedDate = DateTime.Parse("2014-02-08 10:01:36.827")

                };

                Product product505 = new Product
                {
                    ProductID = 505,
                    Name = "Cone-Shaped Race",
                    ProductNumber = "RA-7490",
                    MakeFlag = false,
                    FinishedGoodsFlag = false,
                    Color = null,
                    SafetyStockLevel = 1000,
                    ReorderPoint = 750,
                    StandardCost = 0,
                    ListPrice = 0,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null,
                    DaysToManufacture = 0,
                    ProductLine = null,
                    Class = null,
                    Style = null,
                    ProductSubcategoryID = null,
                    ProductModelID = null,
                    SellStartDate = DateTime.Parse("2008-04-30 00:00:00.000"),
                    SellEndDate = null,
                    DiscontinuedDate = null,
                    ModifiedDate = DateTime.Parse("2014-02-08 10:01:36.827")
                };

                BillOfMaterials billOfMaterials2 = new BillOfMaterials()
                {
                    BillOfMaterialsID = 2000,
                    ProductAssemblyID = 3,
                    ComponentID = 2,
                    StartDate = DateTime.Parse("2010-07-08 00:00:00.000"),
                    EndDate = null,
                    UnitMeasureCode = "EA",
                    BOMLevel = 3,
                    PerAssemblyQty = 10,
                    ModifiedDate = DateTime.Parse("2010-06-24 00:00:00.000")
                };

                BillOfMaterials billOfMaterials461 = new BillOfMaterials()
                {
                    BillOfMaterialsID = 1657,
                    ProductAssemblyID = 3,
                    ComponentID = 461,
                    StartDate = DateTime.Parse("2010-06-19 00:00:00.000"),
                    EndDate = null,
                    UnitMeasureCode = "EA",
                    BOMLevel = 3,
                    PerAssemblyQty = 1,
                    ModifiedDate = DateTime.Parse("2010-06-05 00:00:00.000")
                };

                BillOfMaterials billOfMaterials504 = new BillOfMaterials()
                {
                    BillOfMaterialsID = 389,
                    ProductAssemblyID = 3,
                    ComponentID = 504,
                    StartDate = DateTime.Parse("2010-03-18 00:00:00.000"),
                    EndDate = null,
                    UnitMeasureCode = "EA",
                    BOMLevel = 3,
                    PerAssemblyQty = 2,
                    ModifiedDate = DateTime.Parse("2010-03-04 00:00:00.000")
                };

                BillOfMaterials billOfMaterials505 = new BillOfMaterials()
                {
                    BillOfMaterialsID = 389,
                    ProductAssemblyID = 3,
                    ComponentID = 505,
                    StartDate = DateTime.Parse("2010-05-26 00:00:00.000"),
                    EndDate = null,
                    UnitMeasureCode = "EA",
                    BOMLevel = 3,
                    PerAssemblyQty = 2,
                    ModifiedDate = DateTime.Parse("2010-05-26 00:00:00.000")
                };

                mock.Insert(product2, dbContext);
                mock.Insert(product461, dbContext);
                mock.Insert(product504, dbContext);
                mock.Insert(product505, dbContext);

                mock.Insert(billOfMaterials2, dbContext);
                mock.Insert(billOfMaterials461, dbContext);
                mock.Insert(billOfMaterials504, dbContext);
                mock.Insert(billOfMaterials505, dbContext);

                //Act

                var actualResult = mock.ExecuteQueryToDatatable($"Execute dbo.uspGetBillOfMaterials 3, {DateTime.Now}");

                //Assert

                Assert.Multiple(() =>
                {
                    DataRow[] rows = actualResult.Select();

                    for (var i = 0; i < rows.Length; i++)
                    {
                        var productId = rows[i]["ComponentID"];

                        switch (productId)
                        {
                            case 2:
                                Assert.AreEqual(billOfMaterials2.ProductAssemblyID, rows[i]["ProductAssemblyID"]);
                                Assert.AreEqual(billOfMaterials2.ComponentID, rows[i]["ProductID"]);
                                Assert.AreEqual(billOfMaterials2.PerAssemblyQty, rows[i]["TotalQuantity"]);
                                Assert.AreEqual(billOfMaterials2.BOMLevel, rows[i]["BOMLevel"]);

                                Assert.AreEqual(product2.ProductID, rows[i]["ProductID"]);
                                Assert.AreEqual(product2.Name, rows[i]["ComponentDesc"]);
                                Assert.AreEqual(product2.StandardCost, rows[i]["StandardCost"]);
                                Assert.AreEqual(product2.ListPrice, rows[i]["ListPrice"]);

                                break;

                            case 461:
                                Assert.AreEqual(billOfMaterials461.ProductAssemblyID, rows[i]["ProductAssemblyID"]);
                                Assert.AreEqual(billOfMaterials461.ComponentID, rows[i]["ProductID"]);
                                Assert.AreEqual(billOfMaterials461.PerAssemblyQty, rows[i]["TotalQuantity"]);
                                Assert.AreEqual(billOfMaterials461.BOMLevel, rows[i]["BOMLevel"]);

                                Assert.AreEqual(product461.ProductID, rows[i]["ProductID"]);
                                Assert.AreEqual(product461.Name, rows[i]["ComponentDesc"]);
                                Assert.AreEqual(product461.StandardCost, rows[i]["StandardCost"]);
                                Assert.AreEqual(product461.ListPrice, rows[i]["ListPrice"]);

                                break;

                            case 504:
                                Assert.AreEqual(billOfMaterials504.ProductAssemblyID, rows[i]["ProductAssemblyID"]);
                                Assert.AreEqual(billOfMaterials504.ComponentID, rows[i]["ProductID"]);
                                Assert.AreEqual(billOfMaterials504.PerAssemblyQty, rows[i]["TotalQuantity"]);
                                Assert.AreEqual(billOfMaterials504.BOMLevel, rows[i]["BOMLevel"]);

                                Assert.AreEqual(product504.ProductID, rows[i]["ProductID"]);
                                Assert.AreEqual(product504.Name, rows[i]["ComponentDesc"]);
                                Assert.AreEqual(product504.StandardCost, rows[i]["StandardCost"]);
                                Assert.AreEqual(product504.ListPrice, rows[i]["ListPrice"]);

                                break;

                            case 505:
                                Assert.AreEqual(billOfMaterials505.ProductAssemblyID, rows[i]["ProductAssemblyID"]);
                                Assert.AreEqual(billOfMaterials505.ComponentID, rows[i]["ProductID"]);
                                Assert.AreEqual(billOfMaterials505.PerAssemblyQty, rows[i]["TotalQuantity"]);
                                Assert.AreEqual(billOfMaterials505.BOMLevel, rows[i]["BOMLevel"]);

                                Assert.AreEqual(product505.ProductID, rows[i]["ProductID"]);
                                Assert.AreEqual(product505.Name, rows[i]["ComponentDesc"]);
                                Assert.AreEqual(product505.StandardCost, rows[i]["StandardCost"]);
                                Assert.AreEqual(product505.ListPrice, rows[i]["ListPrice"]);

                                break;

                            default:
                                Assert.AreEqual(0, 1, $"Result set came back with extra records. ProductID: {productId}");
                                break;

                        }


                    }

                });
            }
        }
    }
}