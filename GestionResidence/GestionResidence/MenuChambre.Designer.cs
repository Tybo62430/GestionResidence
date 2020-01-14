namespace GestionResidence
{
    partial class MenuChambre
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
            this.buttonModifier = new System.Windows.Forms.Button();
            this.dataGridViewChambres = new System.Windows.Forms.DataGridView();
            this.chambresDataSet = new GestionResidence.ChambresDataSet();
            this.chambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chambreTableAdapter = new GestionResidence.ChambresDataSetTableAdapters.ChambreTableAdapter();
            this.chambreIdentifiantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chambreTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chambreEtageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chambrePrixMensuelHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChambres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambresDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(12, 541);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(249, 93);
            this.buttonModifier.TabIndex = 1;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // dataGridViewChambres
            // 
            this.dataGridViewChambres.AutoGenerateColumns = false;
            this.dataGridViewChambres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChambres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chambreIdentifiantDataGridViewTextBoxColumn,
            this.chambreTypeDataGridViewTextBoxColumn,
            this.chambreEtageDataGridViewTextBoxColumn,
            this.chambrePrixMensuelHTDataGridViewTextBoxColumn});
            this.dataGridViewChambres.DataSource = this.chambreBindingSource;
            this.dataGridViewChambres.Location = new System.Drawing.Point(12, 128);
            this.dataGridViewChambres.Name = "dataGridViewChambres";
            this.dataGridViewChambres.RowTemplate.Height = 24;
            this.dataGridViewChambres.Size = new System.Drawing.Size(1378, 323);
            this.dataGridViewChambres.TabIndex = 2;
            // 
            // chambresDataSet
            // 
            this.chambresDataSet.DataSetName = "ChambresDataSet";
            this.chambresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chambreBindingSource
            // 
            this.chambreBindingSource.DataMember = "Chambre";
            this.chambreBindingSource.DataSource = this.chambresDataSet;
            // 
            // chambreTableAdapter
            // 
            this.chambreTableAdapter.ClearBeforeFill = true;
            // 
            // chambreIdentifiantDataGridViewTextBoxColumn
            // 
            this.chambreIdentifiantDataGridViewTextBoxColumn.DataPropertyName = "ChambreIdentifiant";
            this.chambreIdentifiantDataGridViewTextBoxColumn.HeaderText = "ChambreIdentifiant";
            this.chambreIdentifiantDataGridViewTextBoxColumn.Name = "chambreIdentifiantDataGridViewTextBoxColumn";
            // 
            // chambreTypeDataGridViewTextBoxColumn
            // 
            this.chambreTypeDataGridViewTextBoxColumn.DataPropertyName = "ChambreType";
            this.chambreTypeDataGridViewTextBoxColumn.HeaderText = "ChambreType";
            this.chambreTypeDataGridViewTextBoxColumn.Name = "chambreTypeDataGridViewTextBoxColumn";
            // 
            // chambreEtageDataGridViewTextBoxColumn
            // 
            this.chambreEtageDataGridViewTextBoxColumn.DataPropertyName = "ChambreEtage";
            this.chambreEtageDataGridViewTextBoxColumn.HeaderText = "ChambreEtage";
            this.chambreEtageDataGridViewTextBoxColumn.Name = "chambreEtageDataGridViewTextBoxColumn";
            // 
            // chambrePrixMensuelHTDataGridViewTextBoxColumn
            // 
            this.chambrePrixMensuelHTDataGridViewTextBoxColumn.DataPropertyName = "ChambrePrixMensuelHT";
            this.chambrePrixMensuelHTDataGridViewTextBoxColumn.HeaderText = "ChambrePrixMensuelHT";
            this.chambrePrixMensuelHTDataGridViewTextBoxColumn.Name = "chambrePrixMensuelHTDataGridViewTextBoxColumn";
            // 
            // MenuChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 646);
            this.Controls.Add(this.dataGridViewChambres);
            this.Controls.Add(this.buttonModifier);
            this.Name = "MenuChambre";
            this.Text = "MenuChambre";
            this.Load += new System.EventHandler(this.MenuChambre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChambres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambresDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.DataGridView dataGridViewChambres;
        private ChambresDataSet chambresDataSet;
        private System.Windows.Forms.BindingSource chambreBindingSource;
        private ChambresDataSetTableAdapters.ChambreTableAdapter chambreTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn chambreIdentifiantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chambreTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chambreEtageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chambrePrixMensuelHTDataGridViewTextBoxColumn;
    }
}