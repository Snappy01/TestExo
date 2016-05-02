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
            Discover.MaListe.Clear();
            ListBox.DataSource = null;
            Discover.DiscoveryGo();
            // ListBox.Items.Clear();


            //ListBox.Text = "";
            ListBox.DataSource = Discover.MaListe;

            //Discover.Liste();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form2 = new Diagnostic();
            form2.Show();
            
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(ListBox.SelectedIndex);

            Result.Text = Discover.MaListe[ListBox.SelectedIndex];


        }

      
       
        

      

       
    }
}
