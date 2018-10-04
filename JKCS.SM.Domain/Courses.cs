using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKCS.SM.Domain
{
    public class Courses : BaseEntity
    {
        [Column(TypeName = "VARCHAR")]
        [StringLength(10)]
        [Required]
        public string Code { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(70)]
        [Required]
        public string Description { get; set; }
    }
}
