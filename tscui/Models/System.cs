using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tscui.Models
{
    /// <summary>
    /// 系统参数表
    /// </summary>
    class System
    {
        private short _usDeviceId;
        private byte _ucSynchTime;
        private short _usSynchFlag;
        private long _lZone;
        private byte _ucDetDataSeqNo;
        private byte _ucDetDataCycle;
        private byte _ucDetPulseSeqNo;
        private byte _ucDetPulseCycle;
        private byte _ucFlsTimeWhenStart;
        private byte _ucAllRedTimeWhenStart;
        private byte _ucRemoteCtrlFlag;
        private byte _ucFlashFreq;
        private long _ulBrtCtrlBgnTime;
        private long _ulBrtCtrlEndTime;
        private byte _ucGlobalCycle;
        private byte _ucCoorPhaseOffset;
        private byte _ucDegradeMode;
        private string _sDegradePattern;
        private byte _ucCtrlMasterOptFlag;
        private byte _ucDownloadFlag;
        private string _usBaseAddr;
        private byte _ucSigDevCount;

        public short usDeviceId
        {
            get { return _usDeviceId; }
            set { _usDeviceId = value; }
        }
        public byte ucSynchTime
        {
            get { return _ucSynchTime; }
            set { _ucSynchTime = value; }
        }
        public short usSynchFlag
        {
            get { return _usSynchFlag; }
            set { _usSynchFlag = value; }
        }
        public long lZone
        {
            get { return _lZone; }
            set { _lZone = value; }
        }
        public byte ucDetDataSeqNo
        {
            get { return _ucDetDataSeqNo; }
            set { _ucDetDataSeqNo = value; }
        }
        public byte ucDetDataCycle
        {
            get { return _ucDetDataCycle; }
            set { _ucDetDataCycle = value; }
        }
        public byte ucDetPulseSeqNo
        {
            get { return _ucDetPulseSeqNo; }
            set { _ucDetPulseSeqNo = value; }
        }
        public byte ucDetPulseCycle
        {
            get { return _ucDetPulseCycle; }
            set { _ucDetPulseCycle = value; }
        }
        public byte ucFlsTimeWhenStart
        {
            get { return _ucFlsTimeWhenStart; }
            set { _ucFlsTimeWhenStart = value; }
        }
        public byte ucAllRedTimeWhenStart
        {
            get { return _ucAllRedTimeWhenStart; }
            set { _ucAllRedTimeWhenStart = value; }
        }
        public byte ucRemoteCtrlFlag
        {
            get { return _ucRemoteCtrlFlag; }
            set { _ucRemoteCtrlFlag = value; }
        }
        public byte ucFlashFreq
        {
            get { return _ucFlashFreq; }
            set { _ucFlashFreq = value; }
        }
        public long ulBrtCtrlBgnTime
        {
            get { return _ulBrtCtrlBgnTime; }
            set { _ulBrtCtrlBgnTime = value; }
        }
        public long ulBrtCtrlEndTime
        {
            get { return _ulBrtCtrlEndTime; }
            set { _ulBrtCtrlEndTime = value; }
        }
        public byte ucGlobalCycle
        {
            get { return _ucGlobalCycle; }
            set { _ucGlobalCycle = value; }
        }
        public byte ucCoorPhaseOffset
        {
            get { return _ucCoorPhaseOffset; }
            set { _ucCoorPhaseOffset = value; }
        }
        public byte ucDegradeMode
        {
            get { return _ucDegradeMode; }
            set { _ucDegradeMode = value; }
        }
        public string sDegradePattern
        {
            get { return _sDegradePattern; }
            set { _sDegradePattern = value; }
        }
        public byte ucCtrlMasterOptFlag
        {
            get { return _ucCtrlMasterOptFlag; }
            set { _ucCtrlMasterOptFlag = value; }
        }
        public byte ucDownloadFlag
        {
            get { return _ucDownloadFlag; }
            set { _ucDownloadFlag = value; }
        }
        public string usBaseAddr
        {
            get { return _usBaseAddr; }
            set { _usBaseAddr = value; }
        }
        public byte ucSigDevCount
        {
            get { return _ucSigDevCount; }
            set { _ucSigDevCount = value; }
        }
      
    }
}
