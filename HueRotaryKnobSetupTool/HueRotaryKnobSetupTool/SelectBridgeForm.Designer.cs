namespace Rca.HrkSetupTool
{
    partial class SelectBridgeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_Bridges = new System.Windows.Forms.DataGridView();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Abort = new System.Windows.Forms.Button();
            this.col_BridgeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BridgeIp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bridges)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Bridges
            // 
            this.dgv_Bridges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Bridges.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_BridgeName,
            this.col_BridgeIp});
            this.dgv_Bridges.Location = new System.Drawing.Point(12, 12);
            this.dgv_Bridges.Name = "dgv_Bridges";
            this.dgv_Bridges.RowHeadersVisible = false;
            this.dgv_Bridges.Size = new System.Drawing.Size(306, 150);
            this.dgv_Bridges.TabIndex = 0;
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(243, 179);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 1;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Abort
            // 
            this.btn_Abort.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Abort.Location = new System.Drawing.Point(12, 179);
            this.btn_Abort.Name = "btn_Abort";
            this.btn_Abort.Size = new System.Drawing.Size(75, 23);
            this.btn_Abort.TabIndex = 2;
            this.btn_Abort.Text = "Abbrechen";
            this.btn_Abort.UseVisualStyleBackColor = true;
            this.btn_Abort.Click += new System.EventHandler(this.btn_Abort_Click);
            // 
            // col_BridgeName
            // 
            this.col_BridgeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_BridgeName.DataPropertyName = "BridgeId";
            this.col_BridgeName.HeaderText = "Bridge ID";
            this.col_BridgeName.Name = "col_BridgeName";
            // 
            // col_BridgeIp
            // 
            this.col_BridgeIp.DataPropertyName = "IpAddress";
            this.col_BridgeIp.FillWeight = 140F;
            this.col_BridgeIp.HeaderText = "IP";
            this.col_BridgeIp.Name = "col_BridgeIp";
            this.col_BridgeIp.Width = 140;
            // 
            // SelectBridgeForm
            // 
            this.AcceptButton = this.btn_Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Abort;
            this.ClientSize = new System.Drawing.Size(331, 217);
            this.Controls.Add(this.btn_Abort);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.dgv_Bridges);
            this.Name = "SelectBridgeForm";
            this.Text = "Gefundene Hue Bridges";
            this.Load += new System.EventHandler(this.SelectBridgeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bridges)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Bridges;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_Abort;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BridgeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BridgeIp;
    }
}