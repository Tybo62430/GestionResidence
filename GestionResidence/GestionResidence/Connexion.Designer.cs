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
            this.labelIdentifiant.Location = new System.Drawing.Point(252, 234);
            this.labelIdentifiant.Name = "labelIdentifiant";
            this.labelIdentifiant.Size = new System.Drawing.Size(78, 19);
            this.labelIdentifiant.TabIndex = 0;
            this.labelIdentifiant.Text = "Identifiant :";
            // 
            // textBoxIdentifiant
            // 
            this.textBoxIdentifiant.BackColor = System.Drawing.Color.White;
            this.textBoxIdentifiant.Location = new System.Drawing.Point(354, 230);
            this.textBoxIdentifiant.Name = "textBoxIdentifiant";
            this.textBoxIdentifiant.Size = new System.Drawing.Size(122, 25);
            this.textBoxIdentifiant.TabIndex = 1;
            this.textBoxIdentifiant.Leave += new System.EventHandler(this.textBoxIdentifiant_Leave);
            // 
            // textBoxMotdepasse
            // 
            this.textBoxMotdepasse.BackColor = System.Drawing.Color.White;
            this.textBoxMotdepasse.Location = new System.Drawing.Point(354, 305);
            this.textBoxMotdepasse.Name = "textBoxMotdepasse";
            this.textBoxMotdepasse.PasswordChar = '*';
            this.textBoxMotdepasse.Size = new System.Drawing.Size(122, 25);
            this.textBoxMotdepasse.TabIndex = 2;
            this.textBoxMotdepasse.Leave += new System.EventHandler(this.textBoxMotdepasse_Leave);
            // 
            // labelMotDePasse
            // 
            this.labelMotDePasse.AutoSize = true;
            this.labelMotDePasse.Location = new System.Drawing.Point(252, 308);
            this.labelMotDePasse.Name = "labelMotDePasse";
            this.labelMotDePasse.Size = new System.Drawing.Size(99, 19);
            this.labelMotDePasse.TabIndex = 0;
            this.labelMotDePasse.Text = "Mot de passe :";
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(318, 370);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(66, 25);
            this.buttonValider.TabIndex = 0;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 587);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.textBoxMotdepasse);
            this.Controls.Add(this.labelMotDePasse);
            this.Controls.Add(this.textBoxIdentifiant);
            this.Controls.Add(this.labelIdentifiant);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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

