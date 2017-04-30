using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.controller;
using WindowsFormsApplication1.model;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        private List<Part> selectedParts = new List<Part>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboCars.DataSource = CarController.CarC.Cars;
            comboCars.DisplayMember = "Name";
            comboCars.ValueMember = null;
            comboCars.SelectedIndex = -1;

            objectListServices.SetObjects(ServiceController.ServiceC.Services);
            updateParts();
            objectListSelectedParts.SetObjects(SelectedPartController.SelectedPartC.Parts);
            objectListSelectedServices.SetObjects(SelectedServiceController.SelectedServiceC.Services);
        }

        private void updateParts()
        {
            selectedParts.Clear();
            SelectedPartController.SelectedPartC.Parts.Clear();
            objectListSelectedParts.SetObjects(SelectedPartController.SelectedPartC.Parts);
            Car carTemp = (Car)comboCars.SelectedValue;
            if (carTemp != null)
            {
                foreach (Part p in PartController.PartC.Parts)
                {
                    if (String.Equals(carTemp.Model.Name, p.CarModel.Name) && (carTemp.Year >= p.Year && carTemp.Year <= p.EndYear))
                    {
                        selectedParts.Add(p);
                    }
                }
            }
            
            objectListParts.SetObjects(selectedParts);
        }

        private void comboCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateParts();
            Singleton.updateTotal();
            labelTotal.Text = Singleton.Total.ToString();
        }

        private void buttonNewCar_Click(object sender, EventArgs e)
        {
            Singleton.openCarWindow();
        }

        private void buttonNewPart_Click(object sender, EventArgs e)
        {
            Singleton.openPartWindow();
        }

        private void buttonNewService_Click(object sender, EventArgs e)
        {
            Singleton.openServiceWindow();
        }



        public void updateLists()
        {
            //Update ObjectListService
            objectListServices.SetObjects(ServiceController.ServiceC.Services);

            //Update ObjectListPart
            updateParts();

            //Update ObjectListSelectedPart
            objectListSelectedParts.SetObjects(SelectedPartController.SelectedPartC.Parts);

            //Update ObjectListSelectedServices
            objectListSelectedServices.SetObjects(SelectedServiceController.SelectedServiceC.Services);
        }

        public void updateCars()
        {
            //Update comboCars
            comboCars.DataSource = null;
            comboCars.DataSource = CarController.CarC.Cars;
            comboCars.DisplayMember = "Name";
            comboCars.ValueMember = null;
        }

        private void addServiceButton_Click(object sender, EventArgs e)
        {
            if (objectListServices.SelectedObjects != null)
            {
                foreach (Service o in objectListServices.SelectedObjects)
                {
                    SelectedServiceController.SelectedServiceC.add(o);
                }
                objectListSelectedServices.SetObjects(SelectedServiceController.SelectedServiceC.Services);
                Singleton.updateTotal();
                labelTotal.Text = Singleton.Total.ToString();
            }
        }

        private void removeServiceButton_Click(object sender, EventArgs e)
        {
            if (objectListSelectedServices.SelectedObjects != null)
            {
                foreach (Service o in objectListSelectedServices.SelectedObjects)
                {
                    SelectedServiceController.SelectedServiceC.remove(o);
                }
                objectListSelectedServices.SetObjects(SelectedServiceController.SelectedServiceC.Services);
                Singleton.updateTotal();
                labelTotal.Text = Singleton.Total.ToString();
            }
        }

        private void addPartButton_Click(object sender, EventArgs e)
        {
            if (objectListParts.SelectedObjects != null)
            {
                foreach (Part o in objectListParts.SelectedObjects)
                {
                    SelectedPartController.SelectedPartC.add(o);
                }
                objectListSelectedParts.SetObjects(SelectedPartController.SelectedPartC.Parts);
                Singleton.updateTotal();
                labelTotal.Text = Singleton.Total.ToString();
            }
        }

        private void removePartButton_Click(object sender, EventArgs e)
        {
            if (objectListSelectedParts.SelectedObjects != null)
            {
                foreach (Part o in objectListSelectedParts.SelectedObjects)
                {
                    SelectedPartController.SelectedPartC.remove(o);
                }
                objectListSelectedParts.SetObjects(SelectedPartController.SelectedPartC.Parts);
                Singleton.updateTotal();
                labelTotal.Text = Singleton.Total.ToString();
            }
        }
    }
}
