using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tscui.Models
{
    class DetectorState
    {
        private byte _ucDetectorStateId;
        private byte _ucDetectorState;
        private byte _ucDetectorStateAlert;
        public byte UcDetectorStateId
        {
            get { return _ucDetectorStateId; }
            set { _ucDetectorStateId = value; }
        }
        public byte UcDetectorState
        {
            get { return _ucDetectorState; }
            set { _ucDetectorState = value; }
        }
        public byte UcDetectorStateAlert
        {
            get { return _ucDetectorStateAlert; }
            set { _ucDetectorStateAlert = value; }
        }
    }
}
