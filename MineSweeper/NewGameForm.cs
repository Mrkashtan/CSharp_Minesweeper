using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class NewGameForm : Form
    {
        public NewGameForm()
        {
            InitializeComponent();
        }

        MineSweeper.MainForm m_parent;

        //Coupled meh
        public void setParent(MineSweeper.MainForm parent)
        {
            m_parent = parent;
        }

        private void NewGame_Load(object sender, EventArgs e)
        {
            
        }

        private void bttn_start_Click(object sender, EventArgs e)
        {
            int diff = 0;
            if (rb_hard.Checked)
            {
                diff = 3;
            }
            else if (rb_medium.Checked)
            {
                diff = 2;
            }
            else
            {
                diff = 1;
            }

            m_parent.startGame(diff);

            Close();
        }

        private void rb_hard_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
