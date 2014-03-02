using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tscui.Models
{
    class EventLog
    {
        private byte _ucEventId;
        private byte _ucEvtType;
        private uint _ulHappenTime;
        private uint _ulEvtValue;
        private string _sEventType;
        //国标中无此属性，界面显示用到
        private string _ulEventTime;
        //国标中无此属性，程序处理方便面增加
        private string _sEventDesc;
        public string sEventType
        {
            get { return _sEventType; }
            set { _sEventType = value; }
        }
        public string sEventDesc
        {
            get { return _sEventDesc; }
            set { _sEventDesc = value; }
        }
        public byte ucEventId
        {
            get { return _ucEventId; }
            set { _ucEventId = value; }
        }
        public byte ucEvtType
        {
            get { return _ucEvtType; }
            set { _ucEvtType = value; }
        }
        public uint ulHappenTime
        {
            get { return _ulHappenTime; }
            set { _ulHappenTime = value; }
        }
        public uint ulEvtValue
        {
            get { return _ulEvtValue; }
            set { _ulEvtValue = value; }
        }
        public string ulEventTime
        {
            get { return _ulEventTime; }
            set { _ulEventTime = value; }
        }
    }
}
