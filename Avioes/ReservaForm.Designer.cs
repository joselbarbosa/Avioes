namespace Avioes
{
    partial class ReservaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            headerReservaLabel = new Label();
            selecionarVooLabel = new Label();
            criarVooLink = new LinkLabel();
            lugarVooLabel = new Label();
            lugarReservaValue = new TextBox();
            vooReservaValue = new TextBox();
            clienteReservaValue = new TextBox();
            numClienteLabel = new Label();
            registarReservaButton = new Button();
            apagarReservaValue = new TextBox();
            apagarReservaButton = new Button();
            apagarReservaLabel = new Label();
            menuClienteButton = new Button();
            selectLugarValue = new TextBox();
            selectLugarButton = new Button();
            updateLugarButton = new Button();
            updateLugarValue = new TextBox();
            updateLugarLabel = new Label();
            SuspendLayout();
            // 
            // headerReservaLabel
            // 
            headerReservaLabel.AutoSize = true;
            headerReservaLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            headerReservaLabel.ForeColor = Color.LightSeaGreen;
            headerReservaLabel.Location = new Point(257, 17);
            headerReservaLabel.Name = "headerReservaLabel";
            headerReservaLabel.Size = new Size(113, 37);
            headerReservaLabel.TabIndex = 1;
            headerReservaLabel.Text = "Reserva:";
            // 
            // selecionarVooLabel
            // 
            selecionarVooLabel.AutoSize = true;
            selecionarVooLabel.ForeColor = SystemColors.ControlText;
            selecionarVooLabel.Location = new Point(71, 80);
            selecionarVooLabel.Name = "selecionarVooLabel";
            selecionarVooLabel.Size = new Size(80, 28);
            selecionarVooLabel.TabIndex = 3;
            selecionarVooLabel.Text = "Nº Voo:";
            // 
            // criarVooLink
            // 
            criarVooLink.AutoSize = true;
            criarVooLink.Location = new Point(181, 126);
            criarVooLink.Name = "criarVooLink";
            criarVooLink.Size = new Size(117, 28);
            criarVooLink.TabIndex = 12;
            criarVooLink.TabStop = true;
            criarVooLink.Text = "registar voo";
            criarVooLink.LinkClicked += criarVooLink_LinkClicked;
            // 
            // lugarVooLabel
            // 
            lugarVooLabel.AutoSize = true;
            lugarVooLabel.ForeColor = SystemColors.ControlText;
            lugarVooLabel.Location = new Point(86, 239);
            lugarVooLabel.Name = "lugarVooLabel";
            lugarVooLabel.Size = new Size(65, 28);
            lugarVooLabel.TabIndex = 6;
            lugarVooLabel.Text = "Lugar:";
            // 
            // lugarReservaValue
            // 
            lugarReservaValue.Location = new Point(181, 236);
            lugarReservaValue.Name = "lugarReservaValue";
            lugarReservaValue.Size = new Size(268, 34);
            lugarReservaValue.TabIndex = 14;
            // 
            // vooReservaValue
            // 
            vooReservaValue.Location = new Point(181, 80);
            vooReservaValue.Name = "vooReservaValue";
            vooReservaValue.Size = new Size(268, 34);
            vooReservaValue.TabIndex = 11;
            // 
            // clienteReservaValue
            // 
            clienteReservaValue.Location = new Point(181, 174);
            clienteReservaValue.Name = "clienteReservaValue";
            clienteReservaValue.Size = new Size(268, 34);
            clienteReservaValue.TabIndex = 13;
            // 
            // numClienteLabel
            // 
            numClienteLabel.AutoSize = true;
            numClienteLabel.ForeColor = SystemColors.ControlText;
            numClienteLabel.Location = new Point(47, 179);
            numClienteLabel.Name = "numClienteLabel";
            numClienteLabel.Size = new Size(105, 28);
            numClienteLabel.TabIndex = 12;
            numClienteLabel.Text = "Nº Cliente:";
            // 
            // registarReservaButton
            // 
            registarReservaButton.BackColor = Color.Silver;
            registarReservaButton.Location = new Point(473, 174);
            registarReservaButton.Name = "registarReservaButton";
            registarReservaButton.Size = new Size(114, 65);
            registarReservaButton.TabIndex = 16;
            registarReservaButton.Text = "Registar Reserva";
            registarReservaButton.UseVisualStyleBackColor = false;
            registarReservaButton.Click += registarReservaButton_Click;
            // 
            // apagarReservaValue
            // 
            apagarReservaValue.Location = new Point(181, 303);
            apagarReservaValue.Name = "apagarReservaValue";
            apagarReservaValue.Size = new Size(268, 34);
            apagarReservaValue.TabIndex = 18;
            apagarReservaValue.Text = "0";
            // 
            // apagarReservaButton
            // 
            apagarReservaButton.BackColor = Color.Silver;
            apagarReservaButton.Location = new Point(473, 298);
            apagarReservaButton.Name = "apagarReservaButton";
            apagarReservaButton.Size = new Size(114, 45);
            apagarReservaButton.TabIndex = 19;
            apagarReservaButton.Text = "Delete";
            apagarReservaButton.UseVisualStyleBackColor = false;
            apagarReservaButton.Click += apagarReservaButton_Click;
            // 
            // apagarReservaLabel
            // 
            apagarReservaLabel.AutoSize = true;
            apagarReservaLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            apagarReservaLabel.ForeColor = Color.LightSeaGreen;
            apagarReservaLabel.Location = new Point(47, 303);
            apagarReservaLabel.Name = "apagarReservaLabel";
            apagarReservaLabel.Size = new Size(116, 32);
            apagarReservaLabel.TabIndex = 20;
            apagarReservaLabel.Text = "Reserva #";
            // 
            // menuClienteButton
            // 
            menuClienteButton.BackColor = Color.Silver;
            menuClienteButton.Location = new Point(47, 505);
            menuClienteButton.Name = "menuClienteButton";
            menuClienteButton.Size = new Size(540, 41);
            menuClienteButton.TabIndex = 21;
            menuClienteButton.Text = "Menu Cliente";
            menuClienteButton.UseVisualStyleBackColor = false;
            menuClienteButton.Click += menuClienteButton_Click;
            // 
            // selectLugarValue
            // 
            selectLugarValue.Location = new Point(214, 369);
            selectLugarValue.Name = "selectLugarValue";
            selectLugarValue.Size = new Size(235, 34);
            selectLugarValue.TabIndex = 26;
            // 
            // selectLugarButton
            // 
            selectLugarButton.BackColor = Color.Silver;
            selectLugarButton.Location = new Point(47, 364);
            selectLugarButton.Name = "selectLugarButton";
            selectLugarButton.Size = new Size(161, 45);
            selectLugarButton.TabIndex = 28;
            selectLugarButton.Text = "Localizar lugar";
            selectLugarButton.UseVisualStyleBackColor = false;
            selectLugarButton.Click += selectLugarButton_Click;
            // 
            // updateLugarButton
            // 
            updateLugarButton.BackColor = Color.Silver;
            updateLugarButton.Location = new Point(47, 433);
            updateLugarButton.Name = "updateLugarButton";
            updateLugarButton.Size = new Size(161, 45);
            updateLugarButton.TabIndex = 29;
            updateLugarButton.Text = "Permutar lugar";
            updateLugarButton.UseVisualStyleBackColor = false;
            updateLugarButton.Click += updateLugarButton_Click;
            // 
            // updateLugarValue
            // 
            updateLugarValue.Location = new Point(280, 438);
            updateLugarValue.Name = "updateLugarValue";
            updateLugarValue.Size = new Size(169, 34);
            updateLugarValue.TabIndex = 31;
            // 
            // updateLugarLabel
            // 
            updateLugarLabel.AutoSize = true;
            updateLugarLabel.Location = new Point(221, 441);
            updateLugarLabel.Name = "updateLugarLabel";
            updateLugarLabel.Size = new Size(53, 28);
            updateLugarLabel.TabIndex = 32;
            updateLugarLabel.Text = "Para:";
            // 
            // ReservaForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(635, 582);
            Controls.Add(updateLugarLabel);
            Controls.Add(updateLugarValue);
            Controls.Add(updateLugarButton);
            Controls.Add(selectLugarButton);
            Controls.Add(selectLugarValue);
            Controls.Add(menuClienteButton);
            Controls.Add(apagarReservaLabel);
            Controls.Add(apagarReservaButton);
            Controls.Add(apagarReservaValue);
            Controls.Add(registarReservaButton);
            Controls.Add(clienteReservaValue);
            Controls.Add(numClienteLabel);
            Controls.Add(vooReservaValue);
            Controls.Add(lugarReservaValue);
            Controls.Add(lugarVooLabel);
            Controls.Add(criarVooLink);
            Controls.Add(selecionarVooLabel);
            Controls.Add(headerReservaLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "ReservaForm";
            Text = "ReservaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerReservaLabel;
        private Label selecionarVooLabel;
        private LinkLabel criarVooLink;
        private Label lugarVooLabel;
        private TextBox lugarReservaValue;
        private TextBox vooReservaValue;
        private TextBox clienteReservaValue;
        private Label numClienteLabel;
        private Button registarReservaButton;
        private TextBox apagarReservaValue;
        private Button apagarReservaButton;
        private Label apagarReservaLabel;
        private Button menuClienteButton;
        private TextBox selectLugarValue;
        private Button selectLugarButton;
        private Button updateLugarButton;
        private TextBox updateLugarValue;
        private Label updateLugarLabel;
    }
}