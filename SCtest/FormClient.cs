using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCtest
{
    public partial class FormClient : Form
    {
        Socket client;
        public FormClient()
        {
            InitializeComponent();
            textBox_port.Text = "11000";
        }

        /// <summary>
        /// UDP连接
        /// </summary>
        public void UDPConnect()
        {
            client = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        }

        /// <summary>
        /// 连接到服务器
        /// </summary>
        public void AsyncConnect()
        {
            try
            {
                button_con.Enabled = false;

                //端口及IP
                IPEndPoint ipe = new IPEndPoint(IPAddress.Parse(textBox_ip.Text), int.Parse(textBox_port.Text));
                //创建套接字
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //开始连接到服务器
                client.BeginConnect(ipe, asyncResult =>
                {
                    client.EndConnect(asyncResult);
                    //向服务器发送消息
                    //AsyncSend(client, "你好我是客户端");
                    //接受消息
                    AsyncReceive(client);
                }, null);
            }
            catch (Exception ex)
            {
                button_con.Enabled = true;
            }
        }

        /// <summary>
        /// UDP发送消息
        /// </summary>
        /// <param name="socket"></param>
        /// <param name="message"></param>
        public void UDPSend(Socket socket,string message)
        {
            var ip = textBox_ip.Text;
            var port = textBox_port.Text;
            IPAddress broadcast = IPAddress.Parse(ip);

            byte[] sendbuf = Encoding.ASCII.GetBytes(message);
            IPEndPoint ep = new IPEndPoint(broadcast, Convert.ToInt32(port));

            socket.SendTo(sendbuf, ep);
        }

        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="socket"></param>
        /// <param name="message"></param>
        public void AsyncSend(Socket socket, string message)
        {
            if (socket == null || message == string.Empty) return;
            //编码
            byte[] data = Encoding.UTF8.GetBytes(message);
            try
            {
                setText(message);
                socket.BeginSend(data, 0, data.Length, SocketFlags.None, asyncResult =>
                {
                    //完成发送消息
                    int length = socket.EndSend(asyncResult);
                }, null);
            }
            catch (Exception ex)
            {
                setText("发送失败！");
            }
        }

        /// <summary>
        /// 接收消息
        /// </summary>
        /// <param name="socket"></param>
        public void AsyncReceive(Socket socket)
        {
            byte[] data = new byte[1024];
            try
            {

                //开始接收数据
                socket.BeginReceive(data, 0, data.Length, SocketFlags.None,
                asyncResult =>
                {
                    try
                    {
                        int length = socket.EndReceive(asyncResult);
                        setText(Encoding.UTF8.GetString(data));
                    }
                    catch (Exception)
                    {
                        AsyncReceive(socket);
                    }


                    AsyncReceive(socket);
                }, null);
            }
            catch (Exception ex)
            {
            }
        }

        private void setText(string str)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(() => setText(str)));
            }
            else
            {
                textBox_MSG.AppendText("\r\n" + DateTime.Now.ToString());
                textBox_MSG.AppendText("\r\n" + str);
                textBox_MSG.AppendText("\r\n");
            }
        }

        /// <summary>
        /// 向服务端发送信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_send_Click(object sender, EventArgs e)
        {
            var typestr = comboBox_type.Text;
            if (typestr == "TCP")
            {
                AsyncSend(client, textBox_send.Text);
            }
            else
            {
                UDPSend(client, textBox_send.Text);
            }           
        }
       

        /// <summary>
        /// 连接服务端
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_con_Click(object sender, EventArgs e)
        {
            button_con.Enabled = false;

            var contype = comboBox_type.Text;
            var ip = textBox_ip.Text;
            var port = textBox_port.Text;
            if (contype == "" || ip == "" || port == "")
            {
                MessageBox.Show("请先输入连接类型、IP和端口号");
                button_con.Enabled = true;
                return;
            }

            comboBox_type.Enabled = false;
            textBox_ip.ReadOnly = true;
            textBox_port.ReadOnly = true;
            textBox_MSG.ReadOnly = true;

            if (contype == "TCP")
            {
                AsyncConnect();
            }
            else
            {
                UDPConnect();
            }           
        }
    }
}
