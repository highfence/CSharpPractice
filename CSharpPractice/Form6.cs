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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Control control in this.panel1.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton rdBtn = control as RadioButton;
                    
                    if (rdBtn.Checked == true)
                    {
                        MessageBox.Show(rdBtn.Text);
                    }

                }
            }
        }
    }
}
