using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.VisualBasic;

namespace prj5BISofoAlles._02_VariabelenEnConstantenInteractieMetDeGebruiker.KlassikaleOefeningen
{
    public partial class frmVarEnConst : Form
    {
        string strVoornaam;
        int intGetal = 0;

        public frmVarEnConst()
        {
            InitializeComponent();
        }

        private void btnVar1_Click(object sender, EventArgs e)
        {
            int intGetal1 = 10;
            int intGetal2 = 5;

            MessageBox.Show("Het resultaat is " + Convert.ToString(intGetal1 + intGetal2), intGetal1.ToString() + " + " + intGetal2.ToString() + " = ?");
        }

        private void btnVar2_Click(object sender, EventArgs e)
        {
            int intGetal1;
            int intGetal2;

            intGetal1 = Convert.ToInt32(Interaction.InputBox("Geef de waarde voor getal 1 in."));
            intGetal2 = Convert.ToInt32(Interaction.InputBox("Geef de waarde voor getal 2 in."));

            MessageBox.Show("De som van " + intGetal1 + " en " + intGetal2 + " is " + Convert.ToString(intGetal1 + intGetal2) + ".");
        }

        private void btnVar3_Click(object sender, EventArgs e)
        {
            strVoornaam = Interaction.InputBox("Geef je voornaam in.", "Invoer verplicht.");
            MessageBox.Show("Welkom " + strVoornaam + "!");
        }

        private void btnVar4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welkom " + strVoornaam + "!", "Ook hier werkt het nu");
        }

        private void btnVar5_Click(object sender, EventArgs e)
        {
            intGetal++;
            lblGetal.Text = Convert.ToString(intGetal);
        }
    }
}
