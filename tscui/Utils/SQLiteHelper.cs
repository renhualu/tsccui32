using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;
using System.Windows;
using System.Data.Common;

namespace tscui.Utils
{
    class SQLiteHelper
    {
        private static string dbPath = "Db/tsc.db";
        private string connectionString = string.Empty; 
                 /// <summary> 
                 /// 构造函数 
                 /// </summary> 
                 /// <param name="dbPath">SQLite数据库文件路径</param> 
        public SQLiteHelper(string dbPath) 
                 {
                     this.connectionString = "Data Source=" + dbPath; 
                 } 
                 /// <summary> 
                 /// 创建SQLite数据库文件 
                 /// </summary> 
                 /// <param name="dbPath">要创建的SQLite数据库文件路径</param> 
                 public static void CreateDB(string dbPath) 
                 { 
                         using (SQLiteConnection connection = new SQLiteConnection("Data Source=" + dbPath)) 
                         { 
                                 connection.Open(); 
                                 using (SQLiteCommand command = new SQLiteCommand(connection)) 
                                 {
                                     command.CommandText = "create table Tbl_System("
                                        + "usDeviceId int not null, "
                                        + "ucSynchTime tinyint not null default(0), "
                                        + "usSynchFlag int not null default(0), "
                                        + "lZone int not null default(0), "
                                        + "ucDetDataSeqNo tinyint not null default(1), "
                                        + "ucDetDataCycle tinyint not null default(180), "
                                        + "ucDetPulseSeqNo tinyint not null default(1), "
                                        + "ucDetPulseCycle tinyint not null default(30), "
                                        + "ucFlsTimeWhenStart tinyint not null default(12), "
                                        + "ucAllRedTimeWhenStart tinyint not null default(6), "
                                        + "ucRemoteCtrlFlag tinyint not null default(0), "
                                        + "ucFlashFreq tinyint not null default(1), "
                                        + "ulBrtCtrlBgnTime bigint not null default(0), "
                                        + "ulBrtCtrlEndTime bigint not null default(0), "
                                        + "ucGlobalCycle tinyint not null default(0), "
                                        + "ucCoorPhaseOffset tinyint not null default(0), "
                                        + "ucDegradeMode tinyint not null default(0), "
                                        + "sDegradePattern varchar(256) not null default(' '), "
                                        + "ucCtrlMasterOptFlag tinyint not null default(0), "
                                        + "ucDownloadFlag tinyint not null default(0), "
                                        + "usBaseAddr int not null default(0), "
                                        + "ucSigDevCount tinyint not null default(0), "
                                        + "ucEypDevSerial  varchar(256) not null default('')) "; 
                                         command.ExecuteNonQuery();

                                         command.CommandText = "create table Tbl_Constant( "
                                            + "ucMaxModule tinyint not null default(16), "
                                            + "ucMaxPlan tinyint not null default(40), "
                                            + "ucMaxSchedule tinyint not null default(16), "
                                            + "ucMaxScheduleEvt tinyint not null default(48), "
                                            + "ucMaxEventType tinyint not null default(255), "
                                            + "ucMaxEventLog tinyint not null default(255), "
                                            + "ucMaxDetector tinyint not null default(48), "
                                            + "ucMaxPhase tinyint not null default(32), "
                                            + "ucMaxChannel tinyint not null default(32), "
                                            + "ucMaxPattern tinyint not null default(32), "
                                            + "ucMaxStagePattern tinyint not null default(16), "
                                            + "ucMaxStage tinyint not null default(16), "
                                            + "ucMaxOverlapPhase tinyint not null default(16)) "; 
                                         command.ExecuteNonQuery();

                                         command.CommandText = "create table Tbl_Module( "
                                            + "ucModuleId tinyint primary key, "
                                            + "sDevNode varchar(256) not null, "
                                            + "sCompany varchar(256) not null, "
                                            + "sModel   varchar(256) not null, "
                                            + "sVersion varchar(256) not null, "
                                            + "ucType   tinyint not null default(0))";
                                         command.ExecuteNonQuery();
                                         command.CommandText = "create table Tbl_Plan( "
                                            + "ucId tinyint  primary key, "
                                            + "usMonthFlag int not null default(0), "
                                            + "ucWeekFlag  tinyint not null default(0), "
                                            + "ulDayFlag   bigint not null default(0), "
                                            + "ucScheduleId tinyint not null default(0))";
                                         command.ExecuteNonQuery();

                                         command.CommandText = "create table Tbl_Schedule( "
                                            + "ucScheduleId tinyint, "
                                            + "ucEvtId tinyint, "
                                            + "ucBgnHour tinyint not null default(0), "
                                            + "ucBgnMinute tinyint not null default(0), "
                                            + "ucCtrlMode tinyint not null default(0), "
                                            + "ucPatternNo tinyint not null default(0), "
                                            + "ucAuxOut tinyint not null default(0), "
                                            + "ucSpecialOut tinyint not null default(0), "
                                            + "CONSTRAINT Schedule_Key PRIMARY KEY (ucScheduleId, ucEvtId))";
                                         command.ExecuteNonQuery();


                                         command.CommandText = "create table Tbl_Phase( "
                                            + " ucPhaseId tinyint primary key, "
                                            + " ucPedestrianGreen tinyint not null default(10), "
                                            + " ucPedestrianClear tinyint not null default(3), "
                                            + " ucMinGreen tinyint not null default(15), "
                                            + " ucGreenDelayUnit tinyint not null default(3), "
                                            + " ucMaxGreen1 tinyint not null default(45), "
                                            + " ucMaxGreen2 tinyint not null default(60), "
                                            + " ucFixGreen tinyint not null default(20), "
                                            + " ucGreenFlash tinyint not null default(3), "
                                            + " ucPhaseTypeFlag tinyint not null default(0), "
                                            + " ucPhaseOption tinyint not null default(0), "
                                            + " ucExtend tinyint not null default(0))";
                                         command.ExecuteNonQuery();
                                         command.CommandText = "create table Tbl_Collision( "
                                            + "ucPhaseId tinyint primary key, "
                                            + "usCollisonFlag int not null default(0))";
                                         command.ExecuteNonQuery();
                                         command.CommandText = "create table Tbl_Detector( "
                                            + "ucDetectorId tinyint primary key, "
                                            + "ucPhaseId tinyint not null default(0), "
                                            + "ucDetFlag tinyint not null default(0), "
                                            + "ucDirect tinyint not null default(0), "
                                            + "ucValidTime tinyint not null default(0), "
                                            + "ucOptionFlag tinyint not null default(0), "
                                            + "usSaturationFlow int not null default(0), "
                                            + "ucSaturationOccupy tinyint not null default(0))";
                                         command.ExecuteNonQuery();
                                         command.CommandText = "create table Tbl_Channel( "
                                            + "ucChannelId tinyint primary key, "
                                            + "ucCtrlSrc tinyint not null default(0), "
                                            + "ucAutoFlsCtrlFlag tinyint not null default(0), "
                                            + "ucCtrlType tinyint not null default(0))";
                                         command.ExecuteNonQuery();
                                         command.CommandText = "create table Tbl_Pattern( "
                                            + "ucPatternId tinyint primary key, "
                                            + "ucCycleTime tinyint not null default(0), "
                                            + "ucOffset tinyint not null default(0), "
                                            + "ucCoorPhase tinyint not null default(0), "
                                            + "ucStagePatternId tinyint not null default(0))";
                                         command.ExecuteNonQuery();
                                         command.CommandText = "create table Tbl_StagePattern( "
                                            + "ucStagePatternId tinyint, "
                                            + "ucStageNo tinyint, "
                                            + "usAllowPhase int not null default(0), "
                                            + "ucGreenTime tinyint not null default(0), "
                                            + "ucYellowTime tinyint not null default(0), "
                                            + "ucRedTime tinyint not null default(0), "
                                            + "ucOption tinyint not null default(0), "
                                            + "CONSTRAINT StagePattern_Key PRIMARY KEY (ucStagePatternId, ucStageNo))";
                                         command.ExecuteNonQuery();
                                         command.CommandText = "create table Tbl_OverlapPhase( "
                                            + "ucOverlapPhaseId tinyint primary key, "
                                            + "ucOperateType tinyint not null default(0), "
                                            + "ucIncldPhaseCount tinyint not null default(0), "
                                            + "sIncldPhase varchar(256) not null, "
                                            + "ucAdjustPhaseCount tinyint not null default(0), "
                                            + "sAdjustPhase varchar(256) not null, "
                                            + "ucTailGreen tinyint not null default(0), "
                                            + "ucTailYellow tinyint not null default(0), "
                                            + "ucTailRed tinyint not null default(0))";
                                         command.ExecuteNonQuery();
                                         command.CommandText = "create table Tbl_EventType( "
                                            + "ucEvtTypeId tinyint primary key, "
                                            + "ulClearTime bigint not null default(0), "
                                            + "sEvtDesc varchar(256) not null,ucLogCount tinyint not null  default(0))";
                                         command.ExecuteNonQuery();
                                         command.CommandText = "create table Tbl_EventLog( "
                                            + "ucEventId bigint not null, "
                                            + "ucEvtType tinyint not null default(0), "
                                            + "ulHappenTime bigint not null default(0), "
                                            + "ulEvtValue bigint not null default(0), "
                                            + "ulEventTime varchar(20))";
                                         command.ExecuteNonQuery();
                                         command.CommandText = "create table Tbl_VehicleStat( "
                                            + "ulId bigint primary key, "
                                            + "ucDetId tinyint not null default(0), "
                                            + "ulCarTotal bigint not null default(0), "
                                            + "ucOccupancy tinyint not null default(0), "
                                            + "ulAddTime bigint not null default(0))";
                                         command.ExecuteNonQuery();
                                         command.CommandText = "create table Tbl_CntDownDev( "
                                            + "ucDevId tinyint not null, "
                                            + "usPhase int not null default(0), "
                                            + "ucOverlapPhase tinyint not null default(0), "
                                            + "ucMode tinyint not null default(0))";
                                         command.ExecuteNonQuery();
                                         command.CommandText = "create table Tbl_SpecFun( "
                                            + "ucFunType tinyint not null, "
                                            + "ucValue tinyint not null default(0))";
                                         command.ExecuteNonQuery();
                                         command.CommandText = "create table Tbl_DetExtend( "
                                            + "ucId tinyint primary key, "
                                            + "ucSensi tinyint not null default(0), "
                                            + "ucGrpNo tinyint not null default(0), "
                                            + "ucPro tinyint not null default(0), "
                                            + "ucOcuDefault tinyint not null default(0), "
                                            + "usCarFlow smallint not null default(0), "
                                            + "ucFrency  tinyint not null default(0), "
                                            + "ucGrpData smallint not null default(0), "
                                            + "ucGrpDistns smallint not null default(0))";
                                         command.ExecuteNonQuery();
                                         command.CommandText = "create table Tbl_StageFactTime( "
                                            + "ulAddTime int primary key, "
                                            + "ucStageCnt tinyint not null default(0), "
                                            + "sStageGreenTime varchar(32) not null)";
                                         command.ExecuteNonQuery();
                                         command.CommandText = "create table Tbl_AdaptStageTime( "
                                            + "ucId INTEGER primary key, "
                                            + "ucWeekType tinyint not null default(0), "
                                            + "ucHour tinyint not null default(0), "
                                            + "ucMin tinyint not null default(0), "
                                            + "ucStageCnt tinyint not null default(0), "
                                            + "sStageTime varchar(32) not null)";
                                         command.ExecuteNonQuery();
                                         command.CommandText = "create table Tbl_PhaseToDirec( "
                                            + "ucId tinyint primary key, "
                                            + "ucPhase tinyint not null default(0), "
                                            + "ucOverlapPhase tinyint not null default(0), "
                                            + "ucRoadCnt tinyint not null default(0))";
                                         command.ExecuteNonQuery();
                                         command.CommandText = "create table Tbl_AdaptPara( "
                                            + "ucType tinyint not null, "
                                            + "ucFirstPro tinyint not null default(0), "
                                            + "ucSecPro tinyint not null default(0), "
                                            + "ucThirdPro tinyint not null default(0), "
                                            + "ucOcuPro tinyint not null default(0), "
                                            + "ucCarFlowPro tinyint not null default(0), "
                                            + "ucSmoothPara tinyint not null default(0))";
                                         command.ExecuteNonQuery(); 
                                 } 
                         } 
                 } 
                 /// <summary> 
                 /// 对SQLite数据库执行增删改操作，返回受影响的行数。 
                 /// </summary> 
                 /// <param name="sql">要执行的增删改的SQL语句</param> 
                 /// <param name="parameters">执行增删改语句所需要的参数，参数必须以它们在SQL语句中的顺序为准</param> 
                 /// <returns></returns> 
                 public int ExecuteNonQuery(string sql, SQLiteParameter[] parameters) 
                 { 
                         int affectedRows = 0; 
                         using (SQLiteConnection connection = new SQLiteConnection(connectionString)) 
                         { 
                                 connection.Open(); 
                                 using (DbTransaction transaction = connection.BeginTransaction()) 
                                 { 
                                         using (SQLiteCommand command = new SQLiteCommand(connection)) 
                                         { 
                                                 command.CommandText = sql; 
                                                 if (parameters != null) 
                                                 { 
                                                         command.Parameters.AddRange(parameters); 
                                                 } 
                                                 affectedRows = command.ExecuteNonQuery(); 
                                         } 
                                         transaction.Commit(); 
                                 } 
                         } 
                         return affectedRows; 
                 } 
                 /// <summary> 
                 /// 执行一个查询语句，返回一个关联的SQLiteDataReader实例 
                 /// </summary> 
                 /// <param name="sql">要执行的查询语句</param> 
                 /// <param name="parameters">执行SQL查询语句所需要的参数，参数必须以它们在SQL语句中的顺序为准</param> 
                 /// <returns></returns> 
                 public SQLiteDataReader ExecuteReader(string sql, SQLiteParameter[] parameters) 
                 { 
                         SQLiteConnection connection = new SQLiteConnection(connectionString); 
                         SQLiteCommand command = new SQLiteCommand(sql, connection); 
                         if (parameters != null) 
                         { 
                                 command.Parameters.AddRange(parameters); 
                         } 
                         connection.Open(); 
                         return command.ExecuteReader(CommandBehavior.CloseConnection); 
                 } 
                 /// <summary> 
                 /// 执行一个查询语句，返回一个包含查询结果的DataTable 
                 /// </summary> 
                 /// <param name="sql">要执行的查询语句</param> 
                 /// <param name="parameters">执行SQL查询语句所需要的参数，参数必须以它们在SQL语句中的顺序为准</param> 
                 /// <returns></returns> 
                 public DataTable ExecuteDataTable(string sql, SQLiteParameter[] parameters) 
                 { 
                         using (SQLiteConnection connection = new SQLiteConnection(connectionString)) 
                         { 
                                 using (SQLiteCommand command = new SQLiteCommand(sql, connection)) 
                                 { 
                                         if (parameters != null) 
                                         { 
                                                 command.Parameters.AddRange(parameters); 
                                         } 
                                         SQLiteDataAdapter adapter = new SQLiteDataAdapter(command); 
                                         DataTable data = new DataTable(); 
                                         adapter.Fill(data); 
                                         return data; 
                                 } 
                         } 
                          
                 } 
                 /// <summary> 
                 /// 执行一个查询语句，返回查询结果的第一行第一列 
                 /// </summary> 
                 /// <param name="sql">要执行的查询语句</param> 
                 /// <param name="parameters">执行SQL查询语句所需要的参数，参数必须以它们在SQL语句中的顺序为准</param> 
                 /// <returns></returns> 
                 public Object ExecuteScalar(string sql, SQLiteParameter[] parameters) 
                 { 
                         using (SQLiteConnection connection = new SQLiteConnection(connectionString)) 
                         { 
                                 using (SQLiteCommand command = new SQLiteCommand(sql, connection)) 
                                 { 
                                         if (parameters != null) 
                                         { 
                                                 command.Parameters.AddRange(parameters); 
                                         } 
                                         SQLiteDataAdapter adapter = new SQLiteDataAdapter(command); 
                                         DataTable data = new DataTable(); 
                                         adapter.Fill(data); 
                                         return data; 
                                 } 
                         } 
                 } 
                 /// <summary> 
                 /// 查询数据库中的所有数据类型信息 
                 /// </summary> 
                 /// <returns></returns> 
                 public DataTable GetSchema() 
                 { 
                         using (SQLiteConnection connection = new SQLiteConnection(connectionString)) 
                         { 
                                 connection.Open(); 
                                 DataTable data=connection.GetSchema("TABLES"); 
                                 connection.Close(); 
                                 //foreach (DataColumn column in data.Columns) 
                                 //{ 
                                 //        Console.WriteLine(column.ColumnName); 
                                 //} 
                                 return data; 
                         } 
                 } 
      
    }
}
