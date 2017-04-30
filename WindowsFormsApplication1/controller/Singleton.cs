using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using WindowsFormsApplication1.model;
using WindowsFormsApplication1.view;

namespace WindowsFormsApplication1.controller
{
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();
        private static double total = 0;

        private static CarView carView;
        private static PartView partView;
        private static ServiceView serviceView;
        private static MainForm mainForm;

        private Singleton() { }

        public static Singleton Instance
            {
            get
            {
                return instance;
            }
        }

        public static double Total
        {
            get
            {
                return total;
            }
        }

        public static void Start()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainForm = new MainForm();
            carView = new CarView();
            partView = new PartView();
            serviceView = new ServiceView();
            Application.Run(mainForm);
        }

        public static void openCarWindow()
        {
            carView.ShowDialog(mainForm);
        }

        public static void openPartWindow()
        {
            partView.ShowDialog(mainForm);
        }

        public static void openServiceWindow()
        {
            serviceView.ShowDialog(mainForm);
        }

        public static void closeCarWindow()
        {
            carView.Close();
        }

        public static void closePartWindow()
        {
            partView.Close();
        }

        public static void closeServiceWindow()
        {
            serviceView.Close();
        }

        public static void addCar(string name, string model, DateTime year)
        {
            Car car = new Car();
            car.Name = name;
            car.Year = year;

            Model m = ModelController.ModelC.search(model);
            if (m == null)
            {
                m = new Model();
                m.Name = model;
                ModelController.ModelC.add(m);
            }
            car.Model = m;

            CarController.CarC.add(car);
        }

        public static void addService(string name, float price)
        {
            Service service = new Service();
            service.Name = name;
            service.PricePerHour = price;

            ServiceController.ServiceC.add(service);
        }

        public static void addPart(string name,Model model, DateTime startYear, DateTime endYear, float price)
        {
            Part part = new Part();
            part.Name = name;
            part.CarModel = model;
            part.Year = startYear;
            part.EndYear = endYear;
            part.Price = price;

            PartController.PartC.add(part);
        }

        public static void updateMainView()
        {
            mainForm.updateLists();
            mainForm.updateCars();
            partView.UpdateView();
            mainForm.Update();
            updateTotal();
        }

        public static void updateTotal()
        {
            total = 0;

            foreach(Part p in SelectedPartController.SelectedPartC.Parts)
            {
                total += p.Price;
            }

            foreach(Service s in SelectedServiceController.SelectedServiceC.Services)
            {
                total += s.PricePerHour;
            }

        }

    }
}
