using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace runningroad
{
    public partial class MainForm : Form
    {
        public int startx, starty, stopx, stopy, xx1, xx2, yy1, yy2, xx3, yy3, i, j, nn, choice1 = 1, choice2 = 4;
        public double xcenter, ycenter, a1, n, dzy, mply, x, z, dx, dz;

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            choice2 = 5;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            choice2 = 6;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            choice2 = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            choice2 = 4;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            choice1 = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            choice1 = 2;
        }

        public Pen myPen1 = new Pen(Color.White, 1);
        public Pen myPen2 = new Pen(Color.OrangeRed, 1);
        public Pen myPen3 = new Pen(Color.Yellow, 1);
        public Pen myPen;
        public Graphics g = null;

        public MainForm()
        {
            InitializeComponent();
        }

        public void MainForm_Load(object sender, EventArgs e)
        {
            a1 = 25.0;
            mply = 40.0;
            dz = 0.1;
        }

        public void trackBarOpacity_MouseUp(object sender, MouseEventArgs e)
        {
            MainForm.ActiveForm.Opacity = Convert.ToDouble(trackBarOpacity.Value) / 10;
            ActiveForm.Refresh();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            ActiveForm.Refresh();
        }

        public void trackBarDZ_MouseUp(object sender, MouseEventArgs e)
        {
            dz = Convert.ToDouble(trackBarDZ.Value) / 50;
        }

        public void trackBarDY_MouseUp(object sender, MouseEventArgs e)
        {
            dzy = Convert.ToDouble(trackBarDY.Value) * 10;
        }

        public void trackBarSize_MouseUp(object sender, MouseEventArgs e)
        {
            MainForm.ActiveForm.Width = trackBarSize.Value * 160;
            MainForm.ActiveForm.Height = trackBarSize.Value * 120;
            ActiveForm.Refresh();
        }

        private void buttonStartStop_MouseClick(object sender, MouseEventArgs e)
        {
            RunIt();
        }

        public void RunIt()
        {
            ActiveForm.Refresh();
            startx = 0;
            stopx = MainForm.ActiveForm.Width - 17;
            starty = 65;
            stopy = MainForm.ActiveForm.Height - 89;
            g = this.CreateGraphics();
            //Rectangle r = new Rectangle(startx,starty,stopx,stopy);
            //g.DrawRectangle(myPen1, r);

            double[] hhor = new double[stopx];
            double[] lhor = new double[stopx];

            foreach (int ii in hhor)
            {
                hhor[ii] = Convert.ToDouble(-stopy);
                lhor[ii] = Convert.ToDouble(stopy);
            }
            xcenter = (Convert.ToDouble(stopx) - Convert.ToDouble(startx)) / 2.0 + 1.0;
            ycenter = (Convert.ToDouble(stopy) - Convert.ToDouble(starty)) * 4.0 / 3.6;

            n = 4.0 * Math.PI / dz + 1.0;
            dzy = 4.0 * Math.PI * Math.Cos(a1 * Math.PI / 180.0) / n;
            dx = 4.0 * Math.PI / Convert.ToDouble(stopx);
            nn = Convert.ToInt32(n);
            for (i = 1; i <= nn; i++)
            {
                z = 2.0 * Math.PI - dz * (Convert.ToDouble(i) - 1.0);
                x = -2.0 * Math.PI;
                xx1 = xpix(x, dx);
                yy1 = ypix(x, z, dzy, i, mply);
                if (yy1 > hhor[0]) { hhor[0] = yy1; }
                if (yy1 < lhor[0]) { lhor[0] = yy1; }

                for (j = 1; j < stopx; j++)
                {
                    x = -2.0 * Math.PI + Convert.ToDouble(j) * dx;
                    xx3 = xpix(x, dx);
                    yy3 = ypix(x, z, dzy, i, mply);
                    if (yy3 >= hhor[j])
                    {
                        hhor[j] = yy3;
                        myPen = myPen3;
                        mline(xx3, yy3);
                    }
                    if (yy3 <= lhor[j])
                    {
                        lhor[j] = yy3;
                        myPen = myPen2;
                        mline(xx3, yy3);
                    }
                    if ((yy3 < hhor[j]) && (yy3 > lhor[j]))
                    {
                        xx1 = Convert.ToInt32(xx3 + xcenter);
                        yy1 = Convert.ToInt32(ycenter - yy3);
                    }
                }
            }
        }

        public void mline(double xx, double yy)
        {
            xx2 = Convert.ToInt32(xx + xcenter);
            yy2 = Convert.ToInt32(ycenter - yy);
            drawchoice();
            //if ((yy1 <= stopy) && (yy1 >= starty) && (yy2 <= stopy) && (yy2 >= starty) && (xx1 <= stopx) && (xx1 >= startx) && (xx2 <= stopx) && (xx2 >= startx) && (xx1 != xx2) && (yy1 != yy2))
            //{ g.DrawLine(myPen, xx1, yy1, xx2, yy2); }
            //g.DrawLine(myPen, xx1, yy1, xx2, yy2);
            xx1 = xx2;
            yy1 = yy2;
        }

        public void drawchoice()
        {
            switch (choice1)
            {
                case 1:
                    g.DrawLine(myPen, xx1, yy1, xx2, yy2);
                break;

                case 2:
                    if ((yy1 <= stopy) && (yy1 >= starty) && (yy2 <= stopy) && (yy2 >= starty) && (xx1 <= stopx) && (xx1 >= startx) && (xx2 <= stopx) && (xx2 >= startx) && (xx1 != xx2) && (yy1 != yy2))
                    { g.DrawLine(myPen, xx1, yy1, xx2, yy2); }
                break;
            }
        }

        public double func(double x, double z, double dzy, int i)
        {
            double f;

            switch (choice2)
            {
                case 3:
                    f = 8.0 * Math.Cos(1.2 * Math.Cos(x * x + z * z)) / (Math.Sqrt(x * x + z * z) + 1.0) + dzy * Convert.ToDouble(i);
                    return (f);

                case 4:
                    f = 8.0 * Math.Cos(1.2 * Math.Sqrt(x * x + z * z)) / (Math.Sqrt(x * x + z * z) + 1.0) + dzy * Convert.ToDouble(i);
                    return (f);

                case 5:
                    f = 4.0 * Math.Sqrt(x * x * z * z) * (1.2 * Math.Cos(x * x + z * z)) / (Math.Sqrt(x * x + z * z) + 1.0) + dzy * Convert.ToDouble(i);
                    return (f);

                case 6:
                    f = 2.0 * Math.Sin(x * x * z * z) * (1.2 * Math.Cos(x * x + z * z)) / (Math.Sqrt(x * x + z * z) + 1.0) + dzy * Convert.ToDouble(i);
                    return (f);

                default:
                    f = 4.0 * Math.Sqrt(x *x*z*z)*(1.2 * Math.Cos(x * x + z * z)) / (Math.Sqrt(x * x + z * z) + 1.0) + dzy * Convert.ToDouble(i);
                    return (f);
            }
        }

        public int ypix(double x, double z, double dzy, int i, double mply)
        {
            int yp;
            yp = Convert.ToInt32(func(x, z, dzy, i) * mply);
            return (yp);
        }

        public int xpix(double x, double dx)
        {
            int xp;
            xp = Convert.ToInt32(x / dx);
            return (xp);
        }
    }
}