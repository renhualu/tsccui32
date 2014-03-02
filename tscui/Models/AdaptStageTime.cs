using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tscui.Models
{
    class AdaptStageTime
    {
        private byte _ucId;
        private byte _ucWeekType;
        private byte _ucHour;
        private byte _ucMin;
        private byte _ucStageCnt;
        private string _sStageTime;

        public byte ucId
        {
            get { return _ucId; }
            set { _ucId = value; }
        }
        public byte ucWeekType
        {
            get { return _ucWeekType; }
            set { _ucWeekType = value; }
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
        public byte ucStageCnt
        {
            get { return _ucStageCnt; }
            set { _ucStageCnt = value; }
        }
        public string sStageTime
        {
            get { return _sStageTime; }
            set { _sStageTime = value; }
        }
    }
}
