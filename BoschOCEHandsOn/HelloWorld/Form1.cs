using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using commlpiLib;

namespace HelloWorld
{
    public partial class Form1 : Form
    {

        MlpiConnection connection = new MlpiConnection();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Connect("192.168.1.103 -user=labview -password=labview2015");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (connection.IsConnected)
            {
                //var diag = connection.System.GetDisplayedDiagnosis().text;
                //label1.Text = diag; 

                //var axes = connection.Motion.GetConfiguredAxes();
                connection.System.SetTargetMode(SystemMode.SYSTEMMODE_BB);
                AxisInformation[] axisInfo = (AxisInformation[])connection.Motion.GetConfiguredAxes();

                foreach (var ax in axisInfo)
                {
                    
                    Console.WriteLine(ax.);
                }

            } 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection.Disconnect();
        }
    }
}
