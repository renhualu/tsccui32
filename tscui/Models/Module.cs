using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tscui.Models
{
    class Module
    {
        private byte _ucModuleId;
        private string _sDevNode;
        private string _sCompany;
        private string _sModel;
        private string _sVersion;
        private byte _ucType;

        public byte ucModuleId
        {
            get { return _ucModuleId; }
            set { _ucModuleId = value; }
        }
        public string sDevNode
        {
            get { return _sDevNode; }
            set { _sDevNode = value; }
        }
        public string sCompany
        {
            get { return _sCompany; }
            set { _sCompany = value; }

        }
        public string sModel
        {
            get { return _sModel; }
            set { _sModel = value; }
        }
        public string sVersion
        {
            get { return _sVersion; }
            set { _sVersion = value; }
        }
        public byte ucType
        {
            get { return _ucType; }
            set { _ucType = value; }
        }
    }
}
