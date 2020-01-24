using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace GestionResidence
{
    public partial class ModifierChambre : Form
    {
        public int Chambre;
        public int Resident;
        public int Formule;
        public int Supplement;
        string DonneeCellule;
        public string sChaineConnect = "Data Source= .\\SQLEXPRESS;database=GestionResidence;integrated security=SSPI";

        public ModifierChambre(string recupRow)
        {
            InitializeComponent();
            DonneeCellule = recupRow;
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

        // 
        // Charge les combobox avec les données résident et les données de formule
        //

        public void FillComboBoxOnLoad()
        {
            comboBoxFormule.Items.Clear();
            comboBoxIdentifiant.Items.Clear();           
            try
            {
                SqlConnection sqlconn = new SqlConnection(sChaineConnect);
                SqlCommand cmd, cmd2;
                string sSQL, sSQL2;
                sSQL = "SELECT ResidentId, ResidentIdentifiant, ResidentNom, ResidentPrenom FROM Resident ORDER BY ResidentNom";
                sSQL2 = "SELECT FormuleDescriptif FROM Formule";
                cmd = new SqlCommand(sSQL, sqlconn);
                cmd2 = new SqlCommand(sSQL2, sqlconn);
                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();              
                while (DataRead.Read())
                {
                    comboBoxIdentifiant.Items.Add(DataRead["ResidentIdentifiant"].ToString() + " - " + DataRead["ResidentNom"].ToString() + " - " + DataRead["ResidentPrenom"].ToString());
                    comboBoxIdentifiant.SelectedIndex = 0;                                                 
                }
                DataRead.Close();
                DataRead = cmd2.ExecuteReader();
                while (DataRead.Read())
                {
                    comboBoxFormule.Items.Add(DataRead["FormuleDescriptif"].ToString());
                    comboBoxFormule.SelectedIndex = 0;
                }
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex);   
            }
        }

        // 
        // Affiche le résultat d'une recherche par nom dans la combobox
        //

        public void ResidentIdOnKeyPress()
        {
            comboBoxIdentifiant.Items.Clear();
            try
            {
                SqlConnection sqlconn = new SqlConnection(sChaineConnect);
                SqlCommand cmd;
                string sSQL;
                sSQL = "SELECT ResidentId, ResidentIdentifiant, ResidentNom, ResidentPrenom FROM Resident WHERE ResidentNom LIKE @Nom+'%'";
                cmd = new SqlCommand(sSQL, sqlconn);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("@Nom", SqlDbType.NVarChar, 100);
                //On affecte les valeurs
                cmd.Parameters["@Nom"].Value = textBoxNom.Text;


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

        public void GetComboBoxId()
        {
            Resident = 0;
            try
            {
                SqlConnection sqlconn = new SqlConnection(sChaineConnect);
                SqlCommand cmd;
                string sSQL;
                sSQL = "SELECT ResidentId FROM Resident WHERE ResidentIdentifiant = @ResidentIdentifiant";
                cmd = new SqlCommand(sSQL, sqlconn);
                cmd.CommandType = CommandType.Text;
                // Add Parameters to Command Parameters collection
                cmd.Parameters.Add("@ResidentIdentifiant", SqlDbType.NVarChar, 30);

                //On affecte les valeurs
                cmd.Parameters["@ResidentIdentifiant"].Value =  comboBoxIdentifiant.Text.Substring(0,14);

                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();
                int id;
                while (DataRead.Read())
                {
                    id = Convert.ToInt32(DataRead["ResidentId"]);
                    Resident = id;
                }
                sqlconn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex);
                Resident = 0;
            }
        }

        //
        // Récupère l'ID de la chambre grâce à l'identifiant récupéré lors de la sélection d'une chambre dans le form "Menu Chambre"
        //

        public void IdChambre()
        {
            Chambre = 0;
            try
            {
                SqlConnection sqlconn = new SqlConnection(sChaineConnect);
                SqlCommand cmd;
                string sSQL;
                sSQL = "SELECT ChambreId FROM Chambre WHERE ChambreIdentifiant = @ChambreIdentifiant";
                cmd = new SqlCommand(sSQL, sqlconn);
                cmd.CommandType = CommandType.Text;
                // Add Parameters to Command Parameters collection
                cmd.Parameters.Add("@ChambreIdentifiant", SqlDbType.NVarChar, 30);

                //On affecte les valeurs
                cmd.Parameters["@ChambreIdentifiant"].Value = DonneeCellule;

                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();
                int id;
                while (DataRead.Read())
                {
                    id = Convert.ToInt32(DataRead["ChambreId"]);
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

        //
        //Recherche de l'id de formule via le résultat de la combobox comboBoxFormule
        //

        public void SearchIdFormule()
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

        private void AssignerResident()
        {
            int NewElmt = 0;
            SqlConnection thisConnection = new SqlConnection(sChaineConnect);
            thisConnection.Open();
            SqlCommand myCommand = new SqlCommand("AssignationChambre", thisConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            // Add Parameters to Command Parameters collection
            myCommand.Parameters.Add("@Chambre_ChambreId", SqlDbType.Int);
            myCommand.Parameters.Add("@Resident_ResidentId", SqlDbType.Int);
            myCommand.Parameters.Add("@PeriodeLocationDateDebut", SqlDbType.Date);
            myCommand.Parameters.Add("@PeriodeLocationDateFin", SqlDbType.Date);
            myCommand.Parameters.Add("@Formule_FormuleId", SqlDbType.Int);
            myCommand.Parameters.Add("@Supplement_SupplementId", SqlDbType.Int);

            // Affectation des valeurs
            IdChambre();
            myCommand.Parameters["@Chambre_ChambreId"].Value = Chambre;
            GetComboBoxId();
            myCommand.Parameters["@Resident_ResidentId"].Value = Resident;
            myCommand.Parameters["@PeriodeLocationDateDebut"].Value = textBoxDebutSejour.Text;
            myCommand.Parameters["@PeriodelocationDateFin"].Value = textBoxFinSejour.Text;
            SearchIdFormule();
            myCommand.Parameters["@Formule_FormuleId"].Value = Formule;
            myCommand.Parameters["@Supplement_SupplementId"].Value = Supplement;

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
            FillComboBoxOnLoad();
        }

        private void buttonAssigner_Click(object sender, EventArgs e)
        {
            AssignerResident();
        }

        private void textBoxIdentifiant_KeyPress(object sender, KeyPressEventArgs e)
        {
            ResidentIdOnKeyPress();
        }

        private void textBoxDebutSejour_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValideDate(textBoxDebutSejour.Text);
        }

        private void textBoxFinSejour_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValideDate(textBoxFinSejour.Text);
        }

        private void checkBoxPetitDejeune_CheckedChanged(object sender, EventArgs e)
        {
            Supplement = 0;
            if (checkBoxPetitDejeune.Checked)
                Supplement = 1;
            else
                Supplement = 0;
        }
    }
}
