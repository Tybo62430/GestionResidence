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
    public partial class Connexion : Form
    {
        public string sChaineConnect = "Data Source= .\\SQLEXPRESS;database=GestionResidence;integrated security=SSPI";
        public Connexion()
        {
            InitializeComponent();
        }

        private void textBoxIdentifiant_Leave(object sender, EventArgs e)
        {
            textBoxIdentifiant.Text = textBoxIdentifiant.Text.ToUpper();//converti en majuscule l'identifiant 
        }

        private void textBoxMotdepasse_Leave(object sender, EventArgs e)
        {
            textBoxMotdepasse.Text = textBoxMotdepasse.Text.ToUpper();//converti en majuscule le mot de passe
        }

        private void buttonValider_Click(object sender, EventArgs e)// rechercher et comparer dans la BDD l'identifiant et le mot de passe
        {                                                           // si OK acces au logiciel
            try
            {
                SqlConnection sqlconn = new SqlConnection(sChaineConnect);
                SqlCommand cmd;
                string sSQL;
                sSQL = "SELECT EmployePrenom FROM Employe WHERE (EmployeIdentifiant = @Identifiant) AND (EmployeMDP = @MotDePasse)";
                cmd = new SqlCommand(sSQL, sqlconn);
                cmd.CommandType = CommandType.Text;
                // Add Parameters to Command Parameters collection
                cmd.Parameters.Add("@Identifiant", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@MotDePasse", SqlDbType.NVarChar, 100);
                //On affecte les valeurs
                cmd.Parameters["@Identifiant"].Value = textBoxIdentifiant.Text;
                cmd.Parameters["@MotDePasse"].Value = textBoxMotdepasse.Text;
                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();
                bool trouve = false;
                while (DataRead.Read())
                {
                    
                    trouve = true;
                    Menu Menu = new Menu();
                    Menu.ShowDialog();
                }
                if (trouve)
                {
                    this.Close();           
                }
                    
                else
                    MessageBox.Show("NOT Ok");

                sqlconn.Close();               
                
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex);
            }

        }
    }
}
