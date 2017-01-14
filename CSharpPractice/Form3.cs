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

        int intVal1;
        int intVal2;

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != ""))
            {
                intVal1 = Convert.ToInt16(textBox1.Text);
                intVal2 = Convert.ToInt16(textBox2.Text);
                int resultVal = intVal1 + intVal2;

                MessageBox.Show(resultVal.ToString());
            }
        }
    }
}
