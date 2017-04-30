using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.model;

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
                return models;
            }

            set
            {
                models = value;
            }
        }

        public Model search(int id)
        {
            foreach (Model c in models)
            {
                if (c.Id == id)
                {
                    return c;
                }
            }
            return null;
        }

        public Model search(string name)
        {
            foreach (Model c in models)
            {
                if (c.Name.Equals(name))
                {
                    return c;
                }
            }
            return null;
        }

        public bool remove(int id)
        {
            foreach (Model c in models)
            {
                if (c.Id == id)
                {
                    models.Remove(c);
                    return true;
                }
            }
            return false;
        }

        public bool remove(string name)
        {
            foreach (Model c in models)
            {
                if (c.Name.Equals(name))
                {
                    models.Remove(c);
                    return true;
                }
            }
            return false;
        }

        public void add(Model model)
        {
            models.Add(model);
        }
    }
}
