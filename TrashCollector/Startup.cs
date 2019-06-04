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
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));


            // In Startup iam creating first Admin Role and creating a default Admin User    
            if (!roleManager.RoleExists("TrashGod"))
            {

                // first we create Admin rool   
                var role = new IdentityRole();
                role.Name = "TrashGod";
                roleManager.Create(role);

                //Here we create a Admin super user who will maintain the website                  

                var person = new ApplicationUser();
                person.UserName = "TrashKami";
                person.Email = "trashkami@123.com";

                string userPWD = "qaz";

                var checkPerson = UserManager.Create(person, userPWD);

                //Add default User to Role Admin   
                if (checkPerson.Succeeded)
                {
                    var result1 = UserManager.AddToRole(person.Id, "TrashGod");
                }
            }

            // creating Creating Manager role    
            if (!roleManager.RoleExists("CheifOfTrash"))
            {
                var role = new IdentityRole();
                role.Name = "CheifOfTrash";
                roleManager.Create(role);

            }

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
