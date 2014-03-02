using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Windows;
using System.Threading;
using tscui.Service;

namespace tscui.Models
{

    /// <summary>
    /// UDP操作工具类
    /// </summary>
    class Udp
    {

        static Socket _socket;
        static IPEndPoint _local = new IPEndPoint(IPAddress.Parse("192.168.0.2"), 5238);
        static Thread _receiveThread = null;

        #region 开启接收线程
        public static void StartReceive()
        {
            try
            {

                _socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                bool aa = _socket.Connected;
                _receiveThread = new Thread(Receive);
                _receiveThread.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
        #endregion

        #region 向服务端发送数据

        public static bool sendUdp(string ipstr, int port, byte[] hex)
        {
            try
            {
                // int len;
                // bool flag = IsSocketConnected(_socket);
                IPEndPoint ip = new IPEndPoint(IPAddress.Parse(ipstr), port);
                _socket.SendTimeout = 1000;
                _socket.ReceiveTimeout = 1000;
                _socket.SendTo(hex, ip);
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                return false;

            }
        }
        #endregion

        #region 关闭接收线程和socket连接
        public static void Close()
        {
            if (_receiveThread != null)
                _receiveThread.Abort();
            if (_socket != null)
                _socket.Close();
        }
        #endregion

        #region 接收线程委托方法
        private static void Receive()
        {
            try
            {
                Thread.Sleep(500);
                if (_socket.Connected)
                {
                    _socket.Bind(_local);                  
                }
                while (true)
                {
                    byte[] buffer = new byte[255];
                    EndPoint remoteEP = (EndPoint)(new IPEndPoint(IPAddress.Any, 0));
                    int len = _socket.ReceiveFrom(buffer, ref remoteEP);
                    IPEndPoint ipEndPoint = remoteEP as IPEndPoint;
                    GBT_20999_Utils gb20999 = new GBT_20999_Utils(buffer, len);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + _socket.Connected.ToString() + "UpdSocket类 Receive方法出错");
            }
        }
        #endregion


        static Socket _countDownSocket;
        static IPEndPoint _countDownLocal = new IPEndPoint(IPAddress.Parse("192.168.0.2"), 5238);
        static Thread _countDownReceiveThread = null;
        #region 开启接收线程
        public static void StartReceiveEchoCountDown()
        {
            try
            {

                _countDownSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                bool aa = _countDownSocket.Connected;
                _countDownReceiveThread = new Thread(ReceiveEchoCountDown);
                _countDownReceiveThread.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
        #endregion

        #region 向服务端发送数据

        public static bool sendUdpEchoCountDown(string ipstr, int port, byte[] hex)
        {
            try
            {
                // int len;
                // bool flag = IsSocketConnected(_socket);
                IPEndPoint ip = new IPEndPoint(IPAddress.Parse(ipstr), port);
                //_countDownSocket.SendTimeout = 1000;
                //_countDownSocket.ReceiveTimeout = 1000;
                _countDownSocket.SendTo(hex, ip);
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                return false;

            }
        }
        #endregion

        #region 关闭接收线程和socket连接
        public static void CloseEchoCountDown()
        {
            if (_countDownReceiveThread != null)
                _countDownReceiveThread.Abort();
            if (_countDownSocket != null)
                _countDownSocket.Close();
        }
        #endregion

        #region 接收线程委托方法
        private static void ReceiveEchoCountDown()
        {
            try
            {
                Thread.Sleep(500);
                if (_countDownSocket.Connected)
                {
                    _countDownSocket.Bind(_countDownLocal);
                }
                while (true)
                {
                    byte[] buffer = new byte[255];
                    EndPoint remoteEP = (EndPoint)(new IPEndPoint(IPAddress.Any, 0));
                    int len = _countDownSocket.ReceiveFrom(buffer, ref remoteEP);
                    IPEndPoint ipEndPoint = remoteEP as IPEndPoint;
                    EchoCountDownService gb20999 = new EchoCountDownService(buffer, len);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + _countDownSocket.Connected.ToString() + "UpdSocket类 Receive方法出错");
            }
        }
        #endregion

        public static bool sendUdpNoReciveData(string ipstr, int port, byte[] hex)
        {
            int recv;
            Socket server = null;
            byte[] bytes = new byte[65535];
            try
            {
                IPEndPoint ip = new IPEndPoint(IPAddress.Parse(ipstr), port);
                server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                // string str = "Hello Server!";
                //bytes = System.Text.Encoding.ASCII.GetBytes(str);
                server.SendTimeout = 4000;
                server.ReceiveTimeout = 4000;
                server.SendTo(hex, ip);
                IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
                EndPoint Remote = (EndPoint)(sender);
                //server.Bind(sender);
                recv = server.ReceiveFrom(bytes, ref Remote);
                Console.WriteLine("Message received from {0}", Remote.ToString());
                //str = System.Text.Encoding.ASCII.GetString(bytes, 0, recv);
                Console.WriteLine("Message: " + bytes[0]);
                server.Close();
                server = null;
                if (bytes[0] == 134)
                    return false;
                else
                    return true;
            }
            catch (Exception exce)
            {
                Console.WriteLine(exce.ToString());
                server.Close();
                server = null;
                return false;
            }

        }


        public static byte[] recvUdp(string ipstr, int port, byte[] hex)
        {
            int recv;
            Socket server = null;
            byte[] bytes = new byte[65535];
            byte[] result = { };
            try
            {
                IPEndPoint ip = new IPEndPoint(IPAddress.Parse(ipstr), port);
                server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                // string str = "Hello Server!";
                server.ReceiveTimeout = 4000;
                server.SendTimeout = 4000;
                //bytes = System.Text.Encoding.ASCII.GetBytes(str);
                server.SendTo(hex, ip);
                IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
                EndPoint Remote = (EndPoint)(sender);
                //server.Bind(sender);
                recv = server.ReceiveFrom(bytes, ref Remote);
                Console.WriteLine("Message received from {0}", Remote.ToString());
                //str = System.Text.Encoding.ASCII.GetString(bytes, 0, recv);
                Console.WriteLine("Message: " + bytes[0]);
                result = new byte[recv];
                Array.Copy(bytes, result, recv);
                server.Close();
                server = null;
                return result;
            }
            catch (Exception exce)
            {
                Console.WriteLine(exce.ToString());
                server.Close();
                server = null;
                return result;
            }

        }
        /// <summary>
        /// 得到本机的所以IP，如果只有一个网卡也就得
        /// 到一个IP，有多个就可以得到多少IP
        /// </summary>
        /// <returns></returns>
        public static List<IPAddress> getLocalHostIpAddress()
        {
            List<IPAddress> list = new List<IPAddress>();
            //for(int i=0;i)
            IPAddress[] ipa = Dns.GetHostByName(Dns.GetHostName()).AddressList;
            for (int i = 0; i < ipa.Length; i++)
                list.Add(ipa[i]);
            return list;
        }
 
    }
}
