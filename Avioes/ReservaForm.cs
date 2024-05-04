using AvioesLibrary.Models;
using AvioesLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avioes
{
    public partial class ReservaForm : Form
    {
        public ReservaForm()
        {
            InitializeComponent();
        }

        private void criarVooLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VooForm vooForm = new VooForm();

            // Show the new form
            vooForm.Show();
        }

        private void registarReservaButton_Click(object sender, EventArgs e)
        {
            if (ValidateReservaForm())
            {
                ReservaModel model = new ReservaModel (vooReservaValue.Text, clienteReservaValue.Text, lugarReservaValue.Text);

                GlobalConfig.Connection.CreateReserva(model);

                vooReservaValue.Text = "0";
                clienteReservaValue.Text = "0";          
                lugarReservaValue.Text = "";
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
        }

        private bool ValidateReservaForm()
        {
            bool output = true;

            int vooReserva = 0;
            int clienteReserva = 0;

            bool vooReservaValidNumber = int.TryParse(vooReservaValue.Text, out vooReserva);
            bool clienteReservaValidNumber = int.TryParse(clienteReservaValue.Text, out clienteReserva);

            if (vooReservaValidNumber == false)
            {
                output = false;
            }
            if (vooReserva <= 0)
            {
                output = false;
            }

            if (clienteReservaValidNumber == false)
            {
                output = false;
            }
            if (clienteReserva <= 0)
            {
                output = false;
            }

            if (lugarReservaValue.Text.Length == 0)
            {
                output = false;
            }

            return output;
        }
    }
}
