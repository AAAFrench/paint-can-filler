using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * Name: Aaron Audet
 * Student Number: 000367464
 * File Date: December 11, 2020
 * Program purpose: The purpose of this program is to display a bucket filling with paint of a color you chose
 * Statement of Authorship: I, Aaron Audet, 000367464 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
 */

namespace Lab5A
{
    public partial class Form1 : Form
    {
        private Graphics g;             // Allow Graphics
        private Pen p;                  // Used for making the bucket and the paint
        private SolidBrush b;           // This brush is for adding paint
        private SolidBrush bReset;      // This brush is for removing paint
        private Color c = Color.White;  // Makes default color white
        private int height = 399;       // Makes default paint height
        private bool reset = false;     // This is to tell us to clear the paint

        /// <summary>
        /// Sets the default configurations
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(form1_Paint);
            flowRate.Tick += new EventHandler(tick);
        }

        /// <summary>
        /// Sets default vaules and draws the container
        /// </summary>
        /// <param name="sender">Not used</param>
        /// <param name="e">Not Used</param>
        private void form1_Paint(object sender, PaintEventArgs e)
        {
            // Set values
            g = e.Graphics;
            p = new Pen(c);
            b = new SolidBrush(c);
            bReset = new SolidBrush(Color.Black);

            // Draw container
            g.DrawLine(p, 100, 290, 100, 400);
            g.DrawLine(p, 100, 400, 300, 400);
            g.DrawLine(p, 300, 400, 300, 290);
        }

        /// <summary>
        /// Exits the application
        /// </summary>
        /// <param name="sender">Not Used</param>
        /// <param name="e">Not Used</param>
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Handles changing the color
        /// </summary>
        /// <param name="sender">Not Used</param>
        /// <param name="e">Not Used</param>
        private void colorPick_Click(object sender, EventArgs e)
        {
            colorDialog.Color = c;
            colorDialog.ShowDialog();
            c = colorDialog.Color;
        }

        /// <summary>
        /// This handles any changes in the trackbar to change flow rate
        /// </summary>
        /// <param name="sender">Not Used</param>
        /// <param name="e">Not Used</param>
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if(reset)                   // If bucket is full, remove paint
            {
                g = this.CreateGraphics();

                g.FillRectangle(bReset, 101, 300, 199, 100);
                reset = false;
                height = 399;
            }
            
            if(trackBar1.Value == 0)    // If tap is off, stop tap and remove paint flow
            {
                flowRate.Enabled = false;
                g.FillRectangle(bReset, 125, 205, 20, height - 204);
            } else                      // Start timer and change flow rate
            {
                flowRate.Enabled = true;
                flowRate.Interval = 100 - (trackBar1.Value - 1) * (50 / 9);
            }
        }

        /// <summary>
        /// This method will fill the bucket every event call
        /// </summary>
        /// <param name="sender">Not Used</param>
        /// <param name="e">Not Used</param>
        private void tick(object sender, EventArgs e)
        {
            if (height < 300) // If bucket is full
            {
                g.FillRectangle(bReset, 125, 205, 20, height - 204);
                flowRate.Enabled = false;
                trackBar1.Value = 0;
                reset = true;
            } else           // If not then fill
            {
                g = this.CreateGraphics();

                g.DrawLine(p, 101, height, 299, height);        // Paint
                g.FillRectangle(b, 125, 205, 20, height - 204); // Tap
                height--;
            }
            
        }
    }
}
