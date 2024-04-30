namespace Avioes
{
    partial class Formulario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            headerClienteLabel = new Label();
            nomeLabel = new Label();
            nomeCliente = new Label();
            emailLabel = new Label();
            emailCliente = new Label();
            telefoneLabel = new Label();
            telefoneCliente = new Label();
            nascimentoLabel = new Label();
            label1 = new Label();
            passaporteLabel = new Label();
            passaporteCliente = new Label();
            headerBagagemLabel = new Label();
            numBagagemLabel = new Label();
            menuReservaButton = new Button();
            criarBagagenLink = new LinkLabel();
            bagagemListBox = new ListBox();
            SuspendLayout();
            // 
            // headerClienteLabel
            // 
            headerClienteLabel.AutoSize = true;
            headerClienteLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            headerClienteLabel.ForeColor = Color.LightSeaGreen;
            headerClienteLabel.Location = new Point(39, 28);
            headerClienteLabel.Name = "headerClienteLabel";
            headerClienteLabel.Size = new Size(149, 37);
            headerClienteLabel.TabIndex = 0;
            headerClienteLabel.Text = "Passageiro:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.ForeColor = SystemColors.ControlText;
            nomeLabel.Location = new Point(39, 100);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new Size(70, 28);
            nomeLabel.TabIndex = 1;
            nomeLabel.Text = "Nome:";
            // 
            // nomeCliente
            // 
            nomeCliente.AutoSize = true;
            nomeCliente.Location = new Point(123, 100);
            nomeCliente.Name = "nomeCliente";
            nomeCliente.Size = new Size(84, 28);
            nomeCliente.TabIndex = 2;
            nomeCliente.Text = "<none>";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(39, 166);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(63, 28);
            emailLabel.TabIndex = 3;
            emailLabel.Text = "Email:";
            // 
            // emailCliente
            // 
            emailCliente.AutoSize = true;
            emailCliente.Location = new Point(123, 166);
            emailCliente.Name = "emailCliente";
            emailCliente.Size = new Size(84, 28);
            emailCliente.TabIndex = 4;
            emailCliente.Text = "<none>";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new Point(39, 233);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new Size(88, 28);
            telefoneLabel.TabIndex = 5;
            telefoneLabel.Text = "Telefone:";
            // 
            // telefoneCliente
            // 
            telefoneCliente.AutoSize = true;
            telefoneCliente.Location = new Point(123, 233);
            telefoneCliente.Name = "telefoneCliente";
            telefoneCliente.Size = new Size(84, 28);
            telefoneCliente.TabIndex = 6;
            telefoneCliente.Text = "<none>";
            // 
            // nascimentoLabel
            // 
            nascimentoLabel.AutoSize = true;
            nascimentoLabel.Location = new Point(39, 302);
            nascimentoLabel.Name = "nascimentoLabel";
            nascimentoLabel.Size = new Size(166, 28);
            nascimentoLabel.TabIndex = 7;
            nascimentoLabel.Text = "Data Nascimento:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(211, 302);
            label1.Name = "label1";
            label1.Size = new Size(84, 28);
            label1.TabIndex = 8;
            label1.Text = "<none>";
            // 
            // passaporteLabel
            // 
            passaporteLabel.AutoSize = true;
            passaporteLabel.Location = new Point(39, 366);
            passaporteLabel.Name = "passaporteLabel";
            passaporteLabel.Size = new Size(110, 28);
            passaporteLabel.TabIndex = 9;
            passaporteLabel.Text = "Passaporte:";
            // 
            // passaporteCliente
            // 
            passaporteCliente.AutoSize = true;
            passaporteCliente.Location = new Point(155, 366);
            passaporteCliente.Name = "passaporteCliente";
            passaporteCliente.Size = new Size(84, 28);
            passaporteCliente.TabIndex = 10;
            passaporteCliente.Text = "<none>";
            // 
            // headerBagagemLabel
            // 
            headerBagagemLabel.AutoSize = true;
            headerBagagemLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            headerBagagemLabel.ForeColor = Color.LightSeaGreen;
            headerBagagemLabel.Location = new Point(554, 28);
            headerBagagemLabel.Name = "headerBagagemLabel";
            headerBagagemLabel.Size = new Size(135, 37);
            headerBagagemLabel.TabIndex = 11;
            headerBagagemLabel.Text = "Bagagem:";
            // 
            // numBagagemLabel
            // 
            numBagagemLabel.AutoSize = true;
            numBagagemLabel.Location = new Point(554, 100);
            numBagagemLabel.Name = "numBagagemLabel";
            numBagagemLabel.Size = new Size(127, 28);
            numBagagemLabel.TabIndex = 13;
            numBagagemLabel.Text = "Nº Bagagem:";
            // 
            // menuReservaButton
            // 
            menuReservaButton.BackColor = Color.Silver;
            menuReservaButton.Location = new Point(376, 390);
            menuReservaButton.Name = "menuReservaButton";
            menuReservaButton.Size = new Size(173, 51);
            menuReservaButton.TabIndex = 15;
            menuReservaButton.Text = "Menu Reserva";
            menuReservaButton.UseVisualStyleBackColor = false;
            // 
            // criarBagagenLink
            // 
            criarBagagenLink.AutoSize = true;
            criarBagagenLink.Location = new Point(687, 100);
            criarBagagenLink.Name = "criarBagagenLink";
            criarBagagenLink.Size = new Size(161, 28);
            criarBagagenLink.TabIndex = 16;
            criarBagagenLink.TabStop = true;
            criarBagagenLink.Text = "registo bagagem";
            // 
            // bagagemListBox
            // 
            bagagemListBox.FormattingEnabled = true;
            bagagemListBox.ItemHeight = 28;
            bagagemListBox.Location = new Point(554, 166);
            bagagemListBox.Name = "bagagemListBox";
            bagagemListBox.Size = new Size(321, 144);
            bagagemListBox.TabIndex = 17;
            // 
            // Formulario
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(928, 477);
            Controls.Add(bagagemListBox);
            Controls.Add(criarBagagenLink);
            Controls.Add(menuReservaButton);
            Controls.Add(numBagagemLabel);
            Controls.Add(headerBagagemLabel);
            Controls.Add(passaporteCliente);
            Controls.Add(passaporteLabel);
            Controls.Add(label1);
            Controls.Add(nascimentoLabel);
            Controls.Add(telefoneCliente);
            Controls.Add(telefoneLabel);
            Controls.Add(emailCliente);
            Controls.Add(emailLabel);
            Controls.Add(nomeCliente);
            Controls.Add(nomeLabel);
            Controls.Add(headerClienteLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Formulario";
            Text = "Formulario Passageiro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerClienteLabel;
        private Label nomeLabel;
        private Label nomeCliente;
        private Label emailLabel;
        private Label emailCliente;
        private Label telefoneLabel;
        private Label telefoneCliente;
        private Label nascimentoLabel;
        private Label label1;
        private Label passaporteLabel;
        private Label passaporteCliente;
        private Label headerBagagemLabel;
        private Label numBagagemLabel;
        private CheckBox checkCheckBox;
        private Button menuReservaButton;
        private LinkLabel criarBagagenLink;
        private ListBox bagagemListBox;
    }
}
