using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tscui.Models
{
    /// <summary>
    /// 配时方案
    /// </summary>
    class Pattern
    {
        private byte _ucPatternId;
        private byte _ucCycleTime;
        private byte _ucOffset;
        private byte _ucCoorPhase;
        private byte _ucStagePatternId;
        public byte ucPatternId
        {
            get { return _ucPatternId; }
            set { _ucPatternId = value; }
        }
        public byte ucCycleTime
        {
            get { return _ucCycleTime; }
            set { _ucCycleTime = value; }
        }
        public byte ucOffset
        {
            get { return _ucOffset; }
            set { _ucOffset = value; }
        }
        public byte ucCoorPhase
        {
            get { return _ucCoorPhase; }
            set { _ucCoorPhase = value; }
        }
        public byte ucStagePatternId
        {
            get { return _ucStagePatternId; }
            set { _ucStagePatternId = value; }
        }
    }
}
