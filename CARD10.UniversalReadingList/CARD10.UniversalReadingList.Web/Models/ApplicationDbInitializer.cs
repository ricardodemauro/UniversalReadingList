using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARD10.UniversalReadingList.Web.Models
{
    public class ApplicationDbInitializer : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            IEnumerable<Category> categoryColl = new List<Category>
            {
                new Category()
                {
                    Title = "Category 1"
                },
                new Category()
                {
                    Title = "Category 2"
                },
                new Category()
                {
                    Title = "Category 3"
                },
            };

            context.Categories.AddRange(categoryColl);

            context.SaveChanges();

            IEnumerable<ReadItem> readItemColl = new List<ReadItem>
            {
                new ReadItem()
                {
                    Title = "Lista 1",
                    Uri = "http://www.google.com",
                    Description = "Google",
                    CategoryId = 1
                },
                new ReadItem()
                {
                    Title = "Lista 2",
                    Uri = "http://www.google.com",
                    Description = "Google 2",
                    CategoryId = 2
                },
                new ReadItem()
                {
                    Title = "Lista 3",
                    Uri = "http://www.google.com",
                    Description = "Google 3",
                    CategoryId = 3
                },
                new ReadItem()
                {
                    Title = "Lista 4",
                    Uri = "http://www.google.com",
                    Description = "Google 4",
                    CategoryId = 1
                }
            };

            context.ReadItems.AddRange(readItemColl);

            context.SaveChanges();
            base.Seed(context);
        }
    }
}
