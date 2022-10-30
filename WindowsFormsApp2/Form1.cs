using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        
        int age, fee;
        string gender;
        public Form1()
        {
            InitializeComponent();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //gender take balue
            gender = "Man";
            radioButton2.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //取得數值
           

            int firstNumber;

            //取得第一個數值
            try
            {
                firstNumber = GetFirstNumber();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            age = int.Parse(textBox1.Text);
            //if age is less then equal to 3
            if (age <= 3)
            {
                fee = 0;
            }//if age is more than 3
            else
            {
                //Otherwise
                if (age <= 60 && string.Compare(gender, "Woman") == 0)
                {
                    fee = 15;
                    label6.Text = "全票";
                }

                // if age gender <= 70
                if (age <= 70 && String.Compare(gender, "Man") == 0)
                {
                    fee = 15;
                    label6.Text = "全票";
                }
                //if age gender >= 70 
                if (age >= 70 && string.Compare(gender, "Man") == 0)
                {
                    fee = 2;
                    label6.Text = "年紀超過70";
                }

                //if age woman >= 60
                if (age >= 60 && string.Compare(gender, "Woman") == 0)
                {
                    fee = 3;
                    label6.Text = "年紀超過60";
                }
            }
            label5.Text = fee.ToString();
            //if fee is 0
            if (fee == 0)
            {
                label6.Text = "3嵗以下不用付車費";
            }
            //else
            //{
            //    label6.Text = "";
            //}
        }
        private int GetFirstNumber()
        {
            TextBox txt = textBox1;
            string title = "第一個數字";

            return GetInt(txt, title);
        }
        private int  GetInt(TextBox control, string title)
        {
            string value = control.Text;
            bool isInt = int.TryParse(value, out int number);
            return isInt ? number : throw new Exception($"{title}必需填寫數值");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //gender take value
            gender = "Woman";
            radioButton1.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
