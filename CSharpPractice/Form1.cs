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

        string helloWord;
        string loveWord;
        string exitWord;

        private void button3_Click(object sender, EventArgs e)
        {
            helloWord = "안녕하세요";
            MessageBox.Show(helloWord);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loveWord = "사랑합니다.";
            MessageBox.Show(loveWord);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exitWord = "나갈까요?";
            MessageBox.Show(exitWord);
        }
    }
}
