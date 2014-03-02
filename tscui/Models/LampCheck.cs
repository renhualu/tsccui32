using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tscui.Models
{
    class LampCheck
    {
        private byte _ucId;
        private byte _ucFlag;
        public byte ucId
        {
            get { return _ucId; }
            set { _ucId = value; }
        }
        public byte ucFlag
        {
            get { return _ucFlag; }
            set { _ucFlag = value; }
        }
    }
}
