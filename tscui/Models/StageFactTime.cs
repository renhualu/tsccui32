using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tscui.Models
{
    class StageFactTime
    {
        private int _ulAddTime;
        private byte _ucStageCnt;
        private string _sStageGreenTime;

        public int ulAddTime
        {
            get { return _ulAddTime; }
            set { _ulAddTime = value; }
        }
        public byte ucStageCnt
        {
            get { return _ucStageCnt; }
            set { _ucStageCnt = value; }
        }
        public string sStageGreenTime
        {
            get { return _sStageGreenTime; }
            set { _sStageGreenTime = value; }
        }
        
    }
}
