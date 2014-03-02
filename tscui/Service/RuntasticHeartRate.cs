using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Windows;
using tscui.Models;
using System.Timers;

namespace tscui.Service
{
    class RuntasticHeartRate
    {


        public  RuntasticHeartRate()
        {
        }
        public void BroadCastToTsc(object source, ElapsedEventArgs e)
        {
            
            try
            {
                UdpClient client = new UdpClient(AddressFamily.InterNetwork);
                IPEndPoint iep = new IPEndPoint(IPAddress.Broadcast, Define.GBT_PORT);
               // buffer =
                client.Send(Define.DEGRADATION_UTC, Define.DEGRADATION_UTC.Length, iep);
                //buffer = client.Receive(ref iep);
                client.Close();
                client = null;
            }
            catch (Exception ext)
            {
                //(ext.Message);
                Console.WriteLine(ext.Message);
            }
        }
        public void TimerBroadCast()
        {
            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(BroadCastToTsc);  //到达时间的时候执行事件；
            //设置引发时间的时间间隔此处设置为１秒（１０００毫秒）
            aTimer.Interval = Define.RUNTASTIC_HEART_RATE_TIME;
            aTimer.AutoReset = true;//设置是执行一次（false）还是一直执行 (true)； 
            aTimer.Enabled = true; //是否执行System.Timers.Timer.Elapsed事件

        }
        public void RunHeartRate()
        {
            // 启动消息接收线程
            if (Define.RUN_THREAD_FLAG)
            {
                Thread ReceiveMessageThread = new Thread(TimerBroadCast);
                ReceiveMessageThread.IsBackground = true;
                ReceiveMessageThread.Start();
            }
        }
      
    }
}
