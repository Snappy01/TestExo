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
        public Socket tcp;
        public Form1()
        { 
            InitializeComponent();
            Discover = new UDPDiscovery( ListBox);
            tcp = new Socket();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DiscoverBtn_Click(object sender, EventArgs e)
        {
            Discover.MaListeDevice.Clear();
            Discover.MesDevices.Clear();
            ListBox.DataSource = null;
            Discover.DiscoveryGo();
            // ListBox.Items.Clear();


                //ListBox.Text = "";
                Console.WriteLine(Discover.MesDevices.Count);
                Console.WriteLine(Discover.MesDevices[0].dev);
                
                ListBox.DataSource = Discover.MesDevices;
                //ListBox.DisplayMember = "dev";
               
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

            Result.Text = String.Format("{0} ||Adresse: {1}", Discover.MesDevices[ListBox.SelectedIndex].dev, Discover.MesDevices[ListBox.SelectedIndex].ip);
            IpSelected = Discover.MesDevices[ListBox.SelectedIndex].ip;
            DevSelected = Discover.MesDevices[ListBox.SelectedIndex].dev;

            



        }

        private void CheckUp_Click(object sender, EventArgs e)
        {
            Result.Text = "Waiting CheckUp running ... ";
            Result.Text="[WHO]"+tcp.Connect(IpSelected, "who\r");
            Result.AppendText(Environment.NewLine + "********************************" + Environment.NewLine);
            Result.AppendText("[IP Table]"+tcp.Connect(IpSelected, "ipt\r"));
            Result.AppendText(Environment.NewLine + "********************************" + Environment.NewLine);
            Result.AppendText("[UP Time]"+tcp.Connect(IpSelected, "uptime\r"));
            Result.AppendText(Environment.NewLine + "********************************" + Environment.NewLine);

        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }

        

      
       
        

      

       
    }
}
