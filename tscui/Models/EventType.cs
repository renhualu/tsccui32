using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tscui.Models
{
    class EventType
    {
        
        private byte _ucEvtTypeId;
        private string _ucEvtDesc;
        private long _ulClearTime;
        private byte _ucLogCount;

        public byte ucEvtTypeId
        {
            get { return _ucEvtTypeId; }
            set { _ucEvtTypeId = value; }
        }
        public string ucEvtDesc
        {
            get { return _ucEvtDesc; }
            set { _ucEvtDesc = value; }
        }
        public long ulClearTime
        {
            get { return _ulClearTime; }
            set { _ulClearTime = value; }
        }
        public byte ucLogCount
        {
            get { return _ucLogCount; }
            set { _ucLogCount = value; }
        }
    }
}
