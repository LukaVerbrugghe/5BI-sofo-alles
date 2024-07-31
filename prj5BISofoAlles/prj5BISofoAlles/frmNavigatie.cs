using prj5BISofoAlles._01_InleidingProgrammeren;
using prj5BISofoAlles._02_VariabelenEnConstantenInteractieMetDeGebruiker;
using prj5BISofoAlles._03_IngebouwdeProceduresEnFuncties;
using prj5BISofoAlles._04_Controlestructuren;
using prj5BISofoAlles._05_ZelfgedefinieerdeFunctiesEnProcedures;
using prj5BISofoAlles._06_TimerObjecten;
using prj5BISofoAlles._07_Arrays;
using prj5BISofoAlles._08_KlassenEnObjecten;
using prj5BISofoAlles._09_Foutafhandeling;
using prj5BISofoAlles.ExtraOefeningen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj5BISofoAlles
{
    public partial class frmNavigatie : Form
    {
        public frmNavigatie()
        {
            InitializeComponent();
        }

        private void btnHoofdstuk1_Click(object sender, EventArgs e)
        {
            frmHoofdstuk1Navigatie frmHoofdstuk1Navigatie = new frmHoofdstuk1Navigatie();
            frmHoofdstuk1Navigatie.ShowDialog();
        }

        private void btnHoofdstuk2_Click(object sender, EventArgs e)
        {
            frmHoofdstuk2Navigatie frmHoofdstuk2Navigatie = new frmHoofdstuk2Navigatie();
            frmHoofdstuk2Navigatie.ShowDialog();
        }

        private void btnHoofdstuk3_Click(object sender, EventArgs e)
        {
            frmHoofdstuk3Navigatie frmHoofdstuk3Navigatie = new frmHoofdstuk3Navigatie();
            frmHoofdstuk3Navigatie.ShowDialog();
        }

        private void btnHoofdstuk4_Click(object sender, EventArgs e)
        {
            frmHoofdstuk4Navigatie frmHoofdstuk4Navigatie = new frmHoofdstuk4Navigatie();
            frmHoofdstuk4Navigatie.ShowDialog();
        }

        private void btnHoofdstuk5_Click(object sender, EventArgs e)
        {
            frmHoofdstuk5Navigatie frmHoofdstuk5Navigatie = new frmHoofdstuk5Navigatie();
            frmHoofdstuk5Navigatie.ShowDialog();
        }

        private void btnHoofdstuk6_Click(object sender, EventArgs e)
        {
            frmHoofdstuk6Navigatie frmHoofdstuk6Navigatie = new frmHoofdstuk6Navigatie();
            frmHoofdstuk6Navigatie.ShowDialog();
        }

        private void btnHoofdstuk7_Click(object sender, EventArgs e)
        {
            frmHoofdstuk7Navigatie frmHoofdstuk7Navigatie = new frmHoofdstuk7Navigatie();
            frmHoofdstuk7Navigatie.ShowDialog();
        }

        private void btnHoofdstuk8_Click(object sender, EventArgs e)
        {
            frmHoofdstuk8Navigatie frmHoofdstuk8Navigatie = new frmHoofdstuk8Navigatie();
            frmHoofdstuk8Navigatie.ShowDialog();
        }

        private void btnHoofdstuk9_Click(object sender, EventArgs e)
        {
            frmHoofdstuk9Navigatie frmHoofdstuk9Navigatie = new frmHoofdstuk9Navigatie();
            frmHoofdstuk9Navigatie.ShowDialog();
        }

        private void btnExtraOefeningen_Click(object sender, EventArgs e)
        {
            frmExtraOefeningenNavigatie frmExtraOefeningenNavigatie = new frmExtraOefeningenNavigatie();
            frmExtraOefeningenNavigatie.ShowDialog();
        }
    }
}
