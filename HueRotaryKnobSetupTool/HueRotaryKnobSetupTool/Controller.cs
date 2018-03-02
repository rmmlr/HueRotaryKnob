using Q42.HueApi;
using Q42.HueApi.Interfaces;
using Q42.HueApi.Models.Bridge;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rca.HrkSetupTool
{
    public class Controller : INotifyPropertyChanged
    {
        #region Constants
        const string APP_NAME = "HueRotaryKnobSetuuTool";
        const string DEVICE_NAME = "TestDevice"; //TODO: Rechnername verwenden

        #endregion

        #region Member

        AppKeyManager m_AppKeyManager;
        ILocalHueClient m_Client;

        #endregion Member

        #region Properties
        private bool m_SetupMode;

        public bool SetupMode
        {
            get { return m_SetupMode; }
            set
            {
                m_SetupMode = value;
                PropChanged();
            }
        }

        public LocatedBridge CurrentBridge
        {
            get
            {
                var bridge = new LocatedBridge();
                bridge.BridgeId = Properties.Settings.Default.LastBridgeId;
                bridge.IpAddress = Properties.Settings.Default.LastBridgeIpAddress;
                if (string.IsNullOrWhiteSpace(bridge.BridgeId) || string.IsNullOrWhiteSpace(bridge.IpAddress))
                    return null;
                else
                    return bridge;
            }
            set
            {
                if (value != null)
                {
                    Properties.Settings.Default.LastBridgeId = value.BridgeId;
                    Properties.Settings.Default.LastBridgeIpAddress = value.IpAddress;
                    Properties.Settings.Default.Save();

                    PropChanged();
                }
            }
        }

        #endregion Properties

        #region Constructor
        /// <summary>
        /// Standardkonstruktor für Controller
        /// </summary>
        public Controller()
        {
            m_AppKeyManager = new AppKeyManager();

            if (CurrentBridge != null)
            {
                if (MessageBox.Show("Soll versucht werden eine Verbindung zur zuletzt verbundenen Bridge (ID: " + CurrentBridge.BridgeId + " IP: "
                    + CurrentBridge.IpAddress + ") herzustellen?", "Verbinde Bridge", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Initialize(CurrentBridge.IpAddress); //TODO: was passiert wenn die Bridge nicht erreichbar ist?
                }
            }
        }

        #endregion Constructor

        #region Services
        /// <summary>
        /// Umschalten des Setup-Modus für den verbundenen Rotary-Knob
        /// </summary>
        public void ToggleSetupMode()
        {
            //nur zum Testen:
            SetupMode =! SetupMode;
        }

        /// <summary>
        /// Suchen nach Bridges
        /// </summary>
        public async Task<LocatedBridge[]> ScanBridges()
        {
            IBridgeLocator locator = new HttpBridgeLocator();
            var bridgeIPs = await locator.LocateBridgesAsync(TimeSpan.FromSeconds(5));

            var locatedBridges = new List<LocatedBridge>();
            foreach (LocatedBridge bridge in bridgeIPs)
                locatedBridges.Add(bridge);

            return locatedBridges.ToArray();
        }

        /// <summary>
        /// Initialisieren einer bestimmten Bridge
        /// </summary>
        /// <param name="bridgeIp">IP der zu initialisierenden Bridge</param>
        public async Task<Bridge> Initialize(string bridgeIp)
        {
            m_Client = new LocalHueClient(bridgeIp);

            var appKey = m_AppKeyManager.AppKey;
            if (string.IsNullOrEmpty(appKey))
            {
                appKey = await m_Client.RegisterAsync(APP_NAME, DEVICE_NAME);
                m_AppKeyManager.AppKey = appKey;
            }
            m_Client.Initialize(appKey);

            return await m_Client.GetBridgeAsync();
        }

        #endregion Services

        #region Internal services


        #endregion Internal services

        #region Events


        #endregion Events

        #region INotifyPropertyChanged Member
        /// <summary>
        /// Helpmethod, to call the <see cref="PropertyChanged"/> event
        /// </summary>
        /// <param name="propName">Name of changed property</param>
        protected void PropChanged([CallerMemberName] string propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        /// <summary>
        /// Updated property values available
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
