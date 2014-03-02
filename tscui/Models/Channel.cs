using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tscui.Models
{
    class Channel
    {
        private byte _ucId;
        private byte _ucSourcePhase;
        private byte _ucFlashAuto;
        private byte _ucType;

        public byte ucId
        {
            get { return _ucId; }
            set { _ucId = value; }
        }
        public byte ucSourcePhase
        {
            get { return _ucSourcePhase; }
            set { _ucSourcePhase = value; }
        }
        public byte ucFlashAuto
        {
            get { return _ucFlashAuto; }
            set { _ucFlashAuto = value; }
        }
        public byte ucType
        {
            get { return _ucType; }
            set { _ucType = value; }
        }

    }
}
