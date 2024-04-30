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
            lugarVoo = new Label();
            lugarVooLabel = new Label();
            label1 = new Label();
            idClienteLabel = new Label();
            SuspendLayout();
            // 
            // headerReservaLabel
            // 
            headerReservaLabel.AutoSize = true;
            headerReservaLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            headerReservaLabel.ForeColor = Color.LightSeaGreen;
            headerReservaLabel.Location = new Point(48, 45);
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
            // lugarVoo
            // 
            lugarVoo.AutoSize = true;
            lugarVoo.Location = new Point(119, 219);
            lugarVoo.Name = "lugarVoo";
            lugarVoo.Size = new Size(84, 28);
            lugarVoo.TabIndex = 7;
            lugarVoo.Text = "<none>";
            // 
            // lugarVooLabel
            // 
            lugarVooLabel.AutoSize = true;
            lugarVooLabel.ForeColor = SystemColors.ControlText;
            lugarVooLabel.Location = new Point(48, 219);
            lugarVooLabel.Name = "lugarVooLabel";
            lugarVooLabel.Size = new Size(65, 28);
            lugarVooLabel.TabIndex = 6;
            lugarVooLabel.Text = "Lugar:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(154, 301);
            label1.Name = "label1";
            label1.Size = new Size(84, 28);
            label1.TabIndex = 9;
            label1.Text = "<none>";
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.ForeColor = SystemColors.ControlText;
            idClienteLabel.Location = new Point(48, 301);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new Size(100, 28);
            idClienteLabel.TabIndex = 8;
            idClienteLabel.Text = "ID Cliente:";
            // 
            // ReservaForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(643, 476);
            Controls.Add(label1);
            Controls.Add(idClienteLabel);
            Controls.Add(lugarVoo);
            Controls.Add(lugarVooLabel);
            Controls.Add(criarVooLink);
            Controls.Add(VooDropDown);
            Controls.Add(selecionarVooLabel);
            Controls.Add(headerReservaLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
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
        private Label lugarVoo;
        private Label lugarVooLabel;
        private Label label1;
        private Label idClienteLabel;
    }
}