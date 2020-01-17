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
using System.Globalization;
using System.Xml;

namespace GestionResidence
{
    public partial class MenuChambre : Form
    {
        public MenuChambre()
        {
            InitializeComponent();
        }

        public string sChaineConnect = "Data Source= .\\SQLEXPRESS;database=GestionResidence;integrated security=SSPI";
        private DataGridView dataGridViewChambre = new DataGridView();
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private Button reloadButton = new Button();
        private Button submitButton = new Button();

        [STAThread()]

        private void GetData(string selectCommand)
        {
            try
            {
                // Specify a connection string.  
                // Replace <SQL Server> with the SQL Server for your Northwind sample database.
                // Replace "Integrated Security=True" with user login information if necessary.
                SqlConnection connectionString = new SqlConnection(sChaineConnect);

            // Create a new data adapter based on the specified query.
                dataAdapter = new SqlDataAdapter(selectCommand, connectionString);

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand. 
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable
                {
                    Locale = CultureInfo.InvariantCulture
                };
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;

                // Resize the DataGridView columns to fit the newly loaded content.
                dataGridViewChambre.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch (SqlException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }
        }

        private void MenuChambre_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionResidenceDataSet.VueChambres'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vueChambresTableAdapter.Fill(this.gestionResidenceDataSet.VueChambres);
            // Bind the DataGridView to the BindingSource
            // and load the data from the database.
            dataGridViewChambre.DataSource = bindingSource1;
            GetData(@"SELECT * FROM VueChambres");
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            // Update the database with changes.
            dataAdapter.Update((DataTable)bindingSource1.DataSource);
        }

        //private void MenuChambre_Load(object sender, EventArgs e)
        //{
        //    //CHARGEMENT DE LA REQUETE SQL DANS LE DATAGRID

        //    //dataGridViewChambres.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //    //SqlConnection thisConnection = new SqlConnection(sChaineConnect);
        //    //thisConnection.Open();
        //    //SqlCommand command = new SqlCommand(@"SELECT dbo.PeriodeLocation.PeriodeLocationDateFin, dbo.PeriodeLocation.PeriodeLocationDateDebut, dbo.Resident.ResidentIdentifiant, dbo.Resident.ResidentNom, dbo.Resident.ResidentPrenom, dbo.Resident.Chambre_ChambreIdentifiant, dbo.Chambre.ChambreEtage, dbo.Chambre.ChambreIdentifiant, dbo.Chambre.ChambreType, dbo.Chambre.ChambrePrixMensuelTTC
        //    //      FROM dbo.Chambre
        //    //      INNER JOIN dbo.PeriodeLocation ON dbo.Chambre.ChambreId = dbo.PeriodeLocation.Chambre_ChambreId 
        //    //      INNER JOIN dbo.Resident ON dbo.PeriodeLocation.Resident_ResidentId = dbo.Resident.ResidentId AND dbo.Chambre.ChambreIdentifiant = dbo.Resident.Chambre_ChambreIdentifiant");
        //    //command.Connection = thisConnection;

        //    //SqlDataReader reader = command.ExecuteReader();

        //    //while (reader.Read())
        //    //{
        //    //    Console.WriteLine(reader.GetValue(0));
        //    //}

        //    //thisConnection.Close();

        //    SqlConnection connectionString = new SqlConnection(sChaineConnect);
        //    connectionString.Open();
        //    SqlCommand command = new SqlCommand(@"SELECT dbo.PeriodeLocation.PeriodeLocationDateFin, dbo.PeriodeLocation.PeriodeLocationDateDebut, dbo.Resident.ResidentIdentifiant, dbo.Resident.ResidentNom, dbo.Resident.ResidentPrenom, dbo.Resident.Chambre_ChambreIdentifiant, dbo.Chambre.ChambreEtage, dbo.Chambre.ChambreIdentifiant, dbo.Chambre.ChambreType, dbo.Chambre.ChambrePrixMensuelTTC
        //          FROM dbo.Chambre
        //          INNER JOIN dbo.PeriodeLocation ON dbo.Chambre.ChambreId = dbo.PeriodeLocation.Chambre_ChambreId 
        //          INNER JOIN dbo.Resident ON dbo.PeriodeLocation.Resident_ResidentId = dbo.Resident.ResidentId AND dbo.Chambre.ChambreIdentifiant = dbo.Resident.Chambre_ChambreIdentifiant");
        //    dataAdapter = new OleDbDataAdapter(command, connectionString);

        //    dataSet = new DataSet();
        //    dataAdapter.Fill(dataSet, "ARS");
        //    dataGridView1.DataSource = dataSet.Tables["Archis"].DefaultView;
        //}

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            string recupRow = dataGridViewChambres.CurrentRow.Cells[0].Value.ToString();
            ModifierChambre Chambres = new ModifierChambre(recupRow);
            Chambres.Show();
        }
    }
}