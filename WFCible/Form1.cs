using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFCible
{
    public partial class Form1 : Form
    {

        Cible maCible = new Cible(new Point(0,0), 200);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            maCible.Paint(sender, e);
        }
    }
}
