using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tscui.Models
{
    class OverlapPhase
    {
        private byte _ucId;
        private byte _ucOperateType;
        private byte _ucIncludePhaseLen;
        private byte[] _ucIncludePhase;
        private byte _ucCorrectPhaseLen;
        private byte[] _ucCorrectPhase;
        private byte _ucTailGreen;
        private byte _ucTailYellow;
        private byte _ucTailRed;

        public byte ucId
        {
            get { return _ucId; }
            set { _ucId = value; }
        }
        public byte ucOperateType
        {
            get { return _ucOperateType; }
            set { _ucOperateType = value; }
        }
        public byte ucIncludePhaseLen
        {
            get { return _ucIncludePhaseLen; }
            set { _ucIncludePhaseLen = value; }
        }
        public byte[] ucIncludePhase
        {
            get { return _ucIncludePhase; }
            set { _ucIncludePhase = value; }
        }
        public byte[] ucCorrectPhase
        {
            get { return _ucCorrectPhase; }
            set { _ucCorrectPhase = value; }
        }
        public byte ucCorrectPhaseLen
        {
            get { return _ucCorrectPhaseLen; }
            set { _ucCorrectPhaseLen = value; }
        }
        public byte ucTailGreen
        {
            get { return _ucTailGreen; }
            set { _ucTailGreen = value; }
        }
        public byte ucTailYellow
        {
            get { return _ucTailYellow; }
            set { _ucTailYellow = value; }
        }
        public byte ucTailRed
        {
            get { return _ucTailRed; }
            set { _ucTailRed = value; }
        }
       
    }
}
