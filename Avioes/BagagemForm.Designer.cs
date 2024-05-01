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
            fragilCheckBox = new CheckBox();
            registoBagagemButton = new Button();
            pesoBagagemValue = new TextBox();
            cumpBagagemValue = new TextBox();
            largBagagemValue = new TextBox();
            SuspendLayout();
            // 
            // headerBagagemLabel
            // 
            headerBagagemLabel.AutoSize = true;
            headerBagagemLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            headerBagagemLabel.ForeColor = Color.LightSeaGreen;
            headerBagagemLabel.Location = new Point(161, 38);
            headerBagagemLabel.Margin = new Padding(4, 0, 4, 0);
            headerBagagemLabel.Name = "headerBagagemLabel";
            headerBagagemLabel.Size = new Size(267, 37);
            headerBagagemLabel.TabIndex = 12;
            headerBagagemLabel.Text = "Registo de Bagagem:";
            // 
            // larguraLabel
            // 
            larguraLabel.AutoSize = true;
            larguraLabel.Location = new Point(143, 245);
            larguraLabel.Name = "larguraLabel";
            larguraLabel.Size = new Size(82, 28);
            larguraLabel.TabIndex = 17;
            larguraLabel.Text = "Largura:";
            // 
            // cumprimentoLabel
            // 
            cumprimentoLabel.AutoSize = true;
            cumprimentoLabel.Location = new Point(88, 179);
            cumprimentoLabel.Name = "cumprimentoLabel";
            cumprimentoLabel.Size = new Size(137, 28);
            cumprimentoLabel.TabIndex = 15;
            cumprimentoLabel.Text = "Cumprimento:";
            // 
            // pesoLabel
            // 
            pesoLabel.AutoSize = true;
            pesoLabel.ForeColor = SystemColors.ControlText;
            pesoLabel.Location = new Point(169, 114);
            pesoLabel.Name = "pesoLabel";
            pesoLabel.Size = new Size(56, 28);
            pesoLabel.TabIndex = 13;
            pesoLabel.Text = "Peso:";
            // 
            // fragilCheckBox
            // 
            fragilCheckBox.AutoSize = true;
            fragilCheckBox.Location = new Point(142, 317);
            fragilCheckBox.Name = "fragilCheckBox";
            fragilCheckBox.Size = new Size(83, 32);
            fragilCheckBox.TabIndex = 19;
            fragilCheckBox.Text = "Fragil";
            fragilCheckBox.UseVisualStyleBackColor = true;
            // 
            // registoBagagemButton
            // 
            registoBagagemButton.BackColor = Color.Silver;
            registoBagagemButton.Location = new Point(241, 389);
            registoBagagemButton.Name = "registoBagagemButton";
            registoBagagemButton.Size = new Size(187, 49);
            registoBagagemButton.TabIndex = 20;
            registoBagagemButton.Text = "Registo Bagagem";
            registoBagagemButton.UseVisualStyleBackColor = false;
            // 
            // pesoBagagemValue
            // 
            pesoBagagemValue.Location = new Point(241, 114);
            pesoBagagemValue.Name = "pesoBagagemValue";
            pesoBagagemValue.Size = new Size(125, 34);
            pesoBagagemValue.TabIndex = 21;
            // 
            // cumpBagagemValue
            // 
            cumpBagagemValue.Location = new Point(241, 176);
            cumpBagagemValue.Name = "cumpBagagemValue";
            cumpBagagemValue.Size = new Size(125, 34);
            cumpBagagemValue.TabIndex = 22;
            // 
            // largBagagemValue
            // 
            largBagagemValue.Location = new Point(241, 242);
            largBagagemValue.Name = "largBagagemValue";
            largBagagemValue.Size = new Size(125, 34);
            largBagagemValue.TabIndex = 23;
            // 
            // BagagemForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(646, 473);
            Controls.Add(largBagagemValue);
            Controls.Add(cumpBagagemValue);
            Controls.Add(pesoBagagemValue);
            Controls.Add(registoBagagemButton);
            Controls.Add(fragilCheckBox);
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
        private CheckBox fragilCheckBox;
        private Button registoBagagemButton;
        private TextBox pesoBagagemValue;
        private TextBox cumpBagagemValue;
        private TextBox largBagagemValue;
    }
}