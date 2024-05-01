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
            VooDropDown = new ComboBox();
            criarVooLink = new LinkLabel();
            lugarVooLabel = new Label();
            idClienteLabel = new Label();
            lugarReservaValue = new TextBox();
            clienteReservaValue = new TextBox();
            SuspendLayout();
            // 
            // headerReservaLabel
            // 
            headerReservaLabel.AutoSize = true;
            headerReservaLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            headerReservaLabel.ForeColor = Color.LightSeaGreen;
            headerReservaLabel.Location = new Point(81, 37);
            headerReservaLabel.Name = "headerReservaLabel";
            headerReservaLabel.Size = new Size(113, 37);
            headerReservaLabel.TabIndex = 1;
            headerReservaLabel.Text = "Reserva:";
            // 
            // selecionarVooLabel
            // 
            selecionarVooLabel.AutoSize = true;
            selecionarVooLabel.ForeColor = SystemColors.ControlText;
            selecionarVooLabel.Location = new Point(48, 108);
            selecionarVooLabel.Name = "selecionarVooLabel";
            selecionarVooLabel.Size = new Size(146, 28);
            selecionarVooLabel.TabIndex = 3;
            selecionarVooLabel.Text = "Selecionar Voo:";
            // 
            // VooDropDown
            // 
            VooDropDown.FormattingEnabled = true;
            VooDropDown.Location = new Point(223, 105);
            VooDropDown.Name = "VooDropDown";
            VooDropDown.Size = new Size(151, 36);
            VooDropDown.TabIndex = 4;
            // 
            // criarVooLink
            // 
            criarVooLink.AutoSize = true;
            criarVooLink.Location = new Point(223, 154);
            criarVooLink.Name = "criarVooLink";
            criarVooLink.Size = new Size(89, 28);
            criarVooLink.TabIndex = 5;
            criarVooLink.TabStop = true;
            criarVooLink.Text = "criar voo";
            // 
            // lugarVooLabel
            // 
            lugarVooLabel.AutoSize = true;
            lugarVooLabel.ForeColor = SystemColors.ControlText;
            lugarVooLabel.Location = new Point(129, 219);
            lugarVooLabel.Name = "lugarVooLabel";
            lugarVooLabel.Size = new Size(65, 28);
            lugarVooLabel.TabIndex = 6;
            lugarVooLabel.Text = "Lugar:";
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.ForeColor = SystemColors.ControlText;
            idClienteLabel.Location = new Point(89, 301);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new Size(105, 28);
            idClienteLabel.TabIndex = 8;
            idClienteLabel.Text = "Nº Cliente:";
            // 
            // lugarReservaValue
            // 
            lugarReservaValue.Location = new Point(223, 219);
            lugarReservaValue.Name = "lugarReservaValue";
            lugarReservaValue.Size = new Size(151, 34);
            lugarReservaValue.TabIndex = 9;
            // 
            // clienteReservaValue
            // 
            clienteReservaValue.Location = new Point(223, 295);
            clienteReservaValue.Name = "clienteReservaValue";
            clienteReservaValue.Size = new Size(151, 34);
            clienteReservaValue.TabIndex = 10;
            // 
            // ReservaForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(643, 476);
            Controls.Add(clienteReservaValue);
            Controls.Add(lugarReservaValue);
            Controls.Add(idClienteLabel);
            Controls.Add(lugarVooLabel);
            Controls.Add(criarVooLink);
            Controls.Add(VooDropDown);
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
        private ComboBox VooDropDown;
        private LinkLabel criarVooLink;
        private Label lugarVooLabel;
        private Label idClienteLabel;
        private TextBox lugarReservaValue;
        private TextBox clienteReservaValue;
    }
}