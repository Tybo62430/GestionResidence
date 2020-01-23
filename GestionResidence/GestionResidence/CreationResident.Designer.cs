namespace GestionResidence
{
    partial class CreationResident
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
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.labelCivilite = new System.Windows.Forms.Label();
            this.labelNationalite = new System.Windows.Forms.Label();
            this.labelDateDeNaissance = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelCodePostal = new System.Windows.Forms.Label();
            this.labelTypeDeVoie = new System.Windows.Forms.Label();
            this.labelVoie = new System.Windows.Forms.Label();
            this.labelNumero = new System.Windows.Forms.Label();
            this.buttonCreer = new System.Windows.Forms.Button();
            this.buttonViderChamps = new System.Windows.Forms.Button();
            this.comboBoxCivilite = new System.Windows.Forms.ComboBox();
            this.comboBoxNationalite = new System.Windows.Forms.ComboBox();
            this.labelIban = new System.Windows.Forms.Label();
            this.textBoxIban = new System.Windows.Forms.TextBox();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.labelVille = new System.Windows.Forms.Label();
            this.labelTelephone = new System.Windows.Forms.Label();
            this.textBoxTelephone = new System.Windows.Forms.TextBox();
            this.buttonChargerPhoto = new System.Windows.Forms.Button();
            this.labelSecu = new System.Windows.Forms.Label();
            this.textBoxSecu = new System.Windows.Forms.TextBox();
            this.comboBoxCodePostal = new System.Windows.Forms.ComboBox();
            this.comboBoxTypeDeVoie = new System.Windows.Forms.ComboBox();
            this.comboBoxVoie = new System.Windows.Forms.ComboBox();
            this.comboBoxNumero = new System.Windows.Forms.ComboBox();
            this.comboBoxVille = new System.Windows.Forms.ComboBox();
            this.btnRetour = new System.Windows.Forms.Button();
            this.ErreurNom = new System.Windows.Forms.Label();
            this.ErreurSecu = new System.Windows.Forms.Label();
            this.textBoxDateDeNaissance = new System.Windows.Forms.TextBox();
            this.ErreurDate = new System.Windows.Forms.Label();
            this.ErreurNumero = new System.Windows.Forms.Label();
            this.ErreurMail = new System.Windows.Forms.Label();
            this.ErreurIban = new System.Windows.Forms.Label();
            this.ErreurPrenom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(186, 40);
            this.textBoxNom.MaxLength = 30;
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(225, 22);
            this.textBoxNom.TabIndex = 1;
            this.textBoxNom.Validated += new System.EventHandler(this.textBoxNom_Validated);
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(33, 45);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(45, 17);
            this.labelNom.TabIndex = 1;
            this.labelNom.Text = "Nom :";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(33, 83);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(65, 17);
            this.labelPrenom.TabIndex = 4;
            this.labelPrenom.Text = "Prénom :";
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(186, 78);
            this.textBoxPrenom.MaxLength = 30;
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(225, 22);
            this.textBoxPrenom.TabIndex = 2;
            this.textBoxPrenom.Validated += new System.EventHandler(this.textBoxPrenom_Validated);
            // 
            // labelCivilite
            // 
            this.labelCivilite.AutoSize = true;
            this.labelCivilite.Location = new System.Drawing.Point(33, 125);
            this.labelCivilite.Name = "labelCivilite";
            this.labelCivilite.Size = new System.Drawing.Size(56, 17);
            this.labelCivilite.TabIndex = 6;
            this.labelCivilite.Text = "Civilité :";
            // 
            // labelNationalite
            // 
            this.labelNationalite.AutoSize = true;
            this.labelNationalite.Location = new System.Drawing.Point(33, 168);
            this.labelNationalite.Name = "labelNationalite";
            this.labelNationalite.Size = new System.Drawing.Size(83, 17);
            this.labelNationalite.TabIndex = 8;
            this.labelNationalite.Text = "Nationalité :";
            // 
            // labelDateDeNaissance
            // 
            this.labelDateDeNaissance.AutoSize = true;
            this.labelDateDeNaissance.Location = new System.Drawing.Point(33, 208);
            this.labelDateDeNaissance.Name = "labelDateDeNaissance";
            this.labelDateDeNaissance.Size = new System.Drawing.Size(138, 17);
            this.labelDateDeNaissance.TabIndex = 10;
            this.labelDateDeNaissance.Text = "Date De Naissance :";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(33, 297);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(54, 17);
            this.labelMail.TabIndex = 12;
            this.labelMail.Text = "Email : ";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(186, 292);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(225, 22);
            this.textBoxEmail.TabIndex = 7;
            this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
            // 
            // labelCodePostal
            // 
            this.labelCodePostal.AutoSize = true;
            this.labelCodePostal.Location = new System.Drawing.Point(33, 381);
            this.labelCodePostal.Name = "labelCodePostal";
            this.labelCodePostal.Size = new System.Drawing.Size(92, 17);
            this.labelCodePostal.TabIndex = 14;
            this.labelCodePostal.Text = "Code Postal :";
            // 
            // labelTypeDeVoie
            // 
            this.labelTypeDeVoie.AutoSize = true;
            this.labelTypeDeVoie.Location = new System.Drawing.Point(33, 467);
            this.labelTypeDeVoie.Name = "labelTypeDeVoie";
            this.labelTypeDeVoie.Size = new System.Drawing.Size(100, 17);
            this.labelTypeDeVoie.TabIndex = 16;
            this.labelTypeDeVoie.Text = "Type de Voie :";
            // 
            // labelVoie
            // 
            this.labelVoie.AutoSize = true;
            this.labelVoie.Location = new System.Drawing.Point(367, 467);
            this.labelVoie.Name = "labelVoie";
            this.labelVoie.Size = new System.Drawing.Size(44, 17);
            this.labelVoie.TabIndex = 17;
            this.labelVoie.Text = "Voie :";
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(586, 465);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(66, 17);
            this.labelNumero.TabIndex = 19;
            this.labelNumero.Text = "Numero :";
            // 
            // buttonCreer
            // 
            this.buttonCreer.Enabled = false;
            this.buttonCreer.Location = new System.Drawing.Point(256, 563);
            this.buttonCreer.Name = "buttonCreer";
            this.buttonCreer.Size = new System.Drawing.Size(125, 39);
            this.buttonCreer.TabIndex = 21;
            this.buttonCreer.Text = "Créer ";
            this.buttonCreer.UseVisualStyleBackColor = true;
            this.buttonCreer.Click += new System.EventHandler(this.buttonCreer_Click);
            // 
            // buttonViderChamps
            // 
            this.buttonViderChamps.Location = new System.Drawing.Point(393, 563);
            this.buttonViderChamps.Name = "buttonViderChamps";
            this.buttonViderChamps.Size = new System.Drawing.Size(112, 39);
            this.buttonViderChamps.TabIndex = 22;
            this.buttonViderChamps.Text = "Vider Champs";
            this.buttonViderChamps.UseVisualStyleBackColor = true;
            this.buttonViderChamps.Click += new System.EventHandler(this.buttonViderChamps_Click);
            // 
            // comboBoxCivilite
            // 
            this.comboBoxCivilite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCivilite.FormattingEnabled = true;
            this.comboBoxCivilite.Location = new System.Drawing.Point(186, 122);
            this.comboBoxCivilite.Name = "comboBoxCivilite";
            this.comboBoxCivilite.Size = new System.Drawing.Size(163, 24);
            this.comboBoxCivilite.TabIndex = 3;
            // 
            // comboBoxNationalite
            // 
            this.comboBoxNationalite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNationalite.FormattingEnabled = true;
            this.comboBoxNationalite.Location = new System.Drawing.Point(186, 165);
            this.comboBoxNationalite.Name = "comboBoxNationalite";
            this.comboBoxNationalite.Size = new System.Drawing.Size(163, 24);
            this.comboBoxNationalite.TabIndex = 4;
            // 
            // labelIban
            // 
            this.labelIban.AutoSize = true;
            this.labelIban.Location = new System.Drawing.Point(33, 506);
            this.labelIban.Name = "labelIban";
            this.labelIban.Size = new System.Drawing.Size(43, 17);
            this.labelIban.TabIndex = 44;
            this.labelIban.Text = "Iban :";
            // 
            // textBoxIban
            // 
            this.textBoxIban.Location = new System.Drawing.Point(186, 501);
            this.textBoxIban.MaxLength = 27;
            this.textBoxIban.Name = "textBoxIban";
            this.textBoxIban.Size = new System.Drawing.Size(196, 22);
            this.textBoxIban.TabIndex = 14;
            this.textBoxIban.Validated += new System.EventHandler(this.textBoxIban_Validated);
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(633, 40);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(165, 190);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto.TabIndex = 45;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // labelVille
            // 
            this.labelVille.AutoSize = true;
            this.labelVille.Location = new System.Drawing.Point(33, 423);
            this.labelVille.Name = "labelVille";
            this.labelVille.Size = new System.Drawing.Size(42, 17);
            this.labelVille.TabIndex = 47;
            this.labelVille.Text = "Ville :";
            // 
            // labelTelephone
            // 
            this.labelTelephone.AutoSize = true;
            this.labelTelephone.Location = new System.Drawing.Point(33, 253);
            this.labelTelephone.Name = "labelTelephone";
            this.labelTelephone.Size = new System.Drawing.Size(84, 17);
            this.labelTelephone.TabIndex = 49;
            this.labelTelephone.Text = "Téléphone :";
            // 
            // textBoxTelephone
            // 
            this.textBoxTelephone.Location = new System.Drawing.Point(186, 248);
            this.textBoxTelephone.MaxLength = 12;
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.Size = new System.Drawing.Size(163, 22);
            this.textBoxTelephone.TabIndex = 6;
            this.textBoxTelephone.Text = "+33";
            this.textBoxTelephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTelephone_KeyPress);
            this.textBoxTelephone.Validated += new System.EventHandler(this.textBoxTelephone_Validated);
            // 
            // buttonChargerPhoto
            // 
            this.buttonChargerPhoto.Location = new System.Drawing.Point(633, 248);
            this.buttonChargerPhoto.Name = "buttonChargerPhoto";
            this.buttonChargerPhoto.Size = new System.Drawing.Size(165, 40);
            this.buttonChargerPhoto.TabIndex = 50;
            this.buttonChargerPhoto.Text = "Charger Photo";
            this.buttonChargerPhoto.UseVisualStyleBackColor = true;
            this.buttonChargerPhoto.Click += new System.EventHandler(this.buttonChargerPhoto_Click);
            // 
            // labelSecu
            // 
            this.labelSecu.AutoSize = true;
            this.labelSecu.Location = new System.Drawing.Point(33, 337);
            this.labelSecu.Name = "labelSecu";
            this.labelSecu.Size = new System.Drawing.Size(128, 17);
            this.labelSecu.TabIndex = 51;
            this.labelSecu.Text = "N. Securité Social :";
            // 
            // textBoxSecu
            // 
            this.textBoxSecu.Location = new System.Drawing.Point(189, 334);
            this.textBoxSecu.MaxLength = 13;
            this.textBoxSecu.Name = "textBoxSecu";
            this.textBoxSecu.Size = new System.Drawing.Size(109, 22);
            this.textBoxSecu.TabIndex = 8;
            this.textBoxSecu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSecu_KeyPress);
            this.textBoxSecu.Validated += new System.EventHandler(this.textBoxSecu_Validated);
            // 
            // comboBoxCodePostal
            // 
            this.comboBoxCodePostal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCodePostal.FormattingEnabled = true;
            this.comboBoxCodePostal.Location = new System.Drawing.Point(186, 378);
            this.comboBoxCodePostal.Name = "comboBoxCodePostal";
            this.comboBoxCodePostal.Size = new System.Drawing.Size(86, 24);
            this.comboBoxCodePostal.TabIndex = 9;
            this.comboBoxCodePostal.SelectedIndexChanged += new System.EventHandler(this.comboBoxCodePostal_SelectedIndexChanged);
            // 
            // comboBoxTypeDeVoie
            // 
            this.comboBoxTypeDeVoie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeDeVoie.FormattingEnabled = true;
            this.comboBoxTypeDeVoie.Location = new System.Drawing.Point(186, 464);
            this.comboBoxTypeDeVoie.Name = "comboBoxTypeDeVoie";
            this.comboBoxTypeDeVoie.Size = new System.Drawing.Size(163, 24);
            this.comboBoxTypeDeVoie.TabIndex = 11;
            this.comboBoxTypeDeVoie.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeDeVoie_SelectedIndexChanged);
            // 
            // comboBoxVoie
            // 
            this.comboBoxVoie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVoie.FormattingEnabled = true;
            this.comboBoxVoie.Location = new System.Drawing.Point(417, 464);
            this.comboBoxVoie.Name = "comboBoxVoie";
            this.comboBoxVoie.Size = new System.Drawing.Size(163, 24);
            this.comboBoxVoie.TabIndex = 12;
            this.comboBoxVoie.SelectedIndexChanged += new System.EventHandler(this.comboBoxVoie_SelectedIndexChanged);
            // 
            // comboBoxNumero
            // 
            this.comboBoxNumero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNumero.FormattingEnabled = true;
            this.comboBoxNumero.Location = new System.Drawing.Point(658, 464);
            this.comboBoxNumero.Name = "comboBoxNumero";
            this.comboBoxNumero.Size = new System.Drawing.Size(163, 24);
            this.comboBoxNumero.TabIndex = 13;
            // 
            // comboBoxVille
            // 
            this.comboBoxVille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVille.FormattingEnabled = true;
            this.comboBoxVille.Location = new System.Drawing.Point(186, 420);
            this.comboBoxVille.Name = "comboBoxVille";
            this.comboBoxVille.Size = new System.Drawing.Size(163, 24);
            this.comboBoxVille.TabIndex = 10;
            this.comboBoxVille.SelectedIndexChanged += new System.EventHandler(this.comboBoxVille_SelectedIndexChanged);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(520, 563);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(112, 39);
            this.btnRetour.TabIndex = 58;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // ErreurNom
            // 
            this.ErreurNom.AutoSize = true;
            this.ErreurNom.Location = new System.Drawing.Point(418, 40);
            this.ErreurNom.Name = "ErreurNom";
            this.ErreurNom.Size = new System.Drawing.Size(12, 17);
            this.ErreurNom.TabIndex = 59;
            this.ErreurNom.Text = ".";
            // 
            // ErreurSecu
            // 
            this.ErreurSecu.AutoSize = true;
            this.ErreurSecu.Location = new System.Drawing.Point(304, 339);
            this.ErreurSecu.Name = "ErreurSecu";
            this.ErreurSecu.Size = new System.Drawing.Size(12, 17);
            this.ErreurSecu.TabIndex = 60;
            this.ErreurSecu.Text = ".";
            // 
            // textBoxDateDeNaissance
            // 
            this.textBoxDateDeNaissance.Location = new System.Drawing.Point(186, 205);
            this.textBoxDateDeNaissance.Name = "textBoxDateDeNaissance";
            this.textBoxDateDeNaissance.Size = new System.Drawing.Size(100, 22);
            this.textBoxDateDeNaissance.TabIndex = 5;
            this.textBoxDateDeNaissance.Validated += new System.EventHandler(this.textBoxDateDeNaissance_Validated);
            // 
            // ErreurDate
            // 
            this.ErreurDate.AutoSize = true;
            this.ErreurDate.Location = new System.Drawing.Point(292, 210);
            this.ErreurDate.Name = "ErreurDate";
            this.ErreurDate.Size = new System.Drawing.Size(12, 17);
            this.ErreurDate.TabIndex = 63;
            this.ErreurDate.Text = ".";
            // 
            // ErreurNumero
            // 
            this.ErreurNumero.AutoSize = true;
            this.ErreurNumero.Location = new System.Drawing.Point(355, 251);
            this.ErreurNumero.Name = "ErreurNumero";
            this.ErreurNumero.Size = new System.Drawing.Size(12, 17);
            this.ErreurNumero.TabIndex = 64;
            this.ErreurNumero.Text = ".";
            // 
            // ErreurMail
            // 
            this.ErreurMail.AutoSize = true;
            this.ErreurMail.Location = new System.Drawing.Point(418, 297);
            this.ErreurMail.Name = "ErreurMail";
            this.ErreurMail.Size = new System.Drawing.Size(12, 17);
            this.ErreurMail.TabIndex = 65;
            this.ErreurMail.Text = ".";
            // 
            // ErreurIban
            // 
            this.ErreurIban.AutoSize = true;
            this.ErreurIban.Location = new System.Drawing.Point(388, 506);
            this.ErreurIban.Name = "ErreurIban";
            this.ErreurIban.Size = new System.Drawing.Size(12, 17);
            this.ErreurIban.TabIndex = 66;
            this.ErreurIban.Text = ".";
            // 
            // ErreurPrenom
            // 
            this.ErreurPrenom.AutoSize = true;
            this.ErreurPrenom.Location = new System.Drawing.Point(414, 83);
            this.ErreurPrenom.Name = "ErreurPrenom";
            this.ErreurPrenom.Size = new System.Drawing.Size(12, 17);
            this.ErreurPrenom.TabIndex = 67;
            this.ErreurPrenom.Text = ".";
            // 
            // CreationResident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 730);
            this.ControlBox = false;
            this.Controls.Add(this.ErreurPrenom);
            this.Controls.Add(this.ErreurIban);
            this.Controls.Add(this.ErreurMail);
            this.Controls.Add(this.ErreurNumero);
            this.Controls.Add(this.ErreurDate);
            this.Controls.Add(this.textBoxDateDeNaissance);
            this.Controls.Add(this.ErreurSecu);
            this.Controls.Add(this.ErreurNom);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.comboBoxVille);
            this.Controls.Add(this.comboBoxNumero);
            this.Controls.Add(this.comboBoxVoie);
            this.Controls.Add(this.comboBoxTypeDeVoie);
            this.Controls.Add(this.comboBoxCodePostal);
            this.Controls.Add(this.textBoxSecu);
            this.Controls.Add(this.labelSecu);
            this.Controls.Add(this.buttonChargerPhoto);
            this.Controls.Add(this.labelTelephone);
            this.Controls.Add(this.textBoxTelephone);
            this.Controls.Add(this.labelVille);
            this.Controls.Add(this.pictureBoxPhoto);
            this.Controls.Add(this.labelIban);
            this.Controls.Add(this.textBoxIban);
            this.Controls.Add(this.comboBoxNationalite);
            this.Controls.Add(this.comboBoxCivilite);
            this.Controls.Add(this.buttonViderChamps);
            this.Controls.Add(this.buttonCreer);
            this.Controls.Add(this.labelNumero);
            this.Controls.Add(this.labelVoie);
            this.Controls.Add(this.labelTypeDeVoie);
            this.Controls.Add(this.labelCodePostal);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelDateDeNaissance);
            this.Controls.Add(this.labelNationalite);
            this.Controls.Add(this.labelCivilite);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.textBoxNom);
            this.Name = "CreationResident";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Création Résident";
            this.Load += new System.EventHandler(this.CreationResident_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label labelCivilite;
        private System.Windows.Forms.Label labelNationalite;
        private System.Windows.Forms.Label labelDateDeNaissance;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelCodePostal;
        private System.Windows.Forms.Label labelTypeDeVoie;
        private System.Windows.Forms.Label labelVoie;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.Button buttonCreer;
        private System.Windows.Forms.Button buttonViderChamps;
        private System.Windows.Forms.ComboBox comboBoxCivilite;
        private System.Windows.Forms.ComboBox comboBoxNationalite;
        private System.Windows.Forms.Label labelIban;
        private System.Windows.Forms.TextBox textBoxIban;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Label labelVille;
        private System.Windows.Forms.Label labelTelephone;
        private System.Windows.Forms.TextBox textBoxTelephone;
        private System.Windows.Forms.Button buttonChargerPhoto;
        private System.Windows.Forms.Label labelSecu;
        private System.Windows.Forms.TextBox textBoxSecu;
        private System.Windows.Forms.ComboBox comboBoxCodePostal;
        private System.Windows.Forms.ComboBox comboBoxTypeDeVoie;
        private System.Windows.Forms.ComboBox comboBoxVoie;
        private System.Windows.Forms.ComboBox comboBoxNumero;
        private System.Windows.Forms.ComboBox comboBoxVille;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label ErreurNom;
        private System.Windows.Forms.Label ErreurSecu;
        private System.Windows.Forms.TextBox textBoxDateDeNaissance;
        private System.Windows.Forms.Label ErreurDate;
        private System.Windows.Forms.Label ErreurNumero;
        private System.Windows.Forms.Label ErreurMail;
        private System.Windows.Forms.Label ErreurIban;
        private System.Windows.Forms.Label ErreurPrenom;
    }
}

