using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionResidence
{
    public partial class MenuChambres : Form
    {
        public MenuChambres()
        {
            InitializeComponent();
        }

        private void MenuChambres_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'chambresDataSet.VueChambres'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vueChambresTableAdapter.Fill(this.chambresDataSet.VueChambres);

        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            string recupRow = dataGridViewChambres.CurrentRow.Cells[0].Value.ToString();
            ModifierChambre Chambres = new ModifierChambre(recupRow);
            Chambres.Show();
        }
    }
}
