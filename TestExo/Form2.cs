﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestExo
{
    public partial class Diagnostic : Form1


     {

        public Socket mytcp;
        public Form1 Ui1;

        public Diagnostic()



        {



            InitializeComponent();
            mytcp = new Socket(Ui1);
            

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void BtnManualIpGO_Click_1(object sender, EventArgs e)
        {

            if (textBox1.TextLength>0)
            {

                

                

              
                Result.Text = mytcp.Connect(textBox1.Text, "ver -v\r");

            }
            else { MessageBox.Show("Veuillez saisir une adresse Valide.","Error",MessageBoxButtons.OK); }

        }

        

       
    }
}
