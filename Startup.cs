using EservicesProject.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EservicesProject.Startup))]
namespace EservicesProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateUserAndRoles();
        }
        public void CreateUserAndRoles()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var RoleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            //if (!RoleManager.RoleExists("SuperAdmin"))
            //{
            //    var role = new IdentityRole("SuperAdmin");
            //    RoleManager.Create(role);

            //    var user = new ApplicationUser();
            //    user.UserName ="Admin@1234";
            //    user.Email="Admin@admin.com";
            //    string pwd = "Pass@1234";

            //    var newuser = UserManager.Create(user, pwd);

            //    if (newuser.Succeeded)
            //    {
            //        UserManager.AddToRole(user.Id, "SuperAdmin");
            //    }
            //}

        }
    }
}
