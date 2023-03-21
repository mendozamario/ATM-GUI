using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_GUI
{
    public partial class ATM : Form
    {
        public ATM()
        {
            InitializeComponent();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            SetView("1");
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            SetView("2");
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            SetView("3");
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            SetView("4");
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            SetView("5");
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            SetView("6");
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            SetView("7");
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            SetView("8");
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            SetView("9");
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            SetView("0");
        }

        private void btnTripleZero_Click(object sender, EventArgs e)
        {
            SetView("000");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtView.Text = null;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            AtmResponse atmResponse;
            AtmLogic logic = new AtmLogic();
            atmResponse = logic.MoneyCalculate(int.Parse(txtView.Text));
            if (atmResponse.Error == true)
            {
                MessageBox.Show(atmResponse.Message, "Cantidad Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtTen.Text = atmResponse.Money[0].ToString();
                txtTwenty.Text = atmResponse.Money[1].ToString();
                txtFifty.Text = atmResponse.Money[2].ToString();
                txtOneHundred.Text = atmResponse.Money[3].ToString();
            }
        }

        public void SetView(string number)
        {
            string locale = txtView.Text;
            txtView.Text = locale + number;
        }
    }
}
