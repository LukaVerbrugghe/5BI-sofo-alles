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
    public partial class frmOefening1 : Form
    {
        public frmOefening1()
        {
            InitializeComponent();
        }

        private void btnBerekenBMI_Click(object sender, EventArgs e)
        {
            //var
            double dblGewicht = 0;
            double dblLengte = 0;
            double dblBMI = 0;

            //input
            dblGewicht = Convert.ToDouble(txtGewicht.Text);
            dblLengte = Convert.ToDouble(txtLengte.Text);

            //verwerking
            //formule BMI: gewicht / (lengte*lengte)
            dblBMI = dblGewicht / Math.Pow(dblLengte, 2);

            //uitvoer
            MessageBox.Show("Je BMI is " + Convert.ToString(dblBMI), "Resultaat", MessageBoxButtons.OK);
        }
    }
}
