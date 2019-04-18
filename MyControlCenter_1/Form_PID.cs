using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MyControlCenter_1;
using static MyControlCenter_1.Data;
using static CommandData.Command;

namespace MyControlCenter_1
{
    public partial class Form_PID : Form
    {
        
        public Form_PID()
        {
            InitializeComponent();
            PID_ParaTextChange();
            PID_SetTextChange();
        }
        ROV rov = new ROV();
        ROV rovpid = new ROV();


        public void PID_ParaTextChange()
        {
            tb_pitch_P.Text = rov.pidData_pitch.P.ToString("0.####");
            tb_pitch_I.Text = rov.pidData_pitch.I.ToString("0.####");
            tb_pitch_D.Text = rov.pidData_pitch.D.ToString("0.####");

            tb_pitch_w_P.Text = rov.pidData_pitch_w.P.ToString("0.####");
            tb_pitch_w_I.Text = rov.pidData_pitch_w.I.ToString("0.####");
            tb_pitch_w_D.Text = rov.pidData_pitch_w.D.ToString("0.####");

            tb_depth_P.Text = rov.pidData_depth.P.ToString("0.####");
            tb_depth_I.Text = rov.pidData_depth.I.ToString("0.####");
            tb_depth_D.Text = rov.pidData_depth.D.ToString("0.####");

            tb_yaw_w_P.Text = rov.pidData_yaw_w.P.ToString("0.####");
            tb_yaw_w_I.Text = rov.pidData_yaw_w.I.ToString("0.####");
            tb_yaw_w_D.Text = rov.pidData_yaw_w.D.ToString("0.####");
        }

        public void PID_SetTextChange()
        {

            lbPIDpara_depth.Text = rov.setpara.depth_set.ToString("0.####");
            lbPIDpara_pitch.Text = rov.setpara.pitch_set.ToString("0.####");

        }

        private void tb_Keypress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(Convert.ToString((int)(e.KeyChar)), "Error");
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)45 && e.KeyChar != (char)8 && e.KeyChar != (char)46)
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
                btn_sendpidpara_Click(sender, e);
        }

        private void btn_sendpidpara_Click(object sender, EventArgs e)
        {
            rovpid.pidData_pitch.P = Convert.ToSingle(tb_pitch_P.Text);
            rovpid.pidData_pitch.I = Convert.ToSingle(tb_pitch_I.Text);
            rovpid.pidData_pitch.D = Convert.ToSingle(tb_pitch_D.Text);

            rovpid.pidData_pitch_w.P = Convert.ToSingle(tb_pitch_w_P.Text);
            rovpid.pidData_pitch_w.I = Convert.ToSingle(tb_pitch_w_I.Text);
            rovpid.pidData_pitch_w.D = Convert.ToSingle(tb_pitch_w_D.Text);

            rovpid.pidData_depth.P = Convert.ToSingle(tb_depth_P.Text);
            rovpid.pidData_depth.I = Convert.ToSingle(tb_depth_I.Text);
            rovpid.pidData_depth.D = Convert.ToSingle(tb_depth_D.Text);

            rovpid.pidData_yaw_w.P = Convert.ToSingle(tb_yaw_w_P.Text);
            rovpid.pidData_yaw_w.I = Convert.ToSingle(tb_yaw_w_I.Text);
            rovpid.pidData_yaw_w.D = Convert.ToSingle(tb_yaw_w_D.Text);

            SendData(Startbit_PIDData, rovpid);

        }

        private void Form_PID_Load(object sender, EventArgs e)
        {
            PID_ParaTextChange();
        }

        private void btn_sendpidpara_Click_1(object sender, EventArgs e)
        {
            rovpid.pidData_pitch.P = Convert.ToSingle(tb_pitch_P.Text);
            rovpid.pidData_pitch.I = Convert.ToSingle(tb_pitch_I.Text);
            rovpid.pidData_pitch.D = Convert.ToSingle(tb_pitch_D.Text);

            rovpid.pidData_pitch_w.P = Convert.ToSingle(tb_pitch_w_P.Text);
            rovpid.pidData_pitch_w.I = Convert.ToSingle(tb_pitch_w_I.Text);
            rovpid.pidData_pitch_w.D = Convert.ToSingle(tb_pitch_w_D.Text);

            rovpid.pidData_depth.P = Convert.ToSingle(tb_depth_P.Text);
            rovpid.pidData_depth.I = Convert.ToSingle(tb_depth_I.Text);
            rovpid.pidData_depth.D = Convert.ToSingle(tb_depth_D.Text);

            rovpid.pidData_yaw_w.P = Convert.ToSingle(tb_yaw_w_P.Text);
            rovpid.pidData_yaw_w.I = Convert.ToSingle(tb_yaw_w_I.Text);
            rovpid.pidData_yaw_w.D = Convert.ToSingle(tb_yaw_w_D.Text);
        }

        private void btn_sendsetpara_Click(object sender, EventArgs e)
        {
            ROV rovsetpara = rov;

            rovsetpara.setpara.depth_set = Convert.ToSingle(tb_depthset.Text);
            rovsetpara.setpara.pitch_set = Convert.ToSingle(tb_pitchset.Text);

            SendData(Startbit_Motion_Control, rovsetpara);
        }

    }
}
