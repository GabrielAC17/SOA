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
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboCars.DataSource = CarController.CarC.Cars;
            comboCars.DisplayMember = "Name";
            comboCars.ValueMember = "Model";
            comboCars.SelectedIndex = -1;

            objectListServices.SetObjects(ServiceController.ServiceC.Services);
            objectListParts.SetObjects(PartController.PartC.Parts);
            objectListSelectedParts.SetObjects(SelectedPartController.SelectedPartC.Parts);
            objectListSelectedServices.SetObjects(SelectedServiceController.SelectedServiceC.Services);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboCars_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void listSelectedServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void objectListSelectedServices_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void objectListServices_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void updateView()
        {
            //Update comboCars
            comboCars.DataSource = null;
            comboCars.DataSource = CarController.CarC.Cars;
            comboCars.DisplayMember = "Name";
            comboCars.ValueMember = "Model";

            //Update ObjectListService
            objectListServices.SetObjects(ServiceController.ServiceC.Services);
        }
    }
}
