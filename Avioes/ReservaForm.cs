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

            vooForm.Show();
        }

        private void registarReservaButton_Click(object sender, EventArgs e)
        {
            if (ValidateReservaForm())
            {
                ReservaModel model = new ReservaModel(vooReservaValue.Text, clienteReservaValue.Text, lugarReservaValue.Text);

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

        private void apagarReservaButton_Click(object sender, EventArgs e)
        {
            if (ValidateReservaValue())
            {
                ReservaModel model = new ReservaModel(apagarReservaValue.Text);

                GlobalConfig.Connection.DeleteReserva(model);

                apagarReservaValue.Text = "0";
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
        }

        private void selectLugarButton_Click(object sender, EventArgs e)
        {
            if (ValidateReservaValue())
            {
                ReservaModel model = new ReservaModel(apagarReservaValue.Text);
                model = GlobalConfig.Connection.SelectReserva(model);
                if (model != null)
                {
                    selectLugarValue.Text = model.LugarReserva;
                    apagarReservaValue.Text = "0";
                }
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
        }

        private void updateLugarButton_Click(object sender, EventArgs e)
        {
            if (ValidateReservaValue())
            {
                if (ValidateUpdateLugar())
                {
                    ReservaModel r = new ReservaModel(apagarReservaValue.Text);

                    if (r != null)
                    {
                        r.NewLugarReserva = updateLugarValue.Text;

                        GlobalConfig.Connection.UpdateReserva(r);

                        apagarReservaValue.Text = "0";
                        updateLugarValue.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("This form has invalid information. Please check it and try again.");
                }
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

        private bool ValidateReservaValue()
        {
            bool output = true;

            int apagarReserva = 0;

            bool apagarReservaValidNumber = int.TryParse(apagarReservaValue.Text, out apagarReserva);

            if (apagarReservaValidNumber == false)
            {
                output = false;
            }
            if (apagarReserva <= 0)
            {
                output = false;
            }

            return output;
        }

        private bool ValidateUpdateLugar()
        {
            bool output = true;

            if (updateLugarValue.Text.Length == 0)
            {
                output = false;
            }

            return output;
        }

        private void menuClienteButton_Click(object sender, EventArgs e)
        {
            ClienteForm clienteForm = new ClienteForm();

            clienteForm.Show();
        }
    }
}
