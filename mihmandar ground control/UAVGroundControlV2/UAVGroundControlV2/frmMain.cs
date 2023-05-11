using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.IO.Ports;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;

namespace UAVGroundControlV2
{
    public partial class frmMain : Form
    {


        string[] portlar = SerialPort.GetPortNames();
        public frmMain()
        {
            InitializeComponent();
            
        }
        
        private void frmMain_Load(object sender, EventArgs e)
        {

            /* Add available COM ports to dropdown */
            

            foreach (string port in portlar)
            {
                comboBox1.Items.Add(port);
                comboBox1.SelectedIndex = 0;
            }
            comboBox2.Items.Add("4800");
            comboBox2.Items.Add("9600");
            comboBox2.SelectedIndex = 1;
            label15.Text="Bağlantı kapalı";

        }







        private void groupBox2_Enter(object sender, EventArgs e)
        {
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gMapControl1.Dock = DockStyle.Fill;
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            double lat, lon;
            lat = 37.86596;
            lon = 32.42007;
            gMapControl1.Position = new PointLatLng(lat, lon);
            gMapControl1.Zoom = 25;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbCOMPorts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                string sonuc = serialPort1.ReadExisting();
                string[] olcu = sonuc.Split('*');


                label5.Text = olcu[0];
            
                label6.Text = olcu[1] ;
                label7.Text = olcu[2] ;
                label8.Text = olcu[3] ;
                label11.Text = olcu[4] ;
                label12.Text = olcu[5] ;

                serialPort1.DiscardInBuffer();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                timer1.Stop();
                   
                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            serialPort1.DiscardInBuffer();
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
                label15.Text = "Bağlantı kapalı";
            }







        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (serialPort1.IsOpen == false)
            {
                if (comboBox1.Text == "")
                    return;
                serialPort1.PortName = comboBox1.Text;
                serialPort1.BaudRate = Convert.ToInt16(comboBox2.Text);
                try
                {
                    serialPort1.Open();
                    label15.Text = "Bağlantı Açık";
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Hata:" + hata.Message);
                } 
            }

            else

            {
                label15.Text = "Bağlantı Kuruldu";
            }

            }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen == true)
                serialPort1.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}



