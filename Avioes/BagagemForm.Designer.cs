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
            telefoneCliente = new Label();
            larguraLabel = new Label();
            emailCliente = new Label();
            cumprimentoLabel = new Label();
            nomeCliente = new Label();
            pesoLabel = new Label();
            fragilCheckBox = new CheckBox();
            registoBagagemButton = new Button();
            SuspendLayout();
            // 
            // headerBagagemLabel
            // 
            headerBagagemLabel.AutoSize = true;
            headerBagagemLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            headerBagagemLabel.ForeColor = Color.LightSeaGreen;
            headerBagagemLabel.Location = new Point(38, 40);
            headerBagagemLabel.Margin = new Padding(4, 0, 4, 0);
            headerBagagemLabel.Name = "headerBagagemLabel";
            headerBagagemLabel.Size = new Size(267, 37);
            headerBagagemLabel.TabIndex = 12;
            headerBagagemLabel.Text = "Registo de Bagagem:";
            // 
            // telefoneCliente
            // 
            telefoneCliente.AutoSize = true;
            telefoneCliente.Location = new Point(122, 239);
            telefoneCliente.Name = "telefoneCliente";
            telefoneCliente.Size = new Size(84, 28);
            telefoneCliente.TabIndex = 18;
            telefoneCliente.Text = "<none>";
            // 
            // larguraLabel
            // 
            larguraLabel.AutoSize = true;
            larguraLabel.Location = new Point(38, 239);
            larguraLabel.Name = "larguraLabel";
            larguraLabel.Size = new Size(82, 28);
            larguraLabel.TabIndex = 17;
            larguraLabel.Text = "Largura:";
            // 
            // emailCliente
            // 
            emailCliente.AutoSize = true;
            emailCliente.Location = new Point(181, 172);
            emailCliente.Name = "emailCliente";
            emailCliente.Size = new Size(84, 28);
            emailCliente.TabIndex = 16;
            emailCliente.Text = "<none>";
            // 
            // cumprimentoLabel
            // 
            cumprimentoLabel.AutoSize = true;
            cumprimentoLabel.Location = new Point(38, 172);
            cumprimentoLabel.Name = "cumprimentoLabel";
            cumprimentoLabel.Size = new Size(137, 28);
            cumprimentoLabel.TabIndex = 15;
            cumprimentoLabel.Text = "Cumprimento:";
            // 
            // nomeCliente
            // 
            nomeCliente.AutoSize = true;
            nomeCliente.Location = new Point(100, 106);
            nomeCliente.Name = "nomeCliente";
            nomeCliente.Size = new Size(84, 28);
            nomeCliente.TabIndex = 14;
            nomeCliente.Text = "<none>";
            // 
            // pesoLabel
            // 
            pesoLabel.AutoSize = true;
            pesoLabel.ForeColor = SystemColors.ControlText;
            pesoLabel.Location = new Point(38, 106);
            pesoLabel.Name = "pesoLabel";
            pesoLabel.Size = new Size(56, 28);
            pesoLabel.TabIndex = 13;
            pesoLabel.Text = "Peso:";
            // 
            // fragilCheckBox
            // 
            fragilCheckBox.AutoSize = true;
            fragilCheckBox.Location = new Point(38, 309);
            fragilCheckBox.Name = "fragilCheckBox";
            fragilCheckBox.Size = new Size(83, 32);
            fragilCheckBox.TabIndex = 19;
            fragilCheckBox.Text = "Fragil";
            fragilCheckBox.UseVisualStyleBackColor = true;
            // 
            // registoBagagemButton
            // 
            registoBagagemButton.BackColor = Color.Silver;
            registoBagagemButton.Location = new Point(235, 384);
            registoBagagemButton.Name = "registoBagagemButton";
            registoBagagemButton.Size = new Size(187, 49);
            registoBagagemButton.TabIndex = 20;
            registoBagagemButton.Text = "Registo Bagagem";
            registoBagagemButton.UseVisualStyleBackColor = false;
            // 
            // BagagemForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(646, 473);
            Controls.Add(registoBagagemButton);
            Controls.Add(fragilCheckBox);
            Controls.Add(telefoneCliente);
            Controls.Add(larguraLabel);
            Controls.Add(emailCliente);
            Controls.Add(cumprimentoLabel);
            Controls.Add(nomeCliente);
            Controls.Add(pesoLabel);
            Controls.Add(headerBagagemLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "BagagemForm";
            Text = "BagagemForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerBagagemLabel;
        private Label telefoneCliente;
        private Label larguraLabel;
        private Label emailCliente;
        private Label cumprimentoLabel;
        private Label nomeCliente;
        private Label pesoLabel;
        private CheckBox fragilCheckBox;
        private Button registoBagagemButton;
    }
}