using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using prj5BISofoAlles._01_InleidingProgrammeren.Uitleg;
using prj5BISofoAlles._01_InleidingProgrammeren.Oefeningen;

namespace prj5BISofoAlles._01_InleidingProgrammeren
{
    public partial class frmHoofdstuk1Navigatie : Form
    {
        public frmHoofdstuk1Navigatie()
        {
            InitializeComponent();
        }

        private void btnInleidingProgrammerenPwp_Click(object sender, EventArgs e)
        {
            frmInleidingPdf frmInleidingPdf = new frmInleidingPdf();
            frmInleidingPdf.ShowDialog();
        }

        private void btnBasiscode_Click(object sender, EventArgs e)
        {
            frmBasiscode frmBasiscode = new frmBasiscode();
            frmBasiscode.ShowDialog();
        }

        private void btnExtraVenster_Click(object sender, EventArgs e)
        {
            frmExtraVenster frmExtraVenster = new frmExtraVenster();
            frmExtraVenster.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
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
