using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using tscui.Models;
using System.Windows;
using tscui.Pages.BaseTime;

namespace tscui.Utils
{
    class Utils
    {
        public static uint allowPhase(List<bool> phases)
        {
            
            return 65793;
        }
        public static string GetTscIpAddress()
        {
            TscData t = (TscData)Application.Current.Properties[Define.TSC_DATA];
            return t.Node.sIpAddress;
        }
        /// <summary>
        /// 返回当前选择信号机的对象，如果返回NULL。那么就是没有选择一个信号机的。
        /// </summary>
        /// <returns></returns>
        public static TscData GetTscDataByApplicationCurrentProperties()
        {
            return (TscData)Application.Current.Properties[Define.TSC_DATA];
        }
        public static Phase GetPhaseByCurrent()
        {
            return (Phase)Application.Current.Properties[Define.SELECTED_PHASE_OVERLAP];
        }
        public static void SetPhaseByCurrent(Phase p)
        {
            Application.Current.Properties[Define.SELECTED_PHASE_OVERLAP] = p;
        }
        public static OverlapPhase GetOverLapPhaseByCurrent()
        {
            return (OverlapPhase)Application.Current.Properties[Define.SELECTED_PHASE_OVERLAP];
        }
        public static void SetOverLapPhaseByCurrent(OverlapPhase op)
        {
            Application.Current.Properties[Define.SELECTED_PHASE_OVERLAP] = op;
        }
        public static string GetPhaseOverlapPhaseType()
        {
            return (string)Application.Current.Properties[Define.SELECTED_PHASE_OVERLAP_TYPE];
        }
        public static void SetPhaseOverlapPhaseType(string type)
        {
            Application.Current.Properties[Define.SELECTED_PHASE_OVERLAP_TYPE] = type;
        }
        public static void SetSelectedDetector(int i)
        {
            Application.Current.Properties[Define.SELECTED_DETECTOR] = i;
        }
        public static int GetSelectedDetector()
        {
            return (int)Application.Current.Properties[Define.SELECTED_DETECTOR];
        }
        /// <summary>
        /// 通道灯色状态显示
        /// </summary>
        /// <param name="ba"></param>
        /// <returns></returns>
        public static List<uint> ReportStatusLampStatus(byte[] ba)
        {
            List<uint> listLamp = new List<uint>();
            //ba = ba.Reverse().ToArray();
            uint ui = System.BitConverter.ToUInt32(ba,0);
            //ui >> 31;
            for (int i = 0; i < 32; i++)
            {
                uint rs = (ui >> i) & 0x01;
                listLamp.Add(rs);
            }
            return listLamp;
        }
        /// <summary>
        /// 信号机主动上报的情况下，对控制方式的解析
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public static string ReportStatusControlMode(byte b)
        {
            string result = "";
            int f = b & 0xf0;
            switch (f)
            {
                case 16:
                    result = "多时段";
                    break;
                case 32:
                    result = "系统优化";
                    break;
                case 48:
                    result = "无电线缆协调";
                    break;
                case 96:
                    result = "手动";
                    break;
                case 112:
                    result = "感应";
                    break;
                case 160:
                    result = "自适应";
                    break;
                case 176:
                    result = "面板控制";
                    break;
                case 4:
                    result = "标准";
                    break;
                default:
                    break;
            }
            return result;
        }
        /// <summary>
        /// 信号机主动上报的情况下，对工作状态的解析
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public static string ReportStatusWorkStatus(byte b)
        {
            string result = "";
            int f = b & 0x0c;
            switch (f)
            {
                case 0:
                    result = "关灯";
                    break;
                case 4:
                    result = "全红";
                    break;
                case 8:
                    result = "闪光";
                    break;
                case 12:
                    result = "标准";
                    break;
                default:
                    break;
            }
            return result;
        }
        /// <summary>
        /// 信号机主动上报的情况下，对工作模式的解析
        /// </summary>
        /// <param name="bt"></param>
        /// <returns></returns>
        public static string ReportStatusWorkModel(byte bt)
        {
            string result = "";
            int f = bt &0x03;
            switch (f)
            {
                case 0:
                    result = "信号机正常";
                    break;
                case 1:
                    result = "一次过街";
                    break;
                case 2:
                    result = "二次过街";
                    break;
                case 3:
                    result = "保留";
                    break;
                default:
                    break;
            }
            return result;
        }

