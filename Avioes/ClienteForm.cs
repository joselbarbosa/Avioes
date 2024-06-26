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
    public partial class ClienteForm : Form
    {
        private List<BagagemModel> availableBagagens = GlobalConfig.Connection.GetBagagem_All();
        private List<BagagemModel> selectedBagagens = new List<BagagemModel>();

        public ClienteForm()
        {
            InitializeComponent();

            WireUpLists();
        }

        private void WireUpLists()
        {
            selectBagagemDropDown.DataSource = null;

            selectBagagemDropDown.DataSource = availableBagagens;
            selectBagagemDropDown.DisplayMember = "Bagtag";

            bagagemListBox.DataSource = null;

            bagagemListBox.DataSource = selectedBagagens;
            bagagemListBox.DisplayMember = "Bagtag";
        }

        private void registarPassageiroButton_Click(object sender, EventArgs e)
        {
            if (ValidatePassageiroForm())
            {
                ClienteModel model = new ClienteModel(nomeClienteValue.Text, emailClienteValue.Text, telefoneClienteValue.Text, passaporteClienteValue.Text);

                GlobalConfig.Connection.CreateCliente(model);

                nomeClienteValue.Text = "";
                emailClienteValue.Text = "";
                telefoneClienteValue.Text = "";
                passaporteClienteValue.Text = "";
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
        }

        private bool ValidatePassageiroForm()
        {
            bool output = true;

            if (nomeClienteValue.Text.Length == 0)
            {
                output = false;
            }

            if (emailClienteValue.Text.Length == 0)
            {
                output = false;
            }

            if (telefoneClienteValue.Text.Length == 0)
            {
                output = false;
            }

            if (passaporteClienteValue.Text.Length == 0)
            {
                output = false;
            }

            return output;
        }

        private bool ValidateBagagemUpdate()
        {
            bool output = true;

            if (updateBagtagValue.Text.Length == 0)
            {
                output = false;
            }

            return output;
        }

        private void addBagagemButton_Click(object sender, EventArgs e)
        {
            BagagemModel b = (BagagemModel)selectBagagemDropDown.SelectedItem;

            if (b != null)
            {
                availableBagagens.Remove(b);

                selectedBagagens.Add(b);

                WireUpLists();
            }
        }

        private void removeBagagemButton_Click(object sender, EventArgs e)
        {
            BagagemModel b = (BagagemModel)bagagemListBox.SelectedItem;

            if (b != null)
            {
                selectedBagagens.Remove(b);

                availableBagagens.Add(b);

                WireUpLists();
            }
        }

        private void registoBagagemButton_Click(object sender, EventArgs e)
        {
            if (ValidateBagagemForm())
            {
                BagagemModel b = new BagagemModel(pesoBagagemValue.Text, cumpBagagemValue.Text, largBagagemValue.Text, altBagagemValue.Text, bagtagBagagemValue.Text, numClienteValue.Text);

                b = GlobalConfig.Connection.CreateBagagem(b);

                selectedBagagens.Add(b);

                WireUpLists();

                pesoBagagemValue.Text = "0";
                cumpBagagemValue.Text = "0";
                largBagagemValue.Text = "0";
                altBagagemValue.Text = "0";
                bagtagBagagemValue.Text = "";
                numClienteValue.Text = "0";

            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
        }

        private void deleteBagagemButton_Click(object sender, EventArgs e)
        {
            BagagemModel b = (BagagemModel)bagagemListBox.SelectedItem;

            GlobalConfig.Connection.DeleteBagagem(b);

            if (b != null)
            {
                selectedBagagens.Remove(b);

                WireUpLists();
            }
        }

        private void updateBagtagButton_Click(object sender, EventArgs e)
        {
            if (ValidateBagagemUpdate())
            {
                BagagemModel b = (BagagemModel)bagagemListBox.SelectedItem;

                if (b != null)
                {
                    b.NewBagtag = updateBagtagValue.Text;

                    GlobalConfig.Connection.UpdateBagagem(b);

                    b.Bagtag = updateBagtagValue.Text;

                    selectedBagagens.Remove(b);

                    availableBagagens.Add(b);

                    WireUpLists();

                    updateBagtagValue.Text = "";
                }
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
        }

        private bool ValidateBagagemForm()
        {
            bool output = true;

            decimal pesoBagagem = 0;
            decimal cumpBagagem = 0;
            decimal largBagagem = 0;
            decimal altBagagem = 0;
            int numCliente = 0;

            bool pesoBagagemValidNumber = decimal.TryParse(pesoBagagemValue.Text, out pesoBagagem);
            bool cumpBagagemValidNumber = decimal.TryParse(cumpBagagemValue.Text, out cumpBagagem);
            bool largBagagemValidNumber = decimal.TryParse(largBagagemValue.Text, out largBagagem);
            bool altBagagemValidNumber = decimal.TryParse(altBagagemValue.Text, out altBagagem);
            bool numClienteValidNumber = int.TryParse(altBagagemValue.Text, out numCliente);

            if (pesoBagagemValidNumber == false)
            {
                output = false;
            }
            if (pesoBagagem <= 0)
            {
                output = false;
            }

            if (cumpBagagemValidNumber == false)
            {
                output = false;
            }
            if (cumpBagagem <= 0)
            {
                output = false;
            }

            if (largBagagemValidNumber == false)
            {
                output = false;
            }
            if (largBagagem <= 0)
            {
                output = false;
            }

            if (altBagagemValidNumber == false)
            {
                output = false;
            }
            if (altBagagem <= 0)
            {
                output = false;
            }

            if (bagtagBagagemValue.Text.Length == 0)
            {
                output = false;
            }

            if (numClienteValidNumber == false)
            {
                output = false;
            }
            if (numCliente <= 0)
            {
                output = false;
            }


            return output;
        }
    }
}
