using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tscui.Models
{
    class Phase
    {
        private byte _ucId;
        private byte _ucPedestrianGreen;
        private byte _ucPedestrianClear;
        private byte _ucMinGreen;
        private byte _ucGreenDelayUnit;
        private byte _ucMaxGreen1;
        private byte _ucMaxGreen2;
        private byte _ucFixedGreen;
        private byte _ucGreenFlash;
        private byte _ucType;
        private byte _ucOption;
        private byte _ucExtend;

        public byte ucId
        {
            get { return _ucId; }
            set { _ucId = value; }
        }
        public byte ucPedestrianGreen
        {
            get { return _ucPedestrianGreen; }
            set { _ucPedestrianGreen = value; }
        }
        public byte ucPedestrianClear
        {
            get { return _ucPedestrianClear; }
            set { _ucPedestrianClear = value; }
        }
        public byte ucMinGreen
        {
            get { return _ucMinGreen; }
            set { _ucMinGreen = value; }
        }
        public byte ucGreenDelayUnit
        {
            get { return _ucGreenDelayUnit; }
            set { _ucGreenDelayUnit = value; }
        }
        public byte ucMaxGreen1
        {
            get { return _ucMaxGreen1; }
            set { _ucMaxGreen1 = value; }
        }
        public byte ucMaxGreen2
        {
            get { return _ucMaxGreen2; }
            set { _ucMaxGreen2 = value; }
        }
        public byte ucFixedGreen
        {
            get { return _ucFixedGreen; }
            set { _ucFixedGreen = value; }
        }
        public byte ucGreenFlash
        {
            get { return _ucGreenFlash; }
            set { _ucGreenFlash = value; }
        }
        public byte ucType
        {
            get { return _ucType; }
            set { _ucType = value; }
        }
        public byte ucOption
        {
            get { return _ucOption; }
            set { _ucOption = value; }
        }
        public byte ucExtend
        {
            get { return _ucExtend; }
            set { _ucExtend = value; }
        }
    }
}
