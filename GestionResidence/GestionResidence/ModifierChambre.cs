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
    public partial class ModifierChambre : Form
    {
        public int Chambre;
        public int Resident;
        string DonneeCellule;

        public ModifierChambre(string recupRow)
        {
            InitializeComponent();
            DonneeCellule = recupRow;
        }

        public string sChaineConnect = "Data Source= .\\SQLEXPRESS;database=GestionResidence;integrated security=SSPI";

        public void rechercher()
        {
            comboBoxIdentifiant.Items.Clear();
            try
            {
                SqlConnection sqlconn = new SqlConnection(sChaineConnect);
                SqlCommand cmd;
                string sSQL;
                sSQL = "SELECT ResidentIdentifiant FROM Resident";
                cmd = new SqlCommand(sSQL, sqlconn);
                cmd.CommandType = CommandType.Text;
                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();
                while (DataRead.Read())
                {
                    comboBoxIdentifiant.Items.Add(DataRead["ResidentIdentifiant"].ToString() + " - " + DataRead["ResidentNom"].ToString() + " - " + DataRead["ResidentPrenom"].ToString());
                    comboBoxIdentifiant.SelectedIndex = 0;
                }
                DataRead.Close();
               
                sqlconn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex);
            }
        }

        public void SearchIdResident()
        {
            Chambre = 0;
            try
            {
                SqlConnection sqlconn = new SqlConnection(sChaineConnect);
                SqlCommand cmd;
                string sSQL;
                sSQL = "SELECT ResidentId FROM Resident WHERE ResidentIdentifiant = @ResidentIdentifiant";
                cmd = new SqlCommand(sSQL, sqlconn);
                cmd.CommandType = CommandType.Text;
                // Add Parameters to Command Parameters collection
                cmd.Parameters.Add("@ResidentIdentifiant", SqlDbType.NVarChar, 100);

                //On affecte les valeurs
                cmd.Parameters["@ResidentIdentifiant"].Value = comboBoxIdentifiant.Text;

                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();
                int id;
                while (DataRead.Read())
                {
                    id = Convert.ToInt32(DataRead["ResidentId"]);
                    Chambre = id;
                }
                sqlconn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex);
                Chambre = 0;
            }

        }

        private void AssignerResident()
        {
            int NewElmt = 0;
            SqlConnection thisConnection = new SqlConnection(sChaineConnect);
            thisConnection.Open();
            SqlCommand myCommand = new SqlCommand("AssignationChambre", thisConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            // Add Parameters to Command Parameters collection
            myCommand.Parameters.Add("@ResidentPhoto", SqlDbType.VarChar, 100);
            myCommand.Parameters.Add("@ResidentPhoto", SqlDbType.VarChar, 100);
            myCommand.Parameters.Add("@ResidentPhoto", SqlDbType.VarChar, 100);
            myCommand.Parameters.Add("@ResidentPhoto", SqlDbType.VarChar, 100);

            // Affectation des valeurs
            SearchIdResident();
            myCommand.Parameters["@Chambre_ChambreId"].Value = Chambre;
            myCommand.Parameters["@Chambre_ChambreId"].Value = Chambre;
            myCommand.Parameters["@Chambre_ChambreId"].Value = Chambre;
            myCommand.Parameters["@Chambre_ChambreId"].Value = Chambre;


            try
            {
                NewElmt = (Int32)myCommand.ExecuteScalar();

                if (NewElmt == 1)
                {
                    MessageBox.Show("Chambre déjà affectée");
                }
                else
                {
                    MessageBox.Show("Chambre affectée");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Erreur d'ajout !");
                return;
            }
            thisConnection.Close();
        }

        private void ModifierChambre_Load(object sender, EventArgs e)
        {
            textBoxChambre.Text = DonneeCellule;
            rechercher();
        }

        private void buttonAssigner_Click(object sender, EventArgs e)
        {

        }
    }
}
