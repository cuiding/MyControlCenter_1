using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MyControlCenter_1.Data;
using static CommandData.Command;
using static MyControlCenter_1.ROV;
using CommandData;

namespace MyControlCenter_1
{
    public partial class Form_Engine_Parameter : Form
    {
        ROV rovdebug = new ROV();
        public Form_Engine_Parameter()
        {
            InitializeComponent();
        }

        private void Form_Engine_Parameter_Load(object sender, EventArgs e)
        {
            tbengine1.Text = "0";
            tbengine2.Text = "0";
            tbengine3.Text = "0";
            tbengine4.Text = "0";
            tbengine5.Text = "0";
            tbengine6.Text = "0";
        }

        private void btnstopall_Click(object sender, EventArgs e)
        {
            tbengine1.Text = "0";
            tbengine2.Text = "0";
            tbengine3.Text = "0";
            tbengine4.Text = "0";
            tbengine5.Text = "0";
            tbengine6.Text = "0";
            btnengine_debug_Click(sender, e);
        }

        private void btnengine_debug_Click(object sender, EventArgs e)
        {
            try
            {
                rovdebug.engine.engine1_speed = Convert.ToInt16(tbengine1.Text);
                rovdebug.engine.engine2_speed = Convert.ToInt16(tbengine2.Text);
                rovdebug.engine.engine3_speed = Convert.ToInt16(tbengine3.Text);
                rovdebug.engine.engine4_speed = Convert.ToInt16(tbengine4.Text);
                rovdebug.engine.engine5_speed = Convert.ToInt16(tbengine5.Text);
                rovdebug.engine.engine6_speed = Convert.ToInt16(tbengine6.Text);
                SendData(Startbit_Engine_Control, rovdebug);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Error");
                return;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
 
            hud.alt = rov.sensor.deapth;
            hud.datetime = new System.DateTime();

            aGauge1.Value = rov.engine.engine1_speed;
            aGauge2.Value = rov.engine.engine2_speed;
            aGauge3.Value = rov.engine.engine3_speed;
            aGauge4.Value = rov.engine.engine4_speed;
            aGauge5.Value = rov.engine.engine5_speed;
            aGauge6.Value = rov.engine.engine6_speed;

            lbpara_pitch.Text = "俯仰角：" + Convert.ToString(rov.sensor.angle_pitch);
            lbpara_roll.Text = "横滚角：" + Convert.ToString(rov.sensor.angle_roll);
            lbpara_gyrox.Text = "角速度x：" + Convert.ToString(rov.sensor.gyro_x);
            lbpara_gyroy.Text = "角速度y：" + Convert.ToString(rov.sensor.gyro_y);
            lbpara_gyroz.Text = "角速度z：" + Convert.ToString(rov.sensor.gyro_z);
        }

    }
}
