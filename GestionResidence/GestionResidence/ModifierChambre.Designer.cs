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
            this.components = new System.ComponentModel.Container();
            this.labelChambre = new System.Windows.Forms.Label();
            this.labelIdentifiant = new System.Windows.Forms.Label();
            this.labelDebutSejour = new System.Windows.Forms.Label();
            this.labelFinSejour = new System.Windows.Forms.Label();
            this.textBoxChambre = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxDebutSejour = new System.Windows.Forms.TextBox();
            this.textBoxFinSejour = new System.Windows.Forms.TextBox();
            this.comboBoxIdentifiant = new System.Windows.Forms.ComboBox();
            this.buttonAssigner = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.viewResidentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);            
            this.viewResidentBindingSource = new System.Windows.Forms.BindingSource(this.components);            
            this.checkBoxPetitDejeune = new System.Windows.Forms.CheckBox();
            this.comboBoxFormule = new System.Windows.Forms.ComboBox();
            this.labelSupplement = new System.Windows.Forms.Label();
            this.labelFormule = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.viewResidentBindingSource1)).BeginInit();            
            ((System.ComponentModel.ISupportInitialize)(this.viewResidentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelChambre
            // 
            this.labelChambre.AutoSize = true;
            this.labelChambre.Location = new System.Drawing.Point(338, 52);
            this.labelChambre.Name = "labelChambre";
            this.labelChambre.Size = new System.Drawing.Size(73, 17);
            this.labelChambre.TabIndex = 0;
            this.labelChambre.Text = "Chambre :";
            // 
            // labelIdentifiant
            // 
            this.labelIdentifiant.AutoSize = true;
            this.labelIdentifiant.Location = new System.Drawing.Point(338, 96);
            this.labelIdentifiant.Name = "labelIdentifiant";
            this.labelIdentifiant.Size = new System.Drawing.Size(45, 17);
            this.labelIdentifiant.TabIndex = 1;
            this.labelIdentifiant.Text = "Nom :";
            // 
            // labelDebutSejour
            // 
            this.labelDebutSejour.AutoSize = true;
            this.labelDebutSejour.Location = new System.Drawing.Point(338, 194);
            this.labelDebutSejour.Name = "labelDebutSejour";
            this.labelDebutSejour.Size = new System.Drawing.Size(117, 17);
            this.labelDebutSejour.TabIndex = 2;
            this.labelDebutSejour.Text = "Début du séjour :";
            // 
            // labelFinSejour
            // 
            this.labelFinSejour.AutoSize = true;
            this.labelFinSejour.Location = new System.Drawing.Point(338, 238);
            this.labelFinSejour.Name = "labelFinSejour";
            this.labelFinSejour.Size = new System.Drawing.Size(98, 17);
            this.labelFinSejour.TabIndex = 3;
            this.labelFinSejour.Text = "Fin du séjour :";
            // 
            // textBoxChambre
            // 
            this.textBoxChambre.Location = new System.Drawing.Point(464, 49);
            this.textBoxChambre.Name = "textBoxChambre";
            this.textBoxChambre.ReadOnly = true;
            this.textBoxChambre.Size = new System.Drawing.Size(177, 22);
            this.textBoxChambre.TabIndex = 4;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(464, 93);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(177, 22);
            this.textBoxNom.TabIndex = 5;
            this.textBoxNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdentifiant_KeyPress);
            // 
            // textBoxDebutSejour
            // 
            this.textBoxDebutSejour.Location = new System.Drawing.Point(464, 191);
            this.textBoxDebutSejour.Name = "textBoxDebutSejour";
            this.textBoxDebutSejour.Size = new System.Drawing.Size(177, 22);
            this.textBoxDebutSejour.TabIndex = 6;
            this.textBoxDebutSejour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDebutSejour_KeyPress);
            // 
            // textBoxFinSejour
            // 
            this.textBoxFinSejour.Location = new System.Drawing.Point(464, 235);
            this.textBoxFinSejour.Name = "textBoxFinSejour";
            this.textBoxFinSejour.Size = new System.Drawing.Size(177, 22);
            this.textBoxFinSejour.TabIndex = 7;
            this.textBoxFinSejour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFinSejour_KeyPress);
            // 
            // comboBoxIdentifiant
            // 
            this.comboBoxIdentifiant.FormattingEnabled = true;
            this.comboBoxIdentifiant.Location = new System.Drawing.Point(464, 140);
            this.comboBoxIdentifiant.Name = "comboBoxIdentifiant";
            this.comboBoxIdentifiant.Size = new System.Drawing.Size(269, 24);
            this.comboBoxIdentifiant.TabIndex = 8;
            // 
            // buttonAssigner
            // 
            this.buttonAssigner.Location = new System.Drawing.Point(341, 378);
            this.buttonAssigner.Name = "buttonAssigner";
            this.buttonAssigner.Size = new System.Drawing.Size(170, 49);
            this.buttonAssigner.TabIndex = 9;
            this.buttonAssigner.Text = "Assigner";
            this.buttonAssigner.UseVisualStyleBackColor = true;
            this.buttonAssigner.Click += new System.EventHandler(this.buttonAssigner_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Identifiant :";
            // 
            // checkBoxPetitDejeune
            // 
            this.checkBoxPetitDejeune.AutoSize = true;
            this.checkBoxPetitDejeune.Location = new System.Drawing.Point(464, 281);
            this.checkBoxPetitDejeune.Name = "checkBoxPetitDejeune";
            this.checkBoxPetitDejeune.Size = new System.Drawing.Size(18, 17);
            this.checkBoxPetitDejeune.TabIndex = 11;
            this.checkBoxPetitDejeune.UseVisualStyleBackColor = true;
            this.checkBoxPetitDejeune.CheckedChanged += new System.EventHandler(this.checkBoxPetitDejeune_CheckedChanged);
            // 
            // comboBoxFormule
            // 
            this.comboBoxFormule.FormattingEnabled = true;
            this.comboBoxFormule.Location = new System.Drawing.Point(464, 321);
            this.comboBoxFormule.Name = "comboBoxFormule";
            this.comboBoxFormule.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFormule.TabIndex = 12;
            // 
            // labelSupplement
            // 
            this.labelSupplement.AutoSize = true;
            this.labelSupplement.Location = new System.Drawing.Point(338, 282);
            this.labelSupplement.Name = "labelSupplement";
            this.labelSupplement.Size = new System.Drawing.Size(106, 17);
            this.labelSupplement.TabIndex = 13;
            this.labelSupplement.Text = "Petit Déjeuner :";
            // 
            // labelFormule
            // 
            this.labelFormule.AutoSize = true;
            this.labelFormule.Location = new System.Drawing.Point(338, 324);
            this.labelFormule.Name = "labelFormule";
            this.labelFormule.Size = new System.Drawing.Size(67, 17);
            this.labelFormule.TabIndex = 14;
            this.labelFormule.Text = "Formule :";
            // 
            // ModifierChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 476);
            this.Controls.Add(this.labelFormule);
            this.Controls.Add(this.labelSupplement);
            this.Controls.Add(this.comboBoxFormule);
            this.Controls.Add(this.checkBoxPetitDejeune);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAssigner);
            this.Controls.Add(this.comboBoxIdentifiant);
            this.Controls.Add(this.textBoxFinSejour);
            this.Controls.Add(this.textBoxDebutSejour);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.textBoxChambre);
            this.Controls.Add(this.labelFinSejour);
            this.Controls.Add(this.labelDebutSejour);
            this.Controls.Add(this.labelIdentifiant);
            this.Controls.Add(this.labelChambre);
            this.Name = "ModifierChambre";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ModifierChambre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewResidentBindingSource1)).EndInit();            
            ((System.ComponentModel.ISupportInitialize)(this.viewResidentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChambre;
        private System.Windows.Forms.Label labelIdentifiant;
        private System.Windows.Forms.Label labelDebutSejour;
        private System.Windows.Forms.Label labelFinSejour;
        private System.Windows.Forms.TextBox textBoxChambre;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxDebutSejour;
        private System.Windows.Forms.TextBox textBoxFinSejour;
        private System.Windows.Forms.ComboBox comboBoxIdentifiant;
        private System.Windows.Forms.Button buttonAssigner;
        private System.Windows.Forms.Label label1;        
        private System.Windows.Forms.BindingSource viewResidentBindingSource; 
        private System.Windows.Forms.BindingSource viewResidentBindingSource1;        
        private System.Windows.Forms.CheckBox checkBoxPetitDejeune;
        private System.Windows.Forms.ComboBox comboBoxFormule;
        private System.Windows.Forms.Label labelSupplement;
        private System.Windows.Forms.Label labelFormule;
    }
}