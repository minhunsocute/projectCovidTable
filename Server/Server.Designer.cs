
namespace Server
{
    partial class Server
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textMessage = new Guna.UI2.WinForms.Guna2TextBox();
            this.textInfo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textIP = new Guna.UI2.WinForms.Guna2TextBox();
            this.ListClientIP = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnChange = new Guna.UI2.WinForms.Guna2Button();
            this.btnStart = new Guna.UI2.WinForms.Guna2Button();
            this.btnSend = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(315, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "SERVER";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label2.Location = new System.Drawing.Point(-9, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Message:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textMessage
            // 
            this.textMessage.BorderColor = System.Drawing.Color.Black;
            this.textMessage.BorderThickness = 2;
            this.textMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textMessage.DefaultText = "";
            this.textMessage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textMessage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textMessage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textMessage.DisabledState.Parent = this.textMessage;
            this.textMessage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textMessage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textMessage.FocusedState.Parent = this.textMessage;
            this.textMessage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textMessage.ForeColor = System.Drawing.Color.Black;
            this.textMessage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textMessage.HoverState.Parent = this.textMessage;
            this.textMessage.Location = new System.Drawing.Point(87, 338);
            this.textMessage.Name = "textMessage";
            this.textMessage.PasswordChar = '\0';
            this.textMessage.PlaceholderText = "";
            this.textMessage.SelectedText = "";
            this.textMessage.ShadowDecoration.Parent = this.textMessage;
            this.textMessage.Size = new System.Drawing.Size(347, 25);
            this.textMessage.TabIndex = 13;
            // 
            // textInfo
            // 
            this.textInfo.BorderColor = System.Drawing.Color.Black;
            this.textInfo.BorderThickness = 2;
            this.textInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textInfo.DefaultText = "";
            this.textInfo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textInfo.DisabledState.Parent = this.textInfo;
            this.textInfo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textInfo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textInfo.FocusedState.Parent = this.textInfo;
            this.textInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textInfo.ForeColor = System.Drawing.Color.Black;
            this.textInfo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textInfo.HoverState.Parent = this.textInfo;
            this.textInfo.Location = new System.Drawing.Point(87, 77);
            this.textInfo.Multiline = true;
            this.textInfo.Name = "textInfo";
            this.textInfo.PasswordChar = '\0';
            this.textInfo.PlaceholderForeColor = System.Drawing.Color.Black;
            this.textInfo.PlaceholderText = "";
            this.textInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textInfo.SelectedText = "";
            this.textInfo.ShadowDecoration.Parent = this.textInfo;
            this.textInfo.Size = new System.Drawing.Size(347, 242);
            this.textInfo.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.Location = new System.Drawing.Point(1, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Server:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textIP
            // 
            this.textIP.BorderColor = System.Drawing.Color.Black;
            this.textIP.BorderThickness = 2;
            this.textIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textIP.DefaultText = "192.168.1.13:9000";
            this.textIP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textIP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textIP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textIP.DisabledState.Parent = this.textIP;
            this.textIP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textIP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textIP.FocusedState.Parent = this.textIP;
            this.textIP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textIP.ForeColor = System.Drawing.Color.Black;
            this.textIP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textIP.HoverState.Parent = this.textIP;
            this.textIP.Location = new System.Drawing.Point(87, 46);
            this.textIP.Name = "textIP";
            this.textIP.PasswordChar = '\0';
            this.textIP.PlaceholderForeColor = System.Drawing.Color.Black;
            this.textIP.PlaceholderText = "";
            this.textIP.SelectedText = "";
            this.textIP.SelectionStart = 17;
            this.textIP.ShadowDecoration.Parent = this.textIP;
            this.textIP.Size = new System.Drawing.Size(347, 25);
            this.textIP.TabIndex = 10;
            // 
            // ListClientIP
            // 
            this.ListClientIP.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.ListClientIP.FormattingEnabled = true;
            this.ListClientIP.ItemHeight = 25;
            this.ListClientIP.Location = new System.Drawing.Point(449, 62);
            this.ListClientIP.Name = "ListClientIP";
            this.ListClientIP.Size = new System.Drawing.Size(297, 304);
            this.ListClientIP.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label4.Location = new System.Drawing.Point(460, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Client IP";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label5.Location = new System.Drawing.Point(1, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Activity:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnChange
            // 
            this.btnChange.BorderRadius = 11;
            this.btnChange.BorderThickness = 2;
            this.btnChange.CheckedState.Parent = this.btnChange;
            this.btnChange.CustomImages.Parent = this.btnChange;
            this.btnChange.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChange.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChange.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChange.DisabledState.Parent = this.btnChange;
            this.btnChange.FillColor = System.Drawing.Color.Cyan;
            this.btnChange.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChange.ForeColor = System.Drawing.Color.Black;
            this.btnChange.HoverState.Parent = this.btnChange;
            this.btnChange.Image = global::Server.Properties.Resources.gear;
            this.btnChange.Location = new System.Drawing.Point(634, 381);
            this.btnChange.Name = "btnChange";
            this.btnChange.ShadowDecoration.Parent = this.btnChange;
            this.btnChange.Size = new System.Drawing.Size(112, 47);
            this.btnChange.TabIndex = 21;
            this.btnChange.Text = "Change Table";
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnStart
            // 
            this.btnStart.BorderRadius = 11;
            this.btnStart.BorderThickness = 2;
            this.btnStart.CheckedState.Parent = this.btnStart;
            this.btnStart.CustomImages.Parent = this.btnStart;
            this.btnStart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStart.DisabledState.Parent = this.btnStart;
            this.btnStart.FillColor = System.Drawing.Color.Cyan;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.HoverState.Parent = this.btnStart;
            this.btnStart.Image = global::Server.Properties.Resources.admin;
            this.btnStart.Location = new System.Drawing.Point(279, 381);
            this.btnStart.Name = "btnStart";
            this.btnStart.ShadowDecoration.Parent = this.btnStart;
            this.btnStart.Size = new System.Drawing.Size(101, 47);
            this.btnStart.TabIndex = 16;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSend
            // 
            this.btnSend.BorderRadius = 11;
            this.btnSend.BorderThickness = 2;
            this.btnSend.CheckedState.Parent = this.btnSend;
            this.btnSend.CustomImages.Parent = this.btnSend;
            this.btnSend.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSend.DisabledState.Parent = this.btnSend;
            this.btnSend.FillColor = System.Drawing.Color.Cyan;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSend.ForeColor = System.Drawing.Color.Black;
            this.btnSend.HoverState.Parent = this.btnSend;
            this.btnSend.Image = global::Server.Properties.Resources.right_arrow;
            this.btnSend.Location = new System.Drawing.Point(102, 381);
            this.btnSend.Name = "btnSend";
            this.btnSend.ShadowDecoration.Parent = this.btnSend;
            this.btnSend.Size = new System.Drawing.Size(107, 47);
            this.btnSend.TabIndex = 15;
            this.btnSend.Text = "Send";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(783, 459);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ListClientIP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.textInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textIP);
            this.Name = "Server";
            this.Text = "TCP/IP Server";
            this.Load += new System.EventHandler(this.Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnStart;
        private Guna.UI2.WinForms.Guna2Button btnSend;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox textMessage;
        private Guna.UI2.WinForms.Guna2TextBox textInfo;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox textIP;
        private System.Windows.Forms.ListBox ListClientIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnChange;
    }
}

