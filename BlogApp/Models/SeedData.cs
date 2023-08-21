using BlogApp.Data;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcBlogContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcBlogContext>>()))
            {
                if(context.Users.Any())
                {
                    return;
                }
                context.Users.AddRange(
                    new User
                    {
                        UserName = "admin",
                        Email = "admin@gmail.com",
                        Password = "admin",
                    },

                    new User
                    {
                        UserName = "dex",
                        Email = "dex@gmail.com",
                        Password = "dex",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
