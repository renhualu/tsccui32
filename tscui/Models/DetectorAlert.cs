using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tscui.Models
{
    class DetectorAlert
    {
        private byte _ucDetectorId;
        private byte _ucDetectorAlertState;
        private byte _ucDetectorCoilAlertState;
        public byte UcDetectorId
        {
            get { return _ucDetectorId; }
            set { _ucDetectorId = value; }
        }
        public byte UcDetectorAlertState
        {
            get { return _ucDetectorAlertState; }
            set { _ucDetectorAlertState = value; }
        }
        public byte UcDetectorCoilAlertState
        {
            get { return _ucDetectorCoilAlertState; }
            set { _ucDetectorCoilAlertState = value; }
        }
    }
}
