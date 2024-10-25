using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Reflection.Emit;
using Microsoft.SqlServer.Server;

namespace runningroad
{
    public partial class MainForm : Form
    {
        public delegate void EmptyMethodHandler();
        public int startx, starty, stopx, stopy, xx1, xx2, yy1, yy2, xx3, yy3, i, j, nn, buttonStartStop_State, trigger_Draw, choice1, choice2, pointnumber, mmmm;
        public double xcenter, ycenter, a1, n, dzy, mply, x, z, dx, dz;
        public const int arrmaxmemb = 3000000;
        public int[,] myArr = new int[arrmaxmemb, 2];

        enum btStartStop_State
        {
            Reset = 0,
            Start = 1,
            Abort = 2,
        }
        
        enum trDraw_State
        {
            Draw = 0,
            Abort = 1,
        }

        enum ch1_state
        {
            Solid = 0,
            Ghost = 1,
            Terminator = 2,
        }

        enum ch2_state
        {
            Func1 = 1,
            Func2 = 2,
            Func3 = 3,
            Func4 = 4,
        }

        public Pen myPen1 = new Pen(Color.DarkGoldenrod, 1);
        public Pen myPen2 = new Pen(Color.OrangeRed, 1);
        public Pen myPen3 = new Pen(Color.Gold, 1);
        public Pen myPen;

        public Graphics g = null;

        public Thread threadrunit;

        public MainForm()
        {
            InitializeComponent();
        }

        public void MainForm_Load(object sender, EventArgs e)
        {
            a1 = 25.0;
            mply = 40.0;
            dz = 0.1;

            choice1 = (int)ch1_state.Solid;
            choice2 = (int)ch2_state.Func1;

            buttonStartStop_State = (int)btStartStop_State.Start;
            trigger_Draw = (int)trDraw_State.Draw;
        }


