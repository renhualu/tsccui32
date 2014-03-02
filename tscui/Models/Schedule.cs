using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tscui.Models
{
    /// <summary>
    /// 时段表
    /// </summary>
    class Schedule
    {
        private byte _ucId;
        private byte _ucEventId;
        private byte _ucHour;
        private byte _ucMin;
        private byte _ucCtrl;
        private byte _ucTimePatternId;
        private byte _ucAuxOut;
        private byte _ucSpecialOut;
        public byte ucId
        {
            get { return _ucId; }
            set { _ucId = value; }
        }
        public byte ucEventId
        {
            get { return _ucEventId; }
            set { _ucEventId = value; }
        }
        public byte ucHour
        {
            get { return _ucHour; }
            set { _ucHour = value; }
        }
        public byte ucMin
        {
            get { return _ucMin; }
            set { _ucMin = value; }
        }
        public byte ucCtrl
        {
            get { return _ucCtrl; }
            set { _ucCtrl = value; }
        }
        public byte ucTimePatternId
        {
            get { return _ucTimePatternId; }
            set { _ucTimePatternId = value; }
        }
        public byte ucAuxOut
        {
            get { return _ucAuxOut; }
            set { _ucAuxOut = value; }
        }
        public byte ucSpecialOut
        {
            get { return _ucSpecialOut; }
            set { _ucSpecialOut = value; }
        }
    }
}
