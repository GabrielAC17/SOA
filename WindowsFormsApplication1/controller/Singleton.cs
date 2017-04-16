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

        private static CarView carView;
        private static PartView partView;
        private static ServiceView serviceView;
        private static MainForm mainForm;

        private static int carId = 0;
        private static int partId = 0;
        private static int serviceId = 0;

        private Singleton() { }

        public static Singleton Instance
            {
            get
            {
                return instance;
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
            car.Model = model;
            car.Year = year;
            ++car.Id;

            CarController.CarC.add(car);
        }

        public static void addService(string name, float price)
        {
            Service service = new Service();
            service.Name = name;
            service.PricePerHour = price;
            ++service.Id;

            ServiceController.ServiceC.add(service);
        }

        public static void updateMainView()
        {
            mainForm.updateView();
            mainForm.Update();
        }
    }
}
