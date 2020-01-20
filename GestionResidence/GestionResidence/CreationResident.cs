using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace GestionResidence
{   
    public partial class CreationResident : Form
    {
        public int Nationalite; //variable pour la recherche d'Id Pays
        public int Formule; //variable pour la recherche d'Id formule
        public int Civilite; //variable pour la recherche d'Id civilite   
        public int Supplement = 0; //variable pour la recherche d'Id Supplement 
        public string chemin; //variable pour le chemin d'acces de la photo
        public string sChaineConnect = "Data Source= DESKTOP-6RAATB3;database=GestionResidence;integrated security=SSPI";

        public CreationResident()
        {
            InitializeComponent();
        }

        public void SearchCP()// recherche des code postal dans la BDD
        {
            comboBoxVille.Items.Clear();
            try
            {
                SqlConnection sqlconn = new SqlConnection(sChaineConnect);
                SqlCommand cmd;
                string sSQL;
                sSQL = "SELECT DISTINCT codepostal FROM bano_62 order by codepostal";
                cmd = new SqlCommand(sSQL, sqlconn);
                cmd.CommandType = CommandType.Text;
                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();                
                while (DataRead.Read())
                {
                    comboBoxCodePostal.Items.Add(DataRead["codepostal"].ToString());
                    comboBoxCodePostal.SelectedIndex = 0;
                    
                }
                sqlconn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex);
            }
        }       

        static string FirsLetterToMaj(string mot)
        {
            string oldprenom = mot;
            string newprenom = oldprenom[0].ToString().ToUpper() + oldprenom.Substring(1).ToLower(); // convertir Premier caractere en Maj
            return newprenom;
        }

        public static bool ValidMail(string mail_address) //control du mail
        {
            bool resultat = true;
            if (mail_address != string.Empty)
            {
                Regex myRegex = new
                Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                RegexOptions.IgnoreCase);
                resultat = myRegex.IsMatch(mail_address);
            }
            return resultat;
        }

        public static bool ValideDate(string date)
        {
            bool resultat = true;
            if (date != string.Empty)
            {
                Regex myRegex = new
                Regex(@"^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[1,3-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$",
                RegexOptions.IgnoreCase);
                resultat = myRegex.IsMatch(date);
            }
            return resultat;
        }

        public static bool ValidLettre(string lettre) //control du uniquement des lettres
        {
            bool resultat = true;
            if (lettre != string.Empty)
            {
                Regex myRegex = new
                 Regex(@"^([a-zA-Z]){3,50}$",
                RegexOptions.IgnoreCase);
                resultat = myRegex.IsMatch(lettre);
            }
            return resultat;
        }

        public void rechercher() //recherche des civilité et de nationnalité
        {
            comboBoxCivilite.Items.Clear();
            comboBoxNationalite.Items.Clear();
            try
            {
                SqlConnection sqlconn = new SqlConnection(sChaineConnect);
                SqlCommand cmd, cmd2, cmd3;
                string sSQL, sSQL2, sSQL3;
                sSQL = "SELECT CiviliteNom FROM Civilite";
                sSQL2 = "SELECT NationaliteNom FROM Nationalite";
                sSQL3 = "SELECT FormuleDescriptif FROM Formule";
                cmd = new SqlCommand(sSQL, sqlconn);
                cmd2 = new SqlCommand(sSQL2, sqlconn);
                cmd3 = new SqlCommand(sSQL3, sqlconn);
                cmd.CommandType = CommandType.Text;
                cmd2.CommandType = CommandType.Text;
                cmd3.CommandType = CommandType.Text;
                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();
                while (DataRead.Read())
                {
                    comboBoxCivilite.Items.Add(DataRead["CiviliteNom"].ToString());
                    comboBoxCivilite.SelectedIndex = 0;
                }
                DataRead.Close();
                DataRead = cmd2.ExecuteReader();
                while (DataRead.Read())
                {
                    comboBoxNationalite.Items.Add(DataRead["NationaliteNom"].ToString());
                    
                }
                comboBoxNationalite.SelectedIndex = 62;
                DataRead.Close();
                DataRead = cmd3.ExecuteReader();
                while (DataRead.Read())
                {
                    comboBoxFormule.Items.Add(DataRead["FormuleDescriptif"].ToString());
                    comboBoxFormule.SelectedIndex = 0;
                }
                sqlconn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex);
            }

        }

        private void buttonCreer_Click(object sender, EventArgs e)
        {
            InsertResident();
        }

        public string IdGenerator(string champ1, string champ2, string champ3) //Generateur d'identifiants
        {
            string Id = "";
            if (champ1 != string.Empty && champ2 != string.Empty && champ3 != string.Empty)
            {
                var random = new Random();
                champ1 = champ1.Replace(" ", "");
                champ2 = champ2.Replace(" ", "");
                champ3 = champ3.Replace(" ", "");
                Id = champ1.Substring(0, 2).ToUpper() + champ2.Substring(0, 2).ToUpper() + champ3;                          
            }
            return Id;
        }

        public void SearchIdNationalite()//Recherche de l'id de nationalite
        {
            Nationalite = 0;
            try
            {
                SqlConnection sqlconn = new SqlConnection(sChaineConnect);
                SqlCommand cmd;
                string sSQL;
                sSQL = "SELECT NationaliteId FROM Nationalite WHERE NationaliteNom = @nationaliteNom";
                cmd = new SqlCommand(sSQL, sqlconn);
                cmd.CommandType = CommandType.Text;
                // Add Parameters to Command Parameters collection
                cmd.Parameters.Add("@nationaliteNom", SqlDbType.NVarChar, 100);
                //On affecte les valeurs
                cmd.Parameters["@nationaliteNom"].Value = comboBoxNationalite.Text;
                
                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();
                int id;
                while (DataRead.Read())
                {
                    id = Convert.ToInt32(DataRead["NationaliteId"]);
                    Nationalite = id;                                  
                }
                sqlconn.Close();                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex);
                Nationalite = 0;
            }            
        }

        public void SearchIdFormule()//Recherche de l'id de formule
        {
            Formule = 0;
            try
            {
                SqlConnection sqlconn = new SqlConnection(sChaineConnect);
                SqlCommand cmd;
                string sSQL;
                sSQL = "SELECT FormuleId FROM Formule WHERE FormuleDescriptif = @formuledescriptif";
                cmd = new SqlCommand(sSQL, sqlconn);
                cmd.CommandType = CommandType.Text;
                // Add Parameters to Command Parameters collection
                cmd.Parameters.Add("@formuledescriptif", SqlDbType.NVarChar, 100);
                //On affecte les valeurs
                cmd.Parameters["@formuledescriptif"].Value = comboBoxFormule.Text;
                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();
                int id;
                while (DataRead.Read())
                {
                    id = Convert.ToInt32(DataRead["FormuleID"]);
                    Formule = id;
                }
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex);
                Formule = 0;
            }
        }

        public void SearchIdCivilite()//Recherche de l'id de Civilite
        {
            Civilite = 0;
            try
            {
                SqlConnection sqlconn = new SqlConnection(sChaineConnect);
                SqlCommand cmd;
                string sSQL;
                sSQL = "SELECT CiviliteId FROM Civilite WHERE CiviliteNom = @civilitenom";
                cmd = new SqlCommand(sSQL, sqlconn);
                cmd.CommandType = CommandType.Text;
                // Add Parameters to Command Parameters collection
                cmd.Parameters.Add("@civilitenom", SqlDbType.NVarChar, 100);
                //On affecte les valeurs
                cmd.Parameters["@civilitenom"].Value = comboBoxCivilite.Text;
                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();
                int id;
                while (DataRead.Read())
                {
                    id = Convert.ToInt32(DataRead["CiviliteId"]);
                    Civilite = id;
                }
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex);
                Civilite = 0;
            }
        }

        private void InsertResident() // insertion client dans la BDD
        {
            int NewElmt = 0;
            SqlConnection thisConnection = new SqlConnection(sChaineConnect);
            thisConnection.Open();
            SqlCommand myCommand = new SqlCommand("InsertResident", thisConnection);
            myCommand.CommandType = CommandType.StoredProcedure;
            // Add Parameters to Command Parameters collection

            myCommand.Parameters.Add("@ResidentIdentifiant", SqlDbType.VarChar, 30);
            myCommand.Parameters.Add("@ResidentNom", SqlDbType.VarChar, 30);
            myCommand.Parameters.Add("@ResidentPrenom", SqlDbType.VarChar, 50);
            myCommand.Parameters.Add("@ResidentDateDeNaissance", SqlDbType.Date);
            myCommand.Parameters.Add("@ResidentCodePostal", SqlDbType.Int);
            myCommand.Parameters.Add("@ResidentVille", SqlDbType.VarChar, 50);
            myCommand.Parameters.Add("@ResidentTypeDeVoie", SqlDbType.VarChar, 20);
            myCommand.Parameters.Add("@ResidentVoie", SqlDbType.VarChar, 10);
            myCommand.Parameters.Add("@ResidentNumero", SqlDbType.VarChar, 10);
            myCommand.Parameters.Add("@ResidentTelephone", SqlDbType.VarChar, 14);
            myCommand.Parameters.Add("@ResidentMail", SqlDbType.VarChar, 50);
            myCommand.Parameters.Add("@ResidentSecu", SqlDbType.VarChar, 13);
            myCommand.Parameters.Add("@ResidentIban", SqlDbType.VarChar, 50);
            myCommand.Parameters.Add("@ResidentPhoto", SqlDbType.VarChar, 100);
            myCommand.Parameters.Add("@Formule_FormuleId", SqlDbType.Int);
            myCommand.Parameters.Add("@Supplement_SupplementId", SqlDbType.Int);
            myCommand.Parameters.Add("@Civilite_CiviliteId", SqlDbType.Int);
            myCommand.Parameters.Add("@Nationalite_NationaliteId", SqlDbType.Int);

            // Affectation des valeurs
            myCommand.Parameters["@ResidentIdentifiant"].Value = IdGenerator(textBoxNom.Text, textBoxPrenom.Text,textBoxTelephone.Text.ToString());
            myCommand.Parameters["@ResidentNom"].Value = textBoxNom.Text;
            myCommand.Parameters["@ResidentPrenom"].Value = textBoxPrenom.Text;
            myCommand.Parameters["@ResidentDateDeNaissance"].Value = textBoxDateDeNaissance.Text;
            myCommand.Parameters["@ResidentCodePostal"].Value = comboBoxCodePostal.Text;
            myCommand.Parameters["@ResidentVille"].Value = comboBoxVille.Text;
            myCommand.Parameters["@ResidentTypeDeVoie"].Value = comboBoxTypeDeVoie.Text;
            myCommand.Parameters["@ResidentVoie"].Value = comboBoxVoie.Text;
            myCommand.Parameters["@ResidentNumero"].Value = comboBoxNumero.Text;
            myCommand.Parameters["@ResidentTelephone"].Value = textBoxTelephone.Text;                     
            myCommand.Parameters["@ResidentMail"].Value = textBoxEmail.Text;
            myCommand.Parameters["@ResidentSecu"].Value = textBoxSecu.Text;
            myCommand.Parameters["@ResidentIban"].Value = textBoxIban.Text;
            if (chemin==null)            
                myCommand.Parameters["@ResidentPhoto"].Value = "";
            else    
            myCommand.Parameters["@ResidentPhoto"].Value = chemin;
            SearchIdFormule();
            myCommand.Parameters["@Formule_FormuleId"].Value = Formule;
            myCommand.Parameters["@Supplement_SupplementId"].Value = Supplement;
            SearchIdCivilite();
            myCommand.Parameters["@Civilite_CiviliteId"].Value = Civilite;
            SearchIdNationalite();
            myCommand.Parameters["@Nationalite_NationaliteId"].Value = Nationalite ;

            
            // Affectation des valeurs            
            try
            {
                NewElmt = (Int32)myCommand.ExecuteScalar();

                if (NewElmt == 1)
                {
                    MessageBox.Show("Client existe deja");
                }
                else
                {
                    MessageBox.Show("Nouveau résident ajouté");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Erreur d'ajout !");
                return;
            }
            thisConnection.Close();
        }

        private void CreationResident_Load(object sender, EventArgs e)
        {
            rechercher();
            SearchCP();            
        } 
       
        private void buttonChargerPhoto_Click(object sender, EventArgs e)// charger la photo
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\Users\thibault\Pictures";
            openFileDialog.Filter = "Image Files (*.PNG;*.BMP;*.JPG;*.GIF)|*.PNG;*.BMP;*.JPG;*.GIF|Tous les fichiers (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxPhoto.Image = Image.FromFile(openFileDialog.FileName);
                chemin = openFileDialog.FileName;
                
            }
        }     

        private void comboBoxCodePostal_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxVille.Items.Clear();
            try
            {
                SqlConnection sqlconn = new SqlConnection(sChaineConnect);
                SqlCommand cmd;
                string sSQL;
                sSQL = "SELECT DISTINCT ville FROM bano_62 where codepostal = @CodePostal ";
                cmd = new SqlCommand(sSQL, sqlconn);
                cmd.CommandType = CommandType.Text;
                // Add Parameters to Command Parameters collection
                cmd.Parameters.Add("@CodePostal", SqlDbType.NVarChar, 100);
                //On affecte les valeurs
                cmd.Parameters["@CodePostal"].Value = comboBoxCodePostal.Text;
                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();                
                while (DataRead.Read())
                {
                    comboBoxVille.Items.Add(DataRead["ville"].ToString());
                    comboBoxVille.SelectedIndex = 0;                    
                }
                sqlconn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex);
            }
        }

        private void comboBoxVille_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTypeDeVoie.Items.Clear();
            try
            {
                SqlConnection sqlconn = new SqlConnection(sChaineConnect);
                SqlCommand cmd;
                string sSQL;
                sSQL = "SELECT DISTINCT LEFT(adresse,CHARINDEX(' ',adresse)) AS type_de_voie FROM bano_62 WHERE ville = @ville AND codepostal = @codepostal ORDER BY type_de_voie"; 
                cmd = new SqlCommand(sSQL, sqlconn);
                cmd.CommandType = CommandType.Text;
                // Add Parameters to Command Parameters collection
                cmd.Parameters.Add("@ville", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@codepostal", SqlDbType.NVarChar, 100);
                //On affecte les valeurs
                cmd.Parameters["@ville"].Value = comboBoxVille.Text;
                cmd.Parameters["@codepostal"].Value = comboBoxCodePostal.Text;
                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();                
                while (DataRead.Read())
                {
                    comboBoxTypeDeVoie.Items.Add(DataRead["type_de_voie"].ToString());
                    comboBoxTypeDeVoie.SelectedIndex = 0;                    
                }
                sqlconn.Close();               
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex);
            }
        }        

        private void comboBoxTypeDeVoie_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxVoie.Items.Clear();
            try
            {
                SqlConnection sqlconn = new SqlConnection(sChaineConnect);
                SqlCommand cmd;
                string sSQL;
                sSQL = "SELECT DISTINCT RIGHT(adresse,LEN(adresse)-CHARINDEX(' ',adresse)) AS nom_voie FROM bano_62 WHERE LEFT(adresse,CHARINDEX(' ',adresse)) = @typedevoie AND ville = @ville ORDER BY nom_voie";
                cmd = new SqlCommand(sSQL, sqlconn);
                cmd.CommandType = CommandType.Text;
                // Add Parameters to Command Parameters collection
                cmd.Parameters.Add("@ville", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@typedevoie", SqlDbType.NVarChar, 100);
                //On affecte les valeurs
                cmd.Parameters["@ville"].Value = comboBoxVille.Text;
                cmd.Parameters["@typedevoie"].Value = comboBoxTypeDeVoie.Text;
                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();                
                while (DataRead.Read())
                {
                    comboBoxVoie.Items.Add(DataRead["nom_voie"].ToString());
                    comboBoxVoie.SelectedIndex = 0;                    
                }
                sqlconn.Close();               
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex);
            }
        }        

        private void comboBoxVoie_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxNumero.Items.Clear();
            try
            {
                SqlConnection sqlconn = new SqlConnection(sChaineConnect);
                SqlCommand cmd;
                string sSQL;
                sSQL = "SELECT DISTINCT numero from bano_62 where LEFT(adresse,CHARINDEX(' ',adresse)) = @typedevoie AND RIGHT(adresse,LEN(adresse)-CHARINDEX(' ',adresse)) = @nomdevoie AND ville = @ville";
                cmd = new SqlCommand(sSQL, sqlconn);
                cmd.CommandType = CommandType.Text;
                // Add Parameters to Command Parameters collection
                cmd.Parameters.Add("@typedevoie", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@nomdevoie", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@ville", SqlDbType.NVarChar, 100);
                //On affecte les valeurs
                cmd.Parameters["@typedevoie"].Value = comboBoxTypeDeVoie.Text;
                cmd.Parameters["@nomdevoie"].Value = comboBoxVoie.Text;
                cmd.Parameters["@ville"].Value = comboBoxVille.Text;
                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();                
                while (DataRead.Read())
                {
                    comboBoxNumero.Items.Add(DataRead["numero"].ToString());
                    comboBoxNumero.SelectedIndex = 0;                    
                }
                sqlconn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex);
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Etes-vous sûr ?", "ATTENTION !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void checkBoxPetitDejeune_CheckedChanged(object sender, EventArgs e)
        {
            Supplement = 0;
            if (checkBoxPetitDejeune.Checked)
                Supplement = 1 ;
            else
                Supplement = 0 ;
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (ValidMail(textBoxEmail.Text))
            {
                ErreurMail.Text = "";
            }
            else
            {
                ErreurMail.Text = "E-mail invalide";
            }
        }

        private void buttonViderChamps_Click(object sender, EventArgs e)
        {
            textBoxNom.Clear();
            textBoxPrenom.Clear();
            comboBoxCivilite.SelectedItem = 0;
            comboBoxNationalite.SelectedItem = 63; //63 = Francaise
            textBoxDateDeNaissance.Clear();
            textBoxTelephone.Clear();
            textBoxEmail.Clear();
            textBoxSecu.Clear();
            comboBoxCodePostal.SelectedItem = 0;
            comboBoxVille.SelectedItem = 0;
            comboBoxTypeDeVoie.SelectedItem = 0;
            comboBoxVoie.SelectedItem = 0;
            comboBoxNumero.SelectedItem = 0;
            textBoxIban.Clear();
            comboBoxFormule.SelectedItem = 0;
            checkBoxPetitDejeune.Checked = false;
            pictureBoxPhoto.Image = null;

        }

        private void textBoxNom_Validated(object sender, EventArgs e)
        {              
            if (textBoxNom.Text != string.Empty)
            {
                textBoxNom.Text = textBoxNom.Text.ToUpper();
                UnlockCreate();
            }
            else
                buttonCreer.Enabled = false;
        }

        private void textBoxPrenom_Validated(object sender, EventArgs e)
        {
            if(textBoxPrenom.Text != string.Empty)
            {
                UnlockCreate();
                textBoxPrenom.Text = FirsLetterToMaj(textBoxPrenom.Text);
            }
            else
                buttonCreer.Enabled = false;
        }
               
        private void RechercherByNameSurNamePhone(string var1)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(sChaineConnect);
                SqlCommand cmd;
                string sSQL;
                sSQL = "SELECT * FROM Resident WHERE ResidentIdentifiant=@ValeurRechercher";
                cmd = new SqlCommand(sSQL, sqlconn);
                cmd.CommandType = CommandType.Text;
                // Add Parameters to Command Parameters collection
                cmd.Parameters.Add("@ValeurRechercher", SqlDbType.NVarChar, 100);
                
                //On affecte les valeurs
                cmd.Parameters["@ValeurRechercher"].Value =var1;
               
                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();
                while (DataRead.Read())
                {
                    //comboBoxCivilite.SelectedItem = DataRead["Civilite_CiviliteId"].ToString();
                    //textBoxEmail.Text = DataRead["ResidentMail"].ToString();
                    //textBoxSecu.Text = DataRead["ResidentSecu"].ToString();
                    //comboBoxCodePostal.SelectedItem = DataRead["ResidentCodePostal"].ToString();
                    //comboBoxVille.SelectedItem = DataRead["ResidentVille"].ToString();
                    //comboBoxTypeDeVoie.SelectedItem = DataRead["ResidentTypeDeVoie"].ToString();
                    //comboBoxVoie.SelectedItem = DataRead["ResidentVoie"].ToString();
                    //comboBoxNumero.SelectedItem = DataRead["ResidentNumero"].ToString();
                    //textBoxIban.Text = DataRead["ResidentIban"].ToString();
                    //comboBoxFormule.Text = DataRead["Formule_FormuleId"].ToString();
                    //pictureBoxPhoto.Image = Image.FromFile(DataRead["ResidentPhoto"].ToString());
                    MessageBox.Show("Client existe deja");
                }
                sqlconn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex);
            }
        }

        private void textBoxTelephone_Validated(object sender, EventArgs e)
        {
            string Numero = textBoxTelephone.Text;
            string ValRechercher;
            if (Numero.Length < 10)
            {
                ErreurNumero.Text = "numero invalide";
                buttonCreer.Enabled = false;

            }                
            else
            {
                ValRechercher = IdGenerator(textBoxNom.Text, textBoxPrenom.Text, textBoxTelephone.Text);
                RechercherByNameSurNamePhone(ValRechercher);
                ErreurNumero.Text = "";
                UnlockCreate();
            }            
        }

        private void textBoxDateDeNaissance_Validated(object sender, EventArgs e)
        {
            if (ValideDate(textBoxDateDeNaissance.Text))
            {
                ErreurDate.Text = "";
                UnlockCreate();
            }
            else
            {
                ErreurDate.Text = "Date invalide";
                buttonCreer.Enabled = false;
            }
        }

        private void textBoxTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void textBoxSecu_Validated(object sender, EventArgs e)
        {
            string secu = textBoxSecu.Text;
            if (secu.Length < 13)
                ErreurSecu.Text = "numero de secu invalide";
            else
                ErreurSecu.Text = "";
        }

        private void textBoxSecu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void textBoxIban_Validated(object sender, EventArgs e)
        {
            string Iban = textBoxSecu.Text;
            if (Iban.Length < 27)
                ErreurIban.Text = "numero Iban invalide";
            else
                ErreurIban.Text = "";
        }

        public void UnlockCreate()
        {
            if ((textBoxNom.Text != string.Empty) && (textBoxPrenom.Text != string.Empty) && (textBoxDateDeNaissance.Text != string.Empty) && (textBoxTelephone.Text != string.Empty))
                buttonCreer.Enabled = true;
            else
                buttonCreer.Enabled = false;

        }      
    }
}
