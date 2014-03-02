using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tscui.Models
{
    class Constant
    {
        private byte _ucMaxModule;
        private byte _ucMaxPlan;
        private byte _ucMaxSchedule;
        private byte _ucMaxScheduleEvt;
        private byte _ucMaxEventType;
        private byte _ucMaxEventLog;
        private byte _ucMaxDetector;
        private byte _ucMaxPhase;
        private byte _ucMaxChannel;
        private byte _ucMaxPattern;
        private byte _ucMaxStagePattern;
        private byte _ucMaxStage;
        private byte _ucMaxOverlap;

        public byte ucMaxModule
        {
            get { return _ucMaxModule; }
            set { _ucMaxModule = value; }
        }
        public byte ucMaxPlan
        {
            get { return _ucMaxPlan; }
            set { _ucMaxPlan = value; }
        }
        public byte ucMaxSchedule
        {
            get { return _ucMaxSchedule; }
            set { _ucMaxSchedule = value; }
        }
        public byte ucMaxScheduleEvt
        {
            get { return _ucMaxScheduleEvt; }
            set { _ucMaxScheduleEvt = value; }
        }
        public byte ucMaxEventType
        {
            get { return _ucMaxEventType; }
            set { _ucMaxEventType = value; }
        }
        public byte ucMaxEventLog
        {
            get { return _ucMaxEventLog; }
            set { _ucMaxEventLog = value; }
        }
        public byte ucMaxDetector
        {
            get { return _ucMaxDetector; }
            set { _ucMaxDetector = value; }
        }
        public byte ucMaxPhase
        {
            get { return _ucMaxPhase; }
            set { _ucMaxPhase = value; }
        }
        public byte ucMaxChannel
        {
            get { return _ucMaxChannel; }
            set { _ucMaxChannel = value; }
        }
        public byte ucMaxPattern
        {
            get { return _ucMaxPattern; }
            set { _ucMaxPattern = value; }
        }
        public byte ucMaxStagePattern
        {
            get { return _ucMaxStagePattern; }
            set { _ucMaxStagePattern = value; }
        }
        public byte ucMaxStage
        {
            get { return _ucMaxStage; }
            set { _ucMaxStage = value; }
        }
        public byte ucMaxOverlap
        {
            get { return _ucMaxOverlap; }
            set { _ucMaxOverlap = value; }
        }
    }
}
