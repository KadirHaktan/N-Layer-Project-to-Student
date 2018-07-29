using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Business.Depency_Module
{
  public class InstanceFactory
    {
        public static T GetInstance<T>()
        {
            var kernel = new StandardKernel(new Depency_Module());

            return kernel.Get<T>();
        }
    }
}
