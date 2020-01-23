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
            this.vueChambres2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonModifier = new System.Windows.Forms.Button();
            this.vueChambresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionResidenceDataSetListeChambre = new GestionResidence.GestionResidenceDataSetListeChambre();
            this.vueChambres2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vueChambres2TableAdapter = new GestionResidence.GestionResidenceDataSetListeChambreTableAdapters.VueChambres2TableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChambres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueChambres2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueChambresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionResidenceDataSetListeChambre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueChambres2BindingSource1)).BeginInit();
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dataGridViewChambres.DataSource = this.vueChambres2BindingSource1;
            this.dataGridViewChambres.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewChambres.MultiSelect = false;
            this.dataGridViewChambres.Name = "dataGridViewChambres";
            this.dataGridViewChambres.ReadOnly = true;
            this.dataGridViewChambres.RowTemplate.Height = 24;
            this.dataGridViewChambres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewChambres.Size = new System.Drawing.Size(1358, 281);
            this.dataGridViewChambres.TabIndex = 0;
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
            // gestionResidenceDataSetListeChambre
            // 
            this.gestionResidenceDataSetListeChambre.DataSetName = "GestionResidenceDataSetListeChambre";
            this.gestionResidenceDataSetListeChambre.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vueChambres2BindingSource1
            // 
            this.vueChambres2BindingSource1.DataMember = "VueChambres2";
            this.vueChambres2BindingSource1.DataSource = this.gestionResidenceDataSetListeChambre;
            // 
            // vueChambres2TableAdapter
            // 
            this.vueChambres2TableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ChambreIdentifiant";
            this.dataGridViewTextBoxColumn1.HeaderText = "ChambreIdentifiant";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ChambreType";
            this.dataGridViewTextBoxColumn2.HeaderText = "ChambreType";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ChambreEtage";
            this.dataGridViewTextBoxColumn3.HeaderText = "ChambreEtage";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ResidentIdentifiant";
            this.dataGridViewTextBoxColumn4.HeaderText = "ResidentIdentifiant";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ResidentNom";
            this.dataGridViewTextBoxColumn5.HeaderText = "ResidentNom";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ResidentPrenom";
            this.dataGridViewTextBoxColumn6.HeaderText = "ResidentPrenom";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PeriodeLocationDateDebut";
            this.dataGridViewTextBoxColumn7.HeaderText = "PeriodeLocationDateDebut";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PeriodeLocationDateFin";
            this.dataGridViewTextBoxColumn8.HeaderText = "PeriodeLocationDateFin";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // MenuChambres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 452);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.dataGridViewChambres);
            this.Name = "MenuChambres";
            this.Text = "MenuChambres";
            this.Load += new System.EventHandler(this.MenuChambres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChambres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueChambres2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueChambresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionResidenceDataSetListeChambre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueChambres2BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewChambres;        
        private System.Windows.Forms.BindingSource vueChambresBindingSource;       
        private System.Windows.Forms.DataGridViewTextBoxColumn chambreIdentifiantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chambreTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chambreEtageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentIdentifiantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentNomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentPrenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodeLocationDateDebutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodeLocationDateFinDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonModifier;       
        private System.Windows.Forms.BindingSource vueChambres2BindingSource;
        private GestionResidenceDataSetListeChambre gestionResidenceDataSetListeChambre;
        private System.Windows.Forms.BindingSource vueChambres2BindingSource1;
        private GestionResidenceDataSetListeChambreTableAdapters.VueChambres2TableAdapter vueChambres2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}