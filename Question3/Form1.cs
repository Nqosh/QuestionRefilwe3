using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int [] arr= new int [1];

            int inputNumber = Convert.ToInt32(txtNumber.Text);

            if (inputNumber < 1)
            {
                MessageBox.Show("Your Input Number Must be Greater Than 0 ", "Error", MessageBoxButtons.OK);
                return;
            }
            var numbers = Enumerable.Range(1, inputNumber);
            int result = 0;
            int incrementer = 0;
            for(int i = 1; i < inputNumber; i++)
            {
                incrementer = i;
                incrementer++;
                if(i <= arr[0])
                {
                    result = arr[0] * incrementer;
                }
                else
                {
                    result = (i * incrementer);
                }
             
                arr[0] = result;
            }

            txtAnswer.Text = Convert.ToString(arr[0]);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = "";
            txtNumber.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
