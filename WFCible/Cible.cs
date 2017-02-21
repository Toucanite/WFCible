using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFCible
{
    class Cible
    {
        Point location;
        int sizeOfCible;

        public Cible(Point location, int sizeOfCible)
        {
            this.location = location;
            this.sizeOfCible = sizeOfCible;
        }

        public void Paint(object sender, PaintEventArgs e)
        {
            // cercle intérieur
            Point locationEllipse2 = new Point(sizeOfCible / 4, sizeOfCible / 4);
            int sizeOfEllipse2 = sizeOfCible / 2;

            // cercle au centre
            
            int sizeOfEllipse3 = sizeOfEllipse2 / 4;
            Point locationEllipse3 = new Point(sizeOfCible / 2 - sizeOfEllipse3 / 2, sizeOfCible / 2 - sizeOfEllipse3 / 2);


            e.Graphics.DrawEllipse(Pens.Red, new Rectangle(location, new Size(sizeOfCible,sizeOfCible)));
            e.Graphics.DrawEllipse(Pens.Red, new Rectangle(locationEllipse2, new Size(sizeOfEllipse2, sizeOfEllipse2)));
            e.Graphics.DrawEllipse(Pens.Red, new Rectangle(locationEllipse3, new Size(sizeOfEllipse3, sizeOfEllipse3)));

        }
    }
}
