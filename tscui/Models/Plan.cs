using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tscui.Models
{
    class Plan
    {
        private byte _ucId;
        private ushort _usMonthFlag;
        private byte _ucWeekFlag;
        private uint _ulDayFlag;
        private byte _ucScheduleId;
        public byte ucId
        {
            get { return _ucId; }
            set { _ucId = value; }
        }
        public ushort usMonthFlag
        {
            get { return _usMonthFlag; }
            set { _usMonthFlag = value; }
        }
        public byte ucWeekFlag
        {
            get { return _ucWeekFlag; }
            set { _ucWeekFlag = value; }
        }
        public uint ulDayFlag
        {
            get { return _ulDayFlag; }
            set { _ulDayFlag = value; }
        }
        public byte ucScheduleId
        {
            get { return _ucScheduleId; }
            set { _ucScheduleId = value; }
        }
    }
}
