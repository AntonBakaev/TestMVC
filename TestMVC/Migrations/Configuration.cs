namespace TestMVC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TestMVC.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TestMVC.Models.MovieDBContext context)
        {
            context.Movies.AddOrUpdate(m => m.ID,
                new Models.Movie
                {
                    Title = "title",
                    ReleaseDate = new DateTime(2010, 2, 3),
                    Genre = "genre",
                    Price = 12m
                });
        }
    }
}
