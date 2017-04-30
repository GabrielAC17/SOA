using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.model
{
    public class Service
    {
        private string name;
        private float pricePerHour;
        private int id;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public float PricePerHour
        {
            get
            {
                return pricePerHour;
            }

            set
            {
                pricePerHour = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
    }
}
