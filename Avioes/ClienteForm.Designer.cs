namespace Avioes
{
    partial class ClienteForm
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
            emailLabel = new Label();
            telefoneLabel = new Label();
            passaporteLabel = new Label();
            headerBagagemLabel = new Label();
            numBagagemLabel = new Label();
            menuReservaButton = new Button();
            criarBagagenLink = new LinkLabel();
            bagagemListBox = new ListBox();
            nomeClienteValue = new TextBox();
            emailClienteValue = new TextBox();
            telefoneClienteValue = new TextBox();
            passaporteClienteValue = new TextBox();
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
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(39, 166);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(63, 28);
            emailLabel.TabIndex = 3;
            emailLabel.Text = "Email:";
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
            // passaporteLabel
            // 
            passaporteLabel.AutoSize = true;
            passaporteLabel.Location = new Point(17, 296);
            passaporteLabel.Name = "passaporteLabel";
            passaporteLabel.Size = new Size(110, 28);
            passaporteLabel.TabIndex = 9;
            passaporteLabel.Text = "Passaporte:";
            // 
            // headerBagagemLabel
            // 
            headerBagagemLabel.AutoSize = true;
            headerBagagemLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            headerBagagemLabel.ForeColor = Color.LightSeaGreen;
            headerBagagemLabel.Location = new Point(463, 28);
            headerBagagemLabel.Name = "headerBagagemLabel";
            headerBagagemLabel.Size = new Size(135, 37);
            headerBagagemLabel.TabIndex = 11;
            headerBagagemLabel.Text = "Bagagem:";
            // 
            // numBagagemLabel
            // 
            numBagagemLabel.AutoSize = true;
            numBagagemLabel.Location = new Point(463, 106);
            numBagagemLabel.Name = "numBagagemLabel";
            numBagagemLabel.Size = new Size(127, 28);
            numBagagemLabel.TabIndex = 13;
            numBagagemLabel.Text = "Nº Bagagem:";
            // 
            // menuReservaButton
            // 
            menuReservaButton.BackColor = Color.Silver;
            menuReservaButton.Location = new Point(329, 385);
            menuReservaButton.Name = "menuReservaButton";
            menuReservaButton.Size = new Size(173, 51);
            menuReservaButton.TabIndex = 15;
            menuReservaButton.Text = "Menu Reserva";
            menuReservaButton.UseVisualStyleBackColor = false;
            menuReservaButton.Click += menuReservaButton_Click;
            // 
            // criarBagagenLink
            // 
            criarBagagenLink.AutoSize = true;
            criarBagagenLink.Location = new Point(623, 106);
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
            bagagemListBox.Location = new Point(463, 183);
            bagagemListBox.Name = "bagagemListBox";
            bagagemListBox.Size = new Size(321, 144);
            bagagemListBox.TabIndex = 17;
            // 
            // nomeClienteValue
            // 
            nomeClienteValue.Location = new Point(143, 100);
            nomeClienteValue.Name = "nomeClienteValue";
            nomeClienteValue.Size = new Size(125, 34);
            nomeClienteValue.TabIndex = 18;
            // 
            // emailClienteValue
            // 
            emailClienteValue.Location = new Point(143, 166);
            emailClienteValue.Name = "emailClienteValue";
            emailClienteValue.Size = new Size(125, 34);
            emailClienteValue.TabIndex = 19;
            // 
            // telefoneClienteValue
            // 
            telefoneClienteValue.Location = new Point(143, 227);
            telefoneClienteValue.Name = "telefoneClienteValue";
            telefoneClienteValue.Size = new Size(125, 34);
            telefoneClienteValue.TabIndex = 20;
            // 
            // passaporteClienteValue
            // 
            passaporteClienteValue.Location = new Point(143, 293);
            passaporteClienteValue.Name = "passaporteClienteValue";
            passaporteClienteValue.Size = new Size(125, 34);
            passaporteClienteValue.TabIndex = 21;
            // 
            // ClienteForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(832, 477);
            Controls.Add(passaporteClienteValue);
            Controls.Add(telefoneClienteValue);
            Controls.Add(emailClienteValue);
            Controls.Add(nomeClienteValue);
            Controls.Add(bagagemListBox);
            Controls.Add(criarBagagenLink);
            Controls.Add(menuReservaButton);
            Controls.Add(numBagagemLabel);
            Controls.Add(headerBagagemLabel);
            Controls.Add(passaporteLabel);
            Controls.Add(telefoneLabel);
            Controls.Add(emailLabel);
            Controls.Add(nomeLabel);
            Controls.Add(headerClienteLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "ClienteForm";
            Text = "Formulario Passageiro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerClienteLabel;
        private Label nomeLabel;
        private Label emailLabel;
        private Label telefoneLabel;
        private Label passaporteLabel;
        private Label headerBagagemLabel;
        private Label numBagagemLabel;
        private CheckBox checkCheckBox;
        private Button menuReservaButton;
        private LinkLabel criarBagagenLink;
        private ListBox bagagemListBox;
        private TextBox nomeClienteValue;
        private TextBox emailClienteValue;
        private TextBox telefoneClienteValue;
        private TextBox passaporteClienteValue;
    }
}
