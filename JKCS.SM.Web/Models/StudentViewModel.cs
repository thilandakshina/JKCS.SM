using JKCS.SM.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JKCS.SM.Web.Models
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public string ParentName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public string FullName { get; set; }
        //public DateTime DOB { get; set; }
        //public Gender Gender { get; set; }
    }
}