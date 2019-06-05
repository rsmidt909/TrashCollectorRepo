using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using TrashCollector.Models;

[assembly: OwinStartupAttribute(typeof(TrashCollector.Startup))]
namespace TrashCollector
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            createRolesAndUsers();
        }
        private void createRolesAndUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));


            
            

            // creating Creating Employee role    
            if (!roleManager.RoleExists("TrashGoblin"))
            {
                var role = new IdentityRole();
                role.Name = "TrashGoblin";
                roleManager.Create(role);

            }

            if (!roleManager.RoleExists("TrashGiveAwayer"))
            {
                var role = new IdentityRole();
                role.Name = "TrashGiveAwayer";
                roleManager.Create(role);
            }
        }
    }
}
