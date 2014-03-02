using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tscui.Models
{
    /// <summary>
    /// 配时方案
    /// </summary>
    class TimePattern
    {
        byte _ucId;
        byte _ucCycleLen;
        byte _ucPhaseOffset;
        byte _ucAdjustPhaseGap;
        byte _ucScheduleTimeId;
        public byte ucId
        {
            get { return _ucId; }
            set { _ucId = value; }
        }
        public byte ucCycleLen
        {
            get { return _ucCycleLen; }
            set { _ucCycleLen = value; }
        }
        public byte ucPhaseOffset
        {
            get { return _ucPhaseOffset; }
            set { _ucPhaseOffset = value; }
        }
        public byte ucAdjustPhaseGap
        {
            get { return _ucAdjustPhaseGap; }
            set { _ucAdjustPhaseGap = value; }
        }
        public byte ucScheduleTimeId
        {
            get { return _ucScheduleTimeId; }
            set { _ucScheduleTimeId = value; }
        }
        
    }
}
