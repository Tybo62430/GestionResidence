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
    public partial class MenuChambre : Form
    {
        public MenuChambre()
        {
            InitializeComponent();
        }

        public string sChaineConnect = "Data Source= .\\SQLEXPRESS;database=GestionResidence;integrated security=SSPI";


        private void MenuChambre_Load(object sender, EventArgs e)
        {
            dataGridViewChambres.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // TODO: cette ligne de code charge les données dans la table 'chambresDataSet.Chambre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.chambreTableAdapter.Fill(this.chambresDataSet.Chambre);
            SqlConnection thisConnection = new SqlConnection(sChaineConnect);
            thisConnection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Chambre");
            command.Connection = thisConnection;

            SqlDataReader reader = command.ExecuteReader();

            //on boucle sur les données

            while (reader.Read())
            {
                Console.WriteLine(reader.GetValue(0));
            }
            //on ferme la connexion

            thisConnection.Close();
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            string recupRow = dataGridViewChambres.CurrentRow.Cells[0].Value.ToString();
            ModifierChambre Chambres = new ModifierChambre(recupRow);
            Chambres.Show();         
        }
    }
}