        /// <summary>
        /// 将Unix时间戳转换为DateTime类型时间
        /// </summary>
        /// <param name="d">double 型数字</param>
        /// <returns>DateTime</returns>
        public static System.DateTime ConvertIntDateTime(double d)
        {
            System.DateTime time = System.DateTime.MinValue;
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            time = startTime.AddSeconds(d);
            time = time.AddHours(-8);
            return time;
        }
        /// <summary>
        /// 将c# DateTime时间格式转换为Unix时间戳格式
        /// </summary>
        /// <param name="time">时间</param>
        /// <returns>double</returns>
        public static double ConvertDateTimeInt(System.DateTime time)
        {
            double intResult = 0;
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            intResult = (time - startTime).TotalSeconds;
            return intResult;
        }
        /// <summary>
        /// 根据类型的数字，得到字符串的描述文字
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static string EventType2String(int i)
        {
            string result = "未知";
            switch (i)
            {
                case 0:
                    result = "信号灯";
                    break;
                case 1:
                    result = "绿冲突";
                    break;
                case 2:
                    result = "检测器";
                    break;
                case 3:
                    result = "电压";
                    break;
                case 4:
                    result = "温度";
                    break;
                case 5:
                    result = "黄闪器";
                    break;
                case 15:
                    result = "其他类型日志";
                    break;
                case 6:
                    result = "灯控板";
                    break;
                case 7:
                    result = "检测器板";
                    break;
                case 8:
                    result = "黄闪器板";
                    break;
                case 9:
                    result = "程序重启";
                    break;
                case 10:
                    result = "系统时间修改";
                    break;
                case 11:
                    result = "门报警";
                    break;
                case 12:
                    result = "机器手动";
                    break;
                case 13:
                    result = "灯色输出异常";
                    break;
                case 14:
                    result = "灯色输出异常2";
                    break;
                case 16:
                    result = "can总线";
                    break;
                default:
                    break;
            }

            return result;
        }
        /// <summary>
        /// 事件日志内容的解析方法
        /// </summary>
        /// <param name="i"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string EventDesc2String(uint i, byte type)
        {
            string result = "";
            if (type == 0x00)
            {
                byte[] bpara = System.BitConverter.GetBytes(i);
                bpara = bpara.Reverse().ToArray();
                byte b1 = bpara[0];
                result = result + "信号灯，第【" + b1 + "】号灯，内容：";
                switch (bpara[1])
                {
                    case 0x00:
                        result = result + "【正常】";
                        break;
                    case 0x01:
                        result = result + "【长亮】";
                        break;
                    case 0x02:
                        result = result + "【长灭】";
                        break;
                    case 0x03:
                        result = result + "【可控硅击穿】";
                        break;
                    default:
                        result = result + "【未知】";
                        break;
                }
                result = result + "，第【" + bpara[3] + "】灯控板。";
            }
            else if (type == 0x01)
            {
                byte[] bpara = System.BitConverter.GetBytes(i);
                bpara = bpara.Reverse().ToArray();
                result = result + "绿冲突，";
                switch (bpara[0])
                {
                    case 0x00:
                        result = result + "正常";
                        break;
                    case 0x01:
                        result = result + "红绿软冲突";
                        break;
                    case 0x02:
                        result = result + "红绿硬冲突";
                        break;
                    case 0x03:
                        result = result + "相位绿冲突";
                        break;
                    default:
                        break;
                }
                result = result + ",冲突灯控板号【" + bpara[1] + "】,冲突灯组号【" + bpara[2] + "】";
            }
            else if (type == 0x02)
            {
                byte[] bpara = System.BitConverter.GetBytes(i);
                bpara = bpara.Reverse().ToArray();
                result = result + "检测器，第【" + bpara[0] + "】号";
                switch (bpara[1])
                {
                    case 0x00:
                        result = result + "正常";
                        break;
                    case 0x01:
                        result = result + "线圈开路";
                        break;
                    case 0x02:
                        result = result + "线圈短路";
                        break;
                    case 0x03:
                        result = result + "通道停振";
                        break;
                    default:
                        break;
                }
                //result = result + ",冲突灯控板号【" + bpara[1] + "】,冲突灯组号【" + bpara[2] + "】";
            }
            else if (type == 0x03)
            {
                byte[] bpara = System.BitConverter.GetBytes(i);
                bpara = bpara.Reverse().ToArray();
                result = result + "电压，";
                switch (bpara[0])
                {
                    case 0x00:
                        result = result + "电压正常";
                        break;
                    case 0x01:
                        result = result + "电压偏低";
                        break;
                    case 0x02:
                        result = result + "电压偏高";
                        break;

                    default:
                        break;
                }
                result = result + ",电压值【" + bpara[1] + "】";
            }
            else if (type == 0x04)
            {
                byte[] bpara = System.BitConverter.GetBytes(i);
                bpara = bpara.Reverse().ToArray();
                result = result + "温度，";
                switch (bpara[0])
                {
                    case 0x00:
                        result = result + "温度正常";
                        break;
                    case 0x01:
                        result = result + "温度偏低,需要风扇加热";
                        break;
                    case 0x02:
                        result = result + "温度偏高,需要风扇散热";
                        break;

                    default:
                        break;
                }
                result = result + ",温度值【" + bpara[1] + "】";
            }
            else if (type == 0x05)
            {
                byte[] bpara = System.BitConverter.GetBytes(i);
                bpara = bpara.Reverse().ToArray();
                result = result + "电源板，";
                switch (bpara[0])
                {
                    case 0x00:
                        result = result + "正常";
                        break;
                    case 0x01:
                        result = result + "与主板通信异常";
                        switch (bpara[1])
                        {
                            case 0x00:
                                result = result + "长时间没有通信数据！";
                                break;
                            case 0x01:
                                result = result + "长时间数据错误，地址错误！";
                                break;
                            case 0x02:
                                result = result + "长时间数据错误，检验错误！";
                                break;
                            default:
                                break;
                        }
                        break;
                  
                    default:
                        break;
                }
                result = result + ",问题板卡【" + bpara[2] + "】";
            }
            else if (type == 0x06)
            {
                byte[] bpara = System.BitConverter.GetBytes(i);
                bpara = bpara.Reverse().ToArray();
                result = result + "灯控板，";
                switch (bpara[0])
                {
                    case 0x00:
                        result = result + "正常";
                        break;
                    case 0x01:
                        result = result + "与主板通信异常";
                        switch (bpara[1])
                        {
                            case 0x00:
                                result = result + "长时间没有通信数据！";
                                break;
                            case 0x01:
                                result = result + "长时间数据错误，地址错误！";
                                break;
                            case 0x02:
                                result = result + "长时间数据错误，检验错误！";
                                break;
                            default:
                                break;
                        }
                        break;

                    default:
                        break;
                }
                result = result + ",问题板卡【" + bpara[2] + "】";
            }
            else if (type == 0x07)
            {
                byte[] bpara = System.BitConverter.GetBytes(i);
                bpara = bpara.Reverse().ToArray();
                result = result + "检测器，";
                switch (bpara[0])
                {
                    case 0x00:
                        result = result + "正常";
                        break;
                    case 0x01:
                        result = result + "与主板通信异常";
                        switch (bpara[1])
                        {
                            case 0x00:
                                result = result + "长时间没有通信数据！";
                                break;
                            case 0x01:
                                result = result + "长时间数据错误，地址错误！";
                                break;
                            case 0x02:
                                result = result + "长时间数据错误，检验错误！";
                                break;
                            default:
                                break;
                        }
                        break;

                    default:
                        break;
                }
                result = result + ",问题板卡【" + bpara[2] + "】";
            }
            else if (type == 0x08)
            {
                byte[] bpara = System.BitConverter.GetBytes(i);
                bpara = bpara.Reverse().ToArray();
                result = result + "黄闪器，";
                switch (bpara[0])
                {

                    case 0x01:
                        result = result + "灯泡故障";
                        break;
                    case 0x02:
                        result = result + "绿冲突（相位）(主控板判断)";
                        break;
                    case 0x03:
                        result = result + "红绿冲突(灯控板判断)";
                        break;
                    case 0x04:
                        result = result + "强制黄闪";
                        break;
                    case 0x05:
                        result = result + "降级黄闪";
                        break;
                    case 0x06:
                        result = result + "主板异常黄闪";
                        break;
                    default:
                        break;
                }
                //result = result + ",冲突灯控板号【" + bpara[1] + "】,冲突灯组号【" + bpara[2] + "】";
            }
            else if (type == 0x09)
            {
                byte[] bpara = System.BitConverter.GetBytes(i);
                bpara = bpara.Reverse().ToArray();
                result = result + "程序重起，";
                switch (bpara[0])
                {
                    case 0x00:
                        result = result + "正常";
                        break;
                    case 0x01:
                        result = result + "从主板异常恢复";
                        break;
                    case 0x02:
                        result = result + "从红绿冲突故障恢复";
                        break;
                    case 0x03:
                        result = result + "从灯泡故障恢复";
                        break;
                    
                    default:
                        break;
                }
                
            }
            else if (type == 0x0a)
            {
                //byte[] bpara = System.BitConverter.GetBytes(i);
                result = result + "修改时间，";
                //增加时间转换
                result = result + Utils.ConvertIntDateTime(i).ToString();

            }
            else if (type == 0x0b)
            {
                byte[] bpara = System.BitConverter.GetBytes(i);
                bpara = bpara.Reverse().ToArray();
                result = result + "门检测，";
                switch (bpara[0])
                {
                    case 0x00:
                        result = result + "关门";
                        break;
                    case 0x01:
                        result = result + "开门";
                        break;
                    
                    default:
                        break;
                }

            }
            else if (type == 0x0c)
            {
                byte[] bpara = System.BitConverter.GetBytes(i);
                bpara = bpara.Reverse().ToArray();
                result = result + "手动控制，";
                switch (bpara[0])
                {
                    case 0x00:
                        result = result + "手动";
                        break;
                    case 0x01:
                        result = result + "去掉手动，恢复自主控制";
                        break;
                    case 0x02:
                        result = result + "黄闪";
                        break;
                    case 0x03:
                        result = result + "去掉黄闪";
                        break;
                    case 0x04:
                        result = result + "全红";
                        break;
                    case 0x05:
                        result = result + "去掉全红";
                        break;
                    case 0x06:
                        result = result + "步进";
                        break;
                    default:
                        break;
                }
            }
            else if (type == 0x0d)
            {
                byte[] bpara = System.BitConverter.GetBytes(i);
                bpara = bpara.Reverse().ToArray();
                result = result + "灯控输出异常，";
                switch (bpara[0])
                {
                    case 0x00:
                        result = result + "正常灯色异常";
                        break;
                    case 0x01:
                        result = result + "闪烁灯色异常";
                        break;
                    default:
                        break;
                }
            }
            else if (type == 0x0e)
            {
                byte[] bpara = System.BitConverter.GetBytes(i);
                bpara = bpara.Reverse().ToArray();
                result = result + "广播，";
                switch (bpara[0])
                {
                    case 0x00:
                        result = result + "广播地址错误";
                        break;
                    case 0x01:
                        result = result + "某组灯多亮一盏";
                        break;
                    case 0x02:
                        result = result + "灯色黄闪";
                        break;
                    case 0x03:
                        result = result + "一块灯板多于8个绿灯亮";
                        break;
                    default:
                        break;
                }
            }
            else if (type == 0x0f)
            {
                byte[] bpara = System.BitConverter.GetBytes(i);
                bpara = bpara.Reverse().ToArray();
                result = result + "其他类型日志，";
                switch (bpara[0])
                {

                    case 0x01:
                        result = result + "控制方式切换";
                        result = result + ",旧的控制方式【" + ControlModel2String(bpara[1]) + "】,新的控制方式【" + ControlModel2String(bpara[2]) + "】,";
                        switch (bpara[3])
                        {
                            case 0x00:
                                result = result + "正常切换(上位机命令 时段表 面板)";
                                break;
                            case 0x01:
                                result = result + "异常切换  降级";
                                break;

                            default:
                                result = result + "未知";
                                break;
                        }
                        break;
                    case 0x02:
                        result = result + "故障恢复，";
                        switch (bpara[1])
                        {
                            case 0x00:
                                result = result + "正常";
                                break;
                            case 0x02:
                                result = result + "从主板异常恢复";
                                break;
                            case 0x03:
                                result = result + "从红绿冲突故障恢复";
                                break;
                            case 0x01:
                                result = result + "从灯泡故障恢复";
                                break;
                            default:
                                result = result + "未知";
                                break;
                        }
                        break;
                    default:
                        break;
                }
                
            }
            else if (type == 0x10)
            {
                byte[] bpara = System.BitConverter.GetBytes(i);
                bpara = bpara.Reverse().ToArray();
                result = result + "总线通信异常，总线重起，不影响信号机正常运行。";
            }
            return result;
        }

