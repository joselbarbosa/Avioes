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
    public partial class BagagemForm : Form
    {
        public BagagemForm()
        {
            InitializeComponent();
        }

        private void registoBagagemButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                BagagemModel model = new BagagemModel(pesoBagagemValue.Text, cumpBagagemValue.Text, largBagagemValue.Text, altBagagemValue.Text, bagtagBagagemValue.Text);

                GlobalConfig.Connection.CreateBagagem(model);

                pesoBagagemValue.Text = "0";
                cumpBagagemValue.Text = "0";
                largBagagemValue.Text = "0";
                altBagagemValue.Text = "0";
                bagtagBagagemValue.Text = "";

            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }

        }

        private bool ValidateForm()
        {
            bool output = true;

            decimal pesoBagagem = 0;
            decimal cumpBagagem = 0;
            decimal largBagagem = 0;
            decimal altBagagem = 0;
            
            bool pesoBagagmValidNumber = decimal.TryParse(pesoBagagemValue.Text, out pesoBagagem);
            bool cumpBagagmValidNumber = decimal.TryParse(cumpBagagemValue.Text, out cumpBagagem);
            bool largBagagmValidNumber = decimal.TryParse(largBagagemValue.Text, out largBagagem);
            bool altBagagmValidNumber = decimal.TryParse(altBagagemValue.Text, out altBagagem);
            
            if ( pesoBagagmValidNumber == false)
            {
                output = false;
            }
            if (pesoBagagem < 1)
            {
                output = false;
            }

            if (cumpBagagmValidNumber == false)
            {
                output = false;
            }
            if (cumpBagagem < 1)
            {
                output = false;
            }

            if (largBagagmValidNumber == false)
            {
                output = false;
            }
            if (largBagagem < 1)
            {
                output = false;
            }

            if (altBagagmValidNumber == false)
            {
                output = false;
            }
            if (altBagagem < 1) 
            {
                output = false;
            }

            if (bagtagBagagemValue.Text.Length == 0)
            {
                output = false;
            }
           
            return output;          
        }
    }
}
