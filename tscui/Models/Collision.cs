using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tscui.Models
{
    class Collision
    {
        private byte _ucPhaseId;
        private UInt32 _ucCollisionFlag;


        public byte ucPhaseId
        {
            get { return _ucPhaseId; }
            set { _ucPhaseId = value; }
        }
        public UInt32 ucCollisionFlag
        {
            get { return _ucCollisionFlag; }
            set { _ucCollisionFlag = value; }
        }
    }
}