        public static string devMonitorDescPowerType(byte d)
        {
            string result = "";
            if (d == 0x00)
            {
                result = "市电";
            }
            else if (d == 0x01)
            {
                result = "电池";
            }
            else if (d == 0x02)
            {
                result = "太阳能电池";
            }
            else if (d == 0x03)
            {
                result = "电池供电故障";
            }
            return result;
        }
        public static string devMonitorDescDoor(byte d)
        {
            string result = "";
            if (d == 0x00)
            {
                result = "关闭状态";
            }
            else if (d == 0x01)
            {
                result = "门打开，正在报警！";
            }
            else if(d == 0x02)
            {
                result = "门关闭，报警按钮异常按下";
            }
            else if (d == 0x03)
            {
                result = "门打开，报警按钮正常按下";
            }
            return result;
        }
        /// <summary>
        /// 控制模式的解析 成字符串，文件界面输出
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public static string ControlModel2String(byte b)
        {
            string result = "";
            switch (b)
            {
                case 0x01:
                    result = result + "多时段";
                    break;
                case 0x02:
                    result = result + "系统优化，即联网";
                    break;
                case 0x03:
                    result = result + "无电线缆协调";
                    break;
                case 0x04:
                    result = result + "有线电缆协调";
                    break;
                case 0x05:
                    result = result + "主从线控";
                    break;
                case 0x06:
                    result = result + "手动控制";
                    break;
                case 0x07:
                    result = result + "单点全感应";
                    break;
                case 0x08:
                    result = result + "单点主线优先半感应";
                    break;
                case 0x09:
                    result = result + "单点次线优先半感应";
                    break;
                case 0x0a:
                    result = result + "自适应";
                    break;
                case 0x0b:
                    result = result + "面板控制";
                    break;
                default:
                    result = result + "未知";
                    break;
            }
            return result;
        }
        /// <summary>
        /// 时基表中的 调度日按周。
        /// 将一个字节运算好后，一周七天的是否选中。
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Dictionary<int,bool> WeekFlag2List(byte b)
        {
            Dictionary<int,bool> dic = new Dictionary<int,bool>();
            if ((b & 0x02) == 0x02)
            {
                dic.Add(1, true);
            }
            if ((b & 0x04) == 0x04)
            {
                dic.Add(2, true);
            }
            if ((b & 0x08) == 0x08)
            {
                dic.Add(3, true);
            }
            if ((b & 0x10) == 0x10)
            {
                dic.Add(4, true);
            }
            if ((b & 0x20) == 0x20)
            {
                dic.Add(5, true);
            }
            if ((b & 0x40) == 0x40)
            {
                dic.Add(6, true);

            }
            if ((b & 0x80) == 0x80)
            {
                dic.Add(7, true);
            }
            return dic;
        }
        /// <summary>
        /// 将short 转换成 byte[2]数组
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static byte[] Short2ByteArray(short s)
        {
            byte[] b = new byte[2];
            b[0] = (byte)((0xff00 & s) >> 8);
            b[1] = (byte)((0xff & s));
            return b;
        }
        /// <summary>
        /// 将Plan时基转换成byte[]
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static byte[] Plan2ByteArray(Plan p)
        {
            byte[] b = new byte[Define.PLAN_BYTE_SIZE];
            b[0] = p.ucId;
            //byte[] bm = new byte[2];
            byte[] bmonth = System.BitConverter.GetBytes(p.usMonthFlag);
            b[1] = bmonth[1];
            b[2] = bmonth[0];
            b[3] = p.ucWeekFlag;
            byte[] bday = System.BitConverter.GetBytes(p.ulDayFlag);
            b[4] = bday[3];
            b[5] = bday[2];
            b[6] = bday[1];
            b[7] = bday[0];
            b[8] = p.ucScheduleId;

            return b;
        }
        /// <summary>
        /// 将SeasionTime转换成Plan
        /// </summary>
        /// <param name="stvms"></param>
        /// <returns></returns>
        public static List<Plan> SeasionTime2Plan(List<SeasonTimeViewModel> stvms)
        {
            
            byte weekend = 0x00;
            List<Plan> lp = new List<Plan>();
            //foreach (SeasonTimeViewModel stvm in stvms)
            //{
            //    Plan p = new Plan();
            //    p.ucId = Convert.ToByte(stvm.TimeId);
            //    byte[] bt = new byte[2] { 0x1f, 0xfe };
            //    p.usMonthFlag = (ushort)(bt[0] << 8 + bt[1]);

            //    if (stvm.Monday)
            //    {
            //        weekend = (byte)(weekend | 0x02);
            //    }
            //    if (stvm.Tuesday)
            //    {
            //        weekend = (byte)(weekend | 0x04);
            //    }
            //    if (stvm.Wednesday)
            //    {
            //        weekend = (byte)(weekend | 0x08);
            //    }
            //    if (stvm.Thursday)
            //    {
            //        weekend = (byte)(weekend | 0x10);
            //    }
            //    if (stvm.Friday)
            //    {
            //        weekend = (byte)(weekend | 0x20);
            //    }
            //    if (stvm.Saturday)
            //    {
            //        weekend = (byte)(weekend | 0x40);
            //    }
            //    if (stvm.Sunday)
            //    {
            //        weekend = (byte)(weekend | 0x80);
            //    }
            //    p.ucWeekFlag = weekend;
            //    byte[] btday = new byte[] { 0xff, 0xff, 0xff, 0xfe };
            //    p.ulDayFlag = BitConverter.ToUInt32(btday, 0);
            //    p.ucScheduleId = Convert.ToByte(stvm.ScheduleId);
            //    lp.Add(p);
            //}
            return lp;
        }
        //isDigit是否是数字  

        public static bool isNumberic(string _string)
        {

            if (string.IsNullOrEmpty(_string))

                return false;

            foreach (char c in _string)
            {

                if (!char.IsDigit(c))

                    //if(c<'0' c="">'9')//最好的方法,在下面测试数据中再加一个0，然后这种方法效率会搞10毫秒左右  

                    return false;

            }

            return true;

        }

    }
}
