namespace GestionResidence
{
    partial class MenuChambres
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewChambres = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vueChambres2BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gestionResidenceDataSetListeChambres = new GestionResidence.GestionResidenceDataSetListeChambres();
            this.vueChambres2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vueChambres2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonModifier = new System.Windows.Forms.Button();
            this.vueChambresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vueChambres2TableAdapter = new GestionResidence.GestionResidenceDataSetListeChambresTableAdapters.VueChambres2TableAdapter();
            this.buttonRafraichir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChambres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueChambres2BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionResidenceDataSetListeChambres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueChambres2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueChambres2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueChambresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewChambres
            // 
            this.dataGridViewChambres.AllowUserToAddRows = false;
            this.dataGridViewChambres.AllowUserToDeleteRows = false;
            this.dataGridViewChambres.AutoGenerateColumns = false;
            this.dataGridViewChambres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChambres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChambres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.dataGridViewChambres.DataSource = this.vueChambres2BindingSource2;
            this.dataGridViewChambres.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewChambres.MultiSelect = false;
            this.dataGridViewChambres.Name = "dataGridViewChambres";
            this.dataGridViewChambres.ReadOnly = true;
            this.dataGridViewChambres.RowTemplate.Height = 24;
            this.dataGridViewChambres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewChambres.Size = new System.Drawing.Size(1358, 281);
            this.dataGridViewChambres.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ChambreIdentifiant";
            this.dataGridViewTextBoxColumn9.HeaderText = "ChambreIdentifiant";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ChambreType";
            this.dataGridViewTextBoxColumn10.HeaderText = "ChambreType";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ChambreEtage";
            this.dataGridViewTextBoxColumn11.HeaderText = "ChambreEtage";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ResidentIdentifiant";
            this.dataGridViewTextBoxColumn12.HeaderText = "ResidentIdentifiant";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "ResidentNom";
            this.dataGridViewTextBoxColumn13.HeaderText = "ResidentNom";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "ResidentPrenom";
            this.dataGridViewTextBoxColumn14.HeaderText = "ResidentPrenom";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "PeriodeLocationDateDebut";
            this.dataGridViewTextBoxColumn15.HeaderText = "PeriodeLocationDateDebut";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "PeriodeLocationDateFin";
            this.dataGridViewTextBoxColumn16.HeaderText = "PeriodeLocationDateFin";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // vueChambres2BindingSource2
            // 
            this.vueChambres2BindingSource2.DataMember = "VueChambres2";
            this.vueChambres2BindingSource2.DataSource = this.gestionResidenceDataSetListeChambres;
            // 
            // gestionResidenceDataSetListeChambres
            // 
            this.gestionResidenceDataSetListeChambres.DataSetName = "GestionResidenceDataSetListeChambres";
            this.gestionResidenceDataSetListeChambres.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vueChambres2BindingSource
            // 
            this.vueChambres2BindingSource.DataMember = "VueChambres2";
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(12, 356);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(229, 76);
            this.buttonModifier.TabIndex = 1;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // vueChambresBindingSource
            // 
            this.vueChambresBindingSource.DataMember = "VueChambres";
            // 
            // vueChambres2TableAdapter
            // 
            this.vueChambres2TableAdapter.ClearBeforeFill = true;
            // 
            // buttonRafraichir
            // 
            this.buttonRafraichir.Location = new System.Drawing.Point(349, 356);
            this.buttonRafraichir.Name = "buttonRafraichir";
            this.buttonRafraichir.Size = new System.Drawing.Size(212, 76);
            this.buttonRafraichir.TabIndex = 2;
            this.buttonRafraichir.Text = "Rafraichir";
            this.buttonRafraichir.UseVisualStyleBackColor = true;
            this.buttonRafraichir.Click += new System.EventHandler(this.buttonRafraichir_Click);
            // 
            // MenuChambres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 452);
            this.Controls.Add(this.buttonRafraichir);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.dataGridViewChambres);
            this.Name = "MenuChambres";
            this.Text = "MenuChambres";
            this.Load += new System.EventHandler(this.MenuChambres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChambres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueChambres2BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionResidenceDataSetListeChambres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueChambres2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueChambres2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueChambresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewChambres;        
        private System.Windows.Forms.BindingSource vueChambresBindingSource; 
        private System.Windows.Forms.Button buttonModifier;      
        private System.Windows.Forms.BindingSource vueChambres2BindingSource;        
        private System.Windows.Forms.BindingSource vueChambres2BindingSource1;
        private GestionResidenceDataSetListeChambres gestionResidenceDataSetListeChambres;
        private System.Windows.Forms.BindingSource vueChambres2BindingSource2;
        private GestionResidenceDataSetListeChambresTableAdapters.VueChambres2TableAdapter vueChambres2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.Button buttonRafraichir;
    }
}