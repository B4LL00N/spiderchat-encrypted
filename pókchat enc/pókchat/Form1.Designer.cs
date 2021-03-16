
namespace pókchat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbClientPort = new System.Windows.Forms.TextBox();
            this.tbClientIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbRecievingIP = new System.Windows.Forms.TextBox();
            this.tbRecievingPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbChat = new System.Windows.Forms.ListBox();
            this.tbChat = new System.Windows.Forms.TextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.btConnect = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbClientPort);
            this.groupBox1.Controls.Add(this.tbClientIP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client1";
            // 
            // tbClientPort
            // 
            this.tbClientPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.tbClientPort.ForeColor = System.Drawing.Color.White;
            this.tbClientPort.Location = new System.Drawing.Point(60, 42);
            this.tbClientPort.Name = "tbClientPort";
            this.tbClientPort.Size = new System.Drawing.Size(149, 23);
            this.tbClientPort.TabIndex = 3;
            // 
            // tbClientIP
            // 
            this.tbClientIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.tbClientIP.ForeColor = System.Drawing.Color.White;
            this.tbClientIP.Location = new System.Drawing.Point(60, 16);
            this.tbClientIP.Name = "tbClientIP";
            this.tbClientIP.Size = new System.Drawing.Size(149, 23);
            this.tbClientIP.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Local IP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbRecievingIP);
            this.groupBox2.Controls.Add(this.tbRecievingPort);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(233, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 71);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client2";
            // 
            // tbRecievingIP
            // 
            this.tbRecievingIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.tbRecievingIP.ForeColor = System.Drawing.Color.White;
            this.tbRecievingIP.Location = new System.Drawing.Point(68, 19);
            this.tbRecievingIP.Name = "tbRecievingIP";
            this.tbRecievingIP.Size = new System.Drawing.Size(144, 23);
            this.tbRecievingIP.TabIndex = 5;
            // 
            // tbRecievingPort
            // 
            this.tbRecievingPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.tbRecievingPort.ForeColor = System.Drawing.Color.White;
            this.tbRecievingPort.Location = new System.Drawing.Point(68, 45);
            this.tbRecievingPort.Name = "tbRecievingPort";
            this.tbRecievingPort.Size = new System.Drawing.Size(144, 23);
            this.tbRecievingPort.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Local IP";
            // 
            // lbChat
            // 
            this.lbChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.lbChat.ForeColor = System.Drawing.Color.White;
            this.lbChat.FormattingEnabled = true;
            this.lbChat.ItemHeight = 15;
            this.lbChat.Location = new System.Drawing.Point(12, 89);
            this.lbChat.Name = "lbChat";
            this.lbChat.Size = new System.Drawing.Size(472, 214);
            this.lbChat.TabIndex = 2;
            // 
            // tbChat
            // 
            this.tbChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.tbChat.ForeColor = System.Drawing.Color.White;
            this.tbChat.Location = new System.Drawing.Point(11, 310);
            this.tbChat.Name = "tbChat";
            this.tbChat.Size = new System.Drawing.Size(366, 23);
            this.tbChat.TabIndex = 3;
            // 
            // btSend
            // 
            this.btSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSend.ForeColor = System.Drawing.Color.White;
            this.btSend.Location = new System.Drawing.Point(384, 310);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(100, 23);
            this.btSend.TabIndex = 4;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // btConnect
            // 
            this.btConnect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btConnect.BackgroundImage")));
            this.btConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btConnect.Font = new System.Drawing.Font("Segoe UI", 3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btConnect.Location = new System.Drawing.Point(457, 12);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(36, 71);
            this.btConnect.TabIndex = 5;
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(496, 345);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.tbChat);
            this.Controls.Add(this.lbChat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(512, 384);
            this.MinimumSize = new System.Drawing.Size(512, 384);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pókchat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbClientPort;
        private System.Windows.Forms.TextBox tbClientIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbRecievingIP;
        private System.Windows.Forms.TextBox tbRecievingPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbChat;
        private System.Windows.Forms.TextBox tbChat;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Button btConnect;
    }
}

