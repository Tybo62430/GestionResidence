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
    public partial class Menu : Form
    {
        private int childFormNumber = 0;
        public string sChaineConnect = "Data Source= .\\SQLEXPRESS;database=GestionResidence;integrated security=SSPI";
        public int NbPetitDej ;

        public Menu()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Fenêtre " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionResidenceDataSetDepart.VueChambreDepart'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vueChambreDepartTableAdapter.Fill(this.gestionResidenceDataSetDepart.VueChambreDepart);
            // TODO: cette ligne de code charge les données dans la table 'gestionResidenceDataSetArrivees.VueChambreArrivée'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vueChambreArrivéeTableAdapter.Fill(this.gestionResidenceDataSetArrivees.VueChambreArrivée);
            //Connexion NouvelleConnection = new Connexion();
            //NouvelleConnection.ShowDialog();
            CalculpetitDej();
        }

        private void nouveauRésidentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CreationResident NouveauResident = new CreationResident();
            //NouveauResident.ShowDialog();
        }

        private void chambresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuChambres Chambres = new MenuChambres();
            Chambres.Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Etes-vous sûr ?", "ATTENTION !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void listeDesRésidentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeDesResidents NouvelleListe = new ListeDesResidents();
            NouvelleListe.Show();
        }

        public void CalculpetitDej()
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(sChaineConnect);
                SqlCommand cmd;
                string sSQL;
                sSQL = "SELECT COUNT(*) AS 'NbPetitDej' from Location where ((Supplement_SupplementId = '1') AND (GETDATE() BETWEEN PeriodeLocationDateDeBut AND PeriodeLocationDateFin))";
                cmd = new SqlCommand(sSQL, sqlconn);
                cmd.CommandType = CommandType.Text;               
                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();
                int id;
                while (DataRead.Read())
                {
                    id = Convert.ToInt32(DataRead["NbPetitDej"]);
                    NbPetitDej = id;
                }
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex);
                NbPetitDej = 0;
            }

            if (NbPetitDej >= 1)
                labelNbPetitDej.Text = "Il y a " + NbPetitDej + " petit dejeuner a preparer.";
            else
                labelNbPetitDej.Text = "Aucun petit dejeuner a preparer ce jour.";
        }

        private void residentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeDesResidents NouvelleListes = new ListeDesResidents();
            NouvelleListes.ShowDialog();
        }
    }
}
