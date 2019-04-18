using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyControlCenter_1;
using static MyControlCenter_1.Data;


namespace CommandData
{
    public class Command
    {
            public static int RX_BUFF_LENTH = 42;
            public static int TX_BUFF_LENTH = 32;
            public static int PID_BUFF_LENTH = 47;
            public static int Motion_Control_BUFF_LENTH = 12;
            public static int Servo_BUFF_LENTH = 8;

            public static byte[] ucRxBuffer = new byte[RX_BUFF_LENTH];
            public static int ucRxCnt = 0;
            public static byte endbit = 0x00;

            /****************************起始码***************************/
            public static byte Startbit_Motion = 0xAA;
            public static byte Startbit_Engine_Control = 0xBA;
            public static byte Startbit_PIDData = 0xAC;
            public static byte Startbit_Mode = 0xBB;
            public static byte Startbit_Motion_Control = 0xBC;
            public static byte Startbit_Key = 0xBE;
            public static byte Startbit_Camera = 0xCC;
            public static byte Startbit_Servo = 0xDC;

            static List<byte> UXRxBuffer = new List<byte>();

            //接收数据
            public static void Command_Handler(byte data)
            {
                UXRxBuffer.Add(data);
                if (UXRxBuffer[0] != Startbit_Motion &&
                    UXRxBuffer[0] != Startbit_Mode &&
                    UXRxBuffer[0] != Startbit_PIDData &&
                    UXRxBuffer[0] != Startbit_Motion_Control)
                {

                    UXRxBuffer.Clear();
                    return;//接收出错
                }

            if ((UXRxBuffer.Count < RX_BUFF_LENTH + 2 && UXRxBuffer[0] == Startbit_Motion) ||
                (UXRxBuffer.Count < PID_BUFF_LENTH + 2 && UXRxBuffer[0] == Startbit_PIDData) ||
                 UXRxBuffer.Count < Motion_Control_BUFF_LENTH + 2 && UXRxBuffer[0] == Startbit_Motion_Control)
                return;//还未接收完成，继续接收

            //for (int i = 0; i < UXRxBuffer.Count - 1; i++)
            //        endbit += UXRxBuffer[i];

            //if (endbit != UXRxBuffer[UXRxBuffer.Count - 1])
            //{
            //     UXRxBuffer.Clear();
            //     endbit = 0x00;
            //     return;//接收出错
            //}
                //正确接收，开始解包
                DataHandler(UXRxBuffer, ref rov);

                UXRxBuffer.Clear();
                endbit = 0x00;
            }

            //解包
            public static void DataHandler(List<byte> Buffer, ref ROV rov)
            {
                byte[] RxBuffer = Buffer.ToArray();
                //功能选择，机械臂开合，充放气
                //这里我还没写好
                if (RxBuffer[0] == Startbit_Motion)
                {
                    rov.engine.engine1_speed = BitConverter.ToInt16(RxBuffer, 1);
                    rov.engine.engine2_speed = BitConverter.ToInt16(RxBuffer, 3);
                    rov.engine.engine3_speed = BitConverter.ToInt16(RxBuffer, 5);
                    rov.engine.engine4_speed = BitConverter.ToInt16(RxBuffer, 7);
                    rov.engine.engine5_speed = BitConverter.ToInt16(RxBuffer, 9);
                    rov.engine.engine6_speed = BitConverter.ToInt16(RxBuffer, 11);

                    rov.sensor.angle_pitch = BitConverter.ToSingle(RxBuffer, 13);
                    rov.sensor.angle_roll = BitConverter.ToSingle(RxBuffer, 17);
                    rov.sensor.gyro_x = BitConverter.ToSingle(RxBuffer, 21);
                    rov.sensor.gyro_y = BitConverter.ToSingle(RxBuffer, 25);
                    rov.sensor.gyro_z = BitConverter.ToSingle(RxBuffer, 29);
                    rov.sensor.deapth = BitConverter.ToSingle(RxBuffer, 33);

                    rov.mode_value = BitConverter.ToUInt16(RxBuffer, 37);

                    rov.servo.servo1 = BitConverter.ToUInt16(RxBuffer, 39);
                    rov.servo.servo2 = BitConverter.ToUInt16(RxBuffer, 41);
                    rov.servo.servo3 = BitConverter.ToUInt16(RxBuffer, 43);
                    rov.servo.servo4 = BitConverter.ToUInt16(RxBuffer, 45);
                }

                if (RxBuffer[0] == Startbit_PIDData)
                {

                rov.pidData_pitch.P = BitConverter.ToSingle(RxBuffer, 1);
                rov.pidData_pitch.I = BitConverter.ToSingle(RxBuffer, 5);
                rov.pidData_pitch.D = BitConverter.ToSingle(RxBuffer, 9);

                rov.pidData_pitch_w.P = BitConverter.ToSingle(RxBuffer, 13);
                rov.pidData_pitch_w.I = BitConverter.ToSingle(RxBuffer, 17);
                rov.pidData_pitch_w.D = BitConverter.ToSingle(RxBuffer, 21);

                rov.pidData_depth.P = BitConverter.ToSingle(RxBuffer, 25);
                rov.pidData_depth.I = BitConverter.ToSingle(RxBuffer, 29);
                rov.pidData_depth.D = BitConverter.ToSingle(RxBuffer, 33);

                rov.pidData_yaw_w.P = BitConverter.ToSingle(RxBuffer, 37);
                rov.pidData_yaw_w.I = BitConverter.ToSingle(RxBuffer, 41);
                rov.pidData_yaw_w.D = BitConverter.ToSingle(RxBuffer, 45);

                if (!(Form_PID1 == null || Form_PID1.IsDisposed))
                    Form_PID1.PID_ParaTextChange();//更新当前PID值

            }

                if (RxBuffer[0] == Startbit_Motion_Control)
                {
                    rov.setpara.depth_set = BitConverter.ToSingle(RxBuffer, 1);
                    rov.setpara.pitch_set = BitConverter.ToSingle(RxBuffer, 5);
                    rov.setpara.yaw_w_set = BitConverter.ToSingle(RxBuffer, 9);
                    if (!(Form_PID1 == null || Form_PID1.IsDisposed))
                    Form_PID1.PID_ParaTextChange();//更新当前PID值
            }


            }

