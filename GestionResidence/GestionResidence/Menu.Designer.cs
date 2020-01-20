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
            this.nouveauRésidentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesRésidentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chambresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.labelNbPetitDej = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
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
            this.residentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauRésidentToolStripMenuItem,
            this.listeDesRésidentsToolStripMenuItem});
            this.residentsToolStripMenuItem.Name = "residentsToolStripMenuItem";
            this.residentsToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.residentsToolStripMenuItem.Text = "Résidents";
            // 
            // nouveauRésidentToolStripMenuItem
            // 
            this.nouveauRésidentToolStripMenuItem.Name = "nouveauRésidentToolStripMenuItem";
            this.nouveauRésidentToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.nouveauRésidentToolStripMenuItem.Text = "Nouveau Résident";
            this.nouveauRésidentToolStripMenuItem.Click += new System.EventHandler(this.nouveauRésidentToolStripMenuItem_Click);
            // 
            // listeDesRésidentsToolStripMenuItem
            // 
            this.listeDesRésidentsToolStripMenuItem.Name = "listeDesRésidentsToolStripMenuItem";
            this.listeDesRésidentsToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.listeDesRésidentsToolStripMenuItem.Text = "Liste des Résidents";
            this.listeDesRésidentsToolStripMenuItem.Click += new System.EventHandler(this.listeDesRésidentsToolStripMenuItem_Click);
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
            this.labelNbPetitDej.Location = new System.Drawing.Point(848, 56);
            this.labelNbPetitDej.Name = "labelNbPetitDej";
            this.labelNbPetitDej.Size = new System.Drawing.Size(12, 17);
            this.labelNbPetitDej.TabIndex = 4;
            this.labelNbPetitDej.Text = ".";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.ControlBox = false;
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem residentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauRésidentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chambresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesRésidentsToolStripMenuItem;
        private System.Windows.Forms.Label labelNbPetitDej;
    }
}



