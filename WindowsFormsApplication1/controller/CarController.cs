using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

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
                using (Model1Container model1 = new Model1Container())
                {
                    return model1.CarSet.
                        Include(c => c.Model)
                        .ToList<Car>();
                }
            }
        }

        public Car search(int id)
        {
            using (Model1Container model1 = new Model1Container())
            {
                return model1.CarSet
                    .Include(c => c.Model)
                    .Where(c => c.Id == id)
                    .FirstOrDefault();
            }
        }

        public Car search(string name)
        {
            using (Model1Container model1 = new Model1Container())
            {
                return model1.CarSet
                    .Include(c => c.Model)
                    .Where(c => c.Name == name)
                    .FirstOrDefault();
            }
        }

        public void add(Car car, bool isExistent)
        {
            using (Model1Container model1 = new Model1Container())
            {
                if (isExistent)
                    model1.ModelSet.Attach(car.Model);
                model1.CarSet.Add(car);
                model1.SaveChanges();
            }
        }
    }
}
