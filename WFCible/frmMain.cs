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
    public partial class frmMain : Form
    {

        Cible maCible = new Cible(new PointF(0,0), 100);

        public frmMain()
        {
            DoubleBuffered = true;
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            maCible.Paint(sender, e);
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            maCible.Location = new PointF(maCible.Location.X, vScrollBar1.Value);
            Invalidate();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            maCible.Location = new PointF(hScrollBar1.Value, maCible.Location.Y);
            Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void frmMain_ResizeEnd(object sender, EventArgs e)
        {
            vScrollBar1.Maximum = (sender as Form).Size.Height - hScrollBar1.Size.Height*3 - maCible.SizeOfCible;
            hScrollBar1.Maximum = (sender as Form).Size.Width - vScrollBar1.Size.Width*2 - maCible.SizeOfCible;
        }
    }
}
