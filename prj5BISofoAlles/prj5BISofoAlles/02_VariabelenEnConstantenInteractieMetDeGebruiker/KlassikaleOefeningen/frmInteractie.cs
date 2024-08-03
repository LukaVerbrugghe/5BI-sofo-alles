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
    public partial class frmInteractie : Form
    {
        public frmInteractie()
        {
            InitializeComponent();
        }

        private void btnMessagebox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welkom in mijn programma!");
            MessageBox.Show("Nu met aangepaste titel!", "Dit is de titel");
            MessageBox.Show("En nu met aangepaste knoppen!", "Met knoppen", MessageBoxButtons.YesNoCancel);
            MessageBox.Show("En full option!", "Full option", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
        }

        private void btnInputbox_Click(object sender, EventArgs e)
        {
            Interaction.InputBox("Wat is je naam?", "Dit is zinloos");
            string strNaam = Interaction.InputBox("Wat is je naam?", "Invoer verplicht!");
            MessageBox.Show("Welkom " + strNaam + ".");
            lblNaam.Text = strNaam;
        }

        private void btnMsgb2_Click(object sender, EventArgs e)
        {
            DialogResult dlrAntwoord = MessageBox.Show("Hier word de keuze bijgehouden.", "Return value", MessageBoxButtons.YesNoCancel);
            lblMsgb2Waarde.Text = dlrAntwoord.ToString();
        }
    }
}
