namespace TestExo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.DiscoverBtn = new System.Windows.Forms.Button();
            this.IpManual = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.CheckUp = new System.Windows.Forms.Button();
            this.deviceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.deviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deviceBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // ListBox
            // 
            this.ListBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 22;
            this.ListBox.Location = new System.Drawing.Point(12, 12);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(1003, 246);
            this.ListBox.TabIndex = 0;
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // DiscoverBtn
            // 
            this.DiscoverBtn.Location = new System.Drawing.Point(13, 283);
            this.DiscoverBtn.Name = "DiscoverBtn";
            this.DiscoverBtn.Size = new System.Drawing.Size(174, 78);
            this.DiscoverBtn.TabIndex = 1;
            this.DiscoverBtn.Text = "Discovery";
            this.DiscoverBtn.UseVisualStyleBackColor = true;
            this.DiscoverBtn.Click += new System.EventHandler(this.DiscoverBtn_Click);
            // 
            // IpManual
            // 
            this.IpManual.Location = new System.Drawing.Point(12, 406);
            this.IpManual.Name = "IpManual";
            this.IpManual.Size = new System.Drawing.Size(174, 78);
            this.IpManual.TabIndex = 2;
            this.IpManual.Text = "Enter IP Address Manually";
            this.IpManual.UseVisualStyleBackColor = true;
            this.IpManual.Click += new System.EventHandler(this.button1_Click);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(209, 283);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Result.Size = new System.Drawing.Size(626, 201);
            this.Result.TabIndex = 3;
            this.Result.TextChanged += new System.EventHandler(this.Result_TextChanged);
            // 
            // CheckUp
            // 
            this.CheckUp.Enabled = false;
            this.CheckUp.Location = new System.Drawing.Point(841, 283);
            this.CheckUp.Name = "CheckUp";
            this.CheckUp.Size = new System.Drawing.Size(174, 78);
            this.CheckUp.TabIndex = 4;
            this.CheckUp.Text = "Launch Check Up";
            this.CheckUp.UseVisualStyleBackColor = true;
            this.CheckUp.Click += new System.EventHandler(this.CheckUp_Click);
            // 
            // deviceBindingSource1
            // 
            this.deviceBindingSource1.DataSource = typeof(TestExo.Device);
            // 
            // deviceBindingSource
            // 
            this.deviceBindingSource.DataSource = typeof(TestExo.Device);
            // 
            // deviceBindingSource2
            // 
            this.deviceBindingSource2.DataSource = typeof(TestExo.Device);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 524);
            this.Controls.Add(this.CheckUp);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.IpManual);
            this.Controls.Add(this.DiscoverBtn);
            this.Controls.Add(this.ListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Dragon Tools";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button DiscoverBtn;
        private System.Windows.Forms.Button IpManual;
        public System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button CheckUp;
        private System.Windows.Forms.BindingSource deviceBindingSource;
        private System.Windows.Forms.BindingSource deviceBindingSource1;
        private System.Windows.Forms.BindingSource deviceBindingSource2;
    }
}

