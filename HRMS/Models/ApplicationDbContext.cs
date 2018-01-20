using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace HRMS.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {





        public DbSet<SecurityCode> SecurityCodes { get; set; }


        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}