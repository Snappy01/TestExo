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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsDebugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.deviceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.deviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deviceBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
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
            this.ListBox.Location = new System.Drawing.Point(12, 28);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(1003, 246);
            this.ListBox.TabIndex = 0;
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // DiscoverBtn
            // 
            this.DiscoverBtn.Location = new System.Drawing.Point(15, 291);
            this.DiscoverBtn.Name = "DiscoverBtn";
            this.DiscoverBtn.Size = new System.Drawing.Size(174, 78);
            this.DiscoverBtn.TabIndex = 1;
            this.DiscoverBtn.Text = "Discovery";
            this.DiscoverBtn.UseVisualStyleBackColor = true;
            this.DiscoverBtn.Click += new System.EventHandler(this.DiscoverBtn_Click);
            // 
            // IpManual
            // 
            this.IpManual.Location = new System.Drawing.Point(15, 442);
            this.IpManual.Name = "IpManual";
            this.IpManual.Size = new System.Drawing.Size(174, 78);
            this.IpManual.TabIndex = 2;
            this.IpManual.Text = "Enter IP Address Manually";
            this.IpManual.UseVisualStyleBackColor = true;
            this.IpManual.Click += new System.EventHandler(this.button1_Click);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(195, 291);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Result.Size = new System.Drawing.Size(640, 229);
            this.Result.TabIndex = 3;
            this.Result.TextChanged += new System.EventHandler(this.Result_TextChanged);
            // 
            // CheckUp
            // 
            this.CheckUp.Enabled = false;
            this.CheckUp.Location = new System.Drawing.Point(842, 291);
            this.CheckUp.Name = "CheckUp";
            this.CheckUp.Size = new System.Drawing.Size(174, 78);
            this.CheckUp.TabIndex = 4;
            this.CheckUp.Text = "Launch Check Up";
            this.CheckUp.UseVisualStyleBackColor = true;
            this.CheckUp.Click += new System.EventHandler(this.CheckUp_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1028, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsDebugToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // saveAsDebugToolStripMenuItem
            // 
            this.saveAsDebugToolStripMenuItem.Name = "saveAsDebugToolStripMenuItem";
            this.saveAsDebugToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.saveAsDebugToolStripMenuItem.Text = "Save as Debug ...";
            this.saveAsDebugToolStripMenuItem.Click += new System.EventHandler(this.saveAsDebugToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sureToolStripMenuItem,
            this.oupsToolStripMenuItem});
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // sureToolStripMenuItem
            // 
            this.sureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byeToolStripMenuItem});
            this.sureToolStripMenuItem.Name = "sureToolStripMenuItem";
            this.sureToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.sureToolStripMenuItem.Text = "Sure ?";
            // 
            // byeToolStripMenuItem
            // 
            this.byeToolStripMenuItem.Name = "byeToolStripMenuItem";
            this.byeToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.byeToolStripMenuItem.Text = "Bye :)";
            this.byeToolStripMenuItem.Click += new System.EventHandler(this.byeToolStripMenuItem_Click);
            // 
            // oupsToolStripMenuItem
            // 
            this.oupsToolStripMenuItem.Name = "oupsToolStripMenuItem";
            this.oupsToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.oupsToolStripMenuItem.Text = "Oups";
            this.oupsToolStripMenuItem.Click += new System.EventHandler(this.oupsToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
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
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1028, 524);
            this.Controls.Add(this.CheckUp);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.IpManual);
            this.Controls.Add(this.DiscoverBtn);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ProTools";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsDebugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byeToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

