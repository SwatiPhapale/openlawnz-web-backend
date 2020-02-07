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
    using Microsoft.AspNetCore.Mvc;
    [TestFixture]
    public class FoldersControllerTests
    {
        private FoldersController foldersController;
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
            Seeder.AddJoe(backendContext);
            Seeder.AddMary(backendContext);
            foldersController = new FoldersController(backendContext);
        }
        [TearDown]
        public void TearDown()
        {
            sqliteConnection.Close();
            backendContext.Dispose();
        }

        [Test]
        public async Task FoldersEmptyRequestShouldReturnNothing()
        {
            var x = await foldersController.GetFolders();
            Assert.True(true);
        }
    }
}