using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandData;
using System;
using System.IO.Ports;
using System.Windows.Forms;
using static MyControlCenter_1.Data;
using static MyControlCenter_1.ROV;
using static CommandData.Command;
using System.Net;
using System.Net.Sockets;
using System.IO;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Threading;


namespace MyControlCenter_1
{
    public partial class Form_main : Form
    {
        public static bool connectstatus = false;

        string CameraIp = "http://192.168.1.8:8080/?action=snapshot";
        Thread th;

        //public Form_PID Form_PID1;
        public static Form_PID Form_PID1 = null;

        public Form_main()
        {
            InitializeComponent();
        }

        string ControlIp;
        string Port;

        //InsRpmMeters insRpmMeters = new InsRpmMeters();//转速表

        private void main_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            CheckForIllegalCrossThreadCalls = false;

            th = new Thread(ReceiveMsg);

            ControlIp = tbxIPAdress.Text;
            Port = tbxPort.Text;
            pbxCamera.ImageLocation = CameraIp;
        }

        public bool KeyWdown;
        public bool KeyAdown;
        public bool KeySdown;
        public bool KeyDdown;
        public bool KeyLeftdown;
        public bool KeyRightdown;
        public bool KeyUpdown;
        public bool KeyDowndown;

        //socket接收
        public void ReceiveMsg()
        {
            while (true)
            {
                try
                {
                    byte[] receivedData = new byte[50];
                    int n = socketControl.Receive(receivedData);
                    for (int i = 0; i < n; i++)
                    {
                        Command_Handler((receivedData[i]));
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    break;
                }
            }
        }

        private void btn_PID_Click(object sender, EventArgs e)
        {
            //if (gb_select_connection.Enabled)
            //{
            //    MessageBox.Show("请先建立连接！", "连接未建立");
            //    return;
            //}

            if (Form_PID1 == null || Form_PID1.IsDisposed)
            {
                Form_PID1 = new Form_PID();
            }
            Form_PID1.Show();
        }

        private void btn_Engine_Parameter_Click(object sender, EventArgs e)
        {
            //if (gb_select_connection.Enabled)
            //{
            //    MessageBox.Show("请先建立连接！", "连接未建立");
            //    return;
            //}

            if (Form_Debug1 == null || Form_Debug1.IsDisposed)
            {
                Form_Debug1 = new Form_Engine_Parameter();
            }
            Form_Debug1.Show();
        }

        private void btnCamera_Click(object sender, EventArgs e)
        {
            if (btnCamera.Text == "打开视频")
            {
                btnCamera.Text = "关闭视频";
                timCamera.Enabled = true;
            }
            else
            {
                btnCamera.Text = "打开视频";
                timCamera.Enabled = false;
            }
        }

        private void timCamera_Tick(object sender, EventArgs e)
        {
            pbxCamera.ImageLocation = CameraIp;
        }

        //Thread th_receive;
        //Thread th_send;
        private void btnSwitch_Click(object sender, EventArgs e)
        {
            if (!sp1.IsOpen)
            {
                try
                {
                    //设置串口号
                    string serialName = cbSerialSelect.SelectedItem.ToString();
                    //sp1.PortName = serialName;
                    sp1.PortName = "COM3";
                    //sp1.BaudRate = Convert.ToInt32(cbBaudrate.SelectedItem);    //波特率
                    sp1.BaudRate = 115200;
                    sp1.DataBits = 8;       //数据位
                    sp1.StopBits = StopBits.One;
                    sp1.Parity = Parity.None;
                    if (sp1.IsOpen == true)//如果打开状态，则先关闭一下
                    {
                        sp1.Close();
                    }
                    sp1.DataReceived += new SerialDataReceivedEventHandler(sp1_DataReceived);
                    sp1.Open();     //打开串口
                    btnSwitch.Text = "关闭串口";
                    //th_receive = new Thread(sp1_DataReceived);
                    //th_receive.Start();

                    //设置数据读取超时为1秒
                    sp1.ReadTimeout = 1000;

                    cbSerialSelect.Enabled = false;
                    cbBaudrate.Enabled = false;
                    gb_select_connection.Enabled = false;
                    serialconnection = true;
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message, "Error");
                    cbSerialSelect.Enabled = true;
                    return;
                }
            }
            else
            {
                try
                {
                    tim_commu.Enabled = false;
                    cbSerialSelect.Enabled = true;
                    cbBaudrate.Enabled = true;
                    sp1.Close();                    //关闭串口
                    btnSwitch.Text = "打开串口";
                    gb_select_connection.Enabled = true;
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message, "Error");
                    return;
                }
            }
        }

        void sp1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (sp1.IsOpen)     //此处可能没有必要判断是否打开串口，但为了严谨性，我还是加上了
            {
                //string str = sp1.ReadExisting();
                //textBox1.AppendText(str);
                    byte[] byteRead = new byte[sp1.BytesToRead];    //BytesToRead:sp1接收的字符个数                                      //'发送16进制按钮'
                    {
                    Byte[] receivedData = new Byte[sp1.BytesToRead];        //创建接收字节数组
                    sp1.Read(receivedData, 0, receivedData.Length);         //读取数据
                    Console.WriteLine("接收区：");
                    foreach (byte b in receivedData)
                    {
                        Console.WriteLine(b);
                    }
                    sp1.DiscardInBuffer();                                  //清空SerialPort控件的接收Buffer
                    foreach (byte b in receivedData)
                    {
                        Command_Handler(b);
                    }
                }
            }
            else
            {
                MessageBox.Show("请打开某个串口", "错误提示");
            }
        }


        private void rbtn_select_connection_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_serial_connection.Checked == true)
            {
                gb_com_set.Enabled = true;
                gb_net_set.Enabled = false;
            }

            else
            {
                gb_com_set.Enabled = false;
                gb_net_set.Enabled = true;
            }
        }

        private void rbtn_socket_connection_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_socket_connection.Checked == true)
            {
                gb_com_set.Enabled = false;
                gb_net_set.Enabled = true;
            }
            else
            {
                gb_com_set.Enabled = true;
                gb_net_set.Enabled = false;
            }
        }

        private void cbSerialSelect_DropDown(object sender, EventArgs e)
        {
            if (sp1.IsOpen)
                return;
            cbSerialSelect.Items.Clear();
            string[] str = SerialPort.GetPortNames();
            if (str == null)
            {
                MessageBox.Show("本机没有串口！", "Error");
                return;
            }
            //添加串口项目
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {//获取有多少个COM口
                cbSerialSelect.Items.Add(s);
            }
            cbSerialSelect.SelectedIndex = cbSerialSelect.Items.Count - 1;
        }

        private void btnSocketconnect_Click(object sender, EventArgs e)
        {
            if (btnSocketconnect.Text == "连接服务器")
            {
                IPAddress ips = IPAddress.Parse(ControlIp);
                IPEndPoint ipe = new IPEndPoint(ips, Convert.ToInt32(Port.ToString()));//把ip和端口转化为IPEndPoint实例
                socketControl = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    socketControl.Connect(ipe);//连接到服务器
                    MessageBox.Show("连接到服务器");
                    gb_select_connection.Enabled = false;
                    serialconnection = false;
                    //gb_contolmode.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                th = new Thread(ReceiveMsg);
                th.IsBackground = true;
                th.Start();
                btnSocketconnect.Text = "断开服务器";
                tim_commu.Enabled = true;
            }
            else
            {
                th.Abort();

                socketControl.Close();
                btnSocketconnect.Text = "连接服务器";
                gb_select_connection.Enabled = true;
                //gb_contolmode.Enabled = false;
                tim_commu.Enabled = false;
            }
        }

      
        private void Form_main_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.W && (KeyWdown != true))
            {
                KeyWdown = true;
                //
                SendData(Startbit_Key, rov);
            }
            else if (e.KeyCode == Keys.S && (KeySdown != true))
            {
                KeySdown = true;
                //
                SendData(Startbit_Key, rov);

            }
            else if (e.KeyCode == Keys.A && (KeyAdown != true))
            {
                KeyAdown = true;
                //
                SendData(Startbit_Key, rov);

            }
            else if (e.KeyCode == Keys.D && (KeyDdown != true))
            {
                KeyDdown = true;
                //
                SendData(Startbit_Key, rov);

            }

            //摄像头旋转控制
            else if (e.KeyCode == Keys.Left && (KeyDdown != true))
            {
                KeyLeftdown = true;
                rov.Camera_angle += 40;
                SendData(Startbit_Camera, rov);
            }

            else if (e.KeyCode == Keys.Right && (KeyDdown != true))
            {
                KeyRightdown = true;
                rov.Camera_angle -= 40;
                SendData(Startbit_Camera, rov);
            }

            else if (e.KeyCode == Keys.Up && (KeyDdown != true))
            {
                KeyUpdown = true;
                rov.Camera_angle = 128;
                SendData(Startbit_Camera, rov);
            }
        }
        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        //Int16 test = 0;
        //private void Form_main_KeyUp(object sender, KeyEventArgs e)
        //{
        //    test++;
        //    labtest.Text = test.ToString();
        //    if (e.KeyCode == Keys.W || e.KeyCode == Keys.D || e.KeyCode == Keys.A || e.KeyCode == Keys.S || e.KeyCode == Keys.X || e.KeyCode == Keys.O || e.KeyCode == Keys.L)
        //    {

        //    }
        //    if (e.KeyCode == Keys.W && KeyWdown != false)
        //    {
        //        KeyWdown = false;
        //        CMD.ForwardSpeed = 0;
        //    }

        //    if (e.KeyCode == Keys.S && KeySdown != false)
        //    {
        //        KeySdown = false;
        //        CMD.ForwardSpeed = 0;
        //    }

        //    if (e.KeyCode == Keys.A && KeyAdown != false)
        //    {
        //        KeyAdown = false;
        //        CMD.YawSpeed = 0;
        //    }

        //    if (e.KeyCode == Keys.D && KeyDdown != false)
        //    {
        //        KeyDdown = false;
        //        CMD.YawSpeed = 0;
        //    }

        //    if (e.KeyCode == Keys.O && KeyOdown != false)
        //    {
        //        KeyOdown = false;
        //        CMD.UpdownSpeed = 0;
        //    }
        //    if (e.KeyCode == Keys.L && KeyLdown != false)
        //    {
        //        KeyLdown = false;
        //        CMD.UpdownSpeed = 0;
        //    }

        //    if (e.KeyCode == Keys.X && KeyXdown != false)
        //    {
        //        KeyXdown = false;
        //        CMD.UpdownSpeed = 0;
        //        CMD.ForwardSpeed = 0;
        //        CMD.YawSpeed = 0;

        //    }

        //    SendControlCMDToROV();

        //}

        private void btnArm_close_Click(object sender, EventArgs e)
        {

        }
        private void btnArm_open_Click(object sender, EventArgs e)
        {

        }

    }
    public static class Data
    {
        public static ROV rov = new ROV();
        public static SerialPort sp1 = new SerialPort();
        public static Form_Engine_Parameter Form_Debug1;
        //public static Form_PID Form_PID1;
        public static Form_PID Form_PID1 = null;
        public static bool serialconnection;
        public static IPAddress ips;
        public static IPEndPoint ipe;
        public static Socket socketControl = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        //发送数据
        public static void SendData(byte startbit, ROV rov)
        {
            byte[] TXData = DataToSendProcessor(startbit, rov);

            if (serialconnection == true)
            {
                try
                {
                    sp1.Write(TXData, 0, TXData.Length);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    sp1.Close();

                }
            }
            else
            {
                try
                {
                    socketControl.Send(TXData, TXData.Length, 0);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    socketControl.Close();
                }
            }
        }

    }
}
