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
    public partial class MenuChambres : Form
    {
        public string sChaineConnect = "Data Source= .\\SQLEXPRESS;database=GestionResidence;integrated security=SSPI";
        public MenuChambres()
        {
            InitializeComponent();
        }

        private void MenuChambres_Load(object sender, EventArgs e)
        {          
            // Efface les lignes où la date de sortie est inférieur à la date d'aujourd'hui (devrait, sur un projet normal, se faire archiver)
            try
            {
                SqlConnection sqlconn = new SqlConnection(sChaineConnect);
                SqlCommand cmd;
                string sSQL;
                sSQL = "DELETE FROM Location WHERE(PeriodeLocationDateFin <= GETDATE())";
                cmd = new SqlCommand(sSQL, sqlconn);
                cmd.CommandType = CommandType.Text;
                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex);
            }
            // TODO: cette ligne de code charge les données dans la table 'gestionResidenceDataSetListeChambres.VueChambres2'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vueChambres2TableAdapter.Fill(this.gestionResidenceDataSetListeChambres.VueChambres2);
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            string recupRow = dataGridViewChambres.CurrentRow.Cells[0].Value.ToString();
            ModifierChambre Chambres = new ModifierChambre(recupRow);
            Chambres.Show();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.vueChambresTableAdapter.FillBy(this.chambresDataSet.VueChambres);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void buttonRafraichir_Click(object sender, EventArgs e)
        {
            this.vueChambres2TableAdapter.Fill(this.gestionResidenceDataSetListeChambres.VueChambres2);
        }
    }
}
