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

namespace WindowsFormsApplication1.view
{
    public partial class ServiceView : Form
    {
        public ServiceView()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Singleton.closeServiceWindow();
        }

        private void priceText_TextChanged(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (nameText.Text != "" & priceText.Text != "")
            {
                decimal price;
                if (decimal.TryParse(priceText.Text, out price)){
                    Singleton.addService(nameText.Text,price);
                    Singleton.updateMainView();
                    clearBoxes();
                    Singleton.closeServiceWindow();
                    return;
                }
                else
                    MessageBox.Show("Preço inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
    }
}
