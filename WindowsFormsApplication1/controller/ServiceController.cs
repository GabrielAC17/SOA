using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.controller
{
    class ServiceController
    {
        private static readonly ServiceController serviceC = new ServiceController();
        private static List<Service> services = new List<Service>();

        public static ServiceController ServiceC
        {
            get
            {
                return serviceC;
            }
        }

        internal List<Service> Services
        {
            get
            {
                using (Model1Container model1 = new Model1Container())
                {
                    return (from c in model1.ServiceSet
                            orderby c.Name
                            select c).ToList<Service>();
                }
            }
        }

        public Service search(int id)
        {
            using (Model1Container model1 = new Model1Container())
            {
                return model1.ServiceSet
                    .Where(c => c.Id == id)
                    .FirstOrDefault();
            }
        }

        public Service search(string name)
        {
            using (Model1Container model1 = new Model1Container())
            {
                return model1.ServiceSet
                    .Where(c => c.Name == name)
                    .FirstOrDefault();
            }
        }

        public void add(Service service)
        {
            using (Model1Container model1 = new Model1Container())
            {
                model1.ServiceSet.Add(service);
                model1.SaveChanges();
            }
        }
    }
}
