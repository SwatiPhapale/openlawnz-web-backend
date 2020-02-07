using NUnit.Framework;

namespace Tests
{
    using api.Controllers;
    using api.Entities;
    using System;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Sqlite;
    using Microsoft.Data.Sqlite;

    [TestFixture]
    public class FoldersControllerTests
    {
        private SqliteConnection sqliteConnection;
        private BackendContext backendContext;

        [SetUp]
        public void Setup()
        {
            //New in-memory SQLite database
            sqliteConnection = new SqliteConnection("DataSource=:memory:");
            sqliteConnection.Open();
            var options = new DbContextOptionsBuilder<BackendContext>()
                    .UseSqlite(sqliteConnection)
                    .Options;

            backendContext = new BackendContext(options);
            backendContext.Database.EnsureCreated();
            Seeder.Seed(backendContext);
        }

        [TearDown]
        public void TearDown()
        {
            sqliteConnection.Close();
            backendContext.Dispose();
        }

        [Test]
        public void ExampleTest()
        {
            Assert.That(true);
        }
    }
}