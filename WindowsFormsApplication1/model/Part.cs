using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.model
{
    class Part
    {
        private string name;
        private Car carModel;
        private DateTime year;
        private DateTime endYear;
        private float price;
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

        internal Car CarModel
        {
            get
            {
                return carModel;
            }

            set
            {
                carModel = value;
            }
        }

        public DateTime Year
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
            }
        }

        public float Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
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

        public DateTime EndYear
        {
            get
            {
                return endYear;
            }

            set
            {
                endYear = value;
            }
        }
    }
}
