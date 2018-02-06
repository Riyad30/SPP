using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace SeniorProject
{
    public partial class Form1 : Form
    {
        SerialPort port;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Height_Click(object sender, EventArgs e)
        {
            if (Height.Text == "Enter your height") {
                Height.Text = "";
            }
        }

        private void Weight_TextChanged(object sender, EventArgs e)
        {

        }

        private void Weight_Click(object sender, EventArgs e)
        {
            if (Weight.Text == "Press Get Weight") {
                Weight.Text = "";
            }
        }

        private void GetWeight_Click(object sender, EventArgs e)
        {
            try {
                
                port.Write("Weight");
                Weight.Text= port.ReadLine();

            } catch (Exception) {
                Error.Visible = true;
                if (DPort.SelectedItem == "COM3")
                {
                    ErrorM.Text = "Platform not connected";
                }
                else
                {
                    ErrorM.Text = "You must choose Device Port";
                }
            }
            
        }

        private void start_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
            
            if (DPort.SelectedItem == "COM3") {
                 port = new SerialPort(DPort.SelectedItem.ToString(),9600);
                try
                {
                    port.Open();

                }
                catch (Exception) {

                    Error.Visible = true;
                    ErrorM.Text = "Platform not connected";
                }

            }
        }
    }
}
