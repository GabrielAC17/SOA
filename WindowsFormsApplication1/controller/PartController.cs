using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.controller
{
    class PartController
    {
        private static readonly PartController partC = new PartController();
        private static List<Part> parts = new List<Part>();

        public static PartController PartC
        {
            get
            {
                return partC;
            }
        }

        internal List<Part> Parts
        {
            get
            {
                using (Model1Container model1 = new Model1Container())
                {
                    return model1.PartSet.
                        Include(c => c.Model)
                        .ToList<Part>();
                }
            }
        }

        public Part search(int id)
        {
            using (Model1Container model1 = new Model1Container())
            {
                return model1.PartSet
                    .Include(p => p.Model)
                    .Where(c => c.Id == id)
                    .FirstOrDefault();
            }
        }

        public Part search(string name)
        {
            using (Model1Container model1 = new Model1Container())
            {
                return model1.PartSet
                    .Include(p => p.Model)
                    .Where(c => c.Name == name)
                    .FirstOrDefault();
            }
        }

        public void add(Part part)
        {
            using (Model1Container model1 = new Model1Container())
            {
                model1.ModelSet.Attach(part.Model);
                model1.PartSet.Add(part);
                model1.SaveChanges();
            }
        }
    }
}
