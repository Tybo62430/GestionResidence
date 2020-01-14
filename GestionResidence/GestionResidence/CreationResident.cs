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
        public int Resultat;
        public string chemin;
        public CreationResident()
        {
            InitializeComponent();
        }

        public string sChaineConnect = "Data Source= .\\SQLEXPRESS;database=GestionResidence;integrated security=SSPI";

        public string ToMaj(string Aconvert)
        {
            return Aconvert.ToUpper(); //convertir en majuscule
        }

        static string FirsLetterToMaj(string mot)
        {
            string oldprenom = mot;
            string newprenom = oldprenom[0].ToString().ToUpper() + oldprenom.Substring(1).ToLower(); // convertir Premier caractere en Maj
            return newprenom;
        }

        public static bool ValidMail(string mail_address)
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

        public void rechercher()
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
                sSQL3 = "SELECT FormuleNom FROM Formule";
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
                    comboBoxNationalite.SelectedIndex = 0;
                }
                DataRead.Close();
                DataRead = cmd3.ExecuteReader();
                while (DataRead.Read())
                {
                    comboBoxFormule.Items.Add(DataRead["FormuleNom"].ToString());
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

        public string IdGenerator(string champ1, string champ2, string champ3)
        {
            var random = new Random();
            string Id = champ1.Substring(0, 3) + champ2.Substring(0, 3) + champ3.Substring(6) + random.Next(0, 1000);
            return Id;
        }

        public void SearchIdNationalite()
        {
            Resultat = 0;
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
                    Resultat = id;                                  
                }
                sqlconn.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex);
                Resultat = 0;
            }
            
        }

        private void InsertResident()
        {


            

            int NewElmt = 0;
            SqlConnection thisConnection = new SqlConnection(sChaineConnect);
            thisConnection.Open();
            SqlCommand myCommand = new SqlCommand("InsertResident", thisConnection);
            myCommand.CommandType = CommandType.StoredProcedure;
            // Add Parameters to Command Parameters collection

            myCommand.Parameters.Add("@ResidentIdentifiant", SqlDbType.VarChar, 10);
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
            //myCommand.Parameters.Add("@Formule_FormuleId", SqlDbType.Int);
            //myCommand.Parameters.Add("@Supplement_SupplementId", SqlDbType.Int);
            //myCommand.Parameters.Add("@Civilite_CiviliteId", SqlDbType.Int);
            myCommand.Parameters.Add("@Nationalite_NationaliteId", SqlDbType.Int);

            // Affectation des valeurs
            myCommand.Parameters["@ResidentIdentifiant"].Value = IdGenerator(textBoxNom.Text, textBoxPrenom.Text, dateTimePickerDateDeNaissance.Text);
            myCommand.Parameters["@ResidentNom"].Value = textBoxNom.Text;
            myCommand.Parameters["@ResidentPrenom"].Value = textBoxPrenom.Text;
            myCommand.Parameters["@ResidentDateDeNaissance"].Value = Convert.ToDateTime(dateTimePickerDateDeNaissance.Text);
            myCommand.Parameters["@ResidentCodePostal"].Value = textBoxCodePostal.Text;
            myCommand.Parameters["@ResidentVille"].Value = textBoxVille.Text;
            myCommand.Parameters["@ResidentTypeDeVoie"].Value = textBoxTypeDeVoie.Text;
            myCommand.Parameters["@ResidentVoie"].Value = textBoxVoie.Text;
            myCommand.Parameters["@ResidentNumero"].Value = textBoxNumero.Text;
            myCommand.Parameters["@ResidentTelephone"].Value = textBoxTelephone.Text;
            myCommand.Parameters["@ResidentMail"].Value = textBoxEmail.Text;
            myCommand.Parameters["@ResidentSecu"].Value = textBoxSecu.Text;
            myCommand.Parameters["@ResidentIban"].Value = textBoxIban.Text;
            myCommand.Parameters["@ResidentPhoto"].Value = chemin;
            //myCommand.Parameters["@Formule_FormuleId"].Value = comboBoxFormule;
            //myCommand.Parameters["@Supplement_SupplementId"].Value = checkBoxPetitDejeune;
            //myCommand.Parameters["@Civilite_CiviliteId"].Value = comboBoxCivilite;
            SearchIdNationalite();
            myCommand.Parameters["@Nationalite_NationaliteId"].Value = Resultat ;
            // Affectation des valeurs            
            try
            {
                NewElmt = (Int32)myCommand.ExecuteScalar();

                if (NewElmt == 1)
                {
                    MessageBox.Show("Résident déjà existant");
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
        }

        private void textBoxNom_Leave(object sender, EventArgs e)
        {
            string nom = textBoxNom.Text;
            textBoxNom.Text = ToMaj(nom);
        }

        private void textBoxPrenom_Leave(object sender, EventArgs e)
        {
            string prenom = textBoxPrenom.Text;
            textBoxPrenom.Text = FirsLetterToMaj(prenom);
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if (ValidMail(textBoxEmail.Text))
            {
                textBoxEmail.BackColor = Color.Green;
            }
            else
            {
                textBoxEmail.BackColor = Color.Red;
            }
        }

        private void buttonChargerPhoto_Click(object sender, EventArgs e)
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
    }
}
