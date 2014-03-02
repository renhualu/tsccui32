using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tscui.Models
{
    class DetectData
    {
        private byte _ucDetectorId;
        private byte _ucTotalFlow;
        private byte _ucBigVehicleFlow;
        private byte _ucSmallVehicleFlow;
        private byte _ucOccupy;
        private byte _ucSpeed;
        private byte _ucVehicleLength;


        public byte UcDetectorId
        {
            get { return _ucDetectorId; }
            set { _ucDetectorId = value; }
        }
        public byte UcTotalFlow
        {
            get { return _ucTotalFlow; }
            set { _ucTotalFlow = value; }
        }
        public byte UcBigVehicleFlow
        {
            get { return _ucBigVehicleFlow; }
            set { _ucBigVehicleFlow = value; }
        }
        public byte UcSmallVehicleFlow
        {
            get { return _ucSmallVehicleFlow; }
            set { _ucSmallVehicleFlow = value; }
        }
        public byte UcOccupy
        {
            get { return _ucOccupy; }
            set { _ucOccupy = value; }
        }
        public byte UcSpeed
        {
            get { return _ucSpeed; }
            set { _ucSpeed = value; }
        }
        public byte UcVehicleLength
        {
            get { return _ucVehicleLength; }
            set { _ucVehicleLength = value; }
        }
      
    }
}
