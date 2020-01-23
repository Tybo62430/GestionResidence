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
            this.vueClientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonNouveauClient = new System.Windows.Forms.Button();
            this.buttonModifierResident = new System.Windows.Forms.Button();
            this.buttonSupprimerResident = new System.Windows.Forms.Button();
            this.gestionResidenceDataListeResident = new GestionResidence.GestionResidenceDataListeResident();
            this.vueClientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vueClientsTableAdapter = new GestionResidence.GestionResidenceDataListeResidentTableAdapters.VueClientsTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueClientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionResidenceDataListeResident)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueClientsBindingSource1)).BeginInit();
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridViewClients.DataSource = this.vueClientsBindingSource1;
            this.dataGridViewClients.Location = new System.Drawing.Point(12, 23);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.ReadOnly = true;
            this.dataGridViewClients.RowTemplate.Height = 24;
            this.dataGridViewClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClients.Size = new System.Drawing.Size(1238, 678);
            this.dataGridViewClients.TabIndex = 0;
            // 
            // vueClientsBindingSource
            // 
            this.vueClientsBindingSource.DataMember = "VueClients";
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
            // gestionResidenceDataListeResident
            // 
            this.gestionResidenceDataListeResident.DataSetName = "GestionResidenceDataListeResident";
            this.gestionResidenceDataListeResident.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vueClientsBindingSource1
            // 
            this.vueClientsBindingSource1.DataMember = "VueClients";
            this.vueClientsBindingSource1.DataSource = this.gestionResidenceDataListeResident;
            // 
            // vueClientsTableAdapter
            // 
            this.vueClientsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ResidentIdentifiant";
            this.dataGridViewTextBoxColumn1.HeaderText = "ResidentIdentifiant";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ResidentNom";
            this.dataGridViewTextBoxColumn2.HeaderText = "ResidentNom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ResidentPrenom";
            this.dataGridViewTextBoxColumn3.HeaderText = "ResidentPrenom";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ChambreIdentifiant";
            this.dataGridViewTextBoxColumn4.HeaderText = "ChambreIdentifiant";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FormuleDescriptif";
            this.dataGridViewTextBoxColumn5.HeaderText = "FormuleDescriptif";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PeriodeLocationDateDebut";
            this.dataGridViewTextBoxColumn6.HeaderText = "PeriodeLocationDateDebut";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PeriodeLocationDateFin";
            this.dataGridViewTextBoxColumn7.HeaderText = "PeriodeLocationDateFin";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.gestionResidenceDataListeResident)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueClientsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion        
        private System.Windows.Forms.BindingSource vueClientsBindingSource;        
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
        private GestionResidenceDataListeResident gestionResidenceDataListeResident;
        private System.Windows.Forms.BindingSource vueClientsBindingSource1;
        private GestionResidenceDataListeResidentTableAdapters.VueClientsTableAdapter vueClientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}