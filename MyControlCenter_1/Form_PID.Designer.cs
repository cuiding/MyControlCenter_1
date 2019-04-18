namespace MyControlCenter_1
{
    partial class Form_PID
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
            this.gb_setpara = new System.Windows.Forms.GroupBox();
            this.lbPIDpara_pitch = new System.Windows.Forms.Label();
            this.lbPIDpara_depth = new System.Windows.Forms.Label();
            this.lb_pitchset = new System.Windows.Forms.Label();
            this.lb_depthset = new System.Windows.Forms.Label();
            this.tb_pitchset = new System.Windows.Forms.TextBox();
            this.tb_depthset = new System.Windows.Forms.TextBox();
            this.btn_sendsetpara = new System.Windows.Forms.Button();
            this.btn_sendpidpara = new System.Windows.Forms.Button();
            this.gb_data = new System.Windows.Forms.GroupBox();
            this.tb_depth_D = new System.Windows.Forms.TextBox();
            this.tb_roll_w_D = new System.Windows.Forms.TextBox();
            this.tb_roll_D = new System.Windows.Forms.TextBox();
            this.tb_yaw_w_D = new System.Windows.Forms.TextBox();
            this.tb_pitch_w_D = new System.Windows.Forms.TextBox();
            this.tb_pitch_D = new System.Windows.Forms.TextBox();
            this.tb_depth_I = new System.Windows.Forms.TextBox();
            this.tb_roll_w_I = new System.Windows.Forms.TextBox();
            this.tb_roll_I = new System.Windows.Forms.TextBox();
            this.tb_yaw_w_I = new System.Windows.Forms.TextBox();
            this.tb_pitch_w_I = new System.Windows.Forms.TextBox();
            this.tb_pitch_I = new System.Windows.Forms.TextBox();
            this.tb_depth_P = new System.Windows.Forms.TextBox();
            this.tb_roll_w_P = new System.Windows.Forms.TextBox();
            this.tb_roll_P = new System.Windows.Forms.TextBox();
            this.tb_yaw_w_P = new System.Windows.Forms.TextBox();
            this.tb_pitch_w_P = new System.Windows.Forms.TextBox();
            this.tb_pitch_P = new System.Windows.Forms.TextBox();
            this.lb_depth_D = new System.Windows.Forms.Label();
            this.lb_roll_w_D = new System.Windows.Forms.Label();
            this.lb_yaw_w_D = new System.Windows.Forms.Label();
            this.lb_pitch_w_D = new System.Windows.Forms.Label();
            this.lb_roll_D = new System.Windows.Forms.Label();
            this.lb_pitch_D = new System.Windows.Forms.Label();
            this.lb_depth_I = new System.Windows.Forms.Label();
            this.lb_roll_w_I = new System.Windows.Forms.Label();
            this.lb_yaw_w_I = new System.Windows.Forms.Label();
            this.lb_pitch_w_I = new System.Windows.Forms.Label();
            this.roll_I = new System.Windows.Forms.Label();
            this.lb_pitch_I = new System.Windows.Forms.Label();
            this.lb_depth_P = new System.Windows.Forms.Label();
            this.lb_yaw_w_P = new System.Windows.Forms.Label();
            this.lb_roll_w_P = new System.Windows.Forms.Label();
            this.lb_pitch_w_P = new System.Windows.Forms.Label();
            this.lb_roll_P = new System.Windows.Forms.Label();
            this.lb_pitch_P = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gb_setpara.SuspendLayout();
            this.gb_data.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_setpara
            // 
            this.gb_setpara.Controls.Add(this.lbPIDpara_pitch);
            this.gb_setpara.Controls.Add(this.lbPIDpara_depth);
            this.gb_setpara.Controls.Add(this.lb_pitchset);
            this.gb_setpara.Controls.Add(this.lb_depthset);
            this.gb_setpara.Controls.Add(this.tb_pitchset);
            this.gb_setpara.Controls.Add(this.tb_depthset);
            this.gb_setpara.Location = new System.Drawing.Point(30, 426);
            this.gb_setpara.Margin = new System.Windows.Forms.Padding(4);
            this.gb_setpara.Name = "gb_setpara";
            this.gb_setpara.Padding = new System.Windows.Forms.Padding(4);
            this.gb_setpara.Size = new System.Drawing.Size(404, 111);
            this.gb_setpara.TabIndex = 6;
            this.gb_setpara.TabStop = false;
            this.gb_setpara.Text = "设定值";
            // 
            // lbPIDpara_pitch
            // 
            this.lbPIDpara_pitch.AutoSize = true;
            this.lbPIDpara_pitch.Location = new System.Drawing.Point(291, 81);
            this.lbPIDpara_pitch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPIDpara_pitch.Name = "lbPIDpara_pitch";
            this.lbPIDpara_pitch.Size = new System.Drawing.Size(17, 18);
            this.lbPIDpara_pitch.TabIndex = 2;
            this.lbPIDpara_pitch.Text = "0";
            // 
            // lbPIDpara_depth
            // 
            this.lbPIDpara_depth.AutoSize = true;
            this.lbPIDpara_depth.Location = new System.Drawing.Point(116, 81);
            this.lbPIDpara_depth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPIDpara_depth.Name = "lbPIDpara_depth";
            this.lbPIDpara_depth.Size = new System.Drawing.Size(17, 18);
            this.lbPIDpara_depth.TabIndex = 2;
            this.lbPIDpara_depth.Text = "0";
            // 
            // lb_pitchset
            // 
            this.lb_pitchset.AutoSize = true;
            this.lb_pitchset.Location = new System.Drawing.Point(210, 44);
            this.lb_pitchset.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_pitchset.Name = "lb_pitchset";
            this.lb_pitchset.Size = new System.Drawing.Size(71, 18);
            this.lb_pitchset.TabIndex = 0;
            this.lb_pitchset.Text = "pitch：";
            // 
            // lb_depthset
            // 
            this.lb_depthset.AutoSize = true;
            this.lb_depthset.Location = new System.Drawing.Point(34, 44);
            this.lb_depthset.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_depthset.Name = "lb_depthset";
            this.lb_depthset.Size = new System.Drawing.Size(71, 18);
            this.lb_depthset.TabIndex = 0;
            this.lb_depthset.Text = "depth：";
            // 
            // tb_pitchset
            // 
            this.tb_pitchset.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_pitchset.Location = new System.Drawing.Point(290, 39);
            this.tb_pitchset.Margin = new System.Windows.Forms.Padding(4);
            this.tb_pitchset.MaxLength = 7;
            this.tb_pitchset.Name = "tb_pitchset";
            this.tb_pitchset.Size = new System.Drawing.Size(74, 28);
            this.tb_pitchset.TabIndex = 1;
            this.tb_pitchset.Text = "0";
            // 
            // tb_depthset
            // 
            this.tb_depthset.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_depthset.Location = new System.Drawing.Point(114, 39);
            this.tb_depthset.Margin = new System.Windows.Forms.Padding(4);
            this.tb_depthset.MaxLength = 7;
            this.tb_depthset.Name = "tb_depthset";
            this.tb_depthset.Size = new System.Drawing.Size(74, 28);
            this.tb_depthset.TabIndex = 1;
            this.tb_depthset.Text = "0";
            // 
            // btn_sendsetpara
            // 
            this.btn_sendsetpara.Location = new System.Drawing.Point(148, 546);
            this.btn_sendsetpara.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sendsetpara.Name = "btn_sendsetpara";
            this.btn_sendsetpara.Size = new System.Drawing.Size(112, 39);
            this.btn_sendsetpara.TabIndex = 4;
            this.btn_sendsetpara.Text = "发送设定值";
            this.btn_sendsetpara.UseVisualStyleBackColor = true;
            this.btn_sendsetpara.Click += new System.EventHandler(this.btn_sendsetpara_Click);
            // 
            // btn_sendpidpara
            // 
            this.btn_sendpidpara.Location = new System.Drawing.Point(42, 546);
            this.btn_sendpidpara.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sendpidpara.Name = "btn_sendpidpara";
            this.btn_sendpidpara.Size = new System.Drawing.Size(93, 39);
            this.btn_sendpidpara.TabIndex = 5;
            this.btn_sendpidpara.Text = "发送参数";
            this.btn_sendpidpara.UseVisualStyleBackColor = true;
            this.btn_sendpidpara.Click += new System.EventHandler(this.btn_sendpidpara_Click_1);
            // 
            // gb_data
            // 
            this.gb_data.Controls.Add(this.tb_depth_D);
            this.gb_data.Controls.Add(this.tb_roll_w_D);
            this.gb_data.Controls.Add(this.tb_roll_D);
            this.gb_data.Controls.Add(this.tb_yaw_w_D);
            this.gb_data.Controls.Add(this.tb_pitch_w_D);
            this.gb_data.Controls.Add(this.tb_pitch_D);
            this.gb_data.Controls.Add(this.tb_depth_I);
            this.gb_data.Controls.Add(this.tb_roll_w_I);
            this.gb_data.Controls.Add(this.tb_roll_I);
            this.gb_data.Controls.Add(this.tb_yaw_w_I);
            this.gb_data.Controls.Add(this.tb_pitch_w_I);
            this.gb_data.Controls.Add(this.tb_pitch_I);
            this.gb_data.Controls.Add(this.tb_depth_P);
            this.gb_data.Controls.Add(this.tb_roll_w_P);
            this.gb_data.Controls.Add(this.tb_roll_P);
            this.gb_data.Controls.Add(this.tb_yaw_w_P);
            this.gb_data.Controls.Add(this.tb_pitch_w_P);
            this.gb_data.Controls.Add(this.tb_pitch_P);
            this.gb_data.Controls.Add(this.lb_depth_D);
            this.gb_data.Controls.Add(this.lb_roll_w_D);
            this.gb_data.Controls.Add(this.lb_yaw_w_D);
            this.gb_data.Controls.Add(this.lb_pitch_w_D);
            this.gb_data.Controls.Add(this.lb_roll_D);
            this.gb_data.Controls.Add(this.lb_pitch_D);
            this.gb_data.Controls.Add(this.lb_depth_I);
            this.gb_data.Controls.Add(this.lb_roll_w_I);
            this.gb_data.Controls.Add(this.lb_yaw_w_I);
            this.gb_data.Controls.Add(this.lb_pitch_w_I);
            this.gb_data.Controls.Add(this.roll_I);
            this.gb_data.Controls.Add(this.lb_pitch_I);
            this.gb_data.Controls.Add(this.lb_depth_P);
            this.gb_data.Controls.Add(this.lb_yaw_w_P);
            this.gb_data.Controls.Add(this.lb_roll_w_P);
            this.gb_data.Controls.Add(this.lb_pitch_w_P);
            this.gb_data.Controls.Add(this.lb_roll_P);
            this.gb_data.Controls.Add(this.lb_pitch_P);
            this.gb_data.Location = new System.Drawing.Point(30, 27);
            this.gb_data.Margin = new System.Windows.Forms.Padding(4);
            this.gb_data.Name = "gb_data";
            this.gb_data.Padding = new System.Windows.Forms.Padding(4);
            this.gb_data.Size = new System.Drawing.Size(405, 380);
            this.gb_data.TabIndex = 3;
            this.gb_data.TabStop = false;
            this.gb_data.Text = "PID参数";
            // 
            // tb_depth_D
            // 
            this.tb_depth_D.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_depth_D.Location = new System.Drawing.Point(290, 328);
            this.tb_depth_D.Margin = new System.Windows.Forms.Padding(4);
            this.tb_depth_D.MaxLength = 7;
            this.tb_depth_D.Name = "tb_depth_D";
            this.tb_depth_D.Size = new System.Drawing.Size(74, 28);
            this.tb_depth_D.TabIndex = 1;
            // 
            // tb_roll_w_D
            // 
            this.tb_roll_w_D.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_roll_w_D.Location = new System.Drawing.Point(290, 208);
            this.tb_roll_w_D.Margin = new System.Windows.Forms.Padding(4);
            this.tb_roll_w_D.MaxLength = 7;
            this.tb_roll_w_D.Name = "tb_roll_w_D";
            this.tb_roll_w_D.Size = new System.Drawing.Size(74, 28);
            this.tb_roll_w_D.TabIndex = 1;
            // 
            // tb_roll_D
            // 
            this.tb_roll_D.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_roll_D.Location = new System.Drawing.Point(290, 82);
            this.tb_roll_D.Margin = new System.Windows.Forms.Padding(4);
            this.tb_roll_D.MaxLength = 7;
            this.tb_roll_D.Name = "tb_roll_D";
            this.tb_roll_D.Size = new System.Drawing.Size(74, 28);
            this.tb_roll_D.TabIndex = 1;
            // 
            // tb_yaw_w_D
            // 
            this.tb_yaw_w_D.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_yaw_w_D.Location = new System.Drawing.Point(116, 330);
            this.tb_yaw_w_D.Margin = new System.Windows.Forms.Padding(4);
            this.tb_yaw_w_D.MaxLength = 7;
            this.tb_yaw_w_D.Name = "tb_yaw_w_D";
            this.tb_yaw_w_D.Size = new System.Drawing.Size(74, 28);
            this.tb_yaw_w_D.TabIndex = 1;
            // 
            // tb_pitch_w_D
            // 
            this.tb_pitch_w_D.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_pitch_w_D.Location = new System.Drawing.Point(116, 208);
            this.tb_pitch_w_D.Margin = new System.Windows.Forms.Padding(4);
            this.tb_pitch_w_D.MaxLength = 7;
            this.tb_pitch_w_D.Name = "tb_pitch_w_D";
            this.tb_pitch_w_D.Size = new System.Drawing.Size(74, 28);
            this.tb_pitch_w_D.TabIndex = 1;
            // 
            // tb_pitch_D
            // 
            this.tb_pitch_D.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_pitch_D.Location = new System.Drawing.Point(116, 82);
            this.tb_pitch_D.Margin = new System.Windows.Forms.Padding(4);
            this.tb_pitch_D.MaxLength = 7;
            this.tb_pitch_D.Name = "tb_pitch_D";
            this.tb_pitch_D.Size = new System.Drawing.Size(74, 28);
            this.tb_pitch_D.TabIndex = 1;
            // 
            // tb_depth_I
            // 
            this.tb_depth_I.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_depth_I.Location = new System.Drawing.Point(290, 300);
            this.tb_depth_I.Margin = new System.Windows.Forms.Padding(4);
            this.tb_depth_I.MaxLength = 7;
            this.tb_depth_I.Name = "tb_depth_I";
            this.tb_depth_I.Size = new System.Drawing.Size(74, 28);
            this.tb_depth_I.TabIndex = 1;
            // 
            // tb_roll_w_I
            // 
            this.tb_roll_w_I.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_roll_w_I.Location = new System.Drawing.Point(290, 180);
            this.tb_roll_w_I.Margin = new System.Windows.Forms.Padding(4);
            this.tb_roll_w_I.MaxLength = 7;
            this.tb_roll_w_I.Name = "tb_roll_w_I";
            this.tb_roll_w_I.Size = new System.Drawing.Size(74, 28);
            this.tb_roll_w_I.TabIndex = 1;
            // 
            // tb_roll_I
            // 
            this.tb_roll_I.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_roll_I.Location = new System.Drawing.Point(290, 54);
            this.tb_roll_I.Margin = new System.Windows.Forms.Padding(4);
            this.tb_roll_I.MaxLength = 7;
            this.tb_roll_I.Name = "tb_roll_I";
            this.tb_roll_I.Size = new System.Drawing.Size(74, 28);
            this.tb_roll_I.TabIndex = 1;
            // 
            // tb_yaw_w_I
            // 
            this.tb_yaw_w_I.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_yaw_w_I.Location = new System.Drawing.Point(116, 302);
            this.tb_yaw_w_I.Margin = new System.Windows.Forms.Padding(4);
            this.tb_yaw_w_I.MaxLength = 7;
            this.tb_yaw_w_I.Name = "tb_yaw_w_I";
            this.tb_yaw_w_I.Size = new System.Drawing.Size(74, 28);
            this.tb_yaw_w_I.TabIndex = 1;
            // 
            // tb_pitch_w_I
            // 
            this.tb_pitch_w_I.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_pitch_w_I.Location = new System.Drawing.Point(116, 180);
            this.tb_pitch_w_I.Margin = new System.Windows.Forms.Padding(4);
            this.tb_pitch_w_I.MaxLength = 7;
            this.tb_pitch_w_I.Name = "tb_pitch_w_I";
            this.tb_pitch_w_I.Size = new System.Drawing.Size(74, 28);
            this.tb_pitch_w_I.TabIndex = 1;
            // 
            // tb_pitch_I
            // 
            this.tb_pitch_I.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_pitch_I.Location = new System.Drawing.Point(116, 54);
            this.tb_pitch_I.Margin = new System.Windows.Forms.Padding(4);
            this.tb_pitch_I.MaxLength = 7;
            this.tb_pitch_I.Name = "tb_pitch_I";
            this.tb_pitch_I.Size = new System.Drawing.Size(74, 28);
            this.tb_pitch_I.TabIndex = 1;
            // 
            // tb_depth_P
            // 
            this.tb_depth_P.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_depth_P.Location = new System.Drawing.Point(290, 272);
            this.tb_depth_P.Margin = new System.Windows.Forms.Padding(4);
            this.tb_depth_P.MaxLength = 7;
            this.tb_depth_P.Name = "tb_depth_P";
            this.tb_depth_P.Size = new System.Drawing.Size(74, 28);
            this.tb_depth_P.TabIndex = 1;
            // 
            // tb_roll_w_P
            // 
            this.tb_roll_w_P.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_roll_w_P.Location = new System.Drawing.Point(290, 152);
            this.tb_roll_w_P.Margin = new System.Windows.Forms.Padding(4);
            this.tb_roll_w_P.MaxLength = 7;
            this.tb_roll_w_P.Name = "tb_roll_w_P";
            this.tb_roll_w_P.Size = new System.Drawing.Size(74, 28);
            this.tb_roll_w_P.TabIndex = 1;
            // 
            // tb_roll_P
            // 
            this.tb_roll_P.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_roll_P.Location = new System.Drawing.Point(290, 26);
            this.tb_roll_P.Margin = new System.Windows.Forms.Padding(4);
            this.tb_roll_P.MaxLength = 7;
            this.tb_roll_P.Name = "tb_roll_P";
            this.tb_roll_P.Size = new System.Drawing.Size(74, 28);
            this.tb_roll_P.TabIndex = 1;
            // 
            // tb_yaw_w_P
            // 
            this.tb_yaw_w_P.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_yaw_w_P.Location = new System.Drawing.Point(116, 273);
            this.tb_yaw_w_P.Margin = new System.Windows.Forms.Padding(4);
            this.tb_yaw_w_P.MaxLength = 7;
            this.tb_yaw_w_P.Name = "tb_yaw_w_P";
            this.tb_yaw_w_P.Size = new System.Drawing.Size(74, 28);
            this.tb_yaw_w_P.TabIndex = 1;
            // 
            // tb_pitch_w_P
            // 
            this.tb_pitch_w_P.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_pitch_w_P.Location = new System.Drawing.Point(116, 152);
            this.tb_pitch_w_P.Margin = new System.Windows.Forms.Padding(4);
            this.tb_pitch_w_P.MaxLength = 7;
            this.tb_pitch_w_P.Name = "tb_pitch_w_P";
            this.tb_pitch_w_P.Size = new System.Drawing.Size(74, 28);
            this.tb_pitch_w_P.TabIndex = 1;
            // 
            // tb_pitch_P
            // 
            this.tb_pitch_P.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_pitch_P.Location = new System.Drawing.Point(116, 26);
            this.tb_pitch_P.Margin = new System.Windows.Forms.Padding(4);
            this.tb_pitch_P.MaxLength = 7;
            this.tb_pitch_P.Name = "tb_pitch_P";
            this.tb_pitch_P.Size = new System.Drawing.Size(74, 28);
            this.tb_pitch_P.TabIndex = 1;
            // 
            // lb_depth_D
            // 
            this.lb_depth_D.AutoSize = true;
            this.lb_depth_D.Location = new System.Drawing.Point(210, 332);
            this.lb_depth_D.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_depth_D.Name = "lb_depth_D";
            this.lb_depth_D.Size = new System.Drawing.Size(89, 18);
            this.lb_depth_D.TabIndex = 0;
            this.lb_depth_D.Text = "depth_D：";
            // 
            // lb_roll_w_D
            // 
            this.lb_roll_w_D.AutoSize = true;
            this.lb_roll_w_D.Location = new System.Drawing.Point(201, 206);
            this.lb_roll_w_D.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_roll_w_D.Name = "lb_roll_w_D";
            this.lb_roll_w_D.Size = new System.Drawing.Size(98, 18);
            this.lb_roll_w_D.TabIndex = 0;
            this.lb_roll_w_D.Text = "roll_w_D：";
            // 
            // lb_yaw_w_D
            // 
            this.lb_yaw_w_D.AutoSize = true;
            this.lb_yaw_w_D.Location = new System.Drawing.Point(34, 332);
            this.lb_yaw_w_D.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_yaw_w_D.Name = "lb_yaw_w_D";
            this.lb_yaw_w_D.Size = new System.Drawing.Size(89, 18);
            this.lb_yaw_w_D.TabIndex = 0;
            this.lb_yaw_w_D.Text = "yaw_w_D：";
            // 
            // lb_pitch_w_D
            // 
            this.lb_pitch_w_D.AutoSize = true;
            this.lb_pitch_w_D.Location = new System.Drawing.Point(10, 208);
            this.lb_pitch_w_D.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_pitch_w_D.Name = "lb_pitch_w_D";
            this.lb_pitch_w_D.Size = new System.Drawing.Size(107, 18);
            this.lb_pitch_w_D.TabIndex = 0;
            this.lb_pitch_w_D.Text = "pitch_w_D：";
            // 
            // lb_roll_D
            // 
            this.lb_roll_D.AutoSize = true;
            this.lb_roll_D.Location = new System.Drawing.Point(219, 86);
            this.lb_roll_D.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_roll_D.Name = "lb_roll_D";
            this.lb_roll_D.Size = new System.Drawing.Size(80, 18);
            this.lb_roll_D.TabIndex = 0;
            this.lb_roll_D.Text = "roll_D：";
            // 
            // lb_pitch_D
            // 
            this.lb_pitch_D.AutoSize = true;
            this.lb_pitch_D.Location = new System.Drawing.Point(28, 86);
            this.lb_pitch_D.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_pitch_D.Name = "lb_pitch_D";
            this.lb_pitch_D.Size = new System.Drawing.Size(89, 18);
            this.lb_pitch_D.TabIndex = 0;
            this.lb_pitch_D.Text = "pitch_D：";
            // 
            // lb_depth_I
            // 
            this.lb_depth_I.AutoSize = true;
            this.lb_depth_I.Location = new System.Drawing.Point(210, 303);
            this.lb_depth_I.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_depth_I.Name = "lb_depth_I";
            this.lb_depth_I.Size = new System.Drawing.Size(89, 18);
            this.lb_depth_I.TabIndex = 0;
            this.lb_depth_I.Text = "depth_I：";
            // 
            // lb_roll_w_I
            // 
            this.lb_roll_w_I.AutoSize = true;
            this.lb_roll_w_I.Location = new System.Drawing.Point(201, 177);
            this.lb_roll_w_I.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_roll_w_I.Name = "lb_roll_w_I";
            this.lb_roll_w_I.Size = new System.Drawing.Size(98, 18);
            this.lb_roll_w_I.TabIndex = 0;
            this.lb_roll_w_I.Text = "roll_w_I：";
            // 
            // lb_yaw_w_I
            // 
            this.lb_yaw_w_I.AutoSize = true;
            this.lb_yaw_w_I.Location = new System.Drawing.Point(34, 303);
            this.lb_yaw_w_I.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_yaw_w_I.Name = "lb_yaw_w_I";
            this.lb_yaw_w_I.Size = new System.Drawing.Size(89, 18);
            this.lb_yaw_w_I.TabIndex = 0;
            this.lb_yaw_w_I.Text = "yaw_w_I：";
            // 
            // lb_pitch_w_I
            // 
            this.lb_pitch_w_I.AutoSize = true;
            this.lb_pitch_w_I.Location = new System.Drawing.Point(10, 180);
            this.lb_pitch_w_I.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_pitch_w_I.Name = "lb_pitch_w_I";
            this.lb_pitch_w_I.Size = new System.Drawing.Size(107, 18);
            this.lb_pitch_w_I.TabIndex = 0;
            this.lb_pitch_w_I.Text = "pitch_w_I：";
            // 
            // roll_I
            // 
            this.roll_I.AutoSize = true;
            this.roll_I.Location = new System.Drawing.Point(219, 57);
            this.roll_I.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roll_I.Name = "roll_I";
            this.roll_I.Size = new System.Drawing.Size(80, 18);
            this.roll_I.TabIndex = 0;
            this.roll_I.Text = "roll_I：";
            // 
            // lb_pitch_I
            // 
            this.lb_pitch_I.AutoSize = true;
            this.lb_pitch_I.Location = new System.Drawing.Point(28, 57);
            this.lb_pitch_I.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_pitch_I.Name = "lb_pitch_I";
            this.lb_pitch_I.Size = new System.Drawing.Size(89, 18);
            this.lb_pitch_I.TabIndex = 0;
            this.lb_pitch_I.Text = "pitch_I：";
            // 
            // lb_depth_P
            // 
            this.lb_depth_P.AutoSize = true;
            this.lb_depth_P.Location = new System.Drawing.Point(210, 276);
            this.lb_depth_P.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_depth_P.Name = "lb_depth_P";
            this.lb_depth_P.Size = new System.Drawing.Size(89, 18);
            this.lb_depth_P.TabIndex = 0;
            this.lb_depth_P.Text = "depth_P：";
            // 
            // lb_yaw_w_P
            // 
            this.lb_yaw_w_P.AutoSize = true;
            this.lb_yaw_w_P.Location = new System.Drawing.Point(34, 276);
            this.lb_yaw_w_P.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_yaw_w_P.Name = "lb_yaw_w_P";
            this.lb_yaw_w_P.Size = new System.Drawing.Size(89, 18);
            this.lb_yaw_w_P.TabIndex = 0;
            this.lb_yaw_w_P.Text = "yaw_w_P：";
            // 
            // lb_roll_w_P
            // 
            this.lb_roll_w_P.AutoSize = true;
            this.lb_roll_w_P.Location = new System.Drawing.Point(201, 150);
            this.lb_roll_w_P.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_roll_w_P.Name = "lb_roll_w_P";
            this.lb_roll_w_P.Size = new System.Drawing.Size(98, 18);
            this.lb_roll_w_P.TabIndex = 0;
            this.lb_roll_w_P.Text = "roll_w_P：";
            // 
            // lb_pitch_w_P
            // 
            this.lb_pitch_w_P.AutoSize = true;
            this.lb_pitch_w_P.Location = new System.Drawing.Point(10, 153);
            this.lb_pitch_w_P.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_pitch_w_P.Name = "lb_pitch_w_P";
            this.lb_pitch_w_P.Size = new System.Drawing.Size(107, 18);
            this.lb_pitch_w_P.TabIndex = 0;
            this.lb_pitch_w_P.Text = "pitch_w_P：";
            // 
            // lb_roll_P
            // 
            this.lb_roll_P.AutoSize = true;
            this.lb_roll_P.Location = new System.Drawing.Point(219, 30);
            this.lb_roll_P.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_roll_P.Name = "lb_roll_P";
            this.lb_roll_P.Size = new System.Drawing.Size(80, 18);
            this.lb_roll_P.TabIndex = 0;
            this.lb_roll_P.Text = "roll_P：";
            // 
            // lb_pitch_P
            // 
            this.lb_pitch_P.AutoSize = true;
            this.lb_pitch_P.Location = new System.Drawing.Point(28, 30);
            this.lb_pitch_P.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_pitch_P.Name = "lb_pitch_P";
            this.lb_pitch_P.Size = new System.Drawing.Size(89, 18);
            this.lb_pitch_P.TabIndex = 0;
            this.lb_pitch_P.Text = "pitch_P：";
            // 
            // Form_PID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 675);
            this.Controls.Add(this.gb_setpara);
            this.Controls.Add(this.btn_sendsetpara);
            this.Controls.Add(this.btn_sendpidpara);
            this.Controls.Add(this.gb_data);
            this.Name = "Form_PID";
            this.Text = "Form_PID";
            this.Load += new System.EventHandler(this.Form_PID_Load);
            this.gb_setpara.ResumeLayout(false);
            this.gb_setpara.PerformLayout();
            this.gb_data.ResumeLayout(false);
            this.gb_data.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_setpara;
        private System.Windows.Forms.Label lbPIDpara_pitch;
        private System.Windows.Forms.Label lbPIDpara_depth;
        private System.Windows.Forms.Label lb_pitchset;
        private System.Windows.Forms.Label lb_depthset;
        private System.Windows.Forms.TextBox tb_pitchset;
        private System.Windows.Forms.TextBox tb_depthset;
        private System.Windows.Forms.Button btn_sendsetpara;
        private System.Windows.Forms.Button btn_sendpidpara;
        private System.Windows.Forms.GroupBox gb_data;
        private System.Windows.Forms.TextBox tb_depth_D;
        private System.Windows.Forms.TextBox tb_roll_w_D;
        private System.Windows.Forms.TextBox tb_roll_D;
        private System.Windows.Forms.TextBox tb_yaw_w_D;
        private System.Windows.Forms.TextBox tb_pitch_w_D;
        private System.Windows.Forms.TextBox tb_pitch_D;
        private System.Windows.Forms.TextBox tb_depth_I;
        private System.Windows.Forms.TextBox tb_roll_w_I;
        private System.Windows.Forms.TextBox tb_roll_I;
        private System.Windows.Forms.TextBox tb_yaw_w_I;
        private System.Windows.Forms.TextBox tb_pitch_w_I;
        private System.Windows.Forms.TextBox tb_pitch_I;
        private System.Windows.Forms.TextBox tb_depth_P;
        private System.Windows.Forms.TextBox tb_roll_w_P;
        private System.Windows.Forms.TextBox tb_yaw_w_P;
        private System.Windows.Forms.TextBox tb_pitch_w_P;
        private System.Windows.Forms.Label lb_depth_D;
        private System.Windows.Forms.Label lb_roll_w_D;
        private System.Windows.Forms.Label lb_yaw_w_D;
        private System.Windows.Forms.Label lb_pitch_w_D;
        private System.Windows.Forms.Label lb_roll_D;
        private System.Windows.Forms.Label lb_pitch_D;
        private System.Windows.Forms.Label lb_depth_I;
        private System.Windows.Forms.Label lb_roll_w_I;
        private System.Windows.Forms.Label lb_yaw_w_I;
        private System.Windows.Forms.Label lb_pitch_w_I;
        private System.Windows.Forms.Label roll_I;
        private System.Windows.Forms.Label lb_pitch_I;
        private System.Windows.Forms.Label lb_depth_P;
        private System.Windows.Forms.Label lb_yaw_w_P;
        private System.Windows.Forms.Label lb_roll_w_P;
        private System.Windows.Forms.Label lb_pitch_w_P;
        private System.Windows.Forms.Label lb_roll_P;
        private System.Windows.Forms.Label lb_pitch_P;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.TextBox tb_roll_P;
        public System.Windows.Forms.TextBox tb_pitch_P;
    }
}