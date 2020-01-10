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
    public partial class ModifierResident : Form
    {
        public ModifierResident()
        {
            InitializeComponent();
        }

        private void buttonCréer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBoxNom.ToString());
        }
    }
}
