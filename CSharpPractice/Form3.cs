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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        int koreanScore;
        int englishScore;
        int mathScore;

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != "") && (textBox3.Text != ""))
            {
                koreanScore = Convert.ToInt16(textBox1.Text);
                englishScore = Convert.ToInt16(textBox2.Text);
                mathScore = Convert.ToInt16(textBox3.Text);
                int resultVal = koreanScore + englishScore + mathScore;

                MessageBox.Show(resultVal.ToString());
            }
            else
            {
                MessageBox.Show("점수를 채워주세요.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != "") && (textBox3.Text != ""))
            {
                koreanScore = Convert.ToInt16(textBox1.Text);
                englishScore = Convert.ToInt16(textBox2.Text);
                mathScore = Convert.ToInt16(textBox3.Text);
                float resultVal = (koreanScore + englishScore + mathScore) / 3;

                MessageBox.Show(resultVal.ToString());
            }
            else
            {
                MessageBox.Show("점수를 채워주세요.");
            }
        }
    }
}
