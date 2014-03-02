using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tscui.Models
{
    class Node
    {
        public Node(string ip ,string name,string version,int iport)
        {
            _sIpAddress = ip;
            _sName = name;
            _iPort = iport;
            _sVersion = version;
        }
        private string _sName;
        private string _sIpAddress;
        private string _sVersion;
        private int _iPort;
        private string _sProtocol;
        public string sName
        {
            get { return _sName; }
            set { _sName = value; }
        }
        public string sIpAddress
        {
            get { return _sIpAddress; }
            set { _sIpAddress = value; }

        }
        public string sVersion
        {
            get { return _sVersion; }
            set { _sVersion = value; }
        }
        public string sProtocol
        {
            get { return _sProtocol; }
            set { _sProtocol = value; }
        }
        public int iPort
        {
            get { return _iPort; }
            set { _iPort = value; }
        }
    }
}
