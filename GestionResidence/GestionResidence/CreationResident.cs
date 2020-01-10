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

namespace GestionResidence
{
    public partial class CreationResident : Form
    {

        public CreationResident()
        {
            InitializeComponent();
        }

        public string sChaineConnect = "Data Source=.\\SQLEXPRESS;database=GestionResidence;integrated security=SSPI";

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
            MessageBox.Show(textBoxNom.ToString());
            InsertResident();
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
            myCommand.Parameters.Add("@ResidentIban", SqlDbType.VarChar, 50);
            //myCommand.Parameters.Add("@ResidentPhoto", SqlDbType.Image);
            //myCommand.Parameters.Add("@Formule_FormuleId", SqlDbType.Int);
            //myCommand.Parameters.Add("@Supplement_SupplementId", SqlDbType.Int);
            //myCommand.Parameters.Add("@Civilite_CiviliteId", SqlDbType.Int);
            //myCommand.Parameters.Add("@Nationalite_NationaliteId", SqlDbType.Int);

            // Affectation des valeurs
            myCommand.Parameters["@ResidentIdentifiant"].Value = "XD10";
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
            myCommand.Parameters["@ResidentIban"].Value = textBoxIban.Text;
            //myCommand.Parameters["@ResidentPhoto"].Value = pictureBoxPhoto.Image;
            //myCommand.Parameters["@Formule_FormuleId"].Value = comboBoxFormule;
            //myCommand.Parameters["@Supplement_SupplementId"].Value = checkBoxPetitDejeune;
            //myCommand.Parameters["@Civilite_CiviliteId"].Value = comboBoxCivilite;
            //myCommand.Parameters["@Nationalite_NationaliteId"].Value = comboBoxNationalite;
            // Affectation des valeurs

            try
            {
                NewElmt = (Int32)myCommand.ExecuteScalar();

                if (NewElmt == 1)
                {
                    MessageBox.Show("Ligne mise à jours...");
                }
                else
                {
                    MessageBox.Show("Nouvelle Ligne ...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Erreur de mise à jours !");
                return;
            }
            thisConnection.Close();
        }

        private void CreationResident_Load(object sender, EventArgs e)
        {
            rechercher();
        }
    }
}
