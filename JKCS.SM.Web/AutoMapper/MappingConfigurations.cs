using AutoMapper;
using JKCS.SM.Domain;
using JKCS.SM.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JKCS.SM.Web.AutoMapper
{
    public class MappingConfigurations
    {
        public static void Configure()
        {
    //        Mapper.CreateMap<Student, StudentViewModel>().ForMember(cv => cv.FullName, m => m.MapFrom(
    //s => s.FirstName + " " + s.LastName));

    //        Mapper.CreateMap<StudentViewModel, Student>();
        }
    }
}