using prj5BISofoAlles.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj5BISofoAlles._01_InleidingProgrammeren.Uitleg
{
    public partial class frmInleidingPdf : Form
    {
        int slideIndex = 0;

        public frmInleidingPdf()
        {
            InitializeComponent();
            checkButtons();
        }


        private void btnPreviousSlide_Click(object sender, EventArgs e)
        {
            slideIndex--;
            checkButtons();
            updatePic();
        }

        private void btnNextSlide_Click(object sender, EventArgs e)
        {
            slideIndex++;
            checkButtons();
            updatePic();
        }

        private void updatePic()
        {
            switch (slideIndex)
            {
                case 0:
                    picSlide.Image = Properties.Resources.Screenshot_2024_07_31_200642;
                    break;
                case 1:
                    picSlide.Image = Properties.Resources.Screenshot_2024_07_31_201802;
                    break;
                case 2:
                    picSlide.Image = Properties.Resources.Screenshot_2024_07_31_202046;
                    break;
                case 3:
                    picSlide.Image = Properties.Resources.Screenshot_2024_07_31_202235;
                    break;
                case 4:
                    picSlide.Image = Properties.Resources.Screenshot_2024_07_31_202429;
                    break;
                case 5:
                    picSlide.Image = Properties.Resources.Screenshot_2024_07_31_202519;
                    break;
                case 6:
                    picSlide.Image = Properties.Resources.Screenshot_2024_07_31_202608;
                    break;
                case 7:
                    picSlide.Image = Properties.Resources.Screenshot_2024_07_31_202652;
                    break;
                case 8:
                    picSlide.Image = Properties.Resources.Screenshot_2024_07_31_202753;
                    break;
                case 9:
                    picSlide.Image = Properties.Resources.Screenshot_2024_07_31_203215;
                    break;
                case 10:
                    picSlide.Image = Properties.Resources.Screenshot_2024_07_31_203309;
                    break;
                case 11:
                    picSlide.Image = Properties.Resources.Screenshot_2024_07_31_203318;
                    break;
                case 12:
                    picSlide.Image = Properties.Resources.Screenshot_2024_07_31_203324;
                    break;
                case 13:
                    picSlide.Image = Properties.Resources.Screenshot_2024_07_31_203331;
                    break;
                case 14:
                    picSlide.Image = Properties.Resources.Screenshot_2024_07_31_203338;
                    break;
                case 15:
                    picSlide.Image = Properties.Resources.Screenshot_2024_07_31_203343;
                    break;
                case 16:
                    picSlide.Image = Properties.Resources.Screenshot_2024_07_31_203352;
                    break;
                case 17:
                    picSlide.Image = Properties.Resources.Screenshot_2024_07_31_203406;
                    break;
                case 18:
                    picSlide.Image = Properties.Resources.Screenshot_2024_07_31_203413;
                    break;
                case 19:
                    picSlide.Image = Properties.Resources.Screenshot_2024_07_31_203508;
                    break;
                case 20:
                    picSlide.Image = Properties.Resources.Screenshot_2024_07_31_203515;
                    break;
                case 21:
                    picSlide.Image = Properties.Resources.Screenshot_2024_07_31_203521;
                    break;
                case 22:
                    picSlide.Image = Properties.Resources.Screenshot_2024_07_31_203528;
                    break;
                case 23:
                    picSlide.Image = Properties.Resources.Screenshot_2024_07_31_203534;
                    break;
                case 24:
                    picSlide.Image = Properties.Resources.Screenshot_2024_07_31_203539;
                    break;
                case 25:
                    picSlide.Image = Properties.Resources.Screenshot_2024_07_31_203547;
                    break;
                case 26:
                    picSlide.Image = Properties.Resources.Screenshot_2024_07_31_203554;
                    break;
                case 27:
                    picSlide.Image = Properties.Resources.Screenshot_2024_07_31_203602;
                    break;
                case 28:
                    picSlide.Image = Properties.Resources.Screenshot_2024_07_31_203609;
                    break;
                case 29:
                    picSlide.Image = Properties.Resources.Screenshot_2024_07_31_203615;
                    break;
                case 30:
                    picSlide.Image = Properties.Resources.Screenshot_2024_07_31_203622;
                    break;
                case 31:
                    picSlide.Image = Properties.Resources.Screenshot_2024_07_31_204911;
                    break;
                case 32:
                    picSlide.Image = Properties.Resources.Screenshot_2024_07_31_203639;
                    break;
                default:
                    break;
            }
        }


        private void checkButtons()
        {
            if (slideIndex == 0)
            {
                btnPreviousSlide.Enabled = false;
            }
            else
            {
                btnPreviousSlide.Enabled = true;
            }

            if (slideIndex == 33)
            {
                btnNextSlide.Enabled = false;
            }
            else
            {
                btnNextSlide.Enabled = true;
            }
        }
    }
}
