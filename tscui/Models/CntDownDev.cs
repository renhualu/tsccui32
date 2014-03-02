using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tscui.Models
{
    class CntDownDev
    {
        private byte _ucDevId;
        private uint _ucPhase;
        private ushort _ucOverlapPhase;
        private byte _ucMode;


        public byte ucDevId
        {
            get { return _ucDevId; }
            set { _ucDevId = value; }
        }
        public uint ucPhase
        {
            get { return _ucPhase; }
            set { _ucPhase = value; }
        }
        public ushort ucOverlapPhase
        {
            get { return _ucOverlapPhase; }
            set { _ucOverlapPhase = value; }
        }
        public byte ucMode
        {
            get { return _ucMode; }
            set { _ucMode = value; }
        }
    }
}
