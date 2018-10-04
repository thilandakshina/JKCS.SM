using JKCS.SM.BusinessServices;
using JKCS.SM.BusinessServices.Contract;
using JKCS.SM.Repository;
using JKCS.SM.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace JKCS.SM.Ioc
{
    public class IOCUnityContainers
    {
        public UnityContainer GetLiveUnityContainer()
        {

            var container = new UnityContainer();
            container.RegisterType<IStudentManager, StudentManager>();
            container.RegisterType<IStudentRepository, StudentRepository>();

            return container;
        }

        public UnityContainer GetTestUnityContainer()
        {

            var container = new UnityContainer();
            container.RegisterType<IStudentManager, StudentManager>();
            container.RegisterType<IStudentRepository, StudentRepository>();

            return container;
        }

        public UnityContainer GetBusinessServiceTestUnityContainer()
        {

            var container = new UnityContainer();
            container.RegisterType<IStudentManager, StudentManager>();
            // container.RegisterType<IStudentRepository, StudentRepository>();

            return container;
        }
    }
}
