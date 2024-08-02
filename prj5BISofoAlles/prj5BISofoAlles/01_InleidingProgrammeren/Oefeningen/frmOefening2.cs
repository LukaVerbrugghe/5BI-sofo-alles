using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj5BISofoAlles._01_InleidingProgrammeren.Oefeningen
{
    public partial class frmOefening2 : Form
    {
        public frmOefening2()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            frmOefening2Extra frmOefening2Extra = new frmOefening2Extra();
            frmOefening2Extra.ShowDialog();
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
