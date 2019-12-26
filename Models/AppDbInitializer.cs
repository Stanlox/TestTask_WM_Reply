using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WM_Reply.Models
{
    public class AppDbInitializer : DropCreateDatabaseAlways<ApplicationDbContext> 
    {
        protected override void Seed(ApplicationDbContext context)
        {


            var userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(context));
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));


            var roleAdmin = new IdentityRole { Name = "admin" };
            var roleUser = new IdentityRole { Name = "user" };
            roleManager.Create(roleAdmin);
            roleManager.Create(roleUser);


            var admin = new ApplicationUser { Email = "exampleAdmin@google.com", UserName = "MaxB2" };
            string passwordAdmin = "12345";
            var rezultAdmin = userManager.Create(admin, passwordAdmin);

            if(rezultAdmin.Succeeded)
            {
                userManager.AddToRole(admin.Id, roleAdmin.Name);
            }

            var user = new ApplicationUser { Email = "exampleUser.com", UserName = "Straik" };
            string passworUser = "54321";
            var rezultUser = userManager.Create(admin, passworUser);

            if (rezultUser.Succeeded)
            {
                userManager.AddToRole(user.Id, roleUser.Name);
            }


            base.Seed(context);
        }
    }
}