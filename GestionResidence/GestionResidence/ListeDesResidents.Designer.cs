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
            this.vueClientsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.vueClientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vueClientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonNouveauClient = new System.Windows.Forms.Button();
            this.buttonModifierResident = new System.Windows.Forms.Button();
            this.buttonSupprimerResident = new System.Windows.Forms.Button();
            this.gestionResidenceDataSetListeClients = new GestionResidence.GestionResidenceDataSetListeClients();
            this.vueClientsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.vueClientsTableAdapter = new GestionResidence.GestionResidenceDataSetListeClientsTableAdapters.VueClientsTableAdapter();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueClientsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueClientsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueClientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionResidenceDataSetListeClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueClientsBindingSource3)).BeginInit();
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
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21});
            this.dataGridViewClients.DataSource = this.vueClientsBindingSource3;
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
            // gestionResidenceDataSetListeClients
            // 
            this.gestionResidenceDataSetListeClients.DataSetName = "GestionResidenceDataSetListeClients";
            this.gestionResidenceDataSetListeClients.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vueClientsBindingSource3
            // 
            this.vueClientsBindingSource3.DataMember = "VueClients";
            this.vueClientsBindingSource3.DataSource = this.gestionResidenceDataSetListeClients;
            // 
            // vueClientsTableAdapter
            // 
            this.vueClientsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "ResidentIdentifiant";
            this.dataGridViewTextBoxColumn15.HeaderText = "ResidentIdentifiant";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "ResidentNom";
            this.dataGridViewTextBoxColumn16.HeaderText = "ResidentNom";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "ResidentPrenom";
            this.dataGridViewTextBoxColumn17.HeaderText = "ResidentPrenom";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "ChambreIdentifiant";
            this.dataGridViewTextBoxColumn18.HeaderText = "ChambreIdentifiant";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "FormuleDescriptif";
            this.dataGridViewTextBoxColumn19.HeaderText = "FormuleDescriptif";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "PeriodeLocationDateDebut";
            this.dataGridViewTextBoxColumn20.HeaderText = "PeriodeLocationDateDebut";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "PeriodeLocationDateFin";
            this.dataGridViewTextBoxColumn21.HeaderText = "PeriodeLocationDateFin";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.vueClientsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueClientsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueClientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionResidenceDataSetListeClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueClientsBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion        
        private System.Windows.Forms.BindingSource vueClientsBindingSource; 
        private System.Windows.Forms.Button buttonNouveauClient;
        private System.Windows.Forms.Button buttonModifierResident;
        private System.Windows.Forms.Button buttonSupprimerResident;
        private System.Windows.Forms.DataGridView dataGridViewClients;        
        private System.Windows.Forms.BindingSource vueClientsBindingSource1;      
        private System.Windows.Forms.BindingSource vueClientsBindingSource2;    
                private GestionResidenceDataSetListeClients gestionResidenceDataSetListeClients;
        private System.Windows.Forms.BindingSource vueClientsBindingSource3;
        private GestionResidenceDataSetListeClientsTableAdapters.VueClientsTableAdapter vueClientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
    }
}