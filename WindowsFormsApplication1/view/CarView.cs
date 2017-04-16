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
    public partial class CarView : Form
    {
        public CarView()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Singleton.closeCarWindow();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (nameText.Text != "" && modelText.Text != "" && yearText.Text != "")
            {
                DateTime dt;
                if (DateTime.TryParseExact(yearText.Text,
                                       "yyyy",
                                       CultureInfo.InvariantCulture,
                                       DateTimeStyles.None,
                                       out dt))
                {
                    Singleton.addCar(nameText.Text, modelText.Text, dt);
                    Singleton.updateMainView();
                    clearBoxes();
                    Singleton.closeCarWindow();
                    return;
                }
                else
                    MessageBox.Show("Ano inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
