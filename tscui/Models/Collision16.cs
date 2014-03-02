using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tscui.Models
{
    class Collision16
    {
        private byte _ucPhaseId;
        private ushort _ucCollisionFlag;


        public byte ucPhaseId
        {
            get { return _ucPhaseId; }
            set { _ucPhaseId = value; }
        }
        public ushort ucCollisionFlag
        {
            get { return _ucCollisionFlag; }
            set { _ucCollisionFlag = value; }
        }
    }
}
