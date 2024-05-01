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
            passaporteLabel = new Label();
            dataPartidaLabel = new Label();
            destinoLabel = new Label();
            origemLabel = new Label();
            numVooLabel = new Label();
            lugaresDisponiveisLabel = new Label();
            registoVooButton = new Button();
            numVooValue = new TextBox();
            origemVooValue = new TextBox();
            destinoVooValue = new TextBox();
            partidaVooValue = new TextBox();
            chegadaVooValue = new TextBox();
            lugaresDisponiveisValue = new TextBox();
            SuspendLayout();
            // 
            // headerVooLabel
            // 
            headerVooLabel.AutoSize = true;
            headerVooLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            headerVooLabel.ForeColor = Color.LightSeaGreen;
            headerVooLabel.Location = new Point(51, 21);
            headerVooLabel.Name = "headerVooLabel";
            headerVooLabel.Size = new Size(202, 37);
            headerVooLabel.TabIndex = 1;
            headerVooLabel.Text = "Registo de Voo:";
            // 
            // passaporteLabel
            // 
            passaporteLabel.AutoSize = true;
            passaporteLabel.Location = new Point(378, 162);
            passaporteLabel.Name = "passaporteLabel";
            passaporteLabel.Size = new Size(93, 28);
            passaporteLabel.TabIndex = 19;
            passaporteLabel.Text = "Chegada:";
            // 
            // dataPartidaLabel
            // 
            dataPartidaLabel.AutoSize = true;
            dataPartidaLabel.Location = new Point(394, 93);
            dataPartidaLabel.Name = "dataPartidaLabel";
            dataPartidaLabel.Size = new Size(77, 28);
            dataPartidaLabel.TabIndex = 17;
            dataPartidaLabel.Text = "Partida:";
            // 
            // destinoLabel
            // 
            destinoLabel.AutoSize = true;
            destinoLabel.Location = new Point(31, 229);
            destinoLabel.Name = "destinoLabel";
            destinoLabel.Size = new Size(83, 28);
            destinoLabel.TabIndex = 15;
            destinoLabel.Text = "Destino:";
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
            // numVooLabel
            // 
            numVooLabel.AutoSize = true;
            numVooLabel.ForeColor = SystemColors.ControlText;
            numVooLabel.Location = new Point(63, 93);
            numVooLabel.Name = "numVooLabel";
            numVooLabel.Size = new Size(51, 28);
            numVooLabel.TabIndex = 11;
            numVooLabel.Text = "Voo:";
            // 
            // lugaresDisponiveisLabel
            // 
            lugaresDisponiveisLabel.AutoSize = true;
            lugaresDisponiveisLabel.ForeColor = SystemColors.ControlText;
            lugaresDisponiveisLabel.Location = new Point(283, 229);
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
            // numVooValue
            // 
            numVooValue.Location = new Point(128, 93);
            numVooValue.Name = "numVooValue";
            numVooValue.Size = new Size(125, 34);
            numVooValue.TabIndex = 24;
            // 
            // origemVooValue
            // 
            origemVooValue.Location = new Point(128, 159);
            origemVooValue.Name = "origemVooValue";
            origemVooValue.Size = new Size(125, 34);
            origemVooValue.TabIndex = 25;
            // 
            // destinoVooValue
            // 
            destinoVooValue.Location = new Point(128, 226);
            destinoVooValue.Name = "destinoVooValue";
            destinoVooValue.Size = new Size(125, 34);
            destinoVooValue.TabIndex = 26;
            // 
            // partidaVooValue
            // 
            partidaVooValue.Location = new Point(483, 93);
            partidaVooValue.Name = "partidaVooValue";
            partidaVooValue.Size = new Size(125, 34);
            partidaVooValue.TabIndex = 27;
            // 
            // chegadaVooValue
            // 
            chegadaVooValue.Location = new Point(483, 159);
            chegadaVooValue.Name = "chegadaVooValue";
            chegadaVooValue.Size = new Size(125, 34);
            chegadaVooValue.TabIndex = 28;
            // 
            // lugaresDisponiveisValue
            // 
            lugaresDisponiveisValue.Location = new Point(483, 226);
            lugaresDisponiveisValue.Name = "lugaresDisponiveisValue";
            lugaresDisponiveisValue.Size = new Size(125, 34);
            lugaresDisponiveisValue.TabIndex = 29;
            // 
            // VooForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(686, 429);
            Controls.Add(lugaresDisponiveisValue);
            Controls.Add(chegadaVooValue);
            Controls.Add(partidaVooValue);
            Controls.Add(destinoVooValue);
            Controls.Add(origemVooValue);
            Controls.Add(numVooValue);
            Controls.Add(registoVooButton);
            Controls.Add(lugaresDisponiveisLabel);
            Controls.Add(passaporteLabel);
            Controls.Add(dataPartidaLabel);
            Controls.Add(destinoLabel);
            Controls.Add(origemLabel);
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
        private Label passaporteLabel;
        private Label dataPartidaLabel;
        private Label destinoLabel;
        private Label origemLabel;
        private Label numVooLabel;
        private Label lugaresDisponiveisLabel;
        private Button registoVooButton;
        private TextBox numVooValue;
        private TextBox origemVooValue;
        private TextBox destinoVooValue;
        private TextBox partidaVooValue;
        private TextBox chegadaVooValue;
        private TextBox lugaresDisponiveisValue;
    }
}