using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using ezQ.Api.Infrastructure;

namespace ezQ.Api.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ezQ.Api.Infrastructure.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ezQ.Api.Infrastructure.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));

            var user = new ApplicationUser()
            {
                UserName = "admin",
                Email = "super.admin@mail.com",
                EmailConfirmed = true,
                FirstName = "Super",
                LastName = "Admin",
                Level = 1,
                JoinDate = DateTime.Now.AddYears(-3),

                UserProfile = new UserProfile()
                {
                    AddressStreet = "15686 107 Avenue",
                    AddressCity = "Surrey",
                    AddressProvState = "British Columbia",
                    AddressPostZip = "V4N 3H8",
                    AddressCountry = "Canada",

                    ContactEmail = "bob.yuan@yahoo.com",
                    ContactTelephone = "604-619-5810",
                    ContactOthers = ""
                }

            };

            manager.Create(user, "P@ssword!");

            if (roleManager.Roles.Count() == 0)
            {
                roleManager.Create(new IdentityRole { Name = "Admin" });
                roleManager.Create(new IdentityRole { Name = "Executive" });
                roleManager.Create(new IdentityRole { Name = "Director" });
                roleManager.Create(new IdentityRole { Name = "Member" });
                roleManager.Create(new IdentityRole { Name = "Volunteer" });
            }

            var adminUser = manager.FindByName("admin");

            manager.AddToRoles(adminUser.Id, new string[] { "Admin", "admin" });
        }
    }
}
