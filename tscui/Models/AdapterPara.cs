using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tscui.Models
{
    class AdapterPara
    {
        private byte _ucType;
        private byte _ucFirstPro;
        private byte _ucSecPro;
        private byte _ucThirdPro;
        private byte _ucOcuPro;
        private byte _ucCarFlowPro;
        private byte _ucSmoothPro;

        public byte ucType
        {
            get { return _ucType; }
            set { _ucType = value; }
        }
        public byte ucFirstPro
        {
            get { return _ucFirstPro; }
            set { _ucFirstPro = value; }
        }
        public byte ucSecPro
        {
            get { return _ucSecPro; }
            set { _ucSecPro = value; }
        }
        public byte ucThirdPro
        {
            get { return _ucThirdPro; }
            set { _ucThirdPro = value; }
        }
        public byte ucOcuPro
        {
            get { return _ucOcuPro; }
            set { _ucOcuPro = value; }
        }
        public byte ucCarFlowPro
        {
            get { return _ucCarFlowPro; }
            set { _ucCarFlowPro = value; }
        }
        public byte ucSmoothPro
        {
            get { return _ucSmoothPro; }
            set { _ucSmoothPro = value; }
        }
    }
}
