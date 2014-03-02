using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tscui.Models
{
    class PhaseOutputState
    {
        private byte _ucId;
        private byte _ucOutputRedState;
        private byte _ucOutputYellowState;
        private byte _ucOutputGreenState;
        public byte UcId
        {
            get { return _ucId; }
            set { _ucId = value; }
        }
        public byte UcOutputRedState
        {
            get { return _ucOutputRedState; }
            set { _ucOutputRedState = value; }
        }
        public byte UcOutputYellowState
        {
            get { return _ucOutputYellowState; }
            set { _ucOutputYellowState = value; }
        }
        public byte UcOutputGreenState
        {
            get { return _ucOutputGreenState; }
            set { _ucOutputGreenState = value; }
        }
    }
}
