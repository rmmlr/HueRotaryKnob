using Q42.HueApi.Models.Bridge;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rca.HrkSetupTool
{
    public partial class MainView : Form
    {
        #region Member
        Controller m_Controller;

        #endregion Member

        public MainView()
        {
            InitializeComponent();

            m_Controller = new Controller();

            m_Controller.PropertyChanged += controller_PropertyChanged;
        }

        private void controller_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(Controller.SetupMode):
                    toggleSetupMode(m_Controller.SetupMode);
                    break;
            }
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toggleSetupMode(bool enable)
        {
            if (enable)
            {
                btn_SetupMode.Text = "Einrichtungsmodus beenden";
                btn_SetupMode.BackColor = Color.Tomato;
            }
            else
            {
                btn_SetupMode.Text = "Einrichtungsmodus aktivieren";
                btn_SetupMode.BackColor = Color.Transparent;
            }
        }

        private void btn_SetupMode_Click(object sender, EventArgs e)
        {
            m_Controller.ToggleSetupMode();
        }

        private async void sucheBridgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            LocatedBridge[] bridges = await m_Controller.ScanBridges();

            Cursor = Cursors.Default;

            if (bridges.Length <= 0)
            {
                if (MessageBox.Show("Keine Hue Bridge gefunden. Die Suche kann wiederholt werden.", "Suche Bridge...",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                    return;
                else
                    sucheBridgeToolStripMenuItem_Click(sender, e);
            }
            else
            {
                var bridgeDlg = new SelectBridgeForm(bridges);
                
                m_Controller.CurrentBridge = bridgeDlg.ShowDialog();
            }
        }
    }
}
