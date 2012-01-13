namespace CacheUtils
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
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.debug = new System.Windows.Forms.RichTextBox();
            this.SetButton = new System.Windows.Forms.Button();
            this.GetButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.statsButton = new System.Windows.Forms.Button();
            this.flushButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.clearDebugButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.tb_host = new System.Windows.Forms.TextBox();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(8, 3);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(100, 20);
            this.keyTextBox.TabIndex = 0;
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(8, 29);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(100, 20);
            this.valueTextBox.TabIndex = 1;
            // 
            // debug
            // 
            this.debug.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.debug.BackColor = System.Drawing.Color.Black;
            this.debug.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debug.ForeColor = System.Drawing.Color.Chartreuse;
            this.debug.Location = new System.Drawing.Point(3, 3);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(407, 579);
            this.debug.TabIndex = 2;
            this.debug.Text = "";
            // 
            // SetButton
            // 
            this.SetButton.Location = new System.Drawing.Point(8, 55);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(87, 24);
            this.SetButton.TabIndex = 6;
            this.SetButton.Text = "Set Value";
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // GetButton
            // 
            this.GetButton.Location = new System.Drawing.Point(114, 3);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(86, 24);
            this.GetButton.TabIndex = 7;
            this.GetButton.Text = "Get Value";
            this.GetButton.UseVisualStyleBackColor = true;
            this.GetButton.Click += new System.EventHandler(this.GetButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteServerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(143, 26);
            // 
            // deleteServerToolStripMenuItem
            // 
            this.deleteServerToolStripMenuItem.Name = "deleteServerToolStripMenuItem";
            this.deleteServerToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.deleteServerToolStripMenuItem.Text = "Delete Server";
            this.deleteServerToolStripMenuItem.Click += new System.EventHandler(this.DeleteServerToolStripMenuItemClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(4, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.clearDebugButton);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.debug);
            this.splitContainer1.Size = new System.Drawing.Size(655, 585);
            this.splitContainer1.SplitterDistance = 238;
            this.splitContainer1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Cache Actions";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.statsButton);
            this.panel4.Controls.Add(this.flushButton);
            this.panel4.Location = new System.Drawing.Point(12, 245);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(209, 72);
            this.panel4.TabIndex = 21;
            // 
            // statsButton
            // 
            this.statsButton.Location = new System.Drawing.Point(8, 41);
            this.statsButton.Name = "statsButton";
            this.statsButton.Size = new System.Drawing.Size(75, 23);
            this.statsButton.TabIndex = 20;
            this.statsButton.Text = "Cache Stats";
            this.statsButton.UseVisualStyleBackColor = true;
            this.statsButton.Click += new System.EventHandler(this.statsButton_Click);
            // 
            // flushButton
            // 
            this.flushButton.Location = new System.Drawing.Point(8, 12);
            this.flushButton.Name = "flushButton";
            this.flushButton.Size = new System.Drawing.Size(75, 23);
            this.flushButton.TabIndex = 19;
            this.flushButton.Text = "Flush Cache";
            this.flushButton.UseVisualStyleBackColor = true;
            this.flushButton.Click += new System.EventHandler(this.flushButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cache Query";
            // 
            // clearDebugButton
            // 
            this.clearDebugButton.Location = new System.Drawing.Point(140, 550);
            this.clearDebugButton.Name = "clearDebugButton";
            this.clearDebugButton.Size = new System.Drawing.Size(75, 23);
            this.clearDebugButton.TabIndex = 14;
            this.clearDebugButton.Text = "Clear";
            this.clearDebugButton.UseVisualStyleBackColor = true;
            this.clearDebugButton.Click += new System.EventHandler(this.clearDebugButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.deleteButton);
            this.panel2.Controls.Add(this.GetButton);
            this.panel2.Controls.Add(this.SetButton);
            this.panel2.Controls.Add(this.valueTextBox);
            this.panel2.Controls.Add(this.keyTextBox);
            this.panel2.Location = new System.Drawing.Point(12, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 83);
            this.panel2.TabIndex = 13;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(114, 56);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(86, 22);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // tb_host
            // 
            this.tb_host.Location = new System.Drawing.Point(8, 25);
            this.tb_host.Name = "tb_host";
            this.tb_host.Size = new System.Drawing.Size(180, 20);
            this.tb_host.TabIndex = 23;
            this.tb_host.Text = "localhost";
            // 
            // tb_port
            // 
            this.tb_port.Location = new System.Drawing.Point(8, 64);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(100, 20);
            this.tb_port.TabIndex = 24;
            this.tb_port.Text = "11211";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_host);
            this.panel1.Controls.Add(this.tb_port);
            this.panel1.Location = new System.Drawing.Point(12, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 100);
            this.panel1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Memcached Host";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Memcached Host";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Port";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 602);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Memcached Query Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox keyTextBox;
		private System.Windows.Forms.TextBox valueTextBox;
		private System.Windows.Forms.RichTextBox debug;
		private System.Windows.Forms.Button SetButton;
        private System.Windows.Forms.Button GetButton;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem deleteServerToolStripMenuItem;
		private System.Windows.Forms.Button clearDebugButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button statsButton;
		private System.Windows.Forms.Button flushButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_host;
        private System.Windows.Forms.TextBox tb_port;
	}
}

