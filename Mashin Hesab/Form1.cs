namespace Mashin_Hesab
{
    public partial class Form1 : Form
    {
        bool Plus = false, Minus = false, Zarb = false, Taghsim = false;

        double num1 = 1, num2 = 1;
        double fainal_num = 1;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void EnterNumber_Cleck(object sender, EventArgs e)
        {
            if (labscrin.Text == "0")
            {
                labscrin.Text = ((Button)sender).Text;
            }
            else
            {
                labscrin.Text += ((Button)sender).Text;
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(labscrin.Text);
            labscrin.Text = "0";
            Plus = true;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(labscrin.Text);
            labscrin.Text = "0";
            Minus = true;
        }

        private void btnZarb_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(labscrin.Text);
            labscrin.Text = "0";
            Zarb = true;
        }

        private void btnTaghsim_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(labscrin.Text);
            labscrin.Text = "0";
            Taghsim = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (Plus == true)
            {
                num2 = Convert.ToDouble(labscrin.Text);
                fainal_num = num1 + num2;
                labscrin.Text = Convert.ToString(fainal_num);
                Plus = false;
            }
           else if (Minus == true)
            {
                num2 = Convert.ToDouble(labscrin.Text);
                fainal_num = num1 - num2;
                labscrin.Text = Convert.ToString(fainal_num);
                Minus = false;
            }
         else  if (Zarb == true)
            {
                num2 = Convert.ToDouble(labscrin.Text);
                fainal_num = num1 * num2;
                labscrin.Text = Convert.ToString(fainal_num);
                Zarb = false;
            }
            if (Taghsim == true)
            {
                num2 = Convert.ToDouble(labscrin.Text);
                fainal_num = num1 / num2;
                labscrin.Text = Convert.ToString(fainal_num);
                Taghsim = false;
            }
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            labscrin.Text = labscrin.Text.Remove(labscrin.Text.Length - 1);

            if (labscrin.Text == "")
            {
                labscrin.Text += "0";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            labscrin.Text = "0";
            Plus = false;
            Minus = false;
            Zarb = false;
            Taghsim = false;
        }

        private void btnClearE_Click(object sender, EventArgs e)
        {
            labscrin.Text = "0";
            Plus = false;
            Minus = false;
            Zarb = false;
            Taghsim = false;
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            Double PM = Convert.ToDouble(labscrin.Text);
            labscrin.Text = Convert.ToString(-1 * PM);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn1x_Click(object sender, EventArgs e)
        {
            double n;
            n = Convert.ToDouble(1 / Convert.ToDouble(labscrin.Text));
            labscrin.Text = Convert.ToString(n);
        }

        private void btnDarsad_Click(object sender, EventArgs e)
        {
            double d;
            d = Convert.ToDouble(labscrin.Text) / Convert.ToDouble(100);
            labscrin.Text = Convert.ToString(d);
        }

        private void Tavan_Click(object sender, EventArgs e)
        {
            double t;
            t = Convert.ToDouble(labscrin.Text) * Convert.ToDouble(labscrin.Text);
            labscrin.Text = Convert.ToString(t);
        }

        private void btnFactoriaL_Click(object sender, EventArgs e)
        {
            int f = 0;
            f = Convert.ToInt32(labscrin.Text);
            int sum = 1;
            for (int i = f; i > 0; i--)
            {
                sum = sum * i;

            }
            labscrin.Text = Convert.ToString(sum);
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnDL_Cleck(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnLightMode_Click(object sender, EventArgs e)
        {
            BackColor = Color.White;
            labscrin.ForeColor = Color.Black;

            btnBackspace.BackColor = Color.White;
            btnBackspace.ForeColor = Color.Black;

            btnClear.BackColor = Color.White;
            btnClear.ForeColor = Color.Black;

            btnClearE.BackColor = Color.White;
            btnClearE.ForeColor = Color.Black;

            btnClose.ForeColor = Color.White;

            btnDarsad.BackColor = Color.White;
            btnDarsad.ForeColor = Color.Black;

            btnTaghsim.BackColor = Color.White;
            btnTaghsim.ForeColor = Color.Black;

            btn1x.BackColor = Color.White;
            btn1x.ForeColor = Color.Black;

            btnTavan.BackColor = Color.White;
            btnTavan.ForeColor = Color.Black;

            btnFactoriaL.BackColor = Color.White;
            btnFactoriaL.ForeColor = Color.Black;

            btnZarb.BackColor = Color.White;
            btnZarb.ForeColor = Color.Black;

            btn9.BackColor = Color.White;
            btn9.ForeColor = Color.Black;

            btn8.BackColor = Color.White;
            btn8.ForeColor = Color.Black;

            btn7.BackColor = Color.White;
            btn7.ForeColor = Color.Black;

            btnMinus.BackColor = Color.White;
            btnMinus.ForeColor = Color.Black;

            btn6.BackColor = Color.White;
            btn6.ForeColor = Color.Black;

            btn5.BackColor = Color.White;
            btn5.ForeColor = Color.Black;

            btn4.BackColor = Color.White;
            btn4.ForeColor = Color.Black;

            btnPlus.BackColor = Color.White;
            btnPlus.ForeColor = Color.Black;

            btn3.BackColor = Color.White;
            btn3.ForeColor = Color.Black;

            btn2.BackColor = Color.White;
            btn2.ForeColor = Color.Black;

            btn1.BackColor = Color.White;
            btn1.ForeColor = Color.Black;

            btnAshar.BackColor = Color.White;
            btnAshar.ForeColor = Color.Black;

            btn0.BackColor = Color.White;
            btn0.ForeColor = Color.Black;

            btnPlusMinus.BackColor = Color.White;
            btnPlusMinus.ForeColor = Color.Black;

            labMT.ForeColor = Color.Black;
            labMS.ForeColor = Color.Black;
            labMP.ForeColor = Color.Black;
            labMM.ForeColor = Color.Black;
            labMR.ForeColor = Color.Black;
            labMC.ForeColor = Color.Black;

            btnLightMode.BackColor = Color.White;
            btnLightMode.ForeColor = Color.Black;

            btnDarkMode.BackColor = Color.White;
            btnDarkMode.ForeColor = Color.Black;

            btnClose.BackColor = Color.White;
            btnClose.ForeColor = Color.Black;

        }

        private void btnEqual_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0)
            {
                if (labscrin.Text == "0")
                {
                    labscrin.Text = "0";
                }
                else
                {
                    labscrin.Text += "0";
                }
            }

            else if (e.KeyCode == Keys.NumPad1)
            {
                if (labscrin.Text == "0")
                {
                    labscrin.Text = "1";
                }
                else
                {
                    labscrin.Text += "1";
                }
            }

            else if (e.KeyCode == Keys.NumPad2)
            {
                if (labscrin.Text == "0")
                {
                    labscrin.Text = "2";
                }
                else
                {
                    labscrin.Text += "2";
                }
            }
            else if (e.KeyCode == Keys.NumPad3)
            {
                if (labscrin.Text == "0")
                {
                    labscrin.Text = "3";
                }
                else
                {
                    labscrin.Text += "3";
                }
            }

            else if (e.KeyCode == Keys.NumPad4)
            {
                if (labscrin.Text == "0")
                {
                    labscrin.Text = "4";
                }
                else
                {
                    labscrin.Text += "4";
                }
            }

            else if (e.KeyCode == Keys.NumPad5)
            {
                if (labscrin.Text == "0")
                {
                    labscrin.Text = "5";
                }
                else
                {
                    labscrin.Text += "5";
                }
            }

            else if (e.KeyCode == Keys.NumPad6)
            {
                if (labscrin.Text == "0")
                {
                    labscrin.Text = "6";
                }
                else
                {
                    labscrin.Text += "6";
                }
            }

            else if (e.KeyCode == Keys.NumPad7)
            {
                if (labscrin.Text == "0")
                {
                    labscrin.Text = "7";
                }
                else
                {
                    labscrin.Text += "7";
                }
            }

            else if (e.KeyCode == Keys.NumPad8)
            {
                if (labscrin.Text == "0")
                {
                    labscrin.Text = "8";
                }
                else
                {
                    labscrin.Text += "8";
                }
            }

            else if (e.KeyCode == Keys.NumPad9)
            {
                if (labscrin.Text == "0")
                {
                    labscrin.Text = "9";
                }
                else
                {
                    labscrin.Text += "9";
                }
            }
            else if (e.KeyCode == Keys.Back)
            {
                btnBackspace.PerformClick();
            }
            else if (e.KeyCode == Keys.Add)
            {
                btnPlus.PerformClick();
            }
            else if (e.KeyCode == Keys.Divide)
            {
                btnTaghsim.PerformClick();
            }
            else if (e.KeyCode == Keys.Multiply)
            {
                btnZarb.PerformClick();
            }
            else if (e.KeyCode == Keys.Subtract)
            {
                btnMinus.PerformClick();
            }
            else if (e.KeyCode == Keys.Decimal)
            {
                btnAshar.PerformClick();
            }
            else if (e.KeyCode == Keys.Return)
            {
                btnEqual.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btnClear.PerformClick();
            }
            else
            {
                MessageBox.Show("Meghdar  Shoma gheer Mojaz Hast! ");
            }
        }

        private void btnDarkMode_Click(object sender, EventArgs e)
        {
            BackColor = Color.Black;
            labscrin.ForeColor = Color.White;

            btnBackspace.BackColor = Color.Black;
            btnBackspace.ForeColor = Color.White;

            btnClear.BackColor = Color.Black;
            btnClear.ForeColor = Color.White;

            btnClearE.BackColor = Color.Black;
            btnClearE.ForeColor = Color.White;

            btnClose.ForeColor = Color.Black;

            btnDarsad.BackColor = Color.Black;
            btnDarsad.ForeColor = Color.White;

            btnTaghsim.BackColor = Color.Black;
            btnTaghsim.ForeColor = Color.White;

            btn1x.BackColor = Color.Black;
            btn1x.ForeColor = Color.White;

            btnTavan.BackColor = Color.Black;
            btnTavan.ForeColor = Color.White;

            btnFactoriaL.BackColor = Color.Black;
            btnFactoriaL.ForeColor = Color.White;

            btnZarb.BackColor = Color.Black;
            btnZarb.ForeColor = Color.White;

            btn9.BackColor = Color.Black;
            btn9.ForeColor = Color.White;

            btn8.BackColor = Color.Black;
            btn8.ForeColor = Color.White;

            btn7.BackColor = Color.Black;
            btn7.ForeColor = Color.White;

            btnMinus.BackColor = Color.Black;
            btnMinus.ForeColor = Color.White;

            btn6.BackColor = Color.Black;
            btn6.ForeColor = Color.White;

            btn5.BackColor = Color.Black;
            btn5.ForeColor = Color.White;

            btn4.BackColor = Color.Black;
            btn4.ForeColor = Color.White;

            btnPlus.BackColor = Color.Black;
            btnPlus.ForeColor = Color.White;

            btn3.BackColor = Color.Black;
            btn3.ForeColor = Color.White;

            btn2.BackColor = Color.Black;
            btn2.ForeColor = Color.White;

            btn1.BackColor = Color.Black;
            btn1.ForeColor = Color.White;

            btnAshar.BackColor = Color.Black;
            btnAshar.ForeColor = Color.White;

            btn0.BackColor = Color.Black;
            btn0.ForeColor = Color.White;

            btnPlusMinus.BackColor = Color.Black;
            btnPlusMinus.ForeColor = Color.White;

            labMT.ForeColor = Color.White;
            labMS.ForeColor = Color.White;
            labMP.ForeColor = Color.White;
            labMM.ForeColor = Color.White;
            labMR.ForeColor = Color.White;
            labMC.ForeColor = Color.White;

            btnLightMode.BackColor = Color.Black;
            btnLightMode.ForeColor = Color.White;

            btnDarkMode.BackColor = Color.Black;
            btnDarkMode.ForeColor = Color.White;

            btnClose.BackColor = Color.Black;
            btnClose.ForeColor = Color.White;
        }
    }
}
