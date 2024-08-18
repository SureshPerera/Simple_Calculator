using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        double operant1,operant2;
        double result;

        
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (txtOperand1.Text + txtOperand2.Text != "")
            {
                btnAdd.Enabled = btnDivide.Enabled = btnMultiply.Enabled = btnSub.Enabled = true;
               
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
               operant1 = Convert.ToDouble(txtOperand1.Text);
                operant2 = Convert.ToDouble(txtOperand2.Text);
                result = operant1 + operant2;

                txtResult.Text = result.ToString(); 

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            try
            {
                result = operant1 - operant2;
                txtResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                result = operant1 * operant2;
                txtResult.Text = result.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtOperand1.Select();
           btnAdd.Enabled = btnDivide.Enabled = btnMultiply.Enabled=btnSub.Enabled= false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtEnter_Click(object sender, EventArgs e)
        {
            Focus();
        }

        private void txtOperand1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? txtOperand1.Text.Contains('.')==true : true))
            {
                e.Handled = true;

            }
        }

        private void txtOperand2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? txtOperand2.Text.Contains('.') == true : true))
            {
                e.Handled=true;

            }

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                result = operant1 / operant2;
                txtResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }
    }
}
