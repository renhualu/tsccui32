using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tscui.Models
{
    /// <summary>
    /// 阶段配时表
    /// </summary>
    class StagePattern
    {
        private byte _ucStagePatternId;
        private byte _ucStageNo;
        private uint _usAllowPhase;
        private byte _ucGreenTime;
        private byte _ucYellowTime;
        private byte _ucRedTime;
        private byte _ucOption;

        public byte ucStagePatternId
        {
            get { return _ucStagePatternId; }
            set { _ucStagePatternId = value; }
        }
        public byte ucStageNo
        {
            get { return _ucStageNo; }
            set { _ucStageNo = value; }
        }
        public uint usAllowPhase
        {
            get { return _usAllowPhase; }
            set { _usAllowPhase = value; }
        }
        public byte ucGreenTime
        {
            get { return _ucGreenTime; }
            set { _ucGreenTime = value; }
        }
        public byte ucYellowTime
        {
            get { return _ucYellowTime; }
            set { _ucYellowTime = value; }
        }
        public byte ucRedTime
        {
            get { return _ucRedTime; }
            set { _ucRedTime = value; }
        }
        public byte ucOption
        {
            get { return _ucOption; }
            set { _ucOption = value; }
        }
        
    }
}
