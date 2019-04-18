namespace MyControlCenter_1
{
    partial class Form_main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.gb_select_connection = new System.Windows.Forms.GroupBox();
            this.rbtn_socket_connection = new System.Windows.Forms.RadioButton();
            this.rbtn_serial_connection = new System.Windows.Forms.RadioButton();
            this.btn_PID = new System.Windows.Forms.Button();
            this.btn_Engine_Parameter = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timCamera = new System.Windows.Forms.Timer(this.components);
            this.btnCamera = new System.Windows.Forms.Button();
            this.pbxCamera = new System.Windows.Forms.PictureBox();
            this.btnSocketconnect = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.gb_net_set = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tbxPort = new System.Windows.Forms.Label();
            this.tbxIPAdress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gb_com_set = new System.Windows.Forms.GroupBox();
            this.cbBaudrate = new System.Windows.Forms.ComboBox();
            this.cbSerialSelect = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tim_commu = new System.Windows.Forms.Timer(this.components);
            this.btnArm_open = new System.Windows.Forms.Button();
            this.btnArm_close = new System.Windows.Forms.Button();
            this.gb_contolmode = new System.Windows.Forms.GroupBox();
            this.ckb_Key = new System.Windows.Forms.CheckBox();
            this.ckb_PID = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gb_select_connection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCamera)).BeginInit();
            this.gb_net_set.SuspendLayout();
            this.gb_com_set.SuspendLayout();
            this.gb_contolmode.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_select_connection
            // 
            this.gb_select_connection.Controls.Add(this.rbtn_socket_connection);
            this.gb_select_connection.Controls.Add(this.rbtn_serial_connection);
            this.gb_select_connection.Location = new System.Drawing.Point(34, 28);
            this.gb_select_connection.Name = "gb_select_connection";
            this.gb_select_connection.Size = new System.Drawing.Size(424, 109);
            this.gb_select_connection.TabIndex = 1;
            this.gb_select_connection.TabStop = false;
            this.gb_select_connection.Text = "连接选择";
            // 
            // rbtn_socket_connection
            // 
            this.rbtn_socket_connection.AutoSize = true;
            this.rbtn_socket_connection.Location = new System.Drawing.Point(123, 38);
            this.rbtn_socket_connection.Name = "rbtn_socket_connection";
            this.rbtn_socket_connection.Size = new System.Drawing.Size(69, 22);
            this.rbtn_socket_connection.TabIndex = 1;
            this.rbtn_socket_connection.TabStop = true;
            this.rbtn_socket_connection.Text = "网口";
            this.rbtn_socket_connection.UseVisualStyleBackColor = true;
            // 
            // rbtn_serial_connection
            // 
            this.rbtn_serial_connection.AutoSize = true;
            this.rbtn_serial_connection.Location = new System.Drawing.Point(26, 38);
            this.rbtn_serial_connection.Name = "rbtn_serial_connection";
            this.rbtn_serial_connection.Size = new System.Drawing.Size(69, 22);
            this.rbtn_serial_connection.TabIndex = 0;
            this.rbtn_serial_connection.TabStop = true;
            this.rbtn_serial_connection.Text = "串口";
            this.rbtn_serial_connection.UseVisualStyleBackColor = true;
            // 
            // btn_PID
            // 
            this.btn_PID.Location = new System.Drawing.Point(180, 764);
            this.btn_PID.Name = "btn_PID";
            this.btn_PID.Size = new System.Drawing.Size(137, 37);
            this.btn_PID.TabIndex = 8;
            this.btn_PID.Text = "PID参数整定";
            this.btn_PID.UseVisualStyleBackColor = true;
            this.btn_PID.Click += new System.EventHandler(this.btn_PID_Click);
            // 
            // btn_Engine_Parameter
            // 
            this.btn_Engine_Parameter.Location = new System.Drawing.Point(48, 751);
            this.btn_Engine_Parameter.Name = "btn_Engine_Parameter";
            this.btn_Engine_Parameter.Size = new System.Drawing.Size(106, 63);
            this.btn_Engine_Parameter.TabIndex = 12;
            this.btn_Engine_Parameter.Text = "电机控制&&状态显示";
            this.btn_Engine_Parameter.UseVisualStyleBackColor = true;
            this.btn_Engine_Parameter.Click += new System.EventHandler(this.btn_Engine_Parameter_Click);
            // 
            // timCamera
            // 
            this.timCamera.Tick += new System.EventHandler(this.timCamera_Tick);
            // 
            // btnCamera
            // 
            this.btnCamera.Location = new System.Drawing.Point(62, 679);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.Size = new System.Drawing.Size(92, 36);
            this.btnCamera.TabIndex = 13;
            this.btnCamera.Text = "打开视频";
            this.btnCamera.UseVisualStyleBackColor = true;
            this.btnCamera.Click += new System.EventHandler(this.btnCamera_Click);
            // 
            // pbxCamera
            // 
            this.pbxCamera.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxCamera.BackgroundImage")));
            this.pbxCamera.Location = new System.Drawing.Point(480, 43);
            this.pbxCamera.Name = "pbxCamera";
            this.pbxCamera.Size = new System.Drawing.Size(882, 914);
            this.pbxCamera.TabIndex = 14;
            this.pbxCamera.TabStop = false;
            // 
            // btnSocketconnect
            // 
            this.btnSocketconnect.Location = new System.Drawing.Point(146, 129);
            this.btnSocketconnect.Name = "btnSocketconnect";
            this.btnSocketconnect.Size = new System.Drawing.Size(104, 34);
            this.btnSocketconnect.TabIndex = 18;
            this.btnSocketconnect.Text = "连接服务器";
            this.btnSocketconnect.UseVisualStyleBackColor = true;
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(146, 92);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(104, 44);
            this.btnSwitch.TabIndex = 17;
            this.btnSwitch.Text = "打开串口";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // gb_net_set
            // 
            this.gb_net_set.Controls.Add(this.textBox2);
            this.gb_net_set.Controls.Add(this.tbxPort);
            this.gb_net_set.Controls.Add(this.btnSocketconnect);
            this.gb_net_set.Controls.Add(this.tbxIPAdress);
            this.gb_net_set.Controls.Add(this.label9);
            this.gb_net_set.Location = new System.Drawing.Point(34, 314);
            this.gb_net_set.Name = "gb_net_set";
            this.gb_net_set.Size = new System.Drawing.Size(424, 178);
            this.gb_net_set.TabIndex = 16;
            this.gb_net_set.TabStop = false;
            this.gb_net_set.Text = "网络设置";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(132, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 28);
            this.textBox2.TabIndex = 3;
            // 
            // tbxPort
            // 
            this.tbxPort.AutoSize = true;
            this.tbxPort.Location = new System.Drawing.Point(7, 82);
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Size = new System.Drawing.Size(80, 18);
            this.tbxPort.TabIndex = 2;
            this.tbxPort.Text = "控制端口";
            // 
            // tbxIPAdress
            // 
            this.tbxIPAdress.Location = new System.Drawing.Point(132, 44);
            this.tbxIPAdress.Name = "tbxIPAdress";
            this.tbxIPAdress.Size = new System.Drawing.Size(204, 28);
            this.tbxIPAdress.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "IP地址";
            // 
            // gb_com_set
            // 
            this.gb_com_set.Controls.Add(this.cbBaudrate);
            this.gb_com_set.Controls.Add(this.cbSerialSelect);
            this.gb_com_set.Controls.Add(this.btnSwitch);
            this.gb_com_set.Controls.Add(this.label10);
            this.gb_com_set.Controls.Add(this.label11);
            this.gb_com_set.Location = new System.Drawing.Point(34, 157);
            this.gb_com_set.Name = "gb_com_set";
            this.gb_com_set.Size = new System.Drawing.Size(424, 142);
            this.gb_com_set.TabIndex = 15;
            this.gb_com_set.TabStop = false;
            this.gb_com_set.Text = "串口设置";
            // 
            // cbBaudrate
            // 
            this.cbBaudrate.FormattingEnabled = true;
            this.cbBaudrate.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "115200"});
            this.cbBaudrate.Location = new System.Drawing.Point(284, 41);
            this.cbBaudrate.Name = "cbBaudrate";
            this.cbBaudrate.Size = new System.Drawing.Size(68, 26);
            this.cbBaudrate.TabIndex = 5;
            // 
            // cbSerialSelect
            // 
            this.cbSerialSelect.FormattingEnabled = true;
            this.cbSerialSelect.Location = new System.Drawing.Point(100, 37);
            this.cbSerialSelect.Name = "cbSerialSelect";
            this.cbSerialSelect.Size = new System.Drawing.Size(68, 26);
            this.cbSerialSelect.TabIndex = 0;
            this.cbSerialSelect.DropDown += new System.EventHandler(this.cbSerialSelect_DropDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(202, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 18);
            this.label10.TabIndex = 1;
            this.label10.Text = "波特率";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "串口选择";
            // 
            // btnArm_open
            // 
            this.btnArm_open.Location = new System.Drawing.Point(51, 820);
            this.btnArm_open.Name = "btnArm_open";
            this.btnArm_open.Size = new System.Drawing.Size(109, 50);
            this.btnArm_open.TabIndex = 19;
            this.btnArm_open.Text = "机械臂开";
            this.btnArm_open.UseVisualStyleBackColor = true;
            this.btnArm_open.Click += new System.EventHandler(this.btnArm_open_Click);
            // 
            // btnArm_close
            // 
            this.btnArm_close.Location = new System.Drawing.Point(201, 820);
            this.btnArm_close.Name = "btnArm_close";
            this.btnArm_close.Size = new System.Drawing.Size(97, 50);
            this.btnArm_close.TabIndex = 20;
            this.btnArm_close.Text = "机械臂合";
            this.btnArm_close.UseVisualStyleBackColor = true;
            this.btnArm_close.Click += new System.EventHandler(this.btnArm_close_Click);
            // 
            // gb_contolmode
            // 
            this.gb_contolmode.Controls.Add(this.ckb_Key);
            this.gb_contolmode.Controls.Add(this.ckb_PID);
            this.gb_contolmode.Enabled = false;
            this.gb_contolmode.Location = new System.Drawing.Point(34, 533);
            this.gb_contolmode.Margin = new System.Windows.Forms.Padding(4);
            this.gb_contolmode.Name = "gb_contolmode";
            this.gb_contolmode.Padding = new System.Windows.Forms.Padding(4);
            this.gb_contolmode.Size = new System.Drawing.Size(424, 106);
            this.gb_contolmode.TabIndex = 21;
            this.gb_contolmode.TabStop = false;
            this.gb_contolmode.Text = "控制方式";
            // 
            // ckb_Key
            // 
            this.ckb_Key.AutoSize = true;
            this.ckb_Key.Location = new System.Drawing.Point(136, 40);
            this.ckb_Key.Margin = new System.Windows.Forms.Padding(4);
            this.ckb_Key.Name = "ckb_Key";
            this.ckb_Key.Size = new System.Drawing.Size(106, 22);
            this.ckb_Key.TabIndex = 0;
            this.ckb_Key.Text = "手柄控制";
            this.ckb_Key.UseVisualStyleBackColor = true;
            // 
            // ckb_PID
            // 
            this.ckb_PID.AutoSize = true;
            this.ckb_PID.Location = new System.Drawing.Point(28, 40);
            this.ckb_PID.Margin = new System.Windows.Forms.Padding(4);
            this.ckb_PID.Name = "ckb_PID";
            this.ckb_PID.Size = new System.Drawing.Size(97, 22);
            this.ckb_PID.TabIndex = 0;
            this.ckb_PID.Text = "PID控制";
            this.ckb_PID.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 952);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gb_contolmode);
            this.Controls.Add(this.btnArm_close);
            this.Controls.Add(this.btnArm_open);
            this.Controls.Add(this.gb_net_set);
            this.Controls.Add(this.gb_com_set);
            this.Controls.Add(this.pbxCamera);
            this.Controls.Add(this.btnCamera);
            this.Controls.Add(this.btn_Engine_Parameter);
            this.Controls.Add(this.btn_PID);
            this.Controls.Add(this.gb_select_connection);
            this.Name = "Form_main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_main_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.gb_select_connection.ResumeLayout(false);
            this.gb_select_connection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCamera)).EndInit();
            this.gb_net_set.ResumeLayout(false);
            this.gb_net_set.PerformLayout();
            this.gb_com_set.ResumeLayout(false);
            this.gb_com_set.PerformLayout();
            this.gb_contolmode.ResumeLayout(false);
            this.gb_contolmode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_select_connection;
        private System.Windows.Forms.RadioButton rbtn_socket_connection;
        private System.Windows.Forms.RadioButton rbtn_serial_connection;
        private System.Windows.Forms.Button btn_PID;
        private System.Windows.Forms.Button btn_Engine_Parameter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timCamera;
        private System.Windows.Forms.Button btnCamera;
        private System.Windows.Forms.PictureBox pbxCamera;
        private System.Windows.Forms.Button btnSocketconnect;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.GroupBox gb_net_set;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label tbxPort;
        private System.Windows.Forms.TextBox tbxIPAdress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gb_com_set;
        private System.Windows.Forms.ComboBox cbBaudrate;
        private System.Windows.Forms.ComboBox cbSerialSelect;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer tim_commu;
        private System.Windows.Forms.Button btnArm_open;
        private System.Windows.Forms.Button btnArm_close;
        private System.Windows.Forms.GroupBox gb_contolmode;
        private System.Windows.Forms.CheckBox ckb_Key;
        private System.Windows.Forms.CheckBox ckb_PID;
        private System.Windows.Forms.Button button1;
    }
}

