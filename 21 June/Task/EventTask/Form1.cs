using EventTask.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }
        Vehicle vehicle = new Vehicle();
        Timer timer = new Timer();
        bool start = false;
        int speed = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            vehicle.Marka = "Audi";
            vehicle.Model = "A4";
            vehicle.Hiz = 1;
            vehicle.SpeedEvents += Vehicle_SpeedEvents;
            timer.Interval = 50;
            timer.Tick += Timer_Tick;
            circularProgressBar1.Enabled = false;
        }

        private void Vehicle_SpeedEvents(int vites, Color color)
        {
            circularProgressBar1.SuperscriptText = vites.ToString();
            circularProgressBar1.ProgressColor= color;
            this.Text = $"Hiz:{speed} - Vites:{vites}";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (start)
            {
                speed++;
            }
            else 
            {
                speed--;
            }
            if (speed > 0 && speed <= 300) 
            {
                vehicle.Hiz= speed;
                circularProgressBar1.Value = speed;
                circularProgressBar1.Text = speed.ToString();
            }
            if (speed == 0) 
            {
                vehicle.Start = false;
                speed = 1;
                circularProgressBar1.Value = 0;
                circularProgressBar1.Text = "0";
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) { start = false; }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) 
            {
                start = true;
                timer.Start();
                
            }
        }
    }
}
