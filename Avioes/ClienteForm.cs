using AvioesLibrary;
using System.Drawing.Text;

namespace Avioes
{
    public partial class ClienteForm : Form
    {
        public ClienteForm()
        {
            InitializeComponent();
        }

        private void menuReservaButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm()) 
            { 
                ClienteModel model = new ClienteModel(nomeClienteValue.Text, emailClienteValue.Text, telefoneClienteValue.Text, passaporteClienteValue.Text);

                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreateCliente(model);
                }

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

        private bool ValidateForm()
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
    }
}
