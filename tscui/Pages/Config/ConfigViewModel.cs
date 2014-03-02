using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Apex.MVVM;
using tscui.Models;
using System.Windows;

namespace tscui.Pages.Config
{
    /// <summary>
    /// The VariableSignViewModel ViewModel class.
    /// </summary>
    [ViewModel]
    public class ConfigViewModel : PageViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableSignViewModel"/> class.
        /// </summary>
        public ConfigViewModel()
        {
            //  TODO: Use the following snippets to help build viewmodels:
            //      apexnp - Creates a Notifying Property
            //      apexc - Creates a Command.
            Title = "系统配置";
            SaveYellowFlashCommand = new Command(DoSaveYellowFlashCommand);
            BuildSNCommand = new Command(DoBuildSNCommand);
            SetLampCheckCommand = new Command(DoSetLampCheckCommand);
            SetCountDownCommand = new Command(DoSetCountDownCommand);
        }
        public Command SetCountDownCommand { get; private set; }
        private void DoSetCountDownCommand(object parameter)
        {
           //
        }

        public Command SetLampCheckCommand { get; private set; }
        private void DoSetLampCheckCommand(object parameter)
        {
            //Define.BUILD_SN;
            try
            {
                TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                Udp.sendUdp(t.Node.sIpAddress, Define.GBT_PORT, Define.BUILD_SN);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public Command SaveYellowFlashCommand { get; private set; }
        private void DoSaveYellowFlashCommand(object parameter)
        {
            byte syfr = sldYellowFlashRate;
            byte sdr = sldDutyRatio;
            //sdr 
        }
        
        public Command BuildSNCommand { get; private set; }
        private void DoBuildSNCommand(object parameter)
        {
           //Define.BUILD_SN;
            try
            {
                TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                Udp.sendUdp(t.Node.sIpAddress, Define.GBT_PORT, Define.BUILD_SN);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        /// <summary>
        /// The NotifyingProperty for the Name property.
        /// </summary>
        private NotifyingProperty SldYellowFlashRateProperty =
          new NotifyingProperty("sldYellowFlashRate", typeof(byte), default(byte));

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        /// <value>The value of Name.</value>
        public byte sldYellowFlashRate
        {
            get { return (byte)GetValue(SldYellowFlashRateProperty); }
            set { SetValue(SldYellowFlashRateProperty, value); }
        }
        /// <summary>
        /// The NotifyingProperty for the Name property.
        /// </summary>
        private NotifyingProperty SldDutyRatioProperty =
          new NotifyingProperty("sldDutyRatio", typeof(byte), default(byte));

        /// <summary>
        /// Gets or sets Name.rdoFlashSynch
        /// </summary>rdoFlashAsynch
        /// <value>The value of Name.</value>
        public byte sldDutyRatio
        {
            get { return (byte)GetValue(SldDutyRatioProperty); }
            set { SetValue(SldDutyRatioProperty, value); }
        }
        /// <summary>
        /// The NotifyingProperty for the Name property.
        /// </summary>
        private NotifyingProperty RdoFlashSynchProperty =
          new NotifyingProperty("rdoFlashSynch", typeof(bool), default(bool));

        /// <summary>
        /// Gets or sets Name.
        /// </summary>rdoFlashAsynch
        /// <value>The value of Name.</value>
        public bool rdoFlashSynch
        {
            get { return (bool)GetValue(RdoFlashSynchProperty); }
            set { SetValue(RdoFlashSynchProperty, value); }
        }
        /// <summary>
        /// The NotifyingProperty for the Name property.
        /// </summary>
        private NotifyingProperty RdoFlashAsynchProperty =
          new NotifyingProperty("rdoFlashAsynch", typeof(bool), default(bool));

        /// <summary>
        /// Gets or sets Name.txtHighTemperature
        /// </summary>
        /// <value>The value of Name.</value>
        public bool rdoFlashAsynch
        {
            get { return (bool)GetValue(RdoFlashAsynchProperty); }
            set { SetValue(RdoFlashAsynchProperty, value); }
        }

        /// <summary>
        /// The NotifyingProperty for the Name property.
        /// </summary>
        private NotifyingProperty TxtHighTemperatureProperty =
          new NotifyingProperty("txtHighTemperature", typeof(int), default(int));

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        /// <value>The value of Name.</value>
        public int txtHighTemperature
        {
            get { return (int)GetValue(TxtHighTemperatureProperty); }
            set { SetValue(TxtHighTemperatureProperty, value); }
        }
        /// <summary>
        /// The NotifyingProperty for the Name property.
        /// </summary>
        private NotifyingProperty TxtLowTemperatureProperty =
          new NotifyingProperty("txtLowTemperature", typeof(int), default(int));

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        /// <value>The value of Name.</value>
        public int txtLowTemperature
        {
            get { return (int)GetValue(TxtLowTemperatureProperty); }
            set { SetValue(TxtLowTemperatureProperty, value); }
        }
        /// <summary>
        /// The NotifyingProperty for the Name property.
        /// </summary>
        private NotifyingProperty TxtHighVoltageProperty =
          new NotifyingProperty("txtHighVoltage", typeof(int), default(int));

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        /// <value>The value of Name.</value>
        public int txtHighVoltage
        {
            get { return (int)GetValue(TxtHighVoltageProperty); }
            set { SetValue(TxtHighVoltageProperty, value); }
        }
        /// <summary>
        /// The NotifyingProperty for the Name property.
        /// </summary>
        private NotifyingProperty TxtLowVoltageProperty =
          new NotifyingProperty("txtLowVoltage", typeof(int), default(int));

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        /// <value>The value of Name.</value>
        public int txtLowVoltage
        {
            get { return (int)GetValue(TxtLowVoltageProperty); }
            set { SetValue(TxtLowVoltageProperty, value); }
        } 
        /// <summary>
        /// The NotifyingProperty for the Name property.
        /// </summary>
        private NotifyingProperty TxtHighHumidityProperty =
          new NotifyingProperty("txtHighHumidity", typeof(int), default(int));

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        /// <value>The value of Name.</value>
        public int txtHighHumidity
        {
            get { return (int)GetValue(TxtHighHumidityProperty); }
            set { SetValue(TxtHighHumidityProperty, value); }
        }
        /// <summary>
        /// The NotifyingProperty for the Name property.
        /// </summary>
        private NotifyingProperty TxtLowHumidityProperty =
          new NotifyingProperty("txtLowHumidity", typeof(int), default(int));

        /// <summary>
        /// Gets or sets Name.txtDoorCheck
        /// </summary>
        /// <value>The value of Name.</value>
        public int txtLowHumidity
        {
            get { return (int)GetValue(TxtLowHumidityProperty); }
            set { SetValue(TxtLowHumidityProperty, value); }
        }
        /// <summary>
        /// The NotifyingProperty for the Name property.
        /// </summary>
        private NotifyingProperty TxtDoorCheckProperty =
          new NotifyingProperty("txtDoorCheck", typeof(int), default(int));

        /// <summary>
        /// Gets or sets Name.cbxDegradationModel
        /// </summary>
        /// <value>The value of Name.</value>
        public int txtDoorCheck
        {
            get { return (int)GetValue(TxtDoorCheckProperty); }
            set { SetValue(TxtDoorCheckProperty, value); }
        }
 
    }
}
