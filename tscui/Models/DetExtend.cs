using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tscui.Models
{
    class DetExtend
    {
        private byte _ucId;
        private byte _ucSensi;
        private byte _ucGrpNo;
        private byte _ucPro;
        private byte _ucOcuDefualt;
        private byte _usCarFlow;
        private byte _ucFrency;
        private byte _ucGrpData;
        private byte _ucGrpDistns;

        public byte ucId
        {
            get { return _ucId; }
            set { _ucId = value; }
        }
        public byte ucSensi
        {
            get { return _ucSensi; }
            set { _ucSensi = value; }
        }
        public byte ucGrpNo
        {
            get { return _ucGrpNo; }
            set { _ucGrpNo = value; }
        }
        public byte ucPro
        {
            get { return _ucPro; }
            set { _ucPro = value; }
        }
        public byte ucOcuDefualt
        {
            get { return _ucOcuDefualt; }
            set { _ucOcuDefualt = value; }
        }
        public byte usCarFlow
        {
            get { return _usCarFlow; }
            set { _usCarFlow = value; }
        }
        public byte ucFrency
        {
            get { return _ucFrency; }
            set { _ucFrency = value; }
        }
        public byte ucGrpData
        {
            get { return _ucGrpData; }
            set { _ucGrpData = value; }
        }
        public byte ucGrpDistns
        {
            get { return _ucGrpDistns; }
            set { _ucGrpDistns = value; }
        }
    }
}
