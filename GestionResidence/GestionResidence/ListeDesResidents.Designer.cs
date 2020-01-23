namespace GestionResidence
{
    partial class ListeDesResidents
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
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.residentIdentifiantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentNomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentPrenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chambreIdentifiantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formuleDescriptifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodeLocationDateDebutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodeLocationDateFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vueClientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionResidenceDataSet = new GestionResidence.GestionResidenceDataSet();
            this.vueClientsTableAdapter = new GestionResidence.GestionResidenceDataSetTableAdapters.VueClientsTableAdapter();
            this.buttonNouveauClient = new System.Windows.Forms.Button();
            this.buttonModifierResident = new System.Windows.Forms.Button();
            this.buttonSupprimerResident = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueClientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionResidenceDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.AllowUserToAddRows = false;
            this.dataGridViewClients.AllowUserToDeleteRows = false;
            this.dataGridViewClients.AutoGenerateColumns = false;
            this.dataGridViewClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.residentIdentifiantDataGridViewTextBoxColumn,
            this.residentNomDataGridViewTextBoxColumn,
            this.residentPrenomDataGridViewTextBoxColumn,
            this.chambreIdentifiantDataGridViewTextBoxColumn,
            this.formuleDescriptifDataGridViewTextBoxColumn,
            this.periodeLocationDateDebutDataGridViewTextBoxColumn,
            this.periodeLocationDateFinDataGridViewTextBoxColumn});
            this.dataGridViewClients.DataSource = this.vueClientsBindingSource;
            this.dataGridViewClients.Location = new System.Drawing.Point(12, 23);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.ReadOnly = true;
            this.dataGridViewClients.RowTemplate.Height = 24;
            this.dataGridViewClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClients.Size = new System.Drawing.Size(1238, 678);
            this.dataGridViewClients.TabIndex = 0;
            // 
            // residentIdentifiantDataGridViewTextBoxColumn
            // 
            this.residentIdentifiantDataGridViewTextBoxColumn.DataPropertyName = "ResidentIdentifiant";
            this.residentIdentifiantDataGridViewTextBoxColumn.HeaderText = "Identifiant";
            this.residentIdentifiantDataGridViewTextBoxColumn.Name = "residentIdentifiantDataGridViewTextBoxColumn";
            this.residentIdentifiantDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // residentNomDataGridViewTextBoxColumn
            // 
            this.residentNomDataGridViewTextBoxColumn.DataPropertyName = "ResidentNom";
            this.residentNomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.residentNomDataGridViewTextBoxColumn.Name = "residentNomDataGridViewTextBoxColumn";
            this.residentNomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // residentPrenomDataGridViewTextBoxColumn
            // 
            this.residentPrenomDataGridViewTextBoxColumn.DataPropertyName = "ResidentPrenom";
            this.residentPrenomDataGridViewTextBoxColumn.HeaderText = "Prenom";
            this.residentPrenomDataGridViewTextBoxColumn.Name = "residentPrenomDataGridViewTextBoxColumn";
            this.residentPrenomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chambreIdentifiantDataGridViewTextBoxColumn
            // 
            this.chambreIdentifiantDataGridViewTextBoxColumn.DataPropertyName = "ChambreIdentifiant";
            this.chambreIdentifiantDataGridViewTextBoxColumn.HeaderText = "Chambre";
            this.chambreIdentifiantDataGridViewTextBoxColumn.Name = "chambreIdentifiantDataGridViewTextBoxColumn";
            this.chambreIdentifiantDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // formuleDescriptifDataGridViewTextBoxColumn
            // 
            this.formuleDescriptifDataGridViewTextBoxColumn.DataPropertyName = "FormuleDescriptif";
            this.formuleDescriptifDataGridViewTextBoxColumn.HeaderText = "Formule";
            this.formuleDescriptifDataGridViewTextBoxColumn.Name = "formuleDescriptifDataGridViewTextBoxColumn";
            this.formuleDescriptifDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // periodeLocationDateDebutDataGridViewTextBoxColumn
            // 
            this.periodeLocationDateDebutDataGridViewTextBoxColumn.DataPropertyName = "PeriodeLocationDateDebut";
            this.periodeLocationDateDebutDataGridViewTextBoxColumn.HeaderText = "Arrivé";
            this.periodeLocationDateDebutDataGridViewTextBoxColumn.Name = "periodeLocationDateDebutDataGridViewTextBoxColumn";
            this.periodeLocationDateDebutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // periodeLocationDateFinDataGridViewTextBoxColumn
            // 
            this.periodeLocationDateFinDataGridViewTextBoxColumn.DataPropertyName = "PeriodeLocationDateFin";
            this.periodeLocationDateFinDataGridViewTextBoxColumn.HeaderText = "depart";
            this.periodeLocationDateFinDataGridViewTextBoxColumn.Name = "periodeLocationDateFinDataGridViewTextBoxColumn";
            this.periodeLocationDateFinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vueClientsBindingSource
            // 
            this.vueClientsBindingSource.DataMember = "VueClients";
            this.vueClientsBindingSource.DataSource = this.gestionResidenceDataSet;
            // 
            // gestionResidenceDataSet
            // 
            this.gestionResidenceDataSet.DataSetName = "GestionResidenceDataSet";
            this.gestionResidenceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vueClientsTableAdapter
            // 
            this.vueClientsTableAdapter.ClearBeforeFill = true;
            // 
            // buttonNouveauClient
            // 
            this.buttonNouveauClient.Location = new System.Drawing.Point(12, 707);
            this.buttonNouveauClient.Name = "buttonNouveauClient";
            this.buttonNouveauClient.Size = new System.Drawing.Size(159, 69);
            this.buttonNouveauClient.TabIndex = 1;
            this.buttonNouveauClient.Text = "Nouveau Resident";
            this.buttonNouveauClient.UseVisualStyleBackColor = true;
            this.buttonNouveauClient.Click += new System.EventHandler(this.buttonNouveauClient_Click);
            // 
            // buttonModifierResident
            // 
            this.buttonModifierResident.Location = new System.Drawing.Point(197, 707);
            this.buttonModifierResident.Name = "buttonModifierResident";
            this.buttonModifierResident.Size = new System.Drawing.Size(159, 69);
            this.buttonModifierResident.TabIndex = 2;
            this.buttonModifierResident.Text = "Modifier Resident";
            this.buttonModifierResident.UseVisualStyleBackColor = true;
            this.buttonModifierResident.Click += new System.EventHandler(this.buttonModifierResident_Click);
            // 
            // buttonSupprimerResident
            // 
            this.buttonSupprimerResident.Location = new System.Drawing.Point(387, 707);
            this.buttonSupprimerResident.Name = "buttonSupprimerResident";
            this.buttonSupprimerResident.Size = new System.Drawing.Size(159, 69);
            this.buttonSupprimerResident.TabIndex = 3;
            this.buttonSupprimerResident.Text = "Supprimer Resident";
            this.buttonSupprimerResident.UseVisualStyleBackColor = true;
            this.buttonSupprimerResident.Click += new System.EventHandler(this.buttonSupprimerResident_Click);
            // 
            // ListeDesResidents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 1033);
            this.Controls.Add(this.buttonSupprimerResident);
            this.Controls.Add(this.buttonModifierResident);
            this.Controls.Add(this.buttonNouveauClient);
            this.Controls.Add(this.dataGridViewClients);
            this.Name = "ListeDesResidents";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListeDesResidents";
            this.Load += new System.EventHandler(this.ListeDesResidents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueClientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionResidenceDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GestionResidenceDataSet gestionResidenceDataSet;
        private System.Windows.Forms.BindingSource vueClientsBindingSource;
        private GestionResidenceDataSetTableAdapters.VueClientsTableAdapter vueClientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentIdentifiantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentNomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentPrenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chambreIdentifiantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formuleDescriptifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodeLocationDateDebutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodeLocationDateFinDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonNouveauClient;
        private System.Windows.Forms.Button buttonModifierResident;
        private System.Windows.Forms.Button buttonSupprimerResident;
        private System.Windows.Forms.DataGridView dataGridViewClients;
    }
}