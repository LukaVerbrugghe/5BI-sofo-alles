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
using prj5BISofoAlles._02_VariabelenEnConstantenInteractieMetDeGebruiker.Uitleg;
using prj5BISofoAlles._02_VariabelenEnConstantenInteractieMetDeGebruiker.Oefeningen;

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

        private void btnOverzichtDatatypes_Click(object sender, EventArgs e)
        {
            frmOverzichtDatatypes frmOverzichtDatatypes = new frmOverzichtDatatypes();
            frmOverzichtDatatypes.ShowDialog();
        }

        private void btnDeclarerenInitialiseren_Click(object sender, EventArgs e)
        {
            frmDeclarerenInititialiseren frmDeclarerenInitialiseren = new frmDeclarerenInititialiseren();
            frmDeclarerenInitialiseren.ShowDialog();
        }

        private void btnReturnValue_Click(object sender, EventArgs e)
        {
            frmReturnValue frmReturnValue = new frmReturnValue();
            frmReturnValue.ShowDialog();
        }

        private void btnInputbox_Click(object sender, EventArgs e)
        {
            frmInputbox frmInputbox = new frmInputbox();
            frmInputbox.ShowDialog();
        }

        private void btnOperatoren_Click(object sender, EventArgs e)
        {
            frmOperatoren frmOperatoren = new frmOperatoren();
            frmOperatoren.ShowDialog();
        }

        private void btnOefening1_Click(object sender, EventArgs e)
        {
            frmOefening1 frmOefening1 = new frmOefening1();
            frmOefening1.ShowDialog();
        }

        private void btnOefening2_Click(object sender, EventArgs e)
        {
            frmOefening2 frmOefening2 = new frmOefening2();
            frmOefening2.ShowDialog();
        }
    }
}
