using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;


namespace TestExo
{
    public partial class Form1 : Form
    {
        public UDPDiscovery Discover;
        public string IpSelected, DevSelected;

        public Form1()
        { 
            InitializeComponent();
            Discover = new UDPDiscovery( ListBox);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DiscoverBtn_Click(object sender, EventArgs e)
        {
            Discover.MaListeDevice.Clear();
            ListBox.DataSource = null;
            Discover.DiscoveryGo();
            // ListBox.Items.Clear();


            //ListBox.Text = "";
            ListBox.DataSource = Discover.MaListeDevice;

            CheckUp.Enabled = true;
            //Discover.Liste();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form2 = new Diagnostic();
            form2.Show();
            
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Result.Text = String.Format("{0} ||Adresse: {1}", Discover.MaListeDevice[ListBox.SelectedIndex], Discover.MaListeIpAddress[ListBox.SelectedIndex]);
            IpSelected = Discover.MaListeIpAddress[ListBox.SelectedIndex];
            DevSelected = Discover.MaListeDevice[ListBox.SelectedIndex];



        }

        private void CheckUp_Click(object sender, EventArgs e)
        {
            Result.Text = "Waiting CheckUp running ... ";
          
          

        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }

        

      
       
        

      

       
    }
}
