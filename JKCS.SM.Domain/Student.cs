using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKCS.SM.Domain
{
    public class Student : BasePerson
    {
        [Column(TypeName = "VARCHAR")]
        [StringLength(10)]
        [Required]
        public string Code { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        [Required]
        public string ParentName { get; set; }
    }
}
