using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using tscui.Models;

namespace tscui.Service
{
    class GBT_20999_Utils
    {
        public GBT_20999_Utils(byte [] gb20099_byte,int len)
        {
            //System.Windows.MessageBox.Show("20999");
            if (len == 4)
            {
                Resolve(gb20099_byte, len);
            }
            else
            {
                Resolve(gb20099_byte, len);
            }
        }

        private void Resolve(byte[] data, int len)
        {

            byte[] newbyte = ConvertToByte(data, len);
            switch (newbyte[1])
            {
                case 0xA5: //当前的信号机控制状态
                    break;
                case 0xB5: //手动控制方案
                    break;
                case 0xB6: //系统控制方案
                    break;
                case 0xB7: //控制方式
                    break;
                case 0xBA: //阶段状态 
                    break;
                case 0xBB: //步进指令
                    break;
                case 0x86: //公共时间
                    break;
                case 0x88: //本地时间
                    break;
                case 0xf7: //主动上报命令定制
                    break;
                case 0xf8://信号机扩展状态
                    SetReportStatus(newbyte);
                    //System.Windows.MessageBox.Show("0xf8");
                    ReportTscStatus.resportSuccessFlag = true;
                    break;
                default:
                    break;
            }
        }
        private byte[] ConvertToByte(byte[] data, int len)
        {

            string strResult = string.Empty;
            //string strTemp;
            byte[] newbyte = new byte[len];
            for (int i = 0; i < len; i++)
            {
                newbyte[i] = data[i];
            }
            return newbyte;
        }
        public  void SetReportStatus(byte[] byt)
        {
           
            if (!CheckGBT(byt, "主动上报"))
            {
                
            }
            byte b1 = new byte();
            byte b2 = new byte();
            byte b3 = new byte();
            b1 = byt[3];
            b2 = byt[3];
            b3 = byt[3];
            string workModel = Utils.Utils.ReportStatusWorkModel(b1);
            string workStatus = Utils.Utils.ReportStatusWorkStatus(b2);
            string controlMode = Utils.Utils.ReportStatusControlMode(b3); 
            ReportTscStatus.sControlModel = controlMode;
            ReportTscStatus.sWorkModel = workModel;
            ReportTscStatus.sWorkStatus = workStatus;
            ReportTscStatus.iCurrentSchedule = Convert.ToInt32(byt[4]);
            ReportTscStatus.iCurrentTimePattern = Convert.ToInt32(byt[5]);
            ReportTscStatus.iCurrentStagePattern = Convert.ToInt32(byt[6]);
            //ReportTscStatus.iCurrentStage = Convert.ToInt32
            ReportTscStatus.iStageCount = Convert.ToInt32(byt[7]);//当前周期几个阶段
            ReportTscStatus.iCurrentStage = Convert.ToInt32(byt[8]); //当前阶段号
            ReportTscStatus.iStageTotalTime = Convert.ToInt32(byt[9]);//当前阶段总时长
            ReportTscStatus.iStageRunTime = Convert.ToInt32(byt[10]); //当前相位运行时间
            //ReportTscStatus.iCycleTime = Convert.ToInt32(byt[27]); //周期
            byte[] channelRedStatus = { byt[11], byt[12], byt[13], byt[14] }; //红灯
            ReportTscStatus.listChannelRedStatus = Utils.Utils.ReportStatusLampStatus(channelRedStatus);
            byte[] channelYellowStatus = { byt[15], byt[16], byt[17], byt[18] };//黄灯
            ReportTscStatus.listChannelYellowStatus = Utils.Utils.ReportStatusLampStatus(channelYellowStatus);
            byte[] channelGreenStatus = { byt[19], byt[20], byt[21], byt[22] };//绿灯
            ReportTscStatus.listChannelGreenStatus = Utils.Utils.ReportStatusLampStatus(channelGreenStatus);
            byte[] channelFlashStatus = { byt[23], byt[24], byt[25], byt[26] };//黄闪
            ReportTscStatus.listChannelFlashStatus = Utils.Utils.ReportStatusLampStatus(channelFlashStatus);
            ReportTscStatus.iCycleTime = byt[27];

          
        }

        public static bool CheckGBT(byte[] b, string fun)
        {
            if (b[0] == 0x86)
            {
                if (b[1] == 0x05)
                {
                    Console.WriteLine(fun + ":国标通信协议错误类型中的其它错误原因！");
                    return false;
                }
                else if (b[1] == 0x01)
                {
                    Console.WriteLine(fun + ":国标通信协议错误类型中的消息长度太长！");
                    return false;
                }
                else if (b[1] == 0x02)
                {
                    Console.WriteLine(fun + ":国标通信协议错误类型中的消息类型错误！");
                    return false;
                }
                else if (b[1] == 0x03)
                {
                    Console.WriteLine(fun + ":国标通信协议错误类型中的消息设置对象值超出规定的范围！");
                    return false;
                }
                else if (b[1] == 0x04)
                {
                    Console.WriteLine(fun + ":国标通信协议错误类型中的消息长度太短！");
                    return false;
                }
                else
                {
                    //MessageBox.Show(fun + ":未知原因！");
                    return false;
                }
            }

            return true;

        }
    }
}
