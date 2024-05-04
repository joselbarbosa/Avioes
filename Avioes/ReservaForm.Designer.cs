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
            SuspendLayout();
            // 
            // headerReservaLabel
            // 
            headerReservaLabel.AutoSize = true;
            headerReservaLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            headerReservaLabel.ForeColor = Color.LightSeaGreen;
            headerReservaLabel.Location = new Point(210, 36);
            headerReservaLabel.Name = "headerReservaLabel";
            headerReservaLabel.Size = new Size(113, 37);
            headerReservaLabel.TabIndex = 1;
            headerReservaLabel.Text = "Reserva:";
            // 
            // selecionarVooLabel
            // 
            selecionarVooLabel.AutoSize = true;
            selecionarVooLabel.ForeColor = SystemColors.ControlText;
            selecionarVooLabel.Location = new Point(83, 107);
            selecionarVooLabel.Name = "selecionarVooLabel";
            selecionarVooLabel.Size = new Size(145, 28);
            selecionarVooLabel.TabIndex = 3;
            selecionarVooLabel.Text = "Referência Voo:";
            // 
            // criarVooLink
            // 
            criarVooLink.AutoSize = true;
            criarVooLink.Location = new Point(258, 153);
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
            lugarVooLabel.Location = new Point(164, 267);
            lugarVooLabel.Name = "lugarVooLabel";
            lugarVooLabel.Size = new Size(65, 28);
            lugarVooLabel.TabIndex = 6;
            lugarVooLabel.Text = "Lugar:";
            // 
            // lugarReservaValue
            // 
            lugarReservaValue.Location = new Point(258, 267);
            lugarReservaValue.Name = "lugarReservaValue";
            lugarReservaValue.Size = new Size(151, 34);
            lugarReservaValue.TabIndex = 14;
            // 
            // vooReservaValue
            // 
            vooReservaValue.Location = new Point(258, 107);
            vooReservaValue.Name = "vooReservaValue";
            vooReservaValue.Size = new Size(151, 34);
            vooReservaValue.TabIndex = 11;
            // 
            // clienteReservaValue
            // 
            clienteReservaValue.Location = new Point(258, 204);
            clienteReservaValue.Name = "clienteReservaValue";
            clienteReservaValue.Size = new Size(151, 34);
            clienteReservaValue.TabIndex = 13;
            // 
            // numClienteLabel
            // 
            numClienteLabel.AutoSize = true;
            numClienteLabel.ForeColor = SystemColors.ControlText;
            numClienteLabel.Location = new Point(124, 207);
            numClienteLabel.Name = "numClienteLabel";
            numClienteLabel.Size = new Size(105, 28);
            numClienteLabel.TabIndex = 12;
            numClienteLabel.Text = "Nº Cliente:";
            // 
            // registarReservaButton
            // 
            registarReservaButton.BackColor = Color.Silver;
            registarReservaButton.Location = new Point(210, 338);
            registarReservaButton.Name = "registarReservaButton";
            registarReservaButton.Size = new Size(136, 71);
            registarReservaButton.TabIndex = 16;
            registarReservaButton.Text = "Registar Reserva";
            registarReservaButton.UseVisualStyleBackColor = false;
            registarReservaButton.Click += registarReservaButton_Click;
            // 
            // ReservaForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(524, 444);
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
    }
}