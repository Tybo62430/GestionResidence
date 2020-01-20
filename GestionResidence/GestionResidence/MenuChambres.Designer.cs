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
            this.chambresDataSet = new GestionResidence.ChambresDataSet();
            this.vueChambresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vueChambresTableAdapter = new GestionResidence.ChambresDataSetTableAdapters.VueChambresTableAdapter();
            this.chambreIdentifiantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chambreTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chambreEtageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentIdentifiantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentNomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentPrenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodeLocationDateDebutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodeLocationDateFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonModifier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChambres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambresDataSet)).BeginInit();
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
            this.chambreIdentifiantDataGridViewTextBoxColumn,
            this.chambreTypeDataGridViewTextBoxColumn,
            this.chambreEtageDataGridViewTextBoxColumn,
            this.residentIdentifiantDataGridViewTextBoxColumn,
            this.residentNomDataGridViewTextBoxColumn,
            this.residentPrenomDataGridViewTextBoxColumn,
            this.periodeLocationDateDebutDataGridViewTextBoxColumn,
            this.periodeLocationDateFinDataGridViewTextBoxColumn});
            this.dataGridViewChambres.DataSource = this.vueChambresBindingSource;
            this.dataGridViewChambres.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewChambres.MultiSelect = false;
            this.dataGridViewChambres.Name = "dataGridViewChambres";
            this.dataGridViewChambres.ReadOnly = true;
            this.dataGridViewChambres.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewChambres.RowTemplate.Height = 24;
            this.dataGridViewChambres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewChambres.Size = new System.Drawing.Size(1358, 281);
            this.dataGridViewChambres.TabIndex = 0;
            // 
            // chambresDataSet
            // 
            this.chambresDataSet.DataSetName = "ChambresDataSet";
            this.chambresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vueChambresBindingSource
            // 
            this.vueChambresBindingSource.DataMember = "VueChambres";
            this.vueChambresBindingSource.DataSource = this.chambresDataSet;
            // 
            // vueChambresTableAdapter
            // 
            this.vueChambresTableAdapter.ClearBeforeFill = true;
            // 
            // chambreIdentifiantDataGridViewTextBoxColumn
            // 
            this.chambreIdentifiantDataGridViewTextBoxColumn.DataPropertyName = "ChambreIdentifiant";
            this.chambreIdentifiantDataGridViewTextBoxColumn.HeaderText = "ChambreIdentifiant";
            this.chambreIdentifiantDataGridViewTextBoxColumn.Name = "chambreIdentifiantDataGridViewTextBoxColumn";
            this.chambreIdentifiantDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chambreTypeDataGridViewTextBoxColumn
            // 
            this.chambreTypeDataGridViewTextBoxColumn.DataPropertyName = "ChambreType";
            this.chambreTypeDataGridViewTextBoxColumn.HeaderText = "ChambreType";
            this.chambreTypeDataGridViewTextBoxColumn.Name = "chambreTypeDataGridViewTextBoxColumn";
            this.chambreTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chambreEtageDataGridViewTextBoxColumn
            // 
            this.chambreEtageDataGridViewTextBoxColumn.DataPropertyName = "ChambreEtage";
            this.chambreEtageDataGridViewTextBoxColumn.HeaderText = "ChambreEtage";
            this.chambreEtageDataGridViewTextBoxColumn.Name = "chambreEtageDataGridViewTextBoxColumn";
            this.chambreEtageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // residentIdentifiantDataGridViewTextBoxColumn
            // 
            this.residentIdentifiantDataGridViewTextBoxColumn.DataPropertyName = "ResidentIdentifiant";
            this.residentIdentifiantDataGridViewTextBoxColumn.HeaderText = "ResidentIdentifiant";
            this.residentIdentifiantDataGridViewTextBoxColumn.Name = "residentIdentifiantDataGridViewTextBoxColumn";
            this.residentIdentifiantDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // residentNomDataGridViewTextBoxColumn
            // 
            this.residentNomDataGridViewTextBoxColumn.DataPropertyName = "ResidentNom";
            this.residentNomDataGridViewTextBoxColumn.HeaderText = "ResidentNom";
            this.residentNomDataGridViewTextBoxColumn.Name = "residentNomDataGridViewTextBoxColumn";
            this.residentNomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // residentPrenomDataGridViewTextBoxColumn
            // 
            this.residentPrenomDataGridViewTextBoxColumn.DataPropertyName = "ResidentPrenom";
            this.residentPrenomDataGridViewTextBoxColumn.HeaderText = "ResidentPrenom";
            this.residentPrenomDataGridViewTextBoxColumn.Name = "residentPrenomDataGridViewTextBoxColumn";
            this.residentPrenomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // periodeLocationDateDebutDataGridViewTextBoxColumn
            // 
            this.periodeLocationDateDebutDataGridViewTextBoxColumn.DataPropertyName = "PeriodeLocationDateDebut";
            this.periodeLocationDateDebutDataGridViewTextBoxColumn.HeaderText = "Début Séjour";
            this.periodeLocationDateDebutDataGridViewTextBoxColumn.Name = "periodeLocationDateDebutDataGridViewTextBoxColumn";
            this.periodeLocationDateDebutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // periodeLocationDateFinDataGridViewTextBoxColumn
            // 
            this.periodeLocationDateFinDataGridViewTextBoxColumn.DataPropertyName = "PeriodeLocationDateFin";
            this.periodeLocationDateFinDataGridViewTextBoxColumn.HeaderText = "Fin Séjour";
            this.periodeLocationDateFinDataGridViewTextBoxColumn.Name = "periodeLocationDateFinDataGridViewTextBoxColumn";
            this.periodeLocationDateFinDataGridViewTextBoxColumn.ReadOnly = true;
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
            // MenuChambres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 444);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.dataGridViewChambres);
            this.Name = "MenuChambres";
            this.Text = "MenuChambres";
            this.Load += new System.EventHandler(this.MenuChambres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChambres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambresDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueChambresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewChambres;
        private ChambresDataSet chambresDataSet;
        private System.Windows.Forms.BindingSource vueChambresBindingSource;
        private ChambresDataSetTableAdapters.VueChambresTableAdapter vueChambresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn chambreIdentifiantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chambreTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chambreEtageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentIdentifiantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentNomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentPrenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodeLocationDateDebutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodeLocationDateFinDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonModifier;
    }
}