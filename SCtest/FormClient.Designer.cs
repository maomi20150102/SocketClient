namespace SCtest
{
    partial class FormClient
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_send = new System.Windows.Forms.TextBox();
            this.textBox_MSG = new System.Windows.Forms.TextBox();
            this.button_send = new System.Windows.Forms.Button();
            this.button_con = new System.Windows.Forms.Button();
            this.label_ip = new System.Windows.Forms.Label();
            this.label_port = new System.Windows.Forms.Label();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_send
            // 
            this.textBox_send.Location = new System.Drawing.Point(50, 462);
            this.textBox_send.Name = "textBox_send";
            this.textBox_send.Size = new System.Drawing.Size(405, 31);
            this.textBox_send.TabIndex = 0;
            // 
            // textBox_MSG
            // 
            this.textBox_MSG.Location = new System.Drawing.Point(12, 109);
            this.textBox_MSG.Multiline = true;
            this.textBox_MSG.Name = "textBox_MSG";
            this.textBox_MSG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_MSG.Size = new System.Drawing.Size(752, 299);
            this.textBox_MSG.TabIndex = 1;
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(579, 462);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(161, 45);
            this.button_send.TabIndex = 2;
            this.button_send.Text = "发送";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.Button_send_Click);
            // 
            // button_con
            // 
            this.button_con.Location = new System.Drawing.Point(579, 20);
            this.button_con.Name = "button_con";
            this.button_con.Size = new System.Drawing.Size(185, 58);
            this.button_con.TabIndex = 3;
            this.button_con.Text = "连接服务器";
            this.button_con.UseVisualStyleBackColor = true;
            this.button_con.Click += new System.EventHandler(this.Button_con_Click);
            // 
            // label_ip
            // 
            this.label_ip.AutoSize = true;
            this.label_ip.Location = new System.Drawing.Point(12, 36);
            this.label_ip.Name = "label_ip";
            this.label_ip.Size = new System.Drawing.Size(53, 21);
            this.label_ip.TabIndex = 4;
            this.label_ip.Text = "IP：";
            // 
            // label_port
            // 
            this.label_port.AutoSize = true;
            this.label_port.Location = new System.Drawing.Point(352, 36);
            this.label_port.Name = "label_port";
            this.label_port.Size = new System.Drawing.Size(75, 21);
            this.label_port.TabIndex = 5;
            this.label_port.Text = "Port：";
            // 
            // textBox_ip
            // 
            this.textBox_ip.Location = new System.Drawing.Point(70, 36);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(251, 31);
            this.textBox_ip.TabIndex = 6;
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(442, 33);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(100, 31);
            this.textBox_port.TabIndex = 7;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 536);
            this.Controls.Add(this.textBox_port);
            this.Controls.Add(this.textBox_ip);
            this.Controls.Add(this.label_port);
            this.Controls.Add(this.label_ip);
            this.Controls.Add(this.button_con);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.textBox_MSG);
            this.Controls.Add(this.textBox_send);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormClient";
            this.Text = "Socket客户端";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_send;
        private System.Windows.Forms.TextBox textBox_MSG;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Button button_con;
        private System.Windows.Forms.Label label_ip;
        private System.Windows.Forms.Label label_port;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.TextBox textBox_port;
    }
}

