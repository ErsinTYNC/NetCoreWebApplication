using Entites;
using Microsoft.EntityFrameworkCore;

namespace NetCoreWebApplication.Data
{
    public static class DataSeeding
    {
        public static void Seed(IApplicationBuilder app)
        {
            var scope = app.ApplicationServices.CreateScope();
            var context = scope.ServiceProvider.GetService<DataBaseContext>();

            context.Database.Migrate();

            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Users.Count() == 0)
                {
                    User user = new User()
                    {
                        CreateDate = DateTime.Now,
                        IsActive = true,
                        Name = "Admin",
                        Password = "123456",
                        UserName = "Admin",
                        Email = "admin@NetCoreWebApplication.net"
                    };
                    context.Users.Add(user);
                }
                context.SaveChanges();
            }
        }
    }
}
