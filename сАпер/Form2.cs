using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace сАпер
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        сАпер.Form1 m_parent;
        public void setParent(сАпер.Form1 parent)
        {
            m_parent = parent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttNnewgame_Click(object sender, EventArgs e)
        {
            int diff = 0, clr = 0;
            if (radioButton3.Checked)
            {
                diff = 3;
            }
            else if (radioButton2.Checked)
            {
                diff = 2;
            }
            else
            {
                diff = 1;
            }
            
            if (radioButton4.Checked)
            {
                clr = 1;
            }
            else if (radioButton5.Checked)
            {
                clr = 2;
            }
            else
            {
                clr = 3;
            }


            m_parent.startGame(diff,clr);

            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
