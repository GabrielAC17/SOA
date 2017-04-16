using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.model;

namespace WindowsFormsApplication1.controller
{
    class CarController
    {
        private static readonly CarController carC = new CarController();
        private static List<Car> cars = new List<Car>();

        public static CarController CarC
        {
            get
            {
                return carC;
            }
        }

        internal List<Car> Cars
        {
            get
            {
                return cars;
            }

            set
            {
                cars = value;
            }
        }

        public Car search(int id)
        {
            foreach(Car c in cars)
            {
                if (c.Id == id)
                {
                    return c;
                }
            }
            return null;
        }

        public Car search(string name)
        {
            foreach (Car c in cars)
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
            foreach (Car c in cars)
            {
                if (c.Id == id)
                {
                    cars.Remove(c);
                    return true;
                }
            }
            return false;
        }

        public bool remove(string name)
        {
            foreach (Car c in cars)
            {
                if (c.Name == name)
                {
                    cars.Remove(c);
                    return true;
                }
            }
            return false;
        }

        public void add(Car car)
        {
            cars.Add(car);
        }
    }
}
