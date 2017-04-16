using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.model;

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
                return parts;
            }

            set
            {
                parts = value;
            }
        }

        public Part search(int id)
        {
            foreach (Part c in Parts)
            {
                if (c.Id == id)
                {
                    return c;
                }
            }
            return null;
        }

        public Part search(string name)
        {
            foreach (Part c in Parts)
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
            foreach (Part c in Parts)
            {
                if (c.Id == id)
                {
                    Parts.Remove(c);
                    return true;
                }
            }
            return false;
        }

        public bool remove(string name)
        {
            foreach (Part c in Parts)
            {
                if (c.Name == name)
                {
                    Parts.Remove(c);
                    return true;
                }
            }
            return false;
        }

        public void add(Part part)
        {
            Parts.Add(part);
        }
    }
}
