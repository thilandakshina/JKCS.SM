using JKCS.SM.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKCS.SM.Repository
{
   public class SMDbContext : DbContext
    {
        public SMDbContext() : base("SMConnectionString")
        {

        }

        DbSet<Student> Student { get; set; }
        DbSet<Courses> Courses { get; set; }
        DbContext GetDatabaseContext { get; set; }
    }
}
