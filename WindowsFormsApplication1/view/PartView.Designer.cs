namespace WindowsFormsApplication1.view
{
    partial class PartView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nomeText = new System.Windows.Forms.TextBox();
            this.priceText = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.modelCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.yearText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.endYearText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome da peça:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor:";
            // 
            // nomeText
            // 
            this.nomeText.Location = new System.Drawing.Point(151, 9);
            this.nomeText.Name = "nomeText";
            this.nomeText.Size = new System.Drawing.Size(263, 20);
            this.nomeText.TabIndex = 2;
            // 
            // priceText
            // 
            this.priceText.Location = new System.Drawing.Point(151, 121);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(263, 20);
            this.priceText.TabIndex = 3;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(213, 148);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(294, 148);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Modelo de carro:";
            // 
            // modelCombo
            // 
            this.modelCombo.FormattingEnabled = true;
            this.modelCombo.Location = new System.Drawing.Point(151, 46);
            this.modelCombo.Name = "modelCombo";
            this.modelCombo.Size = new System.Drawing.Size(263, 21);
            this.modelCombo.TabIndex = 7;
            this.modelCombo.SelectedIndexChanged += new System.EventHandler(this.carCombo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ano:";
            // 
            // yearText
            // 
            this.yearText.Location = new System.Drawing.Point(151, 84);
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(100, 20);
            this.yearText.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Até";
            // 
            // endYearText
            // 
            this.endYearText.Location = new System.Drawing.Point(294, 84);
            this.endYearText.Name = "endYearText";
            this.endYearText.Size = new System.Drawing.Size(120, 20);
            this.endYearText.TabIndex = 11;
            // 
            // PartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 183);
            this.Controls.Add(this.endYearText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.yearText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.modelCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.nomeText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PartView";
            this.Text = "Cadastro de peça";
            this.Load += new System.EventHandler(this.PartView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomeText;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox modelCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox yearText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox endYearText;
    }
}