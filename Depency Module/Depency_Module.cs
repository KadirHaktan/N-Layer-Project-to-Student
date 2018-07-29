using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layer.Business.Abstract;
using Layer.Business.Concart;
using Layer.Data.Abstract;
using Layer.Data.Concart.EntityFramework;
using Ninject.Modules;

namespace Layer.Business.Depency_Module
{
    public class Depency_Module : NinjectModule
    {
        public override void Load()
        {
            Bind<IStudentLogic>().To<StudentLogic>().InSingletonScope();
            Bind<IStudentClubLogic>().To<StudentClubLogic>().InSingletonScope();
            Bind<IStudentScoreLogic>().To<StudentScoreLogic>().InSingletonScope();

            Bind<IStudentDAL>().To<EntityFrameworkStudent>().InSingletonScope();
            Bind<IStudent_Club_DAL>().To<EntityFrameworkStudentClub>().InSingletonScope();
            Bind<IStudent_Score_DAL>().To<EntityFrameworkStudentScore>().InSingletonScope();

        }
    }
}
