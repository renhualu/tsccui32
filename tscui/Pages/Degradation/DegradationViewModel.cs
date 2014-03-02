using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Apex.MVVM;
using tscui.Models;
using System.Windows;

namespace tscui.Pages.Degradation
{
    /// <summary>
    /// The ThePagesViewModel ViewModel class.
    /// </summary>
    public class DegradationViewModel : PageViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThePagesViewModel"/> class.
        /// </summary>
        public DegradationViewModel()
        {
            Title = "联网降级";
            DegradationCommand = new Command(DoDegradationCommand);
        }
        public Command DegradationCommand { get; private set; }
        private void DoDegradationCommand(object parameter)
        {
            try
            {
                TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                Node n = t.Node;
                int cdm = cbxDegradationModel;
                bool bl = false;
                switch (cdm)
                {
                    case 0:

                        break;
                    case 1:
                        bl = Udp.sendUdp(n.sIpAddress, Define.GBT_PORT, Define.SEND_DEGRADATION_MODE_ONE);
                        break;
                    case 2:
                        bl = Udp.sendUdp(n.sIpAddress, Define.GBT_PORT, Define.SEND_DEGRADATION_MODE_TWO);
                        break;
                    case 3:
                        bl = Udp.sendUdp(n.sIpAddress, Define.GBT_PORT, Define.SEND_DEGRADATION_MODE_THREE);
                        break;
                    case 4:
                        bl = Udp.sendUdp(n.sIpAddress, Define.GBT_PORT, Define.SEND_DEGRADATION_MODE_FOUR);
                        break;
                    case 5:

                        byte[] first = Define.SEND_DEGRADATION_MODEL_FIVE;
                        first[11] = Convert.ToByte(cbxDegradationBaseSchedule);

                        bl = Udp.sendUdp(n.sIpAddress, Define.GBT_PORT, first);
                        break;
                    case 6:
                        bl = Udp.sendUdp(n.sIpAddress, Define.GBT_PORT, Define.SEND_DEGRADATION_MODE_SIX);
                        break;
                    case 7:
                        bl = Udp.sendUdp(n.sIpAddress, Define.GBT_PORT, Define.SEND_DEGRADATION_MODE_SEVEN);
                        break;
                    case 8:
                        bl = Udp.sendUdp(n.sIpAddress, Define.GBT_PORT, Define.SEND_DEGRADATION_MODE_EIGHT);
                        break;
                    case 9:
                        bl = Udp.sendUdp(n.sIpAddress, Define.GBT_PORT, Define.SEND_DEGRADATION_MODE_NINE);
                        break;
                    case 10:
                        bl = Udp.sendUdp(n.sIpAddress, Define.GBT_PORT, Define.SEND_DEGRADATION_MODE_TEN);
                        break;
                    case 11:
                        bl = Udp.sendUdp(n.sIpAddress, Define.GBT_PORT, Define.SEND_DEGRADATION_MODE_ELEVEN);
                        break;
                    case 12:
                        bl = Udp.sendUdp(n.sIpAddress, Define.GBT_PORT, Define.SEND_DEGRADATION_MODE_TWELVE);
                        break;
                    case 13:
                        bl = Udp.sendUdp(n.sIpAddress, Define.GBT_PORT, Define.SEND_DEGRADATION_MODE_THREETH);
                        break;
                    case 14:
                        bl = Udp.sendUdp(n.sIpAddress, Define.GBT_PORT, Define.SEND_DEGRADATION_MODE_FOURTH);
                        break;
                    default:
                        break;
                }
                if (bl)
                {
                    MessageBox.Show("联网降级数据保存成功！");
                }
                else
                {
                    MessageBox.Show("联网降级数据保存失败！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
        /// <summary>
        /// The NotifyingProperty for the Name property.
        /// </summary>
        private NotifyingProperty CbxDegradationModelProperty =
          new NotifyingProperty("cbxDegradationModel", typeof(int), default(int));

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        /// <value>The value of Name.</value>
        public int cbxDegradationModel
        {
            get { return (int)GetValue(CbxDegradationModelProperty); }
            set { SetValue(CbxDegradationModelProperty, value); }
        }

        /// <summary>
        /// The NotifyingProperty for the Name property.
        /// </summary>
        private NotifyingProperty CbxDegradationBaseScheduleProperty =
          new NotifyingProperty("cbxDegradationBaseSchedule", typeof(int), default(int));

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        /// <value>The value of Name.</value>
        public int cbxDegradationBaseSchedule
        {
            get { return (int)GetValue(CbxDegradationBaseScheduleProperty); }
            set { SetValue(CbxDegradationBaseScheduleProperty, value); }
        }

        /// <summary>
        /// The NotifyingProperty for the Name property.
        /// </summary>
        private NotifyingProperty CbxDegradationKeyPhaseProperty =
          new NotifyingProperty("cbxDegradationKeyPhase", typeof(int), default(int));

        /// <summary>
        /// Gets or sets Name.cbxDegradationStagePhaseTime
        /// </summary>
        /// <value>The value of Name.</value>
        public int cbxDegradationKeyPhase
        {
            get { return (int)GetValue(CbxDegradationKeyPhaseProperty); }
            set { SetValue(CbxDegradationKeyPhaseProperty, value); }
        }
        /// <summary>
        /// The NotifyingProperty for the Name property.
        /// </summary>
        private NotifyingProperty CbxDegradationStagePhaseTimeProperty =
          new NotifyingProperty("cbxDegradationStagePhaseTime", typeof(int), default(int));

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        /// <value>The value of Name.</value>
        public int cbxDegradationStagePhaseTime
        {
            get { return (int)GetValue(CbxDegradationStagePhaseTimeProperty); }
            set { SetValue(CbxDegradationStagePhaseTimeProperty, value); }
        }
    }
}
