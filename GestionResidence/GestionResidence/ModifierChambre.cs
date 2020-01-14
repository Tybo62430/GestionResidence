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
        public ModifierChambre()
        {
            InitializeComponent();
        }

        public string sChaineConnect = "Data Source= .\\SQLEXPRESS;database=GestionResidence;integrated security=SSPI";

        private void ModifierChambre_Load(object sender, EventArgs e)
        {
            

        }

        
    }
}