            //装包
            public static byte[] DataToSendProcessor(byte startbit, ROV rov)
            {
                byte endbit = 0x00;
                List<byte> TXBuffer = new List<byte>
                {
                    startbit
                };
                if (startbit == Startbit_Engine_Control)
                {
                    TXBuffer.AddRange(BitConverter.GetBytes(rov.engine.engine1_speed));
                    TXBuffer.AddRange(BitConverter.GetBytes(rov.engine.engine2_speed));
                    TXBuffer.AddRange(BitConverter.GetBytes(rov.engine.engine3_speed));
                    TXBuffer.AddRange(BitConverter.GetBytes(rov.engine.engine4_speed));
                    TXBuffer.AddRange(BitConverter.GetBytes(rov.engine.engine5_speed));
                    TXBuffer.AddRange(BitConverter.GetBytes(rov.engine.engine6_speed));
            }

                if (startbit == Startbit_PIDData)
                {
                TXBuffer.AddRange(BitConverter.GetBytes(rov.pidData_pitch.P));
                TXBuffer.AddRange(BitConverter.GetBytes(rov.pidData_pitch.I));
                TXBuffer.AddRange(BitConverter.GetBytes(rov.pidData_pitch.D));

                TXBuffer.AddRange(BitConverter.GetBytes(rov.pidData_pitch_w.P));
                TXBuffer.AddRange(BitConverter.GetBytes(rov.pidData_pitch_w.I));
                TXBuffer.AddRange(BitConverter.GetBytes(rov.pidData_pitch_w.D));

                TXBuffer.AddRange(BitConverter.GetBytes(rov.pidData_depth.P));
                TXBuffer.AddRange(BitConverter.GetBytes(rov.pidData_depth.I));
                TXBuffer.AddRange(BitConverter.GetBytes(rov.pidData_depth.D));

                TXBuffer.AddRange(BitConverter.GetBytes(rov.pidData_yaw_w.P));
                TXBuffer.AddRange(BitConverter.GetBytes(rov.pidData_yaw_w.I));
                TXBuffer.AddRange(BitConverter.GetBytes(rov.pidData_yaw_w.D));

            }

                if (startbit == Startbit_Motion_Control)
                {
                    TXBuffer.AddRange(BitConverter.GetBytes(rov.setpara.depth_set));
                    TXBuffer.AddRange(BitConverter.GetBytes(rov.setpara.pitch_set));
                    TXBuffer.AddRange(BitConverter.GetBytes(rov.setpara.yaw_w_set));
                }

                if (startbit == Startbit_Mode)
                {
                    TXBuffer.AddRange(BitConverter.GetBytes(rov.mode_value));
                }

                //键盘部分
                if (startbit == Startbit_Key)
                {
                    //TXBuffer.Add(Convert.ToByte((handle.Left_x + 1) / 2 * 255));
                    //TXBuffer.Add(Convert.ToByte((handle.Left_y + 1) / 2 * 255));
                    //TXBuffer.Add(Convert.ToByte((handle.Right_x + 1) / 2 * 255));
                    //TXBuffer.Add(Convert.ToByte((handle.Right_y + 1) / 2 * 255));

                }

                if (startbit == Startbit_Camera)
                {
                    TXBuffer.Add(Convert.ToByte(rov.Camera_angle));
                }

                if (startbit == Startbit_Servo)
                {
                    TXBuffer.AddRange(BitConverter.GetBytes(rov.servo.servo1));
                    TXBuffer.AddRange(BitConverter.GetBytes(rov.servo.servo2));
                    TXBuffer.AddRange(BitConverter.GetBytes(rov.servo.servo3));
                    TXBuffer.AddRange(BitConverter.GetBytes(rov.servo.servo4));
                }

                for (int i = 0; i < TXBuffer.Count; i++)
                    endbit += TXBuffer[i];
                TXBuffer.Add(endbit);
                byte[] TXData = TXBuffer.ToArray();
                return TXData;
            }
    }
}
