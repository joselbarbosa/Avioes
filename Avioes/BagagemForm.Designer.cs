namespace Avioes
{
    partial class BagagemForm
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
            headerBagagemLabel = new Label();
            larguraLabel = new Label();
            cumprimentoLabel = new Label();
            pesoLabel = new Label();
            registoBagagemButton = new Button();
            pesoBagagemValue = new TextBox();
            cumpBagagemValue = new TextBox();
            largBagagemValue = new TextBox();
            bagtagLabel = new Label();
            bagtagBagagemValue = new TextBox();
            altBagagemValue = new TextBox();
            alturaLabel = new Label();
            SuspendLayout();
            // 
            // headerBagagemLabel
            // 
            headerBagagemLabel.AutoSize = true;
            headerBagagemLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            headerBagagemLabel.ForeColor = Color.LightSeaGreen;
            headerBagagemLabel.Location = new Point(104, 22);
            headerBagagemLabel.Margin = new Padding(4, 0, 4, 0);
            headerBagagemLabel.Name = "headerBagagemLabel";
            headerBagagemLabel.Size = new Size(267, 37);
            headerBagagemLabel.TabIndex = 12;
            headerBagagemLabel.Text = "Registo de Bagagem:";
            // 
            // larguraLabel
            // 
            larguraLabel.AutoSize = true;
            larguraLabel.Location = new Point(120, 221);
            larguraLabel.Name = "larguraLabel";
            larguraLabel.Size = new Size(82, 28);
            larguraLabel.TabIndex = 17;
            larguraLabel.Text = "Largura:";
            // 
            // cumprimentoLabel
            // 
            cumprimentoLabel.AutoSize = true;
            cumprimentoLabel.Location = new Point(65, 155);
            cumprimentoLabel.Name = "cumprimentoLabel";
            cumprimentoLabel.Size = new Size(137, 28);
            cumprimentoLabel.TabIndex = 15;
            cumprimentoLabel.Text = "Cumprimento:";
            // 
            // pesoLabel
            // 
            pesoLabel.AutoSize = true;
            pesoLabel.ForeColor = SystemColors.ControlText;
            pesoLabel.Location = new Point(146, 90);
            pesoLabel.Name = "pesoLabel";
            pesoLabel.Size = new Size(56, 28);
            pesoLabel.TabIndex = 13;
            pesoLabel.Text = "Peso:";
            // 
            // registoBagagemButton
            // 
            registoBagagemButton.BackColor = Color.Silver;
            registoBagagemButton.Location = new Point(133, 454);
            registoBagagemButton.Name = "registoBagagemButton";
            registoBagagemButton.Size = new Size(187, 49);
            registoBagagemButton.TabIndex = 20;
            registoBagagemButton.Text = "Registo Bagagem";
            registoBagagemButton.UseVisualStyleBackColor = false;
            registoBagagemButton.Click += registoBagagemButton_Click;
            // 
            // pesoBagagemValue
            // 
            pesoBagagemValue.Location = new Point(218, 90);
            pesoBagagemValue.Name = "pesoBagagemValue";
            pesoBagagemValue.Size = new Size(125, 34);
            pesoBagagemValue.TabIndex = 21;
            pesoBagagemValue.Text = "0";
            // 
            // cumpBagagemValue
            // 
            cumpBagagemValue.Location = new Point(218, 152);
            cumpBagagemValue.Name = "cumpBagagemValue";
            cumpBagagemValue.Size = new Size(125, 34);
            cumpBagagemValue.TabIndex = 22;
            cumpBagagemValue.Text = "0";
            // 
            // largBagagemValue
            // 
            largBagagemValue.Location = new Point(218, 218);
            largBagagemValue.Name = "largBagagemValue";
            largBagagemValue.Size = new Size(125, 34);
            largBagagemValue.TabIndex = 23;
            largBagagemValue.Text = "0";
            // 
            // bagtagLabel
            // 
            bagtagLabel.AutoSize = true;
            bagtagLabel.Location = new Point(124, 379);
            bagtagLabel.Name = "bagtagLabel";
            bagtagLabel.Size = new Size(78, 28);
            bagtagLabel.TabIndex = 24;
            bagtagLabel.Text = "Bagtag:";
            // 
            // bagtagBagagemValue
            // 
            bagtagBagagemValue.Location = new Point(218, 379);
            bagtagBagagemValue.Name = "bagtagBagagemValue";
            bagtagBagagemValue.Size = new Size(125, 34);
            bagtagBagagemValue.TabIndex = 25;
            // 
            // altBagagemValue
            // 
            altBagagemValue.Location = new Point(218, 296);
            altBagagemValue.Name = "altBagagemValue";
            altBagagemValue.Size = new Size(125, 34);
            altBagagemValue.TabIndex = 27;
            altBagagemValue.Text = "0";
            // 
            // alturaLabel
            // 
            alturaLabel.AutoSize = true;
            alturaLabel.Location = new Point(120, 299);
            alturaLabel.Name = "alturaLabel";
            alturaLabel.Size = new Size(82, 28);
            alturaLabel.TabIndex = 26;
            alturaLabel.Text = "Largura:";
            // 
            // BagagemForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(468, 525);
            Controls.Add(altBagagemValue);
            Controls.Add(alturaLabel);
            Controls.Add(bagtagBagagemValue);
            Controls.Add(bagtagLabel);
            Controls.Add(largBagagemValue);
            Controls.Add(cumpBagagemValue);
            Controls.Add(pesoBagagemValue);
            Controls.Add(registoBagagemButton);
            Controls.Add(larguraLabel);
            Controls.Add(cumprimentoLabel);
            Controls.Add(pesoLabel);
            Controls.Add(headerBagagemLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "BagagemForm";
            Text = "BagagemForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerBagagemLabel;
        private Label larguraLabel;
        private Label cumprimentoLabel;
        private Label pesoLabel;
        private Button registoBagagemButton;
        private TextBox pesoBagagemValue;
        private TextBox cumpBagagemValue;
        private TextBox largBagagemValue;
        private Label bagtagLabel;
        private TextBox bagtagBagagemValue;
        private TextBox altBagagemValue;
        private Label alturaLabel;
    }
}