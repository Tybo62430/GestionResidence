namespace GestionResidence
{
    partial class Menu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.residentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chambresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.labelNbPetitDej = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gestionResidenceDataSetDateArrivee = new GestionResidence.GestionResidenceDataSetDateArrivee();
            this.vueChambreArrivéeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vueChambreArrivéeTableAdapter = new GestionResidence.GestionResidenceDataSetDateArriveeTableAdapters.VueChambreArrivéeTableAdapter();
            this.chambreIdentifiantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodeLocationDateDebutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentNomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentPrenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.gestionResidenceDataSetDateDepart = new GestionResidence.GestionResidenceDataSetDateDepart();
            this.vueChambreDepartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vueChambreDepartTableAdapter = new GestionResidence.GestionResidenceDataSetDateDepartTableAdapters.VueChambreDepartTableAdapter();
            this.periodeLocationDateFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentIdentifiantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentNomDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionResidenceDataSetDateArrivee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueChambreArrivéeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionResidenceDataSetDateDepart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueChambreDepartBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.residentsToolStripMenuItem,
            this.chambresToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1902, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // residentsToolStripMenuItem
            // 
            this.residentsToolStripMenuItem.Name = "residentsToolStripMenuItem";
            this.residentsToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.residentsToolStripMenuItem.Text = "Résidents";
            this.residentsToolStripMenuItem.Click += new System.EventHandler(this.residentsToolStripMenuItem_Click);
            // 
            // chambresToolStripMenuItem
            // 
            this.chambresToolStripMenuItem.Name = "chambresToolStripMenuItem";
            this.chambresToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.chambresToolStripMenuItem.Text = "Chambres";
            this.chambresToolStripMenuItem.Click += new System.EventHandler(this.chambresToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 1008);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1902, 25);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(35, 20);
            this.toolStripStatusLabel.Text = "État";
            // 
            // labelNbPetitDej
            // 
            this.labelNbPetitDej.AutoSize = true;
            this.labelNbPetitDej.Location = new System.Drawing.Point(1208, 90);
            this.labelNbPetitDej.Name = "labelNbPetitDej";
            this.labelNbPetitDej.Size = new System.Drawing.Size(12, 17);
            this.labelNbPetitDej.TabIndex = 4;
            this.labelNbPetitDej.Text = ".";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chambreIdentifiantDataGridViewTextBoxColumn,
            this.periodeLocationDateDebutDataGridViewTextBoxColumn,
            this.residentNomDataGridViewTextBoxColumn,
            this.residentPrenomDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vueChambreArrivéeBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(12, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(529, 579);
            this.dataGridView1.TabIndex = 6;
            // 
            // gestionResidenceDataSetDateArrivee
            // 
            this.gestionResidenceDataSetDateArrivee.DataSetName = "GestionResidenceDataSetDateArrivee";
            this.gestionResidenceDataSetDateArrivee.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vueChambreArrivéeBindingSource
            // 
            this.vueChambreArrivéeBindingSource.DataMember = "VueChambreArrivée";
            this.vueChambreArrivéeBindingSource.DataSource = this.gestionResidenceDataSetDateArrivee;
            // 
            // vueChambreArrivéeTableAdapter
            // 
            this.vueChambreArrivéeTableAdapter.ClearBeforeFill = true;
            // 
            // chambreIdentifiantDataGridViewTextBoxColumn
            // 
            this.chambreIdentifiantDataGridViewTextBoxColumn.DataPropertyName = "ChambreIdentifiant";
            this.chambreIdentifiantDataGridViewTextBoxColumn.HeaderText = "ChambreIdentifiant";
            this.chambreIdentifiantDataGridViewTextBoxColumn.Name = "chambreIdentifiantDataGridViewTextBoxColumn";
            // 
            // periodeLocationDateDebutDataGridViewTextBoxColumn
            // 
            this.periodeLocationDateDebutDataGridViewTextBoxColumn.DataPropertyName = "PeriodeLocationDateDebut";
            this.periodeLocationDateDebutDataGridViewTextBoxColumn.HeaderText = "PeriodeLocationDateDebut";
            this.periodeLocationDateDebutDataGridViewTextBoxColumn.Name = "periodeLocationDateDebutDataGridViewTextBoxColumn";
            // 
            // residentNomDataGridViewTextBoxColumn
            // 
            this.residentNomDataGridViewTextBoxColumn.DataPropertyName = "ResidentNom";
            this.residentNomDataGridViewTextBoxColumn.HeaderText = "ResidentNom";
            this.residentNomDataGridViewTextBoxColumn.Name = "residentNomDataGridViewTextBoxColumn";
            // 
            // residentPrenomDataGridViewTextBoxColumn
            // 
            this.residentPrenomDataGridViewTextBoxColumn.DataPropertyName = "ResidentPrenom";
            this.residentPrenomDataGridViewTextBoxColumn.HeaderText = "ResidentPrenom";
            this.residentPrenomDataGridViewTextBoxColumn.Name = "residentPrenomDataGridViewTextBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.periodeLocationDateFinDataGridViewTextBoxColumn,
            this.residentIdentifiantDataGridViewTextBoxColumn,
            this.residentNomDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.vueChambreDepartBindingSource;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.Location = new System.Drawing.Point(651, 90);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(462, 579);
            this.dataGridView2.TabIndex = 7;
            // 
            // gestionResidenceDataSetDateDepart
            // 
            this.gestionResidenceDataSetDateDepart.DataSetName = "GestionResidenceDataSetDateDepart";
            this.gestionResidenceDataSetDateDepart.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vueChambreDepartBindingSource
            // 
            this.vueChambreDepartBindingSource.DataMember = "VueChambreDepart";
            this.vueChambreDepartBindingSource.DataSource = this.gestionResidenceDataSetDateDepart;
            // 
            // vueChambreDepartTableAdapter
            // 
            this.vueChambreDepartTableAdapter.ClearBeforeFill = true;
            // 
            // periodeLocationDateFinDataGridViewTextBoxColumn
            // 
            this.periodeLocationDateFinDataGridViewTextBoxColumn.DataPropertyName = "PeriodeLocationDateFin";
            this.periodeLocationDateFinDataGridViewTextBoxColumn.HeaderText = "PeriodeLocationDateFin";
            this.periodeLocationDateFinDataGridViewTextBoxColumn.Name = "periodeLocationDateFinDataGridViewTextBoxColumn";
            // 
            // residentIdentifiantDataGridViewTextBoxColumn
            // 
            this.residentIdentifiantDataGridViewTextBoxColumn.DataPropertyName = "ResidentIdentifiant";
            this.residentIdentifiantDataGridViewTextBoxColumn.HeaderText = "ResidentIdentifiant";
            this.residentIdentifiantDataGridViewTextBoxColumn.Name = "residentIdentifiantDataGridViewTextBoxColumn";
            // 
            // residentNomDataGridViewTextBoxColumn1
            // 
            this.residentNomDataGridViewTextBoxColumn1.DataPropertyName = "ResidentNom";
            this.residentNomDataGridViewTextBoxColumn1.HeaderText = "ResidentNom";
            this.residentNomDataGridViewTextBoxColumn1.Name = "residentNomDataGridViewTextBoxColumn1";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelNbPetitDej);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionResidenceDataSetDateArrivee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueChambreArrivéeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionResidenceDataSetDateDepart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueChambreDepartBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem residentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chambresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.Label labelNbPetitDej;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GestionResidenceDataSetDateArrivee gestionResidenceDataSetDateArrivee;
        private System.Windows.Forms.BindingSource vueChambreArrivéeBindingSource;
        private GestionResidenceDataSetDateArriveeTableAdapters.VueChambreArrivéeTableAdapter vueChambreArrivéeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn chambreIdentifiantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodeLocationDateDebutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentNomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentPrenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private GestionResidenceDataSetDateDepart gestionResidenceDataSetDateDepart;
        private System.Windows.Forms.BindingSource vueChambreDepartBindingSource;
        private GestionResidenceDataSetDateDepartTableAdapters.VueChambreDepartTableAdapter vueChambreDepartTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodeLocationDateFinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentIdentifiantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentNomDataGridViewTextBoxColumn1;
    }
}



