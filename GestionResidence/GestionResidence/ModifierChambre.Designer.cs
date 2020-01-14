namespace GestionResidence
{
    partial class ModifierChambre
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
            this.labelChambre = new System.Windows.Forms.Label();
            this.labelIdentifiant = new System.Windows.Forms.Label();
            this.labelDebutSejour = new System.Windows.Forms.Label();
            this.labelFinSejour = new System.Windows.Forms.Label();
            this.textBoxChambre = new System.Windows.Forms.TextBox();
            this.textBoxIdentifiant = new System.Windows.Forms.TextBox();
            this.textBoxDebutSejour = new System.Windows.Forms.TextBox();
            this.textBoxFinSejour = new System.Windows.Forms.TextBox();
            this.comboBoxIdentifiant = new System.Windows.Forms.ComboBox();
            this.buttonAssigner = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelChambre
            // 
            this.labelChambre.AutoSize = true;
            this.labelChambre.Location = new System.Drawing.Point(337, 125);
            this.labelChambre.Name = "labelChambre";
            this.labelChambre.Size = new System.Drawing.Size(73, 17);
            this.labelChambre.TabIndex = 0;
            this.labelChambre.Text = "Chambre :";
            // 
            // labelIdentifiant
            // 
            this.labelIdentifiant.AutoSize = true;
            this.labelIdentifiant.Location = new System.Drawing.Point(337, 169);
            this.labelIdentifiant.Name = "labelIdentifiant";
            this.labelIdentifiant.Size = new System.Drawing.Size(77, 17);
            this.labelIdentifiant.TabIndex = 1;
            this.labelIdentifiant.Text = "Identifiant :";
            // 
            // labelDebutSejour
            // 
            this.labelDebutSejour.AutoSize = true;
            this.labelDebutSejour.Location = new System.Drawing.Point(337, 213);
            this.labelDebutSejour.Name = "labelDebutSejour";
            this.labelDebutSejour.Size = new System.Drawing.Size(117, 17);
            this.labelDebutSejour.TabIndex = 2;
            this.labelDebutSejour.Text = "Début du séjour :";
            // 
            // labelFinSejour
            // 
            this.labelFinSejour.AutoSize = true;
            this.labelFinSejour.Location = new System.Drawing.Point(337, 257);
            this.labelFinSejour.Name = "labelFinSejour";
            this.labelFinSejour.Size = new System.Drawing.Size(98, 17);
            this.labelFinSejour.TabIndex = 3;
            this.labelFinSejour.Text = "Fin du séjour :";
            // 
            // textBoxChambre
            // 
            this.textBoxChambre.Location = new System.Drawing.Point(463, 122);
            this.textBoxChambre.Name = "textBoxChambre";
            this.textBoxChambre.ReadOnly = true;
            this.textBoxChambre.Size = new System.Drawing.Size(177, 22);
            this.textBoxChambre.TabIndex = 4;
            // 
            // textBoxIdentifiant
            // 
            this.textBoxIdentifiant.Location = new System.Drawing.Point(463, 166);
            this.textBoxIdentifiant.Name = "textBoxIdentifiant";
            this.textBoxIdentifiant.Size = new System.Drawing.Size(177, 22);
            this.textBoxIdentifiant.TabIndex = 5;
            // 
            // textBoxDebutSejour
            // 
            this.textBoxDebutSejour.Location = new System.Drawing.Point(463, 210);
            this.textBoxDebutSejour.Name = "textBoxDebutSejour";
            this.textBoxDebutSejour.Size = new System.Drawing.Size(177, 22);
            this.textBoxDebutSejour.TabIndex = 6;
            // 
            // textBoxFinSejour
            // 
            this.textBoxFinSejour.Location = new System.Drawing.Point(463, 254);
            this.textBoxFinSejour.Name = "textBoxFinSejour";
            this.textBoxFinSejour.Size = new System.Drawing.Size(177, 22);
            this.textBoxFinSejour.TabIndex = 7;
            // 
            // comboBoxIdentifiant
            // 
            this.comboBoxIdentifiant.FormattingEnabled = true;
            this.comboBoxIdentifiant.Location = new System.Drawing.Point(681, 166);
            this.comboBoxIdentifiant.Name = "comboBoxIdentifiant";
            this.comboBoxIdentifiant.Size = new System.Drawing.Size(198, 24);
            this.comboBoxIdentifiant.TabIndex = 8;
            // 
            // buttonAssigner
            // 
            this.buttonAssigner.Location = new System.Drawing.Point(340, 314);
            this.buttonAssigner.Name = "buttonAssigner";
            this.buttonAssigner.Size = new System.Drawing.Size(170, 49);
            this.buttonAssigner.TabIndex = 9;
            this.buttonAssigner.Text = "Assigner";
            this.buttonAssigner.UseVisualStyleBackColor = true;
            this.buttonAssigner.Click += new System.EventHandler(this.buttonAssigner_Click);
            // 
            // ModifierChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 427);
            this.Controls.Add(this.buttonAssigner);
            this.Controls.Add(this.comboBoxIdentifiant);
            this.Controls.Add(this.textBoxFinSejour);
            this.Controls.Add(this.textBoxDebutSejour);
            this.Controls.Add(this.textBoxIdentifiant);
            this.Controls.Add(this.textBoxChambre);
            this.Controls.Add(this.labelFinSejour);
            this.Controls.Add(this.labelDebutSejour);
            this.Controls.Add(this.labelIdentifiant);
            this.Controls.Add(this.labelChambre);
            this.Name = "ModifierChambre";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ModifierChambre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChambre;
        private System.Windows.Forms.Label labelIdentifiant;
        private System.Windows.Forms.Label labelDebutSejour;
        private System.Windows.Forms.Label labelFinSejour;
        private System.Windows.Forms.TextBox textBoxChambre;
        private System.Windows.Forms.TextBox textBoxIdentifiant;
        private System.Windows.Forms.TextBox textBoxDebutSejour;
        private System.Windows.Forms.TextBox textBoxFinSejour;
        private System.Windows.Forms.ComboBox comboBoxIdentifiant;
        private System.Windows.Forms.Button buttonAssigner;
    }
}