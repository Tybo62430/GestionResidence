﻿using System;
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
    public partial class ListeDesResidents : Form
    {
        public string sChaineConnect = "Data Source= .\\SQLEXPRESS;database=GestionResidence;integrated security=SSPI";
        public int ResidentID = 0;
        public ListeDesResidents()
        {
            InitializeComponent();            
        }

        private void ListeDesResidents_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionResidenceDataSetListeClients.VueClients'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vueClientsTableAdapter.Fill(this.gestionResidenceDataSetListeClients.VueClients);


        }

        private void buttonNouveauClient_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
            CreationResident NouveauResident = new CreationResident(true);
            NouveauResident.ShowDialog();            
        }

        private void buttonModifierResident_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
            RechercheResidentIdByResidentIdentifiant();                     
            CreationResident NouveauResident = new CreationResident(false,ResidentID);
            NouveauResident.ShowDialog();
        }       
        
        public void RechercheResidentIdByResidentIdentifiant()
        {
            string recupRow = dataGridViewClients.CurrentRow.Cells[0].Value.ToString();            
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
                cmd.Parameters["@ResidentIdentifiant"].Value = recupRow;
                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();
                int id;
                while (DataRead.Read())
                {
                    id = Convert.ToInt32(DataRead["ResidentId"]);
                    ResidentID = id;
                }
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex);
                ResidentID = 0;
            }
        }

        public void SupprimerClient()
        {
            string recupRow = dataGridViewClients.CurrentRow.Cells[0].Value.ToString();
            RechercheResidentIdByResidentIdentifiant();
            //MessageBox.Show(Convert.ToString(ResidentID));
            try
            {
                SqlConnection sqlconn = new SqlConnection(sChaineConnect);
                SqlCommand cmd;
                string sSQL;
                sSQL = "DELETE FROM Resident WHERE ResidentID = @ResidentID ; DELETE FROM Location WHERE Resident_ResidentId = @ResidentID";
                cmd = new SqlCommand(sSQL, sqlconn);
                cmd.CommandType = CommandType.Text;
                // Add Parameters to Command Parameters collection
                cmd.Parameters.Add("@ResidentID", SqlDbType.Int, 100);
                //On affecte les valeurs
                cmd.Parameters["@ResidentID"].Value = ResidentID;
                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex);
                ResidentID = 0;
            }
            this.vueClientsTableAdapter.Fill(this.gestionResidenceDataSetListeClients.VueClients);
        }

        private void buttonSupprimerResident_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Supprimer Client ?", "SUPPREMIER !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                SupprimerClient();               
            }
        }
    }
}
