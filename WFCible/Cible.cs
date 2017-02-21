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
        PointF location;
        int sizeOfCible;

        public Cible(PointF location, int sizeOfCible)
        {
            this.location = location;
            this.sizeOfCible = sizeOfCible;
        }

        public PointF Location
        {
            get { 
                return location; 
            }
            set { 
                location = value; 
            }
        }

        public int SizeOfCible
        {
            get { 
                return sizeOfCible;
            }
            set { 
                sizeOfCible = value; 
            }
        }

        public void Paint(object sender, PaintEventArgs e)
        {
            // cercle intérieur
            int sizeOfEllipse2 = sizeOfCible / 2;
            PointF locationEllipse2 = new PointF((sizeOfCible / 4)+location.X, (sizeOfCible / 4)+location.Y);

            // cercle au centre
            int sizeOfEllipse3 = sizeOfEllipse2 / 8;
            PointF locationEllipse3 = new PointF((sizeOfCible / 2 - sizeOfEllipse3 / 2)+location.X, (sizeOfCible / 2 - sizeOfEllipse3 / 2) + location.Y);


            e.Graphics.DrawEllipse(Pens.Red, new Rectangle(Point.Round(location), new Size(sizeOfCible, sizeOfCible)));
            e.Graphics.DrawEllipse(Pens.Red, new Rectangle(Point.Round(locationEllipse2), new Size(sizeOfEllipse2, sizeOfEllipse2)));
            e.Graphics.FillEllipse(Brushes.Red, new Rectangle(Point.Round(locationEllipse3), new Size(sizeOfEllipse3, sizeOfEllipse3)));

        }
    }
}
