using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0903
{
    public partial class Form1 : Form
    { 
        
        int vx =rand.Next(-20, 21);
        int vy=rand.Next(-20,21);
        int point = 100;
        static Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            label1.Left=rand.Next(ClientSize.Width-label1.Size.Width);
            label1.Top=rand.Next(ClientSize.Height-label1.Size.Height);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Top += vy;
            label1.Left += vx;

            if (label1.Left < 0)
            {
                vx = Math.Abs(vx);
            }
            if (label1.Top < 0)
            {
                vy = Math.Abs(vy);
            }
            if (label1.Right > ClientSize.Width)
            {
                vx = -Math.Abs(vx);
            }
            if (label1.Bottom > ClientSize.Height) 
            {
                vy = -Math.Abs(vy);
            }

            Point mp = PointToClient(MousePosition);
            if ((mp.X >= label1.Left)
                && (mp.X < label1.Right)
                && (mp.Y >= label1.Top)
                && (mp.Y > label1.Bottom)
                )
                timer1.Enabled = false;
 

            
        }
    }
}
