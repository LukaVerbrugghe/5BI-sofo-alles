using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj5BISofoAlles._02_VariabelenEnConstantenInteractieMetDeGebruiker.Oefeningen
{
    public partial class frmOefening2 : Form
    {
        public frmOefening2()
        {
            InitializeComponent();
        }

        private void btnPrijsInclBTW_Click(object sender, EventArgs e)
        {
            //var
            double dblPrijsInclBTW = 0;
            double dblPrijsExclBTW = 0;
            const int cintBTW = 21;

            //invoer
            dblPrijsExclBTW = Convert.ToDouble(txtPrijsExclBTW.Text);

            //verwerking
            dblPrijsInclBTW = dblPrijsExclBTW + (dblPrijsExclBTW / 100 * cintBTW);

            //output
            lblBTW.Text = "BTW: " + cintBTW.ToString() + "%";
            lblPrijsInclBTW.Text = "Prijs inclusief BTW: " + Convert.ToString(dblPrijsInclBTW);
        }
    }
}
