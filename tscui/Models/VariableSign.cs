using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tscui.Models
{
    class VariableSign
    {
        private byte _ucId;
        private byte _ucCtrl;
        private byte _ucSchemeId;
        private byte _ucOption;

        public byte ucId
        {
            get { return _ucId; }
            set { _ucId = value; }
        }
        public byte ucCtrl
        {
            get { return _ucCtrl; }
            set { _ucCtrl = value; }
        }
        public byte ucSchemeId
        {
            get { return _ucSchemeId; }
            set { _ucSchemeId = value; }
        }
        public byte ucOption
        {
            get { return _ucOption; }
            set { _ucOption = value; }
        }
    }
}
