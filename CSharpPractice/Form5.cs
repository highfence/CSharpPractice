using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpPractice
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        int[] score = new int[3];
        TextBox[] boxArr = new TextBox[3];

        private void button1_Click(object sender, EventArgs e)
        {
            score[0] = Convert.ToInt16(textBox1.Text);
            score[1] = Convert.ToInt16(textBox2.Text);
            score[2] = Convert.ToInt16(textBox3.Text);
            boxArr[0] = textBox1;
            boxArr[1] = textBox2;
            boxArr[2] = textBox3;


            for (int i = 0; i < 3; ++i)
            {
                boxArr[i].Text = CalculateGrade(score[i]);
            }

            return;
        }

        private string CalculateGrade(int score)
        {
            string returnText = string.Empty;
            if (score >= 90)
            {
                returnText = "수";
            }
            else if (score >= 80)
            {
                returnText = "우";
            }
            else if (score >= 70)
            {
                returnText = "미";
            }
            else
            {
                returnText = "가";
            }

            return returnText;
        }
    }
}
