using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.model;

namespace WindowsFormsApplication1.controller
{
    class SelectedServiceController
    {
        private static readonly SelectedServiceController selectedServiceC = new SelectedServiceController();
        private static List<Service> services = new List<Service>();

        public static SelectedServiceController SelectedServiceC
        {
            get
            {
                return selectedServiceC;
            }
        }

        internal List<Service> Services
        {
            get
            {
                return services;
            }

            set
            {
                services = value;
            }
        }


        public Service search(int id)
        {
            foreach (Service c in Services)
            {
                if (c.Id == id)
                {
                    return c;
                }
            }
            return null;
        }

        public Service search(string name)
        {
            foreach (Service c in Services)
            {
                if (c.Name == name)
                {
                    return c;
                }
            }
            return null;
        }

        public bool remove(int id)
        {
            foreach (Service c in Services)
            {
                if (c.Id == id)
                {
                    Services.Remove(c);
                    return true;
                }
            }
            return false;
        }

        public bool remove(string name)
        {
            foreach (Service c in Services)
            {
                if (c.Name == name)
                {
                    Services.Remove(c);
                    return true;
                }
            }
            return false;
        }

        public void add(Service service)
        {
            Services.Add(service);
        }
    }
}
