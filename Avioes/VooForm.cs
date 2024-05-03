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
    public partial class VooForm : Form
    {
        public VooForm()
        {
            InitializeComponent();
        }

        private void registoVooButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                VooModel model = new VooModel(numVooValue.Text, origemVooValue.Text, destinoVooValue.Text, partidaVooValue.Text, chegadaVooValue.Text, lugaresDisponiveisValue.Text);

                GlobalConfig.Connection.CreateVoo(model);

                numVooValue.Text = "";
                origemVooValue.Text = "";
                destinoVooValue.Text = "";
                partidaVooValue.Text = DateTime.Now.ToString();
                chegadaVooValue.Text = DateTime.Now.ToString();
                lugaresDisponiveisValue.Text = "0";
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;

            if (numVooValue.Text.Length == 0)
            {
                output = false;
            }

            if (origemVooValue.Text.Length == 0)
            {
                output = false;
            }

            if (destinoVooValue.Text.Length == 0)
            {
                output = false;
            }

            DateTime dataPartida = DateTime.Now;
            if (!DateTime.TryParse(partidaVooValue.Text, out dataPartida))
            {
                output = false;
            }
            if (dataPartida <  DateTime.Now) 
            { 
                output = false;
            }

            DateTime dataChegada = DateTime.Now;
            if (!DateTime.TryParse(chegadaVooValue.Text, out dataChegada))
            {
                output = false;
            }
            if (dataChegada < DateTime.Now)
            {
                output = false;
            }

            byte lugaresDisponiveis = 0;
            bool lugaresDisponiveisValidNumber = byte.TryParse(lugaresDisponiveisValue.Text, out lugaresDisponiveis);
            if (lugaresDisponiveisValidNumber == false)
            {
                output = false;
            }
            if (lugaresDisponiveis < 1)
            {
                output = false;
            }

            return output;
        }
    }
}
