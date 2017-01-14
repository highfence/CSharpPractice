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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string helloWord = "안녕하세요";
        string loveWord = "사랑합니다";
        string exitWord; 

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(helloWord);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(loveWord);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exitWord = helloWord + " " + loveWord;
            MessageBox.Show(exitWord);
        }
    }
}