        private void buttonStartStop_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonStartStop_MouseClick(null, null);
            }
        }

        private void buttonStartStop_MouseClick(object sender, MouseEventArgs e)
        {
            switch (buttonStartStop_State)
            {
                case (int)btStartStop_State.Start:
                    buttonStartStop_State = (int)btStartStop_State.Abort;
                    startx = 0;
                    stopx = this.ClientRectangle.Width;
                    starty = 0;
                    stopy = this.Height - ControlPanel.Height - (this.Height - this.ClientRectangle.Size.Height);
                    g = this.CreateGraphics();

                    if (!chBox_Array)
                    {
                        this.Refresh();
                        progressBar1.Value = 0;
                        pointnumber = 0;
                        mmmm = 0;
                        buttonStartStop.Text = "Instant drawing. Press to Abort";

                        threadrunit = new Thread(RunIt)
                        {
                            Priority = ThreadPriority.Normal
                        };
                        threadrunit.Start();
                    }
                    else
                    {
                        this.Refresh();
                        progressBar1.Value = 0;
                        pointnumber = 0;
                        mmmm = 0;
                        buttonStartStop.Text = "Drawing from array. Press to Abort";

                        threadrunit = new Thread(RunIt)
                        {
                            Priority = ThreadPriority.Normal
                        };
                        threadrunit.Start();
                    }
                    break;

                case (int)btStartStop_State.Abort:
                    buttonStartStop_State = (int)btStartStop_State.Reset;
                    threadrunit.Abort();
                    
                    buttonStartStop.Text = "Aborted. Press to Draw";
                    label4.Text = Convert.ToString(mmmm);

                    break;

                case (int)btStartStop_State.Reset:
                    label4.Text = "Count";
                    buttonStartStop.Text = "Press again to Draw";
                    buttonStartStop_State = (int)btStartStop_State.Start;
                    break;
            }
        }

        public void RunIt()
        {
            //Rectangle r = new Rectangle(startx,starty,stopx,stopy);
            //g.DrawRectangle(myPen1, r);
            //g.DrawEllipse(myPen3, 100, 100, 1, 1);

            int[] hhor = new int[stopx+1];
            int[] lhor = new int[stopx+1];

            xcenter = (Convert.ToDouble(stopx) - Convert.ToDouble(startx)) / 2.0 + 1.0;
            ycenter = (Convert.ToDouble(stopy) - Convert.ToDouble(starty)) / 2.0 + 150.0;

            for (i = 0; i < stopx + 1; i++)
            {
                hhor[i] = Convert.ToInt32(-stopy);
                lhor[i] = Convert.ToInt32(stopy);
            }

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
                if (yy1 > hhor[1]) { hhor[1] = yy1; }
                if (yy1 < lhor[1]) { lhor[1] = yy1; }

                for (j = 1; j <= stopx; j++)
                {
                    trigger_Draw = (int)trDraw_State.Draw;
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
                        myPen = myPen1;
                        mline(xx3, yy3);
                    }
                    if ((yy3 < hhor[j]) && (yy3 > lhor[j]))
                    {
                        xx1 = Convert.ToInt32(xx3 + xcenter);
                        yy1 = Convert.ToInt32(ycenter - yy3);
                        trigger_Draw = (int)trDraw_State.Abort;
                    }
                }
            }

            if (chBox_Array)
            {
                drawarrpoints();
            }

            BeginInvoke(new EmptyMethodHandler(delegate { label4.Text = Convert.ToString(mmmm); }));
            BeginInvoke(new EmptyMethodHandler(delegate { buttonStartStop.Text = "Finished. Press to Draw"; }));
            buttonStartStop_State = (int)btStartStop_State.Reset;
        }

        public void mline(double xx, double yy)
        {
            xx2 = Convert.ToInt32(xx + xcenter);
            yy2 = Convert.ToInt32(ycenter - yy);
            drawchoice();

            switch (trigger_Draw)
            {
                case (int)trDraw_State.Draw:
                    xx1 = xx2;
                    yy1 = yy2;
                    break;

                case (int)trDraw_State.Abort:
                    break;
            }
        }

        public void drawchoice()
        {
            int chchoice;
            chchoice = choice1;
            if (xx1 < 0) { choice1 = (int)ch1_state.Terminator; }
            if (xx2 < 0) { choice1 = (int)ch1_state.Terminator; }
            if (yy1 < 65) { choice1 = (int)ch1_state.Terminator; }
            if (yy2 < 65) { choice1 = (int)ch1_state.Terminator; }
            if (xx1 > stopx) { choice1 = (int)ch1_state.Terminator; }
            if (xx2 > stopx) { choice1 = (int)ch1_state.Terminator; }
            if (yy1 > stopy) { choice1 = (int)ch1_state.Terminator; }
            if (yy2 > stopy) { choice1 = (int)ch1_state.Terminator; }
            if ((xx1 == xx2) && (yy1 == yy2)) { choice1 = (int)ch1_state.Terminator; }
            
            switch (choice1)
            {
                case (int)ch1_state.Solid:
                    pointnumber += 1;
                    if (pointnumber < arrmaxmemb)
                    {
                        myArr[pointnumber, 0] = xx1;
                        myArr[pointnumber, 1] = yy1;
                        mmmm += 1;
                        if (!chBox_Array)
                        {
                            //g.DrawEllipse(myPen, xx1, yy1, 1, 0);
                            //g.DrawEllipse(myPen, xx2, yy2, 0, 1);
                            g.DrawLine(myPen, xx1, yy1, xx2, yy2);
                        }
                    }
                    break;

                case (int)ch1_state.Ghost:
                    if ((yy1 <= stopy) && (yy1 >= starty) && (yy2 <= stopy) && (yy2 >= starty) && (xx1 <= stopx) && (xx1 >= startx) && (xx2 <= stopx) && (xx2 >= startx) && (xx1 != xx2) && (yy1 != yy2))
                    {
                        pointnumber += 1;
                        if (pointnumber < arrmaxmemb)
                        {
                            myArr[pointnumber, 0] = xx1;
                            myArr[pointnumber, 1] = yy1;
                            mmmm += 1;
                            if (!chBox_Array)
                            {
                                //g.DrawEllipse(myPen, xx1, yy1, 1, 0);
                                //g.DrawEllipse(myPen, xx2, yy2, 0, 1);
                                g.DrawLine(myPen, xx1, yy1, xx2, yy2);
                            }
                        }
                    }
                    break;

                case (int)ch1_state.Terminator:
                    choice1 = chchoice;
                    break;
            }
        }

        public double func(double x, double z, double dzy, int i)
        {
            double f;

            switch (choice2)
            {
                case (int)ch2_state.Func1:
                    f = 8.0 * Math.Cos(1.2 * Math.Cos(x * x + z * z)) / (Math.Sqrt(x * x + z * z) + 1.0) + dzy * Convert.ToDouble(i);
                    return (f);

                case (int)ch2_state.Func2:
                    f = 8.0 * Math.Cos(1.2 * Math.Sqrt(x * x + z * z)) / (Math.Sqrt(x * x + z * z) + 1.0) + dzy * Convert.ToDouble(i);
                    return (f);

                case (int)ch2_state.Func3:
                    f = 4.0 * Math.Sqrt(x * x * z * z) * (1.2 * Math.Cos(x * x + z * z)) / (Math.Sqrt(x * x + z * z) + 1.0) + dzy * Convert.ToDouble(i);
                    return (f);

                case (int)ch2_state.Func4:
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

        public void drawarrpoints()
        {
            if (mmmm > arrmaxmemb) { mmmm = arrmaxmemb; }

            int maxY = myArr[0, 1];
            int minY = myArr[0, 1];
            for (i = 0; i < mmmm; i++)
            {
                if (maxY < myArr[i, 1])
                {
                    maxY = myArr[i, 1];
                }

                if (minY > myArr[i, 1])
                {
                    minY = myArr[i, 1];
                }
            }
            if (maxY > this.ClientRectangle.Height)
            {
                maxY = this.ClientRectangle.Height;
            }
            if (minY < this.ControlPanel.Height)
            {
                minY = this.ControlPanel.Height;
            }

            int rez = maxY - minY;
            int half_rez = 0;
            int Yappend = 0;
            if (rez > this.ClientRectangle.Height)
            {
                rez = this.ClientRectangle.Height;
            }
            half_rez = Convert.ToInt32((Convert.ToDouble(this.ClientRectangle.Height) - Convert.ToDouble(rez)) / 2.0);

            switch (Yadjust)
            {
                case 0:
                    Yappend = -rez;
                    break;
                case 1:
                    Yappend = -half_rez;
                    break;
                case 2:
                    Yappend = 0;
                    break;
                case 3:
                    Yappend = half_rez;
                    break;
                case 4:
                    Yappend = rez;
                    break;
            }

            xx2 = myArr[0, 0];
            yy2 = myArr[0, 1] + Yappend;
            g.DrawEllipse(myPen2, xx2, yy2, 1, 0);

            for (i = 0; i < mmmm; i++)
            {
                xx1 = myArr[i, 0];
                yy1 = myArr[i, 1] + Yappend;
                g.DrawEllipse(myPen2, xx1, yy1, 1, 0);
                BeginInvoke(new EmptyMethodHandler(delegate { progressBar1.Value = Convert.ToInt32(Convert.ToDouble(i) / Convert.ToDouble(mmmm) * 100.0); }));
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void trackBarOpacity_ValueChanged(object sender, EventArgs e)
        {
            this.Opacity = Convert.ToDouble(trackBarOpacity.Value) / 10.0;
        }

        public void trackBarOpacity_MouseUp(object sender, MouseEventArgs e)
        {
            this.Opacity = Convert.ToDouble(trackBarOpacity.Value) / 10.0;
        }

        private void trackBarDY_ValueChanged(object sender, EventArgs e)
        {
            mply = Convert.ToDouble(trackBarDY.Value) * 10.0;
        }

        public void trackBarDY_MouseUp(object sender, MouseEventArgs e)
        {
            mply = Convert.ToDouble(trackBarDY.Value) * 10.0;
        }

        int Yadjust = 2;
        private void trackBar_Yadjust_ValueChanged(object sender, EventArgs e)
        {
            Yadjust = trackBar_Yadjust.Value;
        }

        private void trackBar_Yadjust_MouseUp(object sender, MouseEventArgs e)
        {
            Yadjust = trackBar_Yadjust.Value;
        }

        private void trackBarDZ_ValueChanged(object sender, EventArgs e)
        {
            dz = Convert.ToDouble(trackBarDZ.Value) / 50.0;
        }

        public void trackBarDZ_MouseUp(object sender, MouseEventArgs e)
        {
            dz = Convert.ToDouble(trackBarDZ.Value) / 50.0;
        }

        public void trackBarSize_MouseUp(object sender, MouseEventArgs e)
        {
            this.Width = trackBarSize.Value * 160;
            this.Height = trackBarSize.Value * 120;
            this.Refresh();
        }

        private void trackBarSize_ValueChanged(object sender, EventArgs e)
        {
            this.Width = trackBarSize.Value * 160;
            this.Height = trackBarSize.Value * 120;
            this.Refresh();
        }

        bool chBox_Array = false;
        private void checkBox_Array_CheckedChanged(object sender, EventArgs e)
        {
            chBox_Array = !chBox_Array;
        }

        private void radioButton_Solid_CheckedChanged(object sender, EventArgs e)
        {
            choice1 = (int)ch1_state.Solid;
        }

        private void radioButton_Ghost_CheckedChanged(object sender, EventArgs e)
        {
            choice1 = (int)ch1_state.Ghost;
        }

        private void radioButton_Func1_CheckedChanged(object sender, EventArgs e)
        {
            choice2 = (int)ch2_state.Func1;
        }

        private void radioButton_Func2_CheckedChanged(object sender, EventArgs e)
        {
            choice2 = (int)ch2_state.Func2;
        }

        private void radioButton_Func3_CheckedChanged(object sender, EventArgs e)
        {
            choice2 = (int)ch2_state.Func3;
        }

        private void radioButton_Func4_CheckedChanged(object sender, EventArgs e)
        {
            choice2 = (int)ch2_state.Func4;
        }

    }
}