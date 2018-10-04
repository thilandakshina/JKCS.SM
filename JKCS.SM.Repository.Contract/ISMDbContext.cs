using JKCS.SM.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKCS.SM.Repository.Contract
{
    public interface ISMDbContext :IDisposable
    {

        Database Database { get; }
        int SaveChanges();
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        DbSet Set(Type entityType);
        DbEntityEntry Entry(object entity);
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        DbSet<Student> Student { get; set; }
        DbSet<Courses> Courses { get; set; }
    
        DbContext GetDatabaseContext { get; }
    }
}
