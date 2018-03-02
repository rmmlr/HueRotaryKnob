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
    public partial class SelectBridgeForm : Form
    {
        LocatedBridge m_SelectedBridge;
        BindingList<LocatedBridge> m_Bridges;

        public SelectBridgeForm(LocatedBridge[] bridges)
        {
            InitializeComponent();

            m_Bridges = new BindingList<LocatedBridge>();
            foreach (var bridge in bridges)
                m_Bridges.Add(bridge);
            dgv_Bridges.DataSource = bridges;
            
            m_SelectedBridge = null;
        }

        private void SelectBridgeForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Zeigt das Fenster als modalen Dialog
        /// </summary>
        /// <returns></returns>
        public new LocatedBridge ShowDialog()
        {
            base.ShowDialog();

            return m_SelectedBridge;
        }

        private void btn_Abort_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (m_Bridges.Count > 0 && dgv_Bridges.SelectedRows.Count > 0)
                m_SelectedBridge = m_Bridges[dgv_Bridges.SelectedRows[0].Index];

            DialogResult = DialogResult.OK;
        }
    }
}
