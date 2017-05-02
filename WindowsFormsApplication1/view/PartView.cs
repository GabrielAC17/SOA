using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.controller;

namespace WindowsFormsApplication1.view
{
    public partial class PartView : Form
    {
        public PartView()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Singleton.closePartWindow();
        }

        private void PartView_Load(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (nomeText.Text != "" && yearText.Text != "" && endYearText.Text != "" 
                && priceText.Text != "" && modelCombo.SelectedValue != null)
            {
                float price;
                DateTime sYear;
                DateTime eYear;
                
                if (float.TryParse(priceText.Text, out price) &&
                    DateTime.TryParseExact(yearText.Text,"yyyy", CultureInfo.InvariantCulture,DateTimeStyles.None, out sYear) &&
                    DateTime.TryParseExact(endYearText.Text, "yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out eYear))
                {
                    Singleton.addPart(nomeText.Text,(Model) modelCombo.SelectedValue, sYear, eYear, price);
                    Singleton.updateMainView();
                    clearBoxes();
                    Singleton.closePartWindow();
                    return;
                }
                else
                    MessageBox.Show("Dados inválidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Nenhum campo pode estar vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearBoxes()
        {
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    ((TextBox)(c)).Text = string.Empty;
                }
            }
        }

        private void carCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void UpdateView()
        {
            modelCombo.DataSource = null;
            modelCombo.DataSource = ModelController.ModelC.Models;
            modelCombo.ValueMember = null;
            modelCombo.DisplayMember = "Name";
            modelCombo.SelectedIndex = -1;
        }


    }
}
