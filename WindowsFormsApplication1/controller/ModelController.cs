using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.controller
{
    class ModelController
    {
        private static readonly ModelController modelC = new ModelController();
        private static List<Model> models = new List<Model>();

        public static ModelController ModelC
        {
            get
            {
                return modelC;
            }
        }

        internal List<Model> Models
        {
            get
            {
                using (Model1Container model1 = new Model1Container())
                {
                    return (from c in model1.ModelSet
                            orderby c.Name
                            select c).ToList<Model>();
                }
            }
        }

        public Model search(int id)
        {
            using (Model1Container model1 = new Model1Container())
            {
                return model1.ModelSet
                    .Where(c => c.Id == id)
                    .FirstOrDefault();
            }
        }

        public Model search(string name)
        {
            using (Model1Container model1 = new Model1Container())
            {
                return model1.ModelSet
                    .Where(c => c.Name == name)
                    .FirstOrDefault();
            }
        }

        public void add(Model model)
        {
            using (Model1Container model1 = new Model1Container())
            {
                model1.ModelSet.Add(model);
                model1.SaveChanges();
            }
        }
    }
}
