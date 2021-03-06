﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;


namespace TestExo
{
    public partial class Form1 : Form
    {
        public UDPDiscovery Discover;
        public string IpSelected, DevSelected, buf;
        public Socket tcp;



        public Form1()
        {
            InitializeComponent();
            Discover = new UDPDiscovery(ListBox);
            tcp = new Socket(this);


        }

        private void Form1_Load(object sender, EventArgs e)
        {


            Console.WriteLine("Debug Screen By Senseï Senzu.");
            this.AutoSize = true;



        }

        private void DiscoverBtn_Click(object sender, EventArgs e)
        {

            Discover.MaListeDevice.Clear();
            Discover.MesDevices.Clear();
            ListBox.DataSource = null;
            Discover.DiscoveryGo();

            ListBox.DataSource = Discover.MesDevices;
            //ListBox.DisplayMember = "dev";


            //Discover.Liste();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form2 = new Diagnostic();
            form2.Show();

        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {


            // Console.WriteLine(System.Net.Dns.GetHostAddresses().ToString());
            if (ListBox.SelectedIndex >= 0)
            {
                CheckUp.Enabled = true;

                Result.Text = String.Format("{0}\n\nAdresse: {1}", Discover.MesDevices[ListBox.SelectedIndex].name, Discover.MesDevices[ListBox.SelectedIndex].ip);

                IpSelected = Discover.MesDevices[ListBox.SelectedIndex].ip;
                DevSelected = Discover.MesDevices[ListBox.SelectedIndex].name;
                tcp.mydev = DevSelected;
                tcp.ipdev = IpSelected;

            }



        }

        private void CheckUp_Click(object sender, EventArgs e)
        {

            Console.WriteLine("Running CheckUp ... Please Wait ..");
            DiscoverBtn.Enabled = false;
            IpManual.Enabled = false;
            CheckUp.Enabled = false;
            
            if (tcp.SendCommandDev())
            {
                Console.WriteLine("Checkup Complete !");
                DiscoverBtn.Enabled = true;
                IpManual.Enabled = true;
                CheckUp.Enabled = true;


            }
            else {

                Console.WriteLine("Error while running Checkup ..");

                DiscoverBtn.Enabled = true;
                IpManual.Enabled = true;
                CheckUp.Enabled = true;

            }
            buf = Result.Text;


        }



        private void Result_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveAsDebugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string name = saveFileDialog1.FileName;


            File.WriteAllText(name, buf);

        }

        private void byeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void oupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuToolStripMenuItem.HideDropDown();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }














    }
}
