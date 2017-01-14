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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int inputAge;
            inputAge = Convert.ToInt16(textBox1.Text);

            if (inputAge < 10)
            {
                MessageBox.Show("당신은 유년기 입니다.");
            }
            else if (inputAge < 20)
            {
                MessageBox.Show("당신은 질풍 노도의 시기");
            }
            else if (inputAge < 30)
            {
                MessageBox.Show("아직 젊네요.");
            }
            else
            {
                MessageBox.Show("껄껄껄");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string bloodtype = string.Empty;
            bloodtype = textBox4.Text.ToUpper();

            switch (bloodtype)
            {
                case "A":
                    MessageBox.Show("그렇군요!");
                    break;
                case "B":
                    MessageBox.Show("그렇군요!");
                    break;
                case "O":
                    MessageBox.Show("그렇군요!");
                    break;
                case "AB":
                    MessageBox.Show("그렇군요!");
                    break;
                default:
                    MessageBox.Show("장난치지 마세요.");
                    break;
            }

        }
    }
}
