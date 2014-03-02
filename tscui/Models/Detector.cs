using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tscui.Models
{
    class Detector
    {
        private byte _ucDetectorId;
        private byte _ucPhaseId;
        private byte _ucDetFlag;
        private byte _ucDirect;
        private byte _ucValidTime;
        private byte _ucOptionFlag;
        private short _usSaturationFlow;
        private byte _ucSaturationOccupy;

        public byte ucDetectorId
        {
            get { return _ucDetectorId; }
            set { _ucDetectorId = value; }
        }
        public byte ucPhaseId
        {
            get { return _ucPhaseId; }
            set { _ucPhaseId = value; }
        }
        public byte ucDetFlag
        {
            get { return _ucDetFlag; }
            set { _ucDetFlag = value; }
        }
        public byte ucDirect
        {
            get { return _ucDirect; }
            set { _ucDirect = value; }
        }
        public byte ucValidTime
        {
            get { return _ucValidTime; }
            set { _ucValidTime = value; }
        }
        public byte ucOptionFlag
        {
            get { return _ucOptionFlag; }
            set { _ucOptionFlag = value; }
        }
        public short usSaturationFlow
        {
            get { return _usSaturationFlow; }
            set { _usSaturationFlow = value; }
        }
        public byte ucSaturationOccupy
        {
            get { return _ucSaturationOccupy; }
            set { _ucSaturationOccupy = value; }
        }
    }
}
