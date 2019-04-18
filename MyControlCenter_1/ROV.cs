using System;

namespace MyControlCenter_1
{
    public class ROV
    {
            public static UInt16 MODE_PID = 0x0080;
            //public static UInt16 MODE_HANDLE = 0x0008;

            //4个电机
            public struct Engine
            {
                public Int16 engine1_speed;
                public Int16 engine2_speed;
                public Int16 engine3_speed; 
                public Int16 engine4_speed;
                public Int16 engine5_speed;
                public Int16 engine6_speed;
        };

            //陀螺仪
            public struct Sensor
            {
                public float angle_pitch;
                public float angle_roll;
                public float gyro_x;
                public float gyro_y;
                public float gyro_z;
                public float deapth;
            };

            public struct PID
            {
                public float P;
                public float I;
                public float D;
            };

            public struct Setpara
            {
                public float depth_set;
                public float pitch_set;
                public float yaw_w_set;

            };

            //4个舵机
            public struct Servo
            {
                public UInt16 servo1;
                public UInt16 servo2;
                public UInt16 servo3;//机械臂
                public UInt16 servo4;
            };
        
            //摄像头
            float camera_angle = 128;

            public float Camera_angle
            {
                get { return camera_angle; }
                set
                {
                    if (value > 255)
                        camera_angle = 255;
                    else if (value < 0)
                        camera_angle = 0;
                    else
                        camera_angle = value;
                }
            }
            
            // 模式选择
            public bool Ismode(UInt16 mode)
            {
                if ((mode_value & mode) != 0)
                    return true;
                else
                    return false;
            }

            public void Setmode(UInt16 mode, bool state)
            {
                if (state == true)
                    mode_value |= mode;
                else
                    mode_value &= (UInt16)(~mode);

            }


            public PID pidData_pitch = new PID();
            public PID pidData_roll = new PID();
            public PID pidData_pitch_w = new PID();
            public PID pidData_roll_w = new PID();
            public PID pidData_yaw_w = new PID();
            public PID pidData_depth = new PID();



            public Engine engine = new Engine();
            public Sensor sensor = new Sensor();
            public Setpara setpara = new Setpara();
            public Servo servo = new Servo();

            public UInt16 mode_value = 0x0000;

            public static UInt16 servo1_max = 90;
            public static UInt16 servo1_min = 60;

            public static UInt16 servo3_max = 80;
            public static UInt16 servo3_min = 45;

            public static UInt16 servo4_max = 22;
            public static UInt16 servo4_min = 5;

            public ROV()
            {
                servo.servo1 = 90;
                servo.servo2 = 51;
                servo.servo3 = 80;
                servo.servo4 = servo4_max;
            }
    }
}
