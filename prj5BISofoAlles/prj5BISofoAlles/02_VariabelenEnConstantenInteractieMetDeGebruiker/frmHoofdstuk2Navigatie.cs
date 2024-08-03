using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using prj5BISofoAlles._02_VariabelenEnConstantenInteractieMetDeGebruiker.KlassikaleOefeningen;

namespace prj5BISofoAlles._02_VariabelenEnConstantenInteractieMetDeGebruiker
{
    public partial class frmHoofdstuk2Navigatie : Form
    {
        public frmHoofdstuk2Navigatie()
        {
            InitializeComponent();
        }

        private void btnHoofdstuk1_Click(object sender, EventArgs e)
        {
            frmInteractie frmInteractie = new frmInteractie();
            frmInteractie.ShowDialog();
        }

        private void btnKlassikaal2_Click(object sender, EventArgs e)
        {
            frmVarEnConst frmVarEnConst = new frmVarEnConst();
            frmVarEnConst.ShowDialog();
        }
    }
}
