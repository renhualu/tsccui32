using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tscui.Models
{
    /// <summary>
    /// 信号机数据整体数据对象
    /// </summary>
    class TscData
    {
        public string writeTscData()
        {
            string result = "";
            result = "==================Module========================\n";
            result = "ucModuleId:[" + Node.sName + "]   sDevNode:[" + Node.sIpAddress + "]    sCompany:[" + Node.iPort + "]   sModel:[" + Node.sVersion + "]\n";
            result = "==================VariableSign========================\n";
            foreach(VariableSign vs in ListVariableSign)
            {
                result = "ucid:[" + vs.ucId + "]   ucCtrl:[" + vs.ucCtrl + "]    ucSchemeId:[" + vs.ucSchemeId + "]   ucOption:[" + vs.ucOption + "]\n";
            }
            result = "==================Detector========================\n";
            foreach (Detector vs in ListDetector)
            {
                result = "ucDetectorId:[" + vs.ucDetectorId + "]   ucDetFlag:[" + vs.ucDetFlag + "]    ucDirect:[" + vs.ucDirect + "]   ucOptionFlag:[" + vs.ucOptionFlag + "]   ucPhaseId:[" + vs.ucPhaseId + "]   ucSaturationOccupy:[" + vs.ucSaturationOccupy + "]   ucValidTime:[" + vs.ucValidTime + "]   usSaturationFlow:[" + vs.usSaturationFlow + "]\n";
            }
            result = "==================Collision========================\n";
            foreach (Collision vs in ListCollision)
            {
                result = "ucPhaseId:[" + vs.ucPhaseId + "]   ucCollisionFlag:[" + vs.ucCollisionFlag + "]\n";
            }
            result = "==================Phase========================\n";
            foreach (Phase vs in ListPhase)
            {
                result = "ucid:[" + vs.ucId + "]   ucPedestrianGreen:[" + vs.ucPedestrianGreen + "]    ucPedestrianClear:[" + vs.ucPedestrianClear + "]   ucMinGreen:[" + vs.ucMinGreen + "]   ucMaxGreen1:[" + vs.ucMaxGreen1 + "]   ucMaxGreen2:[" + vs.ucMaxGreen2 + "]   ucFixedGreen:[" + vs.ucFixedGreen + "]   ucGreenDelayUnit:[" + vs.ucGreenDelayUnit + "]   ucGreenFlash:[" + vs.ucGreenFlash + "]   ucType:[" + vs.ucType + "]   ucOption:[" + vs.ucOption + "]   ucExtend:[" + vs.ucExtend + "]\n";
            }
            result = "==================Channel========================\n";
            foreach (Channel vs in ListChannel)
            {
                result = "ucid:[" + vs.ucId + "]   ucSourcePhase:[" + vs.ucSourcePhase + "]    ucFlashAuto:[" + vs.ucFlashAuto + "]   ucType:[" + vs.ucType + "]\n";
            }
            result = "==================OverlapPhase========================\n";
            foreach (OverlapPhase vs in ListOverlapPhase)
            {
                result = "ucid:[" + vs.ucId + "]   ucIncludePhaseLen:[" + vs.ucIncludePhaseLen + "]    ucIncludePhase:[" + vs.ucIncludePhase + "]   ucCorrectPhaseLen:[" + vs.ucCorrectPhaseLen + "]   ucCorrectPhase:[" + vs.ucCorrectPhase + "]   ucOperateType:[" + vs.ucOperateType + "]   ucTailGreen:[" + vs.ucTailGreen + "]   ucTailRed:[" + vs.ucTailRed + "]   ucTailYellow:[" + vs.ucTailYellow + "]\n";
            }
            result = "==================Schedule========================\n";
            foreach (Schedule vs in ListSchedule)
            {
                result = "ucid:[" + vs.ucId + "]   ucAuxOut:[" + vs.ucAuxOut + "]    ucCtrl:[" + vs.ucCtrl + "]   ucEventId:[" + vs.ucEventId + "]   ucHour:[" + vs.ucHour + "]   ucMin:[" + vs.ucMin + "]   ucSpecialOut:[" + vs.ucSpecialOut + "]   ucTimePatternId:[" + vs.ucTimePatternId + "]\n";
            }
            result = "==================StagePattern========================\n";
            foreach (StagePattern vs in ListStagePattern)
            {
                result = "ucStagePatternId:[" + vs.ucStagePatternId + "]   ucStageNo:[" + vs.ucStageNo + "]    usAllowPhase:[" + vs.usAllowPhase + "]   ucGreenTime:[" + vs.ucGreenTime + "]   ucYellowTime:[" + vs.ucYellowTime + "]   ucRedTime:[" + vs.ucRedTime + "]   ucOption:[" + vs.ucOption + "]\n";
            }
            result = "==================Pattern========================\n";
            foreach (Pattern vs in ListPattern)
            {
                result = "ucStagePatternId:[" + vs.ucStagePatternId + "]   ucPatternId:[" + vs.ucPatternId + "]    ucOffset:[" + vs.ucOffset + "]   ucCycleTime:[" + vs.ucCycleTime + "]   ucCoorPhase:[" + vs.ucCoorPhase + "]\n";
            }
            result = "==================Plan========================\n";
            foreach (Plan vs in ListPlan)
            {
                result = "ucid:[" + vs.ucId + "]   ucScheduleId:[" + vs.ucScheduleId + "]    ucWeekFlag:[" + vs.ucWeekFlag + "]   ulDayFlag:[" + vs.ulDayFlag + "]   usMonthFlag:[" + vs.usMonthFlag + "]\n";
            }
            result = "==================PhaseToDirec========================\n";
            foreach (PhaseToDirec vs in ListPhaseToDirec)
            {
                result = "ucid:[" + vs.ucId + "]   ucOverlapPhase:[" + vs.ucOverlapPhase + "]    ucPhase:[" + vs.ucPhase + "]   ucRoadCnt:[" + vs.ucRoadCnt + "]\n";
            }
            result = "==================LampCheck========================\n";
            foreach (LampCheck vs in ListLampCheck)
            {
                result = "ucid:[" + vs.ucId + "]   ucFlag:[" + vs.ucFlag + "]\n";
            }
            result = "==================CntDownDev========================\n";
            foreach (CntDownDev vs in ListCntDownDev)
            {
                result = "ucDevId:[" + vs.ucDevId + "]   ucPhase:[" + vs.ucPhase + "]    ucOverlapPhase:[" + vs.ucOverlapPhase + "]   ucMode:[" + vs.ucMode + "]\n";
            }
            result = "==================SpecFun========================\n";
            foreach (SpecFun vs in ListSpecFun)
            {
                result = "ucFunType:[" + vs.ucFunType + "]   ucValue:[" + vs.ucValue + "]\n";
            }
            result = "==================Module========================\n";
            foreach (Module vs in ListModule)
            {
                result = "ucModuleId:[" + vs.ucModuleId + "]   sDevNode:[" + vs.sDevNode + "]    sCompany:[" + vs.sCompany + "]   sModel:[" + vs.sModel + "]   sVersion:[" + vs.sVersion + "]   ucType:[" + vs.ucType + "]\n";
            }


            return result;
        }
        public TscData()
        {
            ListCntDownDev = new List<CntDownDev>();
            ListCntDownDev.Add(new CntDownDev());
            ListVariableSign = new List<VariableSign>();
            ListVariableSign.Add(new VariableSign());
        }
        private List<VariableSign> _listVariableSign;
        public List<VariableSign> ListVariableSign
        {
            get { return _listVariableSign; }
            set { _listVariableSign = value; }
        }
        private List<Detector> _listDetector;
        public List<Detector> ListDetector
        {
            get { return _listDetector; }
            set { _listDetector = value; }
        }
        private List<Collision> _listCollision;
        public List<Collision> ListCollision
        {
            get { return _listCollision; }
            set { _listCollision = value; }
        }
        private List<Phase> _listPhase;
        public List<Phase> ListPhase
        {
            get { return _listPhase; }
            set { _listPhase = value; }
        }
        private List<Channel> _listChannel;
        public List<Channel> ListChannel
        {
            get { return _listChannel; }
            set { _listChannel = value; }
        }
        private List<OverlapPhase> _listOverlapPhase;
        public List<OverlapPhase> ListOverlapPhase
        {
            get { return _listOverlapPhase; }
            set { _listOverlapPhase = value; }
        }
        private List<Schedule> _listSchedule;
        public List<Schedule> ListSchedule
        {
            get { return _listSchedule; }
            set { _listSchedule = value; }
        }
        private List<StagePattern> _listStagePattern;
        public List<StagePattern> ListStagePattern
        {
            get { return _listStagePattern; }
            set { _listStagePattern = value; }
        }
        private List<VehicleStat> _listVehicleStat;
        public List<VehicleStat> ListVehicleStat
        {
            get { return _listVehicleStat; }
            set { _listVehicleStat = value; }
        }
        private List<Pattern> _listPattern;
        public List<Pattern> ListPattern
        {
            get { return _listPattern; }
            set { _listPattern = value; }
        }
        private List<System> _listSystem;
        public List<System> ListSystem
        {
            get { return _listSystem; }
            set { _listSystem = value; }
        }

        private List<StageFactTime> _listStageFactTime;
        public List<StageFactTime> ListStageFactTime
        {
            get { return _listStageFactTime; }
            set { _listStageFactTime = value; }
        }
        private List<SpecFun> _listSpecFun;
        public List<SpecFun> ListSpecFun
        {
            get { return _listSpecFun; }
            set { _listSpecFun = value; }
        }
        private List<Plan> _listPlan;
        public List<Plan> ListPlan
        {
            get { return _listPlan; }
            set { _listPlan = value; }
        }
        private List<PhaseToDirec> _listPhaseToDirec;
        public List<PhaseToDirec> ListPhaseToDirec
        {
            get { return _listPhaseToDirec; }
            set { _listPhaseToDirec = value; }
        }

        private List<Module> _listModule;
        public List<Module> ListModule
        {
            get { return _listModule; }
            set { _listModule = value; }
        }
        private List<LampCheck> _listLampCheck;
        public List<LampCheck> ListLampCheck
        {
            get { return _listLampCheck; }
            set { _listLampCheck = value; }
        }
        private List<EventType> _listEventType;
        public List<EventType> ListEventType
        {
            get { return _listEventType; }
            set { _listEventType = value; }
        }
        private List<EventLog> _listEventLog;
        public List<EventLog> ListEventLog
        {
            get { return _listEventLog; }
            set { _listEventLog = value; }
        }
        private List<CntDownDev> _listCntDownDev;
        public List<CntDownDev> ListCntDownDev
        {
            get { return _listCntDownDev; }
            set { _listCntDownDev = value; }
        }
        private List<AdapterPara> _listAdapterPara;
        public List<AdapterPara> ListAdapterPara
        {
            get { return _listAdapterPara; }
            set { _listAdapterPara = value; }
        }
        private List<AdaptStageTime> _listAdaptStageTime;
        public List<AdaptStageTime> ListAdaptStageTime
        {
            get { return _listAdaptStageTime; }
            set { _listAdaptStageTime = value; }
        }
        private Node _node;
        public Node Node
        {
            get { return _node; }
            set { _node = value; }
        }
        
    }
}
