namespace MyControlCenter_1
{
    partial class Form_Engine_Parameter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Engine_Parameter));
            this.gbparameter = new System.Windows.Forms.GroupBox();
            this.lbpara_gyroz = new System.Windows.Forms.Label();
            this.lbpara_gyroy = new System.Windows.Forms.Label();
            this.lbpara_gyrox = new System.Windows.Forms.Label();
            this.lbpara_roll = new System.Windows.Forms.Label();
            this.lbpara_pitch = new System.Windows.Forms.Label();
            this.gbengine_control = new System.Windows.Forms.GroupBox();
            this.btnstopall = new System.Windows.Forms.Button();
            this.btnengine_debug = new System.Windows.Forms.Button();
            this.lbengine4 = new System.Windows.Forms.Label();
            this.lbengine2 = new System.Windows.Forms.Label();
            this.lbengine3 = new System.Windows.Forms.Label();
            this.lbengine1 = new System.Windows.Forms.Label();
            this.tbengine4 = new System.Windows.Forms.TextBox();
            this.tbengine2 = new System.Windows.Forms.TextBox();
            this.tbengine3 = new System.Windows.Forms.TextBox();
            this.tbengine1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.hud = new MissionPlanner.Controls.HUD();
            this.lbengine5 = new System.Windows.Forms.Label();
            this.tbengine5 = new System.Windows.Forms.TextBox();
            this.lbengine6 = new System.Windows.Forms.Label();
            this.tbengine6 = new System.Windows.Forms.TextBox();
            this.aGauge1 = new AGaugeApp.AGauge();
            this.aGauge2 = new AGaugeApp.AGauge();
            this.aGauge3 = new AGaugeApp.AGauge();
            this.aGauge4 = new AGaugeApp.AGauge();
            this.aGauge5 = new AGaugeApp.AGauge();
            this.aGauge6 = new AGaugeApp.AGauge();
            this.gbparameter.SuspendLayout();
            this.gbengine_control.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbparameter
            // 
            this.gbparameter.Controls.Add(this.lbpara_gyroz);
            this.gbparameter.Controls.Add(this.lbpara_gyroy);
            this.gbparameter.Controls.Add(this.lbpara_gyrox);
            this.gbparameter.Controls.Add(this.lbpara_roll);
            this.gbparameter.Controls.Add(this.lbpara_pitch);
            this.gbparameter.Location = new System.Drawing.Point(36, 215);
            this.gbparameter.Margin = new System.Windows.Forms.Padding(4);
            this.gbparameter.Name = "gbparameter";
            this.gbparameter.Padding = new System.Windows.Forms.Padding(4);
            this.gbparameter.Size = new System.Drawing.Size(380, 190);
            this.gbparameter.TabIndex = 3;
            this.gbparameter.TabStop = false;
            this.gbparameter.Text = "状态显示";
            // 
            // lbpara_gyroz
            // 
            this.lbpara_gyroz.AutoSize = true;
            this.lbpara_gyroz.Location = new System.Drawing.Point(22, 141);
            this.lbpara_gyroz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbpara_gyroz.Name = "lbpara_gyroz";
            this.lbpara_gyroz.Size = new System.Drawing.Size(89, 18);
            this.lbpara_gyroz.TabIndex = 2;
            this.lbpara_gyroz.Text = "角速度z：";
            // 
            // lbpara_gyroy
            // 
            this.lbpara_gyroy.AutoSize = true;
            this.lbpara_gyroy.Location = new System.Drawing.Point(22, 114);
            this.lbpara_gyroy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbpara_gyroy.Name = "lbpara_gyroy";
            this.lbpara_gyroy.Size = new System.Drawing.Size(89, 18);
            this.lbpara_gyroy.TabIndex = 2;
            this.lbpara_gyroy.Text = "角速度y：";
            // 
            // lbpara_gyrox
            // 
            this.lbpara_gyrox.AutoSize = true;
            this.lbpara_gyrox.Location = new System.Drawing.Point(22, 89);
            this.lbpara_gyrox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbpara_gyrox.Name = "lbpara_gyrox";
            this.lbpara_gyrox.Size = new System.Drawing.Size(89, 18);
            this.lbpara_gyrox.TabIndex = 2;
            this.lbpara_gyrox.Text = "角速度x：";
            // 
            // lbpara_roll
            // 
            this.lbpara_roll.AutoSize = true;
            this.lbpara_roll.Location = new System.Drawing.Point(22, 65);
            this.lbpara_roll.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbpara_roll.Name = "lbpara_roll";
            this.lbpara_roll.Size = new System.Drawing.Size(80, 18);
            this.lbpara_roll.TabIndex = 2;
            this.lbpara_roll.Text = "横滚角：";
            // 
            // lbpara_pitch
            // 
            this.lbpara_pitch.AutoSize = true;
            this.lbpara_pitch.Location = new System.Drawing.Point(22, 40);
            this.lbpara_pitch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbpara_pitch.Name = "lbpara_pitch";
            this.lbpara_pitch.Size = new System.Drawing.Size(80, 18);
            this.lbpara_pitch.TabIndex = 2;
            this.lbpara_pitch.Text = "俯仰角：";
            // 
            // gbengine_control
            // 
            this.gbengine_control.Controls.Add(this.lbengine6);
            this.gbengine_control.Controls.Add(this.tbengine6);
            this.gbengine_control.Controls.Add(this.lbengine5);
            this.gbengine_control.Controls.Add(this.tbengine5);
            this.gbengine_control.Controls.Add(this.btnstopall);
            this.gbengine_control.Controls.Add(this.btnengine_debug);
            this.gbengine_control.Controls.Add(this.lbengine4);
            this.gbengine_control.Controls.Add(this.lbengine2);
            this.gbengine_control.Controls.Add(this.lbengine3);
            this.gbengine_control.Controls.Add(this.lbengine1);
            this.gbengine_control.Controls.Add(this.tbengine4);
            this.gbengine_control.Controls.Add(this.tbengine3);
            this.gbengine_control.Controls.Add(this.tbengine1);
            this.gbengine_control.Controls.Add(this.tbengine2);
            this.gbengine_control.Location = new System.Drawing.Point(36, 26);
            this.gbengine_control.Margin = new System.Windows.Forms.Padding(4);
            this.gbengine_control.Name = "gbengine_control";
            this.gbengine_control.Padding = new System.Windows.Forms.Padding(4);
            this.gbengine_control.Size = new System.Drawing.Size(400, 181);
            this.gbengine_control.TabIndex = 2;
            this.gbengine_control.TabStop = false;
            this.gbengine_control.Text = "电机控制";
            // 
            // btnstopall
            // 
            this.btnstopall.Location = new System.Drawing.Point(291, 30);
            this.btnstopall.Margin = new System.Windows.Forms.Padding(4);
            this.btnstopall.Name = "btnstopall";
            this.btnstopall.Size = new System.Drawing.Size(74, 30);
            this.btnstopall.TabIndex = 2;
            this.btnstopall.Text = "全停";
            this.btnstopall.UseVisualStyleBackColor = true;
            this.btnstopall.Click += new System.EventHandler(this.btnstopall_Click);
            // 
            // btnengine_debug
            // 
            this.btnengine_debug.Location = new System.Drawing.Point(291, 72);
            this.btnengine_debug.Margin = new System.Windows.Forms.Padding(4);
            this.btnengine_debug.Name = "btnengine_debug";
            this.btnengine_debug.Size = new System.Drawing.Size(74, 30);
            this.btnengine_debug.TabIndex = 2;
            this.btnengine_debug.Text = "调试";
            this.btnengine_debug.UseVisualStyleBackColor = true;
            this.btnengine_debug.Click += new System.EventHandler(this.btnengine_debug_Click);
            // 
            // lbengine4
            // 
            this.lbengine4.AutoSize = true;
            this.lbengine4.Location = new System.Drawing.Point(142, 76);
            this.lbengine4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbengine4.Name = "lbengine4";
            this.lbengine4.Size = new System.Drawing.Size(53, 18);
            this.lbengine4.TabIndex = 1;
            this.lbengine4.Text = "电机4";
            // 
            // lbengine2
            // 
            this.lbengine2.AutoSize = true;
            this.lbengine2.Location = new System.Drawing.Point(143, 37);
            this.lbengine2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbengine2.Name = "lbengine2";
            this.lbengine2.Size = new System.Drawing.Size(53, 18);
            this.lbengine2.TabIndex = 1;
            this.lbengine2.Text = "电机2";
            // 
            // lbengine3
            // 
            this.lbengine3.AutoSize = true;
            this.lbengine3.Location = new System.Drawing.Point(8, 78);
            this.lbengine3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbengine3.Name = "lbengine3";
            this.lbengine3.Size = new System.Drawing.Size(53, 18);
            this.lbengine3.TabIndex = 1;
            this.lbengine3.Text = "电机3";
            // 
            // lbengine1
            // 
            this.lbengine1.AutoSize = true;
            this.lbengine1.Location = new System.Drawing.Point(9, 36);
            this.lbengine1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbengine1.Name = "lbengine1";
            this.lbengine1.Size = new System.Drawing.Size(53, 18);
            this.lbengine1.TabIndex = 1;
            this.lbengine1.Text = "电机1";
            // 
            // tbengine4
            // 
            this.tbengine4.Location = new System.Drawing.Point(198, 72);
            this.tbengine4.Margin = new System.Windows.Forms.Padding(4);
            this.tbengine4.MaxLength = 4;
            this.tbengine4.Name = "tbengine4";
            this.tbengine4.Size = new System.Drawing.Size(60, 28);
            this.tbengine4.TabIndex = 0;
            // 
            // tbengine2
            // 
            this.tbengine2.Location = new System.Drawing.Point(198, 33);
            this.tbengine2.Margin = new System.Windows.Forms.Padding(4);
            this.tbengine2.MaxLength = 4;
            this.tbengine2.Name = "tbengine2";
            this.tbengine2.Size = new System.Drawing.Size(60, 28);
            this.tbengine2.TabIndex = 0;
            // 
            // tbengine3
            // 
            this.tbengine3.Location = new System.Drawing.Point(64, 74);
            this.tbengine3.Margin = new System.Windows.Forms.Padding(4);
            this.tbengine3.MaxLength = 4;
            this.tbengine3.Name = "tbengine3";
            this.tbengine3.Size = new System.Drawing.Size(60, 28);
            this.tbengine3.TabIndex = 0;
            // 
            // tbengine1
            // 
            this.tbengine1.Location = new System.Drawing.Point(64, 32);
            this.tbengine1.Margin = new System.Windows.Forms.Padding(4);
            this.tbengine1.MaxLength = 4;
            this.tbengine1.Name = "tbengine1";
            this.tbengine1.Size = new System.Drawing.Size(60, 28);
            this.tbengine1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // hud
            // 
            this.hud.airspeed = 0F;
            this.hud.alt = 0F;
            this.hud.altunit = null;
            this.hud.AOA = 0F;
            this.hud.BackColor = System.Drawing.Color.Black;
            this.hud.batterylevel = 0F;
            this.hud.batteryremaining = 0F;
            this.hud.bgimage = null;
            this.hud.connected = false;
            this.hud.critAOA = 25F;
            this.hud.critSSA = 30F;
            this.hud.current = 0F;
            this.hud.datetime = new System.DateTime(((long)(0)));
            this.hud.displayAOASSA = false;
            this.hud.disttowp = 0F;
            this.hud.distunit = null;
            this.hud.ekfstatus = 0F;
            this.hud.failsafe = false;
            this.hud.gpsfix = 0F;
            this.hud.gpsfix2 = 0F;
            this.hud.gpshdop = 0F;
            this.hud.gpshdop2 = 0F;
            this.hud.groundalt = 0F;
            this.hud.groundColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(184)))), ((int)(((byte)(36)))));
            this.hud.groundColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(79)))), ((int)(((byte)(7)))));
            this.hud.groundcourse = 0F;
            this.hud.groundspeed = 0F;
            this.hud.heading = 0F;
            this.hud.hudcolor = System.Drawing.Color.LightGray;
            this.hud.linkqualitygcs = 0F;
            this.hud.Location = new System.Drawing.Point(672, -16);
            this.hud.lowairspeed = false;
            this.hud.lowgroundspeed = false;
            this.hud.lowvoltagealert = false;
            this.hud.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hud.message = null;
            this.hud.messagetime = new System.DateTime(((long)(0)));
            this.hud.mode = "Manual";
            this.hud.Name = "hud";
            this.hud.navpitch = 0F;
            this.hud.navroll = 0F;
            this.hud.pitch = 0F;
            this.hud.roll = 0F;
            this.hud.Russian = false;
            this.hud.Size = new System.Drawing.Size(392, 289);
            this.hud.skyColor1 = System.Drawing.Color.Blue;
            this.hud.skyColor2 = System.Drawing.Color.LightBlue;
            this.hud.speedunit = null;
            this.hud.SSA = 0F;
            this.hud.status = false;
            this.hud.streamjpg = ((System.IO.MemoryStream)(resources.GetObject("hud.streamjpg")));
            this.hud.TabIndex = 23;
            this.hud.targetalt = 0F;
            this.hud.targetheading = 0F;
            this.hud.targetspeed = 0F;
            this.hud.turnrate = 0F;
            this.hud.verticalspeed = 0F;
            this.hud.vibex = 0F;
            this.hud.vibey = 0F;
            this.hud.vibez = 0F;
            this.hud.VSync = false;
            this.hud.wpno = 0;
            this.hud.xtrack_error = 0F;
            // 
            // lbengine5
            // 
            this.lbengine5.AutoSize = true;
            this.lbengine5.Location = new System.Drawing.Point(9, 121);
            this.lbengine5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbengine5.Name = "lbengine5";
            this.lbengine5.Size = new System.Drawing.Size(53, 18);
            this.lbengine5.TabIndex = 4;
            this.lbengine5.Text = "电机5";
            // 
            // tbengine5
            // 
            this.tbengine5.Location = new System.Drawing.Point(64, 117);
            this.tbengine5.Margin = new System.Windows.Forms.Padding(4);
            this.tbengine5.MaxLength = 4;
            this.tbengine5.Name = "tbengine5";
            this.tbengine5.Size = new System.Drawing.Size(60, 28);
            this.tbengine5.TabIndex = 3;
            // 
            // lbengine6
            // 
            this.lbengine6.AutoSize = true;
            this.lbengine6.Location = new System.Drawing.Point(143, 125);
            this.lbengine6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbengine6.Name = "lbengine6";
            this.lbengine6.Size = new System.Drawing.Size(53, 18);
            this.lbengine6.TabIndex = 6;
            this.lbengine6.Text = "电机6";
            // 
            // tbengine6
            // 
            this.tbengine6.Location = new System.Drawing.Point(198, 121);
            this.tbengine6.Margin = new System.Windows.Forms.Padding(4);
            this.tbengine6.MaxLength = 4;
            this.tbengine6.Name = "tbengine6";
            this.tbengine6.Size = new System.Drawing.Size(60, 28);
            this.tbengine6.TabIndex = 5;
            // 
            // aGauge1
            // 
            this.aGauge1.BackColor = System.Drawing.Color.Transparent;
            this.aGauge1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.aGauge1.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge1.BaseArcRadius = 80;
            this.aGauge1.BaseArcStart = 135;
            this.aGauge1.BaseArcSweep = 270;
            this.aGauge1.BaseArcWidth = 2;
            this.aGauge1.Cap_Idx = ((byte)(1));
            this.aGauge1.CapColor = System.Drawing.Color.Black;
            this.aGauge1.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge1.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge1.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge1.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge1.CapText = "";
            this.aGauge1.Center = new System.Drawing.Point(100, 100);
            this.aGauge1.Location = new System.Drawing.Point(672, 280);
            this.aGauge1.MaxValue = 400F;
            this.aGauge1.MinValue = -100F;
            this.aGauge1.Name = "aGauge1";
            this.aGauge1.Need_Idx = ((byte)(1));
            this.aGauge1.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGauge1.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge1.NeedleEnabled = false;
            this.aGauge1.NeedleRadius = 80;
            this.aGauge1.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.aGauge1.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.DimGray,
        System.Drawing.Color.DimGray,
        System.Drawing.Color.DimGray,
        System.Drawing.Color.DimGray};
            this.aGauge1.NeedlesEnabled = new bool[] {
        true,
        false,
        false,
        false};
            this.aGauge1.NeedlesRadius = new int[] {
        80,
        80,
        80,
        80};
            this.aGauge1.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.aGauge1.NeedlesWidth = new int[] {
        2,
        2,
        2,
        2};
            this.aGauge1.NeedleType = 0;
            this.aGauge1.NeedleWidth = 2;
            this.aGauge1.Range_Idx = ((byte)(0));
            this.aGauge1.RangeColor = System.Drawing.Color.LightGreen;
            this.aGauge1.RangeEnabled = true;
            this.aGauge1.RangeEndValue = 300F;
            this.aGauge1.RangeInnerRadius = 70;
            this.aGauge1.RangeOuterRadius = 80;
            this.aGauge1.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge1.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
            this.aGauge1.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.aGauge1.RangesInnerRadius = new int[] {
        70,
        70,
        70,
        70,
        70};
            this.aGauge1.RangesOuterRadius = new int[] {
        80,
        80,
        80,
        80,
        80};
            this.aGauge1.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.aGauge1.RangeStartValue = -100F;
            this.aGauge1.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesInterInnerRadius = 73;
            this.aGauge1.ScaleLinesInterOuterRadius = 80;
            this.aGauge1.ScaleLinesInterWidth = 1;
            this.aGauge1.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesMajorInnerRadius = 70;
            this.aGauge1.ScaleLinesMajorOuterRadius = 80;
            this.aGauge1.ScaleLinesMajorStepValue = 50F;
            this.aGauge1.ScaleLinesMajorWidth = 2;
            this.aGauge1.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge1.ScaleLinesMinorInnerRadius = 75;
            this.aGauge1.ScaleLinesMinorNumOf = 9;
            this.aGauge1.ScaleLinesMinorOuterRadius = 80;
            this.aGauge1.ScaleLinesMinorWidth = 1;
            this.aGauge1.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleNumbersFormat = null;
            this.aGauge1.ScaleNumbersRadius = 95;
            this.aGauge1.ScaleNumbersRotation = 0;
            this.aGauge1.ScaleNumbersStartScaleLine = 0;
            this.aGauge1.ScaleNumbersStepScaleLines = 1;
            this.aGauge1.Size = new System.Drawing.Size(150, 150);
            this.aGauge1.TabIndex = 28;
            this.aGauge1.Value = 0F;
            this.aGauge1.Value0 = 0F;
            this.aGauge1.Value1 = 0F;
            this.aGauge1.Value2 = 0F;
            this.aGauge1.Value3 = 0F;
            // 
            // aGauge2
            // 
            this.aGauge2.BackColor = System.Drawing.Color.Transparent;
            this.aGauge2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.aGauge2.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge2.BaseArcRadius = 80;
            this.aGauge2.BaseArcStart = 135;
            this.aGauge2.BaseArcSweep = 270;
            this.aGauge2.BaseArcWidth = 2;
            this.aGauge2.Cap_Idx = ((byte)(1));
            this.aGauge2.CapColor = System.Drawing.Color.Black;
            this.aGauge2.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge2.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge2.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge2.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge2.CapText = "";
            this.aGauge2.Center = new System.Drawing.Point(100, 100);
            this.aGauge2.Location = new System.Drawing.Point(828, 280);
            this.aGauge2.MaxValue = 400F;
            this.aGauge2.MinValue = -100F;
            this.aGauge2.Name = "aGauge2";
            this.aGauge2.Need_Idx = ((byte)(3));
            this.aGauge2.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGauge2.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge2.NeedleEnabled = false;
            this.aGauge2.NeedleRadius = 80;
            this.aGauge2.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.aGauge2.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.DimGray,
        System.Drawing.Color.DimGray,
        System.Drawing.Color.DimGray,
        System.Drawing.Color.DimGray};
            this.aGauge2.NeedlesEnabled = new bool[] {
        true,
        false,
        false,
        false};
            this.aGauge2.NeedlesRadius = new int[] {
        80,
        80,
        80,
        80};
            this.aGauge2.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.aGauge2.NeedlesWidth = new int[] {
        2,
        2,
        2,
        2};
            this.aGauge2.NeedleType = 0;
            this.aGauge2.NeedleWidth = 2;
            this.aGauge2.Range_Idx = ((byte)(0));
            this.aGauge2.RangeColor = System.Drawing.Color.LightGreen;
            this.aGauge2.RangeEnabled = true;
            this.aGauge2.RangeEndValue = 300F;
            this.aGauge2.RangeInnerRadius = 70;
            this.aGauge2.RangeOuterRadius = 80;
            this.aGauge2.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge2.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
            this.aGauge2.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.aGauge2.RangesInnerRadius = new int[] {
        70,
        70,
        70,
        70,
        70};
            this.aGauge2.RangesOuterRadius = new int[] {
        80,
        80,
        80,
        80,
        80};
            this.aGauge2.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.aGauge2.RangeStartValue = -100F;
            this.aGauge2.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleLinesInterInnerRadius = 73;
            this.aGauge2.ScaleLinesInterOuterRadius = 80;
            this.aGauge2.ScaleLinesInterWidth = 1;
            this.aGauge2.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleLinesMajorInnerRadius = 70;
            this.aGauge2.ScaleLinesMajorOuterRadius = 80;
            this.aGauge2.ScaleLinesMajorStepValue = 50F;
            this.aGauge2.ScaleLinesMajorWidth = 2;
            this.aGauge2.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge2.ScaleLinesMinorInnerRadius = 75;
            this.aGauge2.ScaleLinesMinorNumOf = 9;
            this.aGauge2.ScaleLinesMinorOuterRadius = 80;
            this.aGauge2.ScaleLinesMinorWidth = 1;
            this.aGauge2.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleNumbersFormat = null;
            this.aGauge2.ScaleNumbersRadius = 95;
            this.aGauge2.ScaleNumbersRotation = 0;
            this.aGauge2.ScaleNumbersStartScaleLine = 0;
            this.aGauge2.ScaleNumbersStepScaleLines = 1;
            this.aGauge2.Size = new System.Drawing.Size(150, 150);
            this.aGauge2.TabIndex = 29;
            this.aGauge2.Value = 0F;
            this.aGauge2.Value0 = 0F;
            this.aGauge2.Value1 = 0F;
            this.aGauge2.Value2 = 0F;
            this.aGauge2.Value3 = 0F;
            // 
            // aGauge3
            // 
            this.aGauge3.BackColor = System.Drawing.Color.Transparent;
            this.aGauge3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.aGauge3.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge3.BaseArcRadius = 80;
            this.aGauge3.BaseArcStart = 135;
            this.aGauge3.BaseArcSweep = 270;
            this.aGauge3.BaseArcWidth = 2;
            this.aGauge3.Cap_Idx = ((byte)(1));
            this.aGauge3.CapColor = System.Drawing.Color.Black;
            this.aGauge3.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge3.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge3.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge3.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge3.CapText = "";
            this.aGauge3.Center = new System.Drawing.Point(100, 100);
            this.aGauge3.Location = new System.Drawing.Point(984, 280);
            this.aGauge3.MaxValue = 400F;
            this.aGauge3.MinValue = -100F;
            this.aGauge3.Name = "aGauge3";
            this.aGauge3.Need_Idx = ((byte)(3));
            this.aGauge3.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGauge3.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge3.NeedleEnabled = false;
            this.aGauge3.NeedleRadius = 80;
            this.aGauge3.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.aGauge3.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.DimGray,
        System.Drawing.Color.DimGray,
        System.Drawing.Color.DimGray,
        System.Drawing.Color.DimGray};
            this.aGauge3.NeedlesEnabled = new bool[] {
        true,
        false,
        false,
        false};
            this.aGauge3.NeedlesRadius = new int[] {
        80,
        80,
        80,
        80};
            this.aGauge3.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.aGauge3.NeedlesWidth = new int[] {
        2,
        2,
        2,
        2};
            this.aGauge3.NeedleType = 0;
            this.aGauge3.NeedleWidth = 2;
            this.aGauge3.Range_Idx = ((byte)(0));
            this.aGauge3.RangeColor = System.Drawing.Color.LightGreen;
            this.aGauge3.RangeEnabled = true;
            this.aGauge3.RangeEndValue = 300F;
            this.aGauge3.RangeInnerRadius = 70;
            this.aGauge3.RangeOuterRadius = 80;
            this.aGauge3.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge3.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
            this.aGauge3.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.aGauge3.RangesInnerRadius = new int[] {
        70,
        70,
        70,
        70,
        70};
            this.aGauge3.RangesOuterRadius = new int[] {
        80,
        80,
        80,
        80,
        80};
            this.aGauge3.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.aGauge3.RangeStartValue = -100F;
            this.aGauge3.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge3.ScaleLinesInterInnerRadius = 73;
            this.aGauge3.ScaleLinesInterOuterRadius = 80;
            this.aGauge3.ScaleLinesInterWidth = 1;
            this.aGauge3.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge3.ScaleLinesMajorInnerRadius = 70;
            this.aGauge3.ScaleLinesMajorOuterRadius = 80;
            this.aGauge3.ScaleLinesMajorStepValue = 50F;
            this.aGauge3.ScaleLinesMajorWidth = 2;
            this.aGauge3.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge3.ScaleLinesMinorInnerRadius = 75;
            this.aGauge3.ScaleLinesMinorNumOf = 9;
            this.aGauge3.ScaleLinesMinorOuterRadius = 80;
            this.aGauge3.ScaleLinesMinorWidth = 1;
            this.aGauge3.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge3.ScaleNumbersFormat = null;
            this.aGauge3.ScaleNumbersRadius = 95;
            this.aGauge3.ScaleNumbersRotation = 0;
            this.aGauge3.ScaleNumbersStartScaleLine = 0;
            this.aGauge3.ScaleNumbersStepScaleLines = 1;
            this.aGauge3.Size = new System.Drawing.Size(150, 150);
            this.aGauge3.TabIndex = 30;
            this.aGauge3.Value = 0F;
            this.aGauge3.Value0 = 0F;
            this.aGauge3.Value1 = 0F;
            this.aGauge3.Value2 = 0F;
            this.aGauge3.Value3 = 0F;
            // 
            // aGauge4
            // 
            this.aGauge4.BackColor = System.Drawing.Color.Transparent;
            this.aGauge4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.aGauge4.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge4.BaseArcRadius = 80;
            this.aGauge4.BaseArcStart = 135;
            this.aGauge4.BaseArcSweep = 270;
            this.aGauge4.BaseArcWidth = 2;
            this.aGauge4.Cap_Idx = ((byte)(1));
            this.aGauge4.CapColor = System.Drawing.Color.Black;
            this.aGauge4.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge4.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge4.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge4.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge4.CapText = "";
            this.aGauge4.Center = new System.Drawing.Point(100, 100);
            this.aGauge4.Location = new System.Drawing.Point(672, 436);
            this.aGauge4.MaxValue = 400F;
            this.aGauge4.MinValue = -100F;
            this.aGauge4.Name = "aGauge4";
            this.aGauge4.Need_Idx = ((byte)(3));
            this.aGauge4.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGauge4.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge4.NeedleEnabled = false;
            this.aGauge4.NeedleRadius = 80;
            this.aGauge4.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.aGauge4.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.DimGray,
        System.Drawing.Color.DimGray,
        System.Drawing.Color.DimGray,
        System.Drawing.Color.DimGray};
            this.aGauge4.NeedlesEnabled = new bool[] {
        true,
        false,
        false,
        false};
            this.aGauge4.NeedlesRadius = new int[] {
        80,
        80,
        80,
        80};
            this.aGauge4.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.aGauge4.NeedlesWidth = new int[] {
        2,
        2,
        2,
        2};
            this.aGauge4.NeedleType = 0;
            this.aGauge4.NeedleWidth = 2;
            this.aGauge4.Range_Idx = ((byte)(0));
            this.aGauge4.RangeColor = System.Drawing.Color.LightGreen;
            this.aGauge4.RangeEnabled = true;
            this.aGauge4.RangeEndValue = 300F;
            this.aGauge4.RangeInnerRadius = 70;
            this.aGauge4.RangeOuterRadius = 80;
            this.aGauge4.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge4.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
            this.aGauge4.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.aGauge4.RangesInnerRadius = new int[] {
        70,
        70,
        70,
        70,
        70};
            this.aGauge4.RangesOuterRadius = new int[] {
        80,
        80,
        80,
        80,
        80};
            this.aGauge4.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.aGauge4.RangeStartValue = -100F;
            this.aGauge4.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge4.ScaleLinesInterInnerRadius = 73;
            this.aGauge4.ScaleLinesInterOuterRadius = 80;
            this.aGauge4.ScaleLinesInterWidth = 1;
            this.aGauge4.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge4.ScaleLinesMajorInnerRadius = 70;
            this.aGauge4.ScaleLinesMajorOuterRadius = 80;
            this.aGauge4.ScaleLinesMajorStepValue = 50F;
            this.aGauge4.ScaleLinesMajorWidth = 2;
            this.aGauge4.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge4.ScaleLinesMinorInnerRadius = 75;
            this.aGauge4.ScaleLinesMinorNumOf = 9;
            this.aGauge4.ScaleLinesMinorOuterRadius = 80;
            this.aGauge4.ScaleLinesMinorWidth = 1;
            this.aGauge4.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge4.ScaleNumbersFormat = null;
            this.aGauge4.ScaleNumbersRadius = 95;
            this.aGauge4.ScaleNumbersRotation = 0;
            this.aGauge4.ScaleNumbersStartScaleLine = 0;
            this.aGauge4.ScaleNumbersStepScaleLines = 1;
            this.aGauge4.Size = new System.Drawing.Size(150, 150);
            this.aGauge4.TabIndex = 31;
            this.aGauge4.Value = 0F;
            this.aGauge4.Value0 = 0F;
            this.aGauge4.Value1 = 0F;
            this.aGauge4.Value2 = 0F;
            this.aGauge4.Value3 = 0F;
            // 
            // aGauge5
            // 
            this.aGauge5.BackColor = System.Drawing.Color.Transparent;
            this.aGauge5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.aGauge5.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge5.BaseArcRadius = 80;
            this.aGauge5.BaseArcStart = 135;
            this.aGauge5.BaseArcSweep = 270;
            this.aGauge5.BaseArcWidth = 2;
            this.aGauge5.Cap_Idx = ((byte)(1));
            this.aGauge5.CapColor = System.Drawing.Color.Black;
            this.aGauge5.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge5.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge5.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge5.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge5.CapText = "";
            this.aGauge5.Center = new System.Drawing.Point(100, 100);
            this.aGauge5.Location = new System.Drawing.Point(828, 436);
            this.aGauge5.MaxValue = 400F;
            this.aGauge5.MinValue = -100F;
            this.aGauge5.Name = "aGauge5";
            this.aGauge5.Need_Idx = ((byte)(3));
            this.aGauge5.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGauge5.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge5.NeedleEnabled = false;
            this.aGauge5.NeedleRadius = 80;
            this.aGauge5.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.aGauge5.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.DimGray,
        System.Drawing.Color.DimGray,
        System.Drawing.Color.DimGray,
        System.Drawing.Color.DimGray};
            this.aGauge5.NeedlesEnabled = new bool[] {
        true,
        false,
        false,
        false};
            this.aGauge5.NeedlesRadius = new int[] {
        80,
        80,
        80,
        80};
            this.aGauge5.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.aGauge5.NeedlesWidth = new int[] {
        2,
        2,
        2,
        2};
            this.aGauge5.NeedleType = 0;
            this.aGauge5.NeedleWidth = 2;
            this.aGauge5.Range_Idx = ((byte)(0));
            this.aGauge5.RangeColor = System.Drawing.Color.LightGreen;
            this.aGauge5.RangeEnabled = true;
            this.aGauge5.RangeEndValue = 300F;
            this.aGauge5.RangeInnerRadius = 70;
            this.aGauge5.RangeOuterRadius = 80;
            this.aGauge5.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge5.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
            this.aGauge5.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.aGauge5.RangesInnerRadius = new int[] {
        70,
        70,
        70,
        70,
        70};
            this.aGauge5.RangesOuterRadius = new int[] {
        80,
        80,
        80,
        80,
        80};
            this.aGauge5.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.aGauge5.RangeStartValue = -100F;
            this.aGauge5.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge5.ScaleLinesInterInnerRadius = 73;
            this.aGauge5.ScaleLinesInterOuterRadius = 80;
            this.aGauge5.ScaleLinesInterWidth = 1;
            this.aGauge5.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge5.ScaleLinesMajorInnerRadius = 70;
            this.aGauge5.ScaleLinesMajorOuterRadius = 80;
            this.aGauge5.ScaleLinesMajorStepValue = 50F;
            this.aGauge5.ScaleLinesMajorWidth = 2;
            this.aGauge5.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge5.ScaleLinesMinorInnerRadius = 75;
            this.aGauge5.ScaleLinesMinorNumOf = 9;
            this.aGauge5.ScaleLinesMinorOuterRadius = 80;
            this.aGauge5.ScaleLinesMinorWidth = 1;
            this.aGauge5.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge5.ScaleNumbersFormat = null;
            this.aGauge5.ScaleNumbersRadius = 95;
            this.aGauge5.ScaleNumbersRotation = 0;
            this.aGauge5.ScaleNumbersStartScaleLine = 0;
            this.aGauge5.ScaleNumbersStepScaleLines = 1;
            this.aGauge5.Size = new System.Drawing.Size(150, 150);
            this.aGauge5.TabIndex = 32;
            this.aGauge5.Value = 0F;
            this.aGauge5.Value0 = 0F;
            this.aGauge5.Value1 = 0F;
            this.aGauge5.Value2 = 0F;
            this.aGauge5.Value3 = 0F;
            // 
            // aGauge6
            // 
            this.aGauge6.BackColor = System.Drawing.Color.Transparent;
            this.aGauge6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.aGauge6.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge6.BaseArcRadius = 80;
            this.aGauge6.BaseArcStart = 135;
            this.aGauge6.BaseArcSweep = 270;
            this.aGauge6.BaseArcWidth = 2;
            this.aGauge6.Cap_Idx = ((byte)(1));
            this.aGauge6.CapColor = System.Drawing.Color.Black;
            this.aGauge6.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge6.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge6.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge6.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge6.CapText = "";
            this.aGauge6.Center = new System.Drawing.Point(100, 100);
            this.aGauge6.Location = new System.Drawing.Point(984, 436);
            this.aGauge6.MaxValue = 400F;
            this.aGauge6.MinValue = -100F;
            this.aGauge6.Name = "aGauge6";
            this.aGauge6.Need_Idx = ((byte)(3));
            this.aGauge6.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGauge6.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge6.NeedleEnabled = false;
            this.aGauge6.NeedleRadius = 80;
            this.aGauge6.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.aGauge6.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.DimGray,
        System.Drawing.Color.DimGray,
        System.Drawing.Color.DimGray,
        System.Drawing.Color.DimGray};
            this.aGauge6.NeedlesEnabled = new bool[] {
        true,
        false,
        false,
        false};
            this.aGauge6.NeedlesRadius = new int[] {
        80,
        80,
        80,
        80};
            this.aGauge6.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.aGauge6.NeedlesWidth = new int[] {
        2,
        2,
        2,
        2};
            this.aGauge6.NeedleType = 0;
            this.aGauge6.NeedleWidth = 2;
            this.aGauge6.Range_Idx = ((byte)(0));
            this.aGauge6.RangeColor = System.Drawing.Color.LightGreen;
            this.aGauge6.RangeEnabled = true;
            this.aGauge6.RangeEndValue = 300F;
            this.aGauge6.RangeInnerRadius = 70;
            this.aGauge6.RangeOuterRadius = 80;
            this.aGauge6.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge6.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
            this.aGauge6.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.aGauge6.RangesInnerRadius = new int[] {
        70,
        70,
        70,
        70,
        70};
            this.aGauge6.RangesOuterRadius = new int[] {
        80,
        80,
        80,
        80,
        80};
            this.aGauge6.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.aGauge6.RangeStartValue = -100F;
            this.aGauge6.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge6.ScaleLinesInterInnerRadius = 73;
            this.aGauge6.ScaleLinesInterOuterRadius = 80;
            this.aGauge6.ScaleLinesInterWidth = 1;
            this.aGauge6.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge6.ScaleLinesMajorInnerRadius = 70;
            this.aGauge6.ScaleLinesMajorOuterRadius = 80;
            this.aGauge6.ScaleLinesMajorStepValue = 50F;
            this.aGauge6.ScaleLinesMajorWidth = 2;
            this.aGauge6.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge6.ScaleLinesMinorInnerRadius = 75;
            this.aGauge6.ScaleLinesMinorNumOf = 9;
            this.aGauge6.ScaleLinesMinorOuterRadius = 80;
            this.aGauge6.ScaleLinesMinorWidth = 1;
            this.aGauge6.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge6.ScaleNumbersFormat = null;
            this.aGauge6.ScaleNumbersRadius = 95;
            this.aGauge6.ScaleNumbersRotation = 0;
            this.aGauge6.ScaleNumbersStartScaleLine = 0;
            this.aGauge6.ScaleNumbersStepScaleLines = 1;
            this.aGauge6.Size = new System.Drawing.Size(150, 150);
            this.aGauge6.TabIndex = 33;
            this.aGauge6.Value = 0F;
            this.aGauge6.Value0 = 0F;
            this.aGauge6.Value1 = 0F;
            this.aGauge6.Value2 = 0F;
            this.aGauge6.Value3 = 0F;
            // 
            // Form_Engine_Parameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 647);
            this.Controls.Add(this.aGauge6);
            this.Controls.Add(this.aGauge5);
            this.Controls.Add(this.aGauge4);
            this.Controls.Add(this.aGauge3);
            this.Controls.Add(this.aGauge2);
            this.Controls.Add(this.aGauge1);
            this.Controls.Add(this.hud);
            this.Controls.Add(this.gbparameter);
            this.Controls.Add(this.gbengine_control);
            this.Name = "Form_Engine_Parameter";
            this.Text = "电机控制";
            this.Load += new System.EventHandler(this.Form_Engine_Parameter_Load);
            this.gbparameter.ResumeLayout(false);
            this.gbparameter.PerformLayout();
            this.gbengine_control.ResumeLayout(false);
            this.gbengine_control.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbparameter;
        private System.Windows.Forms.Label lbpara_gyroz;
        private System.Windows.Forms.Label lbpara_gyroy;
        private System.Windows.Forms.Label lbpara_gyrox;
        private System.Windows.Forms.Label lbpara_roll;
        private System.Windows.Forms.Label lbpara_pitch;
        private System.Windows.Forms.GroupBox gbengine_control;
        private System.Windows.Forms.Button btnstopall;
        private System.Windows.Forms.Button btnengine_debug;
        private System.Windows.Forms.Label lbengine4;
        private System.Windows.Forms.Label lbengine2;
        private System.Windows.Forms.Label lbengine3;
        private System.Windows.Forms.Label lbengine1;
        private System.Windows.Forms.TextBox tbengine4;
        private System.Windows.Forms.TextBox tbengine2;
        private System.Windows.Forms.TextBox tbengine3;
        private System.Windows.Forms.TextBox tbengine1;
        private System.Windows.Forms.Timer timer1;
        private MissionPlanner.Controls.HUD hud;
        private System.Windows.Forms.Label lbengine6;
        private System.Windows.Forms.TextBox tbengine6;
        private System.Windows.Forms.Label lbengine5;
        private System.Windows.Forms.TextBox tbengine5;
        private AGaugeApp.AGauge aGauge1;
        private AGaugeApp.AGauge aGauge2;
        private AGaugeApp.AGauge aGauge3;
        private AGaugeApp.AGauge aGauge4;
        private AGaugeApp.AGauge aGauge5;
        private AGaugeApp.AGauge aGauge6;
    }
}