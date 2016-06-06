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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile("курсач/W.jpg");
        }
    }
}
