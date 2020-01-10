namespace GestionResidence
{
    partial class Connexion
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
            this.labelIdentifiant = new System.Windows.Forms.Label();
            this.textBoxIdentifiant = new System.Windows.Forms.TextBox();
            this.textBoxMotdepasse = new System.Windows.Forms.TextBox();
            this.labelMotDePasse = new System.Windows.Forms.Label();
            this.buttonValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelIdentifiant
            // 
            this.labelIdentifiant.AutoSize = true;
            this.labelIdentifiant.Location = new System.Drawing.Point(288, 220);
            this.labelIdentifiant.Name = "labelIdentifiant";
            this.labelIdentifiant.Size = new System.Drawing.Size(77, 17);
            this.labelIdentifiant.TabIndex = 0;
            this.labelIdentifiant.Text = "Identifiant :";
            // 
            // textBoxIdentifiant
            // 
            this.textBoxIdentifiant.Location = new System.Drawing.Point(404, 217);
            this.textBoxIdentifiant.Name = "textBoxIdentifiant";
            this.textBoxIdentifiant.Size = new System.Drawing.Size(139, 22);
            this.textBoxIdentifiant.TabIndex = 1;
            this.textBoxIdentifiant.Leave += new System.EventHandler(this.textBoxIdentifiant_Leave);
            // 
            // textBoxMotdepasse
            // 
            this.textBoxMotdepasse.Location = new System.Drawing.Point(404, 287);
            this.textBoxMotdepasse.Name = "textBoxMotdepasse";
            this.textBoxMotdepasse.PasswordChar = '*';
            this.textBoxMotdepasse.Size = new System.Drawing.Size(139, 22);
            this.textBoxMotdepasse.TabIndex = 2;
            this.textBoxMotdepasse.Leave += new System.EventHandler(this.textBoxMotdepasse_Leave);
            // 
            // labelMotDePasse
            // 
            this.labelMotDePasse.AutoSize = true;
            this.labelMotDePasse.Location = new System.Drawing.Point(288, 290);
            this.labelMotDePasse.Name = "labelMotDePasse";
            this.labelMotDePasse.Size = new System.Drawing.Size(101, 17);
            this.labelMotDePasse.TabIndex = 0;
            this.labelMotDePasse.Text = "Mot de passe :";
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(364, 348);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(75, 23);
            this.buttonValider.TabIndex = 0;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.textBoxMotdepasse);
            this.Controls.Add(this.labelMotDePasse);
            this.Controls.Add(this.textBoxIdentifiant);
            this.Controls.Add(this.labelIdentifiant);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Connexion";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIdentifiant;
        private System.Windows.Forms.TextBox textBoxIdentifiant;
        private System.Windows.Forms.TextBox textBoxMotdepasse;
        private System.Windows.Forms.Label labelMotDePasse;
        private System.Windows.Forms.Button buttonValider;
    }
}

