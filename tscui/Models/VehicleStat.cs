using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tscui.Models
{
    /// <summary>
    /// 车辆检测统计结果
    /// </summary>
    class VehicleStat
    {
        private long _ulId;
        private byte _ucDetId;
        private long _ulCarTotal;
        private byte _ucOccupancy;
        private long _ulAddTime;

        public long ulId
        {
            get { return _ulId; }
            set { _ulId = value; }
        }
        public byte ucDetId
        {
            get { return _ucDetId; }
            set { _ucDetId = value; }
        }
        public long ulCarTotal
        {
            get { return _ulCarTotal; }
            set { _ulCarTotal = value; }
        }
        public byte ucOccupancy
        {
            get { return _ucOccupancy; }
            set { _ucOccupancy = value; }
        }
        public long ulAddTime
        {
            get { return _ulAddTime; }
            set { _ulAddTime = value; }
        }
        
    }
}
