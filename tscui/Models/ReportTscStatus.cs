using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tscui.Models
{
    class ReportTscStatus
    {
        private static string _sWorkModel;
        private static string _sWorkStatus;
        private static string _sControlModel;
        private static int _iCurrentSchedule;
        private static int _iCurrentTimePattern;
        private static int _iCurrentStagePattern;
        private static int _iStageCount;
        private static int _iCurrentStage;
        private static int _iStageTotalTime;
        private static int _iStageRunTime;
        private static List<uint> _listChannelRedStatus;
        private static List<uint> _listChannelYellowStatus;
        private static List<uint> _listChannelGreenStatus;
        private static List<uint> _listChannelFlashStatus;
        private static int _iCycleTime;
        private static bool _resportTscStatusFlag = false;

        public static bool resportSuccessFlag
        {
             get { return _resportTscStatusFlag; }
             set { _resportTscStatusFlag = value; }
 
        }

        public static int iCycleTime
        {
            get { return _iCycleTime; }
            set { _iCycleTime = value; }
        }
        public static string sWorkModel
        {
            get { return _sWorkModel; }
            set { _sWorkModel = value; }
        }
        public static  string sWorkStatus
        {
            get { return _sWorkStatus; }
            set { _sWorkStatus = value; }
        }
        public static  string sControlModel
        {
            get { return _sControlModel; }
            set { _sControlModel = value; }

        }
        public static int iCurrentSchedule
        {
            get { return _iCurrentSchedule; }
            set { _iCurrentSchedule = value; }
        }
        public static int iCurrentTimePattern
        {
            get { return _iCurrentTimePattern; }
            set { _iCurrentTimePattern = value; }
        }
        public static int iCurrentStagePattern
        {
            get { return _iCurrentStagePattern; }
            set { _iCurrentStagePattern = value; }
        }
        public static int iStageCount
        {
            get { return _iStageCount; }
            set { _iStageCount = value; }
        }
        public static int iCurrentStage
        {
            get { return _iCurrentStage; }
            set { _iCurrentStage = value; }
        }
        public static int iStageTotalTime
        {
            get { return _iStageTotalTime; }
            set { _iStageTotalTime = value; }
        }
        public static int iStageRunTime
        {
            get { return _iStageRunTime; }
            set { _iStageRunTime = value; }
        }
        public static  List<uint> listChannelRedStatus
        {
            get { return _listChannelRedStatus; }
            set { _listChannelRedStatus = value; }
        }
        public static List<uint> listChannelYellowStatus
        {
            get { return _listChannelYellowStatus; }
            set { _listChannelYellowStatus = value; }
        }
        public static List<uint> listChannelGreenStatus
        {
            get { return _listChannelGreenStatus; }
            set { _listChannelGreenStatus = value; }
        }
        public static List<uint> listChannelFlashStatus
        {
            get { return _listChannelFlashStatus; }
            set { _listChannelFlashStatus = value; }
        }
    }
}
