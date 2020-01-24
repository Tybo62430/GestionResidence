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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gestionResidenceDataSetListeChambres = new GestionResidence.GestionResidenceDataSetListeChambres();
            this.gestionResidenceDataSetListeChambresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionResidenceDataSetArrivees = new GestionResidence.GestionResidenceDataSetArrivees();
            this.vueChambreArrivéeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vueChambreArrivéeTableAdapter = new GestionResidence.GestionResidenceDataSetArriveesTableAdapters.VueChambreArrivéeTableAdapter();
            this.chambreIdentifiantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodeLocationDateDebutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentIdentifiantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gestionResidenceDataSetDepart = new GestionResidence.GestionResidenceDataSetDepart();
            this.vueChambreDepartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vueChambreDepartTableAdapter = new GestionResidence.GestionResidenceDataSetDepartTableAdapters.VueChambreDepartTableAdapter();
            this.chambreIdentifiantDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodeLocationDateFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentIdentifiantDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionResidenceDataSetListeChambres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionResidenceDataSetListeChambresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionResidenceDataSetArrivees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueChambreArrivéeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionResidenceDataSetDepart)).BeginInit();
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
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1664, 28);
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
            this.statusStrip.Location = new System.Drawing.Point(0, 1030);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 17, 0);
            this.statusStrip.Size = new System.Drawing.Size(1664, 25);
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
            this.labelNbPetitDej.Location = new System.Drawing.Point(1086, 68);
            this.labelNbPetitDej.Name = "labelNbPetitDej";
            this.labelNbPetitDej.Size = new System.Drawing.Size(12, 19);
            this.labelNbPetitDej.TabIndex = 4;
            this.labelNbPetitDej.Text = ".";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chambreIdentifiantDataGridViewTextBoxColumn,
            this.periodeLocationDateDebutDataGridViewTextBoxColumn,
            this.residentIdentifiantDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.vueChambreArrivéeBindingSource;
            this.dataGridView2.GridColor = System.Drawing.Color.White;
            this.dataGridView2.Location = new System.Drawing.Point(34, 68);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(436, 463);
            this.dataGridView2.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chambreIdentifiantDataGridViewTextBoxColumn1,
            this.periodeLocationDateFinDataGridViewTextBoxColumn,
            this.residentIdentifiantDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.vueChambreDepartBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(584, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(437, 463);
            this.dataGridView1.TabIndex = 8;
            // 
            // gestionResidenceDataSetListeChambres
            // 
            this.gestionResidenceDataSetListeChambres.DataSetName = "GestionResidenceDataSetListeChambres";
            this.gestionResidenceDataSetListeChambres.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gestionResidenceDataSetListeChambresBindingSource
            // 
            this.gestionResidenceDataSetListeChambresBindingSource.DataSource = this.gestionResidenceDataSetListeChambres;
            this.gestionResidenceDataSetListeChambresBindingSource.Position = 0;
            // 
            // gestionResidenceDataSetArrivees
            // 
            this.gestionResidenceDataSetArrivees.DataSetName = "GestionResidenceDataSetArrivees";
            this.gestionResidenceDataSetArrivees.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vueChambreArrivéeBindingSource
            // 
            this.vueChambreArrivéeBindingSource.DataMember = "VueChambreArrivée";
            this.vueChambreArrivéeBindingSource.DataSource = this.gestionResidenceDataSetArrivees;
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
            this.chambreIdentifiantDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // periodeLocationDateDebutDataGridViewTextBoxColumn
            // 
            this.periodeLocationDateDebutDataGridViewTextBoxColumn.DataPropertyName = "PeriodeLocationDateDebut";
            this.periodeLocationDateDebutDataGridViewTextBoxColumn.HeaderText = "PeriodeLocationDateDebut";
            this.periodeLocationDateDebutDataGridViewTextBoxColumn.Name = "periodeLocationDateDebutDataGridViewTextBoxColumn";
            this.periodeLocationDateDebutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // residentIdentifiantDataGridViewTextBoxColumn
            // 
            this.residentIdentifiantDataGridViewTextBoxColumn.DataPropertyName = "ResidentIdentifiant";
            this.residentIdentifiantDataGridViewTextBoxColumn.HeaderText = "ResidentIdentifiant";
            this.residentIdentifiantDataGridViewTextBoxColumn.Name = "residentIdentifiantDataGridViewTextBoxColumn";
            this.residentIdentifiantDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gestionResidenceDataSetDepart
            // 
            this.gestionResidenceDataSetDepart.DataSetName = "GestionResidenceDataSetDepart";
            this.gestionResidenceDataSetDepart.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vueChambreDepartBindingSource
            // 
            this.vueChambreDepartBindingSource.DataMember = "VueChambreDepart";
            this.vueChambreDepartBindingSource.DataSource = this.gestionResidenceDataSetDepart;
            // 
            // vueChambreDepartTableAdapter
            // 
            this.vueChambreDepartTableAdapter.ClearBeforeFill = true;
            // 
            // chambreIdentifiantDataGridViewTextBoxColumn1
            // 
            this.chambreIdentifiantDataGridViewTextBoxColumn1.DataPropertyName = "ChambreIdentifiant";
            this.chambreIdentifiantDataGridViewTextBoxColumn1.HeaderText = "ChambreIdentifiant";
            this.chambreIdentifiantDataGridViewTextBoxColumn1.Name = "chambreIdentifiantDataGridViewTextBoxColumn1";
            // 
            // periodeLocationDateFinDataGridViewTextBoxColumn
            // 
            this.periodeLocationDateFinDataGridViewTextBoxColumn.DataPropertyName = "PeriodeLocationDateFin";
            this.periodeLocationDateFinDataGridViewTextBoxColumn.HeaderText = "PeriodeLocationDateFin";
            this.periodeLocationDateFinDataGridViewTextBoxColumn.Name = "periodeLocationDateFinDataGridViewTextBoxColumn";
            // 
            // residentIdentifiantDataGridViewTextBoxColumn1
            // 
            this.residentIdentifiantDataGridViewTextBoxColumn1.DataPropertyName = "ResidentIdentifiant";
            this.residentIdentifiantDataGridViewTextBoxColumn1.HeaderText = "ResidentIdentifiant";
            this.residentIdentifiantDataGridViewTextBoxColumn1.Name = "residentIdentifiantDataGridViewTextBoxColumn1";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1664, 1055);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.labelNbPetitDej);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionResidenceDataSetListeChambres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionResidenceDataSetListeChambresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionResidenceDataSetArrivees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueChambreArrivéeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionResidenceDataSetDepart)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource gestionResidenceDataSetListeChambresBindingSource;
        private GestionResidenceDataSetListeChambres gestionResidenceDataSetListeChambres;
        private GestionResidenceDataSetArrivees gestionResidenceDataSetArrivees;
        private System.Windows.Forms.BindingSource vueChambreArrivéeBindingSource;
        private GestionResidenceDataSetArriveesTableAdapters.VueChambreArrivéeTableAdapter vueChambreArrivéeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn chambreIdentifiantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodeLocationDateDebutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentIdentifiantDataGridViewTextBoxColumn;
        private GestionResidenceDataSetDepart gestionResidenceDataSetDepart;
        private System.Windows.Forms.BindingSource vueChambreDepartBindingSource;
        private GestionResidenceDataSetDepartTableAdapters.VueChambreDepartTableAdapter vueChambreDepartTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn chambreIdentifiantDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodeLocationDateFinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentIdentifiantDataGridViewTextBoxColumn1;
    }
}



