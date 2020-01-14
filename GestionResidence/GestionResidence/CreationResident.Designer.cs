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
            this.textBoxCodePostal = new System.Windows.Forms.TextBox();
            this.labelTypeDeVoie = new System.Windows.Forms.Label();
            this.textBoxTypeDeVoie = new System.Windows.Forms.TextBox();
            this.labelVoie = new System.Windows.Forms.Label();
            this.textBoxVoie = new System.Windows.Forms.TextBox();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.labelNumero = new System.Windows.Forms.Label();
            this.labelFormule = new System.Windows.Forms.Label();
            this.checkBoxPetitDejeune = new System.Windows.Forms.CheckBox();
            this.comboBoxFormule = new System.Windows.Forms.ComboBox();
            this.labelDetails = new System.Windows.Forms.Label();
            this.labelLoyer = new System.Windows.Forms.Label();
            this.textBoxLoyer = new System.Windows.Forms.TextBox();
            this.labelPetitDejeuneRedevance = new System.Windows.Forms.Label();
            this.labelFormuleRedevance = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBoxPetitDejeuneRedevance = new System.Windows.Forms.TextBox();
            this.textBoxFormuleRedevance = new System.Windows.Forms.TextBox();
            this.buttonCreer = new System.Windows.Forms.Button();
            this.buttonViderChamps = new System.Windows.Forms.Button();
            this.dateTimePickerDateDeNaissance = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCivilite = new System.Windows.Forms.ComboBox();
            this.comboBoxNationalite = new System.Windows.Forms.ComboBox();
            this.labelIban = new System.Windows.Forms.Label();
            this.textBoxIban = new System.Windows.Forms.TextBox();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.labelVille = new System.Windows.Forms.Label();
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.labelTelephone = new System.Windows.Forms.Label();
            this.textBoxTelephone = new System.Windows.Forms.TextBox();
            this.buttonChargerPhoto = new System.Windows.Forms.Button();
            
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(186, 40);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(163, 22);
            this.textBoxNom.TabIndex = 1;
            this.textBoxNom.Leave += new System.EventHandler(this.textBoxNom_Leave);
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
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(163, 22);
            this.textBoxPrenom.TabIndex = 2;
            this.textBoxPrenom.Leave += new System.EventHandler(this.textBoxPrenom_Leave);
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
            this.textBoxEmail.Size = new System.Drawing.Size(163, 22);
            this.textBoxEmail.TabIndex = 7;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
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
            // textBoxCodePostal
            // 
            this.textBoxCodePostal.Location = new System.Drawing.Point(186, 376);
            this.textBoxCodePostal.Name = "textBoxCodePostal";
            this.textBoxCodePostal.Size = new System.Drawing.Size(163, 22);
            this.textBoxCodePostal.TabIndex = 9;
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
            // textBoxTypeDeVoie
            // 
            this.textBoxTypeDeVoie.Location = new System.Drawing.Point(186, 462);
            this.textBoxTypeDeVoie.Name = "textBoxTypeDeVoie";
            this.textBoxTypeDeVoie.Size = new System.Drawing.Size(127, 22);
            this.textBoxTypeDeVoie.TabIndex = 11;
            // 
            // labelVoie
            // 
            this.labelVoie.AutoSize = true;
            this.labelVoie.Location = new System.Drawing.Point(346, 465);
            this.labelVoie.Name = "labelVoie";
            this.labelVoie.Size = new System.Drawing.Size(44, 17);
            this.labelVoie.TabIndex = 17;
            this.labelVoie.Text = "Voie :";
            // 
            // textBoxVoie
            // 
            this.textBoxVoie.Location = new System.Drawing.Point(423, 462);
            this.textBoxVoie.Name = "textBoxVoie";
            this.textBoxVoie.Size = new System.Drawing.Size(127, 22);
            this.textBoxVoie.TabIndex = 12;
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(671, 462);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(127, 22);
            this.textBoxNumero.TabIndex = 13;
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
            // labelFormule
            // 
            this.labelFormule.AutoSize = true;
            this.labelFormule.Location = new System.Drawing.Point(33, 545);
            this.labelFormule.Name = "labelFormule";
            this.labelFormule.Size = new System.Drawing.Size(67, 17);
            this.labelFormule.TabIndex = 21;
            this.labelFormule.Text = "Formule :";
            // 
            // checkBoxPetitDejeune
            // 
            this.checkBoxPetitDejeune.AutoSize = true;
            this.checkBoxPetitDejeune.Location = new System.Drawing.Point(349, 542);
            this.checkBoxPetitDejeune.Name = "checkBoxPetitDejeune";
            this.checkBoxPetitDejeune.Size = new System.Drawing.Size(115, 21);
            this.checkBoxPetitDejeune.TabIndex = 16;
            this.checkBoxPetitDejeune.Text = "Petit Déjeuné";
            this.checkBoxPetitDejeune.UseVisualStyleBackColor = true;
            // 
            // comboBoxFormule
            // 
            this.comboBoxFormule.FormattingEnabled = true;
            this.comboBoxFormule.Location = new System.Drawing.Point(186, 540);
            this.comboBoxFormule.Name = "comboBoxFormule";
            this.comboBoxFormule.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFormule.TabIndex = 15;
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.Location = new System.Drawing.Point(33, 716);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(127, 17);
            this.labelDetails.TabIndex = 24;
            this.labelDetails.Text = "Détails Redevance";
            // 
            // labelLoyer
            // 
            this.labelLoyer.AutoSize = true;
            this.labelLoyer.Location = new System.Drawing.Point(33, 769);
            this.labelLoyer.Name = "labelLoyer";
            this.labelLoyer.Size = new System.Drawing.Size(52, 17);
            this.labelLoyer.TabIndex = 26;
            this.labelLoyer.Text = "Loyer :";
            // 
            // textBoxLoyer
            // 
            this.textBoxLoyer.Location = new System.Drawing.Point(36, 789);
            this.textBoxLoyer.Name = "textBoxLoyer";
            this.textBoxLoyer.Size = new System.Drawing.Size(133, 22);
            this.textBoxLoyer.TabIndex = 17;
            // 
            // labelPetitDejeuneRedevance
            // 
            this.labelPetitDejeuneRedevance.AutoSize = true;
            this.labelPetitDejeuneRedevance.Location = new System.Drawing.Point(369, 769);
            this.labelPetitDejeuneRedevance.Name = "labelPetitDejeuneRedevance";
            this.labelPetitDejeuneRedevance.Size = new System.Drawing.Size(101, 17);
            this.labelPetitDejeuneRedevance.TabIndex = 30;
            this.labelPetitDejeuneRedevance.Text = "Petit Déjeuné :";
            // 
            // labelFormuleRedevance
            // 
            this.labelFormuleRedevance.AutoSize = true;
            this.labelFormuleRedevance.Location = new System.Drawing.Point(205, 769);
            this.labelFormuleRedevance.Name = "labelFormuleRedevance";
            this.labelFormuleRedevance.Size = new System.Drawing.Size(67, 17);
            this.labelFormuleRedevance.TabIndex = 32;
            this.labelFormuleRedevance.Text = "Formule :";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(543, 769);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(48, 17);
            this.labelTotal.TabIndex = 34;
            this.labelTotal.Text = "Total :";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(546, 789);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(133, 22);
            this.textBoxTotal.TabIndex = 20;
            // 
            // textBoxPetitDejeuneRedevance
            // 
            this.textBoxPetitDejeuneRedevance.Location = new System.Drawing.Point(372, 789);
            this.textBoxPetitDejeuneRedevance.Name = "textBoxPetitDejeuneRedevance";
            this.textBoxPetitDejeuneRedevance.Size = new System.Drawing.Size(133, 22);
            this.textBoxPetitDejeuneRedevance.TabIndex = 19;
            // 
            // textBoxFormuleRedevance
            // 
            this.textBoxFormuleRedevance.Location = new System.Drawing.Point(208, 789);
            this.textBoxFormuleRedevance.Name = "textBoxFormuleRedevance";
            this.textBoxFormuleRedevance.Size = new System.Drawing.Size(133, 22);
            this.textBoxFormuleRedevance.TabIndex = 18;
            // 
            // buttonCreer
            // 
            this.buttonCreer.Location = new System.Drawing.Point(36, 856);
            this.buttonCreer.Name = "buttonCreer";
            this.buttonCreer.Size = new System.Drawing.Size(112, 39);
            this.buttonCreer.TabIndex = 21;
            this.buttonCreer.Text = "Créer";
            this.buttonCreer.UseVisualStyleBackColor = true;
            this.buttonCreer.Click += new System.EventHandler(this.buttonCreer_Click);
            // 
            // buttonViderChamps
            // 
            this.buttonViderChamps.Location = new System.Drawing.Point(186, 856);
            this.buttonViderChamps.Name = "buttonViderChamps";
            this.buttonViderChamps.Size = new System.Drawing.Size(112, 39);
            this.buttonViderChamps.TabIndex = 22;
            this.buttonViderChamps.Text = "Vider Champs";
            this.buttonViderChamps.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDateDeNaissance
            // 
            this.dateTimePickerDateDeNaissance.Location = new System.Drawing.Point(186, 208);
            this.dateTimePickerDateDeNaissance.Name = "dateTimePickerDateDeNaissance";
            this.dateTimePickerDateDeNaissance.Size = new System.Drawing.Size(237, 22);
            this.dateTimePickerDateDeNaissance.TabIndex = 5;
            // 
            // comboBoxCivilite
            // 
            this.comboBoxCivilite.FormattingEnabled = true;
            this.comboBoxCivilite.Location = new System.Drawing.Point(186, 122);
            this.comboBoxCivilite.Name = "comboBoxCivilite";
            this.comboBoxCivilite.Size = new System.Drawing.Size(163, 24);
            this.comboBoxCivilite.TabIndex = 3;
            // 
            // comboBoxNationalite
            // 
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
            this.textBoxIban.Name = "textBoxIban";
            this.textBoxIban.Size = new System.Drawing.Size(163, 22);
            this.textBoxIban.TabIndex = 14;
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
            // textBoxVille
            // 
            this.textBoxVille.Location = new System.Drawing.Point(186, 418);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(163, 22);
            this.textBoxVille.TabIndex = 10;
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
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.Size = new System.Drawing.Size(163, 22);
            this.textBoxTelephone.TabIndex = 6;
            // 
            // labelSecu
            // 
            this.labelSecu.AutoSize = true;
            this.labelSecu.Location = new System.Drawing.Point(33, 337);
            this.labelSecu.Name = "labelSecu";
            this.labelSecu.Size = new System.Drawing.Size(188, 17);
            this.labelSecu.TabIndex = 51;
            this.labelSecu.Text = "Numéro de Sécurité Social : ";
            // 
            // textBoxSecu
            // 
            this.textBoxSecu.Location = new System.Drawing.Point(227, 334);
            this.textBoxSecu.MaxLength = 13;
            this.textBoxSecu.Name = "textBoxSecu";
            this.textBoxSecu.Size = new System.Drawing.Size(196, 22);
            this.textBoxSecu.TabIndex = 8;
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
            // CreationResident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 831);
            this.Controls.Add(this.buttonChargerPhoto);
            this.ClientSize = new System.Drawing.Size(896, 924);
            this.Controls.Add(this.labelTelephone);
            this.Controls.Add(this.textBoxTelephone);
            this.Controls.Add(this.labelVille);
            this.Controls.Add(this.textBoxVille);
            this.Controls.Add(this.pictureBoxPhoto);
            this.Controls.Add(this.labelIban);
            this.Controls.Add(this.textBoxIban);
            this.Controls.Add(this.comboBoxNationalite);
            this.Controls.Add(this.comboBoxCivilite);
            this.Controls.Add(this.dateTimePickerDateDeNaissance);
            this.Controls.Add(this.buttonViderChamps);
            this.Controls.Add(this.buttonCreer);
            this.Controls.Add(this.textBoxFormuleRedevance);
            this.Controls.Add(this.textBoxPetitDejeuneRedevance);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelFormuleRedevance);
            this.Controls.Add(this.labelPetitDejeuneRedevance);
            this.Controls.Add(this.labelLoyer);
            this.Controls.Add(this.textBoxLoyer);
            this.Controls.Add(this.labelDetails);
            this.Controls.Add(this.comboBoxFormule);
            this.Controls.Add(this.checkBoxPetitDejeune);
            this.Controls.Add(this.labelFormule);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.labelNumero);
            this.Controls.Add(this.textBoxVoie);
            this.Controls.Add(this.labelVoie);
            this.Controls.Add(this.labelTypeDeVoie);
            this.Controls.Add(this.textBoxTypeDeVoie);
            this.Controls.Add(this.labelCodePostal);
            this.Controls.Add(this.textBoxCodePostal);
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
        private System.Windows.Forms.TextBox textBoxCodePostal;
        private System.Windows.Forms.Label labelTypeDeVoie;
        private System.Windows.Forms.TextBox textBoxTypeDeVoie;
        private System.Windows.Forms.Label labelVoie;
        private System.Windows.Forms.TextBox textBoxVoie;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.Label labelFormule;
        private System.Windows.Forms.CheckBox checkBoxPetitDejeune;
        private System.Windows.Forms.ComboBox comboBoxFormule;
        private System.Windows.Forms.Label labelDetails;
        private System.Windows.Forms.Label labelLoyer;
        private System.Windows.Forms.TextBox textBoxLoyer;
        private System.Windows.Forms.Label labelPetitDejeuneRedevance;
        private System.Windows.Forms.Label labelFormuleRedevance;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.TextBox textBoxPetitDejeuneRedevance;
        private System.Windows.Forms.TextBox textBoxFormuleRedevance;
        private System.Windows.Forms.Button buttonCreer;
        private System.Windows.Forms.Button buttonViderChamps;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateDeNaissance;
        private System.Windows.Forms.ComboBox comboBoxCivilite;
        private System.Windows.Forms.ComboBox comboBoxNationalite;
        private System.Windows.Forms.Label labelIban;
        private System.Windows.Forms.TextBox textBoxIban;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Label labelVille;
        private System.Windows.Forms.TextBox textBoxVille;
        private System.Windows.Forms.Label labelTelephone;
        private System.Windows.Forms.TextBox textBoxTelephone;
        private System.Windows.Forms.Button buttonChargerPhoto;

    }
}

