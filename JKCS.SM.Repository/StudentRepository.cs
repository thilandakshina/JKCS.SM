using JKCS.SM.Domain;
using JKCS.SM.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKCS.SM.Repository
{
   public class StudentRepository : Repository<Student>, IStudentRepository
    {
    }
}
