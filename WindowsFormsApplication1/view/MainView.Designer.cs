namespace WindowsFormsApplication1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.comboCars = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNewCar = new System.Windows.Forms.Button();
            this.buttonNewPart = new System.Windows.Forms.Button();
            this.buttonNewService = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.objectListServices = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.objectListSelectedServices = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.objectListParts = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn7 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn8 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.objectListSelectedParts = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn9 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn10 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn11 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn12 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.addServiceButton = new System.Windows.Forms.Button();
            this.removeServiceButton = new System.Windows.Forms.Button();
            this.addPartButton = new System.Windows.Forms.Button();
            this.removePartButton = new System.Windows.Forms.Button();
            this.olvColumn13 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn14 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.objectListServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectListSelectedServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectListParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectListSelectedParts)).BeginInit();
            this.SuspendLayout();
            // 
            // comboCars
            // 
            this.comboCars.FormattingEnabled = true;
            this.comboCars.Location = new System.Drawing.Point(5, 38);
            this.comboCars.Name = "comboCars";
            this.comboCars.Size = new System.Drawing.Size(121, 21);
            this.comboCars.TabIndex = 0;
            this.comboCars.SelectedIndexChanged += new System.EventHandler(this.comboCars_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione um veículo:";
            // 
            // buttonNewCar
            // 
            this.buttonNewCar.Location = new System.Drawing.Point(5, 65);
            this.buttonNewCar.Name = "buttonNewCar";
            this.buttonNewCar.Size = new System.Drawing.Size(121, 23);
            this.buttonNewCar.TabIndex = 2;
            this.buttonNewCar.Text = "Cadastrar um carro";
            this.buttonNewCar.UseVisualStyleBackColor = true;
            this.buttonNewCar.Click += new System.EventHandler(this.buttonNewCar_Click);
            // 
            // buttonNewPart
            // 
            this.buttonNewPart.Location = new System.Drawing.Point(5, 94);
            this.buttonNewPart.Name = "buttonNewPart";
            this.buttonNewPart.Size = new System.Drawing.Size(121, 23);
            this.buttonNewPart.TabIndex = 3;
            this.buttonNewPart.Text = "Cadastrar peça";
            this.buttonNewPart.UseVisualStyleBackColor = true;
            this.buttonNewPart.Click += new System.EventHandler(this.buttonNewPart_Click);
            // 
            // buttonNewService
            // 
            this.buttonNewService.Location = new System.Drawing.Point(5, 123);
            this.buttonNewService.Name = "buttonNewService";
            this.buttonNewService.Size = new System.Drawing.Size(121, 23);
            this.buttonNewService.TabIndex = 4;
            this.buttonNewService.Text = "Cadastrar serviço";
            this.buttonNewService.UseVisualStyleBackColor = true;
            this.buttonNewService.Click += new System.EventHandler(this.buttonNewService_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Valor total do orçamento: R$";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(628, 350);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(13, 13);
            this.labelTotal.TabIndex = 10;
            this.labelTotal.Text = "0";
            this.labelTotal.Click += new System.EventHandler(this.labelTotal_Click);
            // 
            // objectListServices
            // 
            this.objectListServices.AllColumns.Add(this.olvColumn3);
            this.objectListServices.AllColumns.Add(this.olvColumn4);
            this.objectListServices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn3,
            this.olvColumn4});
            this.objectListServices.Location = new System.Drawing.Point(132, 22);
            this.objectListServices.Name = "objectListServices";
            this.objectListServices.Size = new System.Drawing.Size(319, 144);
            this.objectListServices.TabIndex = 11;
            this.objectListServices.UseCompatibleStateImageBehavior = false;
            this.objectListServices.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "Name";
            this.olvColumn3.CellPadding = null;
            this.olvColumn3.Text = "Nome do serviço";
            this.olvColumn3.Width = 153;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "PricePerHour";
            this.olvColumn4.CellPadding = null;
            this.olvColumn4.Text = "Preço por hora";
            this.olvColumn4.Width = 89;
            // 
            // objectListSelectedServices
            // 
            this.objectListSelectedServices.AllColumns.Add(this.olvColumn1);
            this.objectListSelectedServices.AllColumns.Add(this.olvColumn2);
            this.objectListSelectedServices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2});
            this.objectListSelectedServices.Location = new System.Drawing.Point(483, 22);
            this.objectListSelectedServices.Name = "objectListSelectedServices";
            this.objectListSelectedServices.Size = new System.Drawing.Size(319, 144);
            this.objectListSelectedServices.TabIndex = 12;
            this.objectListSelectedServices.UseCompatibleStateImageBehavior = false;
            this.objectListSelectedServices.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Name";
            this.olvColumn1.CellPadding = null;
            this.olvColumn1.Text = "Nome do serviço";
            this.olvColumn1.Width = 150;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "PricePerHour";
            this.olvColumn2.AspectToStringFormat = "{0:0.00}";
            this.olvColumn2.CellPadding = null;
            this.olvColumn2.Text = "Preço por hora";
            this.olvColumn2.Width = 91;
            // 
            // objectListParts
            // 
            this.objectListParts.AllColumns.Add(this.olvColumn5);
            this.objectListParts.AllColumns.Add(this.olvColumn13);
            this.objectListParts.AllColumns.Add(this.olvColumn7);
            this.objectListParts.AllColumns.Add(this.olvColumn8);
            this.objectListParts.AllColumns.Add(this.olvColumn6);
            this.objectListParts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn5,
            this.olvColumn13,
            this.olvColumn7,
            this.olvColumn8,
            this.olvColumn6});
            this.objectListParts.Location = new System.Drawing.Point(132, 185);
            this.objectListParts.Name = "objectListParts";
            this.objectListParts.Size = new System.Drawing.Size(319, 144);
            this.objectListParts.TabIndex = 13;
            this.objectListParts.UseCompatibleStateImageBehavior = false;
            this.objectListParts.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "Name";
            this.olvColumn5.CellPadding = null;
            this.olvColumn5.Text = "Nome da peça";
            this.olvColumn5.Width = 86;
            // 
            // olvColumn7
            // 
            this.olvColumn7.AspectName = "Price";
            this.olvColumn7.AspectToStringFormat = "{0:0.00}";
            this.olvColumn7.CellPadding = null;
            this.olvColumn7.Text = "Preço";
            this.olvColumn7.Width = 58;
            // 
            // olvColumn8
            // 
            this.olvColumn8.AspectName = "Year";
            this.olvColumn8.AspectToStringFormat = "{0:yyyy}";
            this.olvColumn8.CellPadding = null;
            this.olvColumn8.Text = "Ano";
            this.olvColumn8.Width = 39;
            // 
            // olvColumn6
            // 
            this.olvColumn6.AspectName = "EndYear";
            this.olvColumn6.AspectToStringFormat = "{0:yyyy}";
            this.olvColumn6.CellPadding = null;
            this.olvColumn6.Text = "Ano Final";
            this.olvColumn6.Width = 56;
            // 
            // objectListSelectedParts
            // 
            this.objectListSelectedParts.AllColumns.Add(this.olvColumn9);
            this.objectListSelectedParts.AllColumns.Add(this.olvColumn14);
            this.objectListSelectedParts.AllColumns.Add(this.olvColumn10);
            this.objectListSelectedParts.AllColumns.Add(this.olvColumn11);
            this.objectListSelectedParts.AllColumns.Add(this.olvColumn12);
            this.objectListSelectedParts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn9,
            this.olvColumn14,
            this.olvColumn10,
            this.olvColumn11,
            this.olvColumn12});
            this.objectListSelectedParts.Location = new System.Drawing.Point(483, 185);
            this.objectListSelectedParts.Name = "objectListSelectedParts";
            this.objectListSelectedParts.Size = new System.Drawing.Size(319, 144);
            this.objectListSelectedParts.TabIndex = 14;
            this.objectListSelectedParts.UseCompatibleStateImageBehavior = false;
            this.objectListSelectedParts.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn9
            // 
            this.olvColumn9.AspectName = "Name";
            this.olvColumn9.CellPadding = null;
            this.olvColumn9.Text = "Nome da peça";
            this.olvColumn9.Width = 86;
            // 
            // olvColumn10
            // 
            this.olvColumn10.AspectName = "Price";
            this.olvColumn10.AspectToStringFormat = "{0:0.00}";
            this.olvColumn10.CellPadding = null;
            this.olvColumn10.Text = "Preço";
            this.olvColumn10.Width = 53;
            // 
            // olvColumn11
            // 
            this.olvColumn11.AspectName = "Year";
            this.olvColumn11.AspectToStringFormat = "{0:yyyy}";
            this.olvColumn11.CellPadding = null;
            this.olvColumn11.Text = "Ano";
            this.olvColumn11.Width = 39;
            // 
            // olvColumn12
            // 
            this.olvColumn12.AspectName = "EndYear";
            this.olvColumn12.AspectToStringFormat = "{0:yyyy}";
            this.olvColumn12.CellPadding = null;
            this.olvColumn12.Text = "Ano Final";
            this.olvColumn12.Width = 59;
            // 
            // addServiceButton
            // 
            this.addServiceButton.Location = new System.Drawing.Point(457, 22);
            this.addServiceButton.Name = "addServiceButton";
            this.addServiceButton.Size = new System.Drawing.Size(20, 23);
            this.addServiceButton.TabIndex = 15;
            this.addServiceButton.Text = "+";
            this.addServiceButton.UseVisualStyleBackColor = true;
            this.addServiceButton.Click += new System.EventHandler(this.addServiceButton_Click);
            // 
            // removeServiceButton
            // 
            this.removeServiceButton.Location = new System.Drawing.Point(457, 51);
            this.removeServiceButton.Name = "removeServiceButton";
            this.removeServiceButton.Size = new System.Drawing.Size(20, 23);
            this.removeServiceButton.TabIndex = 16;
            this.removeServiceButton.Text = "-";
            this.removeServiceButton.UseVisualStyleBackColor = true;
            this.removeServiceButton.Click += new System.EventHandler(this.removeServiceButton_Click);
            // 
            // addPartButton
            // 
            this.addPartButton.Location = new System.Drawing.Point(457, 185);
            this.addPartButton.Name = "addPartButton";
            this.addPartButton.Size = new System.Drawing.Size(20, 23);
            this.addPartButton.TabIndex = 17;
            this.addPartButton.Text = "+";
            this.addPartButton.UseVisualStyleBackColor = true;
            this.addPartButton.Click += new System.EventHandler(this.addPartButton_Click);
            // 
            // removePartButton
            // 
            this.removePartButton.Location = new System.Drawing.Point(457, 214);
            this.removePartButton.Name = "removePartButton";
            this.removePartButton.Size = new System.Drawing.Size(20, 23);
            this.removePartButton.TabIndex = 18;
            this.removePartButton.Text = "-";
            this.removePartButton.UseVisualStyleBackColor = true;
            this.removePartButton.Click += new System.EventHandler(this.removePartButton_Click);
            // 
            // olvColumn13
            // 
            this.olvColumn13.AspectName = "Model.Name";
            this.olvColumn13.CellPadding = null;
            this.olvColumn13.Text = "Modelo";
            // 
            // olvColumn14
            // 
            this.olvColumn14.AspectName = "Model.Name";
            this.olvColumn14.CellPadding = null;
            this.olvColumn14.Text = "Modelo";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 372);
            this.Controls.Add(this.removePartButton);
            this.Controls.Add(this.addPartButton);
            this.Controls.Add(this.removeServiceButton);
            this.Controls.Add(this.addServiceButton);
            this.Controls.Add(this.objectListSelectedParts);
            this.Controls.Add(this.objectListParts);
            this.Controls.Add(this.objectListSelectedServices);
            this.Controls.Add(this.objectListServices);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonNewService);
            this.Controls.Add(this.buttonNewPart);
            this.Controls.Add(this.buttonNewCar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboCars);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Sistema de Orçamentos Automotivos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objectListServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectListSelectedServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectListParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectListSelectedParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboCars;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNewCar;
        private System.Windows.Forms.Button buttonNewPart;
        private System.Windows.Forms.Button buttonNewService;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTotal;
        private BrightIdeasSoftware.ObjectListView objectListServices;
        private BrightIdeasSoftware.ObjectListView objectListSelectedServices;
        private BrightIdeasSoftware.ObjectListView objectListParts;
        private BrightIdeasSoftware.ObjectListView objectListSelectedParts;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
        private BrightIdeasSoftware.OLVColumn olvColumn7;
        private BrightIdeasSoftware.OLVColumn olvColumn8;
        private BrightIdeasSoftware.OLVColumn olvColumn9;
        private BrightIdeasSoftware.OLVColumn olvColumn10;
        private BrightIdeasSoftware.OLVColumn olvColumn11;
        private BrightIdeasSoftware.OLVColumn olvColumn12;
        private System.Windows.Forms.Button addServiceButton;
        private System.Windows.Forms.Button removeServiceButton;
        private System.Windows.Forms.Button addPartButton;
        private System.Windows.Forms.Button removePartButton;
        private BrightIdeasSoftware.OLVColumn olvColumn13;
        private BrightIdeasSoftware.OLVColumn olvColumn14;
    }
}

