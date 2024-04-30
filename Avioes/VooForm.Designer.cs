namespace Avioes
{
    partial class VooForm
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
            headerVooLabel = new Label();
            dataChegadaVoo = new Label();
            passaporteLabel = new Label();
            dataPartidaVoo = new Label();
            dataPartidaLabel = new Label();
            destinoVoo = new Label();
            destinoLabel = new Label();
            origemVoo = new Label();
            origemLabel = new Label();
            numVoo = new Label();
            numVooLabel = new Label();
            lugarVoo = new Label();
            lugaresDisponiveisLabel = new Label();
            registoVooButton = new Button();
            SuspendLayout();
            // 
            // headerVooLabel
            // 
            headerVooLabel.AutoSize = true;
            headerVooLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            headerVooLabel.ForeColor = Color.LightSeaGreen;
            headerVooLabel.Location = new Point(32, 22);
            headerVooLabel.Name = "headerVooLabel";
            headerVooLabel.Size = new Size(202, 37);
            headerVooLabel.TabIndex = 1;
            headerVooLabel.Text = "Registo de Voo:";
            // 
            // dataChegadaVoo
            // 
            dataChegadaVoo.AutoSize = true;
            dataChegadaVoo.Location = new Point(444, 162);
            dataChegadaVoo.Name = "dataChegadaVoo";
            dataChegadaVoo.Size = new Size(84, 28);
            dataChegadaVoo.TabIndex = 20;
            dataChegadaVoo.Text = "<none>";
            // 
            // passaporteLabel
            // 
            passaporteLabel.AutoSize = true;
            passaporteLabel.Location = new Point(345, 162);
            passaporteLabel.Name = "passaporteLabel";
            passaporteLabel.Size = new Size(93, 28);
            passaporteLabel.TabIndex = 19;
            passaporteLabel.Text = "Chegada:";
            // 
            // dataPartidaVoo
            // 
            dataPartidaVoo.AutoSize = true;
            dataPartidaVoo.Location = new Point(429, 96);
            dataPartidaVoo.Name = "dataPartidaVoo";
            dataPartidaVoo.Size = new Size(84, 28);
            dataPartidaVoo.TabIndex = 18;
            dataPartidaVoo.Text = "<none>";
            // 
            // dataPartidaLabel
            // 
            dataPartidaLabel.AutoSize = true;
            dataPartidaLabel.Location = new Point(345, 96);
            dataPartidaLabel.Name = "dataPartidaLabel";
            dataPartidaLabel.Size = new Size(77, 28);
            dataPartidaLabel.TabIndex = 17;
            dataPartidaLabel.Text = "Partida:";
            // 
            // destinoVoo
            // 
            destinoVoo.AutoSize = true;
            destinoVoo.Location = new Point(116, 229);
            destinoVoo.Name = "destinoVoo";
            destinoVoo.Size = new Size(84, 28);
            destinoVoo.TabIndex = 16;
            destinoVoo.Text = "<none>";
            // 
            // destinoLabel
            // 
            destinoLabel.AutoSize = true;
            destinoLabel.Location = new Point(32, 229);
            destinoLabel.Name = "destinoLabel";
            destinoLabel.Size = new Size(83, 28);
            destinoLabel.TabIndex = 15;
            destinoLabel.Text = "Destino:";
            // 
            // origemVoo
            // 
            origemVoo.AutoSize = true;
            origemVoo.Location = new Point(116, 162);
            origemVoo.Name = "origemVoo";
            origemVoo.Size = new Size(84, 28);
            origemVoo.TabIndex = 14;
            origemVoo.Text = "<none>";
            // 
            // origemLabel
            // 
            origemLabel.AutoSize = true;
            origemLabel.Location = new Point(32, 162);
            origemLabel.Name = "origemLabel";
            origemLabel.Size = new Size(82, 28);
            origemLabel.TabIndex = 13;
            origemLabel.Text = "Origem:";
            // 
            // numVoo
            // 
            numVoo.AutoSize = true;
            numVoo.Location = new Point(116, 96);
            numVoo.Name = "numVoo";
            numVoo.Size = new Size(84, 28);
            numVoo.TabIndex = 12;
            numVoo.Text = "<none>";
            // 
            // numVooLabel
            // 
            numVooLabel.AutoSize = true;
            numVooLabel.ForeColor = SystemColors.ControlText;
            numVooLabel.Location = new Point(32, 96);
            numVooLabel.Name = "numVooLabel";
            numVooLabel.Size = new Size(51, 28);
            numVooLabel.TabIndex = 11;
            numVooLabel.Text = "Voo:";
            // 
            // lugarVoo
            // 
            lugarVoo.AutoSize = true;
            lugarVoo.Location = new Point(539, 229);
            lugarVoo.Name = "lugarVoo";
            lugarVoo.Size = new Size(84, 28);
            lugarVoo.TabIndex = 22;
            lugarVoo.Text = "<none>";
            // 
            // lugaresDisponiveisLabel
            // 
            lugaresDisponiveisLabel.AutoSize = true;
            lugaresDisponiveisLabel.ForeColor = SystemColors.ControlText;
            lugaresDisponiveisLabel.Location = new Point(345, 229);
            lugaresDisponiveisLabel.Name = "lugaresDisponiveisLabel";
            lugaresDisponiveisLabel.Size = new Size(188, 28);
            lugaresDisponiveisLabel.TabIndex = 21;
            lugaresDisponiveisLabel.Text = "Lugares Disponíveis:";
            // 
            // registoVooButton
            // 
            registoVooButton.BackColor = Color.Silver;
            registoVooButton.Location = new Point(248, 320);
            registoVooButton.Name = "registoVooButton";
            registoVooButton.Size = new Size(187, 49);
            registoVooButton.TabIndex = 23;
            registoVooButton.Text = "Registo Voo";
            registoVooButton.UseVisualStyleBackColor = false;
            // 
            // VooForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(686, 429);
            Controls.Add(registoVooButton);
            Controls.Add(lugarVoo);
            Controls.Add(lugaresDisponiveisLabel);
            Controls.Add(dataChegadaVoo);
            Controls.Add(passaporteLabel);
            Controls.Add(dataPartidaVoo);
            Controls.Add(dataPartidaLabel);
            Controls.Add(destinoVoo);
            Controls.Add(destinoLabel);
            Controls.Add(origemVoo);
            Controls.Add(origemLabel);
            Controls.Add(numVoo);
            Controls.Add(numVooLabel);
            Controls.Add(headerVooLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "VooForm";
            Text = "VooForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerVooLabel;
        private Label dataChegadaVoo;
        private Label passaporteLabel;
        private Label dataPartidaVoo;
        private Label dataPartidaLabel;
        private Label destinoVoo;
        private Label destinoLabel;
        private Label origemVoo;
        private Label origemLabel;
        private Label numVoo;
        private Label numVooLabel;
        private Label lugarVoo;
        private Label lugaresDisponiveisLabel;
        private Button registoVooButton;
    }
}