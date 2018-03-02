namespace Rca.HrkSetupTool
{
    partial class MainView
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hueBridgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sucheBridgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotaryKnobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anmeldenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_Bridge = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_RotaryKnob = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_SetupMode = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.einstellungenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(656, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öffnenToolStripMenuItem,
            this.speichernToolStripMenuItem,
            this.toolStripSeparator1,
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // öffnenToolStripMenuItem
            // 
            this.öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
            this.öffnenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.öffnenToolStripMenuItem.Text = "Öffnen...";
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.speichernToolStripMenuItem.Text = "Speichern...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hueBridgeToolStripMenuItem,
            this.rotaryKnobToolStripMenuItem});
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.einstellungenToolStripMenuItem.Text = "Einstellungen";
            // 
            // hueBridgeToolStripMenuItem
            // 
            this.hueBridgeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sucheBridgeToolStripMenuItem});
            this.hueBridgeToolStripMenuItem.Name = "hueBridgeToolStripMenuItem";
            this.hueBridgeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hueBridgeToolStripMenuItem.Text = "Hue Bridge";
            // 
            // sucheBridgeToolStripMenuItem
            // 
            this.sucheBridgeToolStripMenuItem.Name = "sucheBridgeToolStripMenuItem";
            this.sucheBridgeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sucheBridgeToolStripMenuItem.Text = "Suche Bridge";
            this.sucheBridgeToolStripMenuItem.Click += new System.EventHandler(this.sucheBridgeToolStripMenuItem_Click);
            // 
            // rotaryKnobToolStripMenuItem
            // 
            this.rotaryKnobToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anmeldenToolStripMenuItem});
            this.rotaryKnobToolStripMenuItem.Name = "rotaryKnobToolStripMenuItem";
            this.rotaryKnobToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rotaryKnobToolStripMenuItem.Text = "Rotary Knob";
            // 
            // anmeldenToolStripMenuItem
            // 
            this.anmeldenToolStripMenuItem.Name = "anmeldenToolStripMenuItem";
            this.anmeldenToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.anmeldenToolStripMenuItem.Text = "Anmelden";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_Bridge,
            this.lbl_RotaryKnob});
            this.statusStrip1.Location = new System.Drawing.Point(0, 413);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(656, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_Bridge
            // 
            this.lbl_Bridge.Name = "lbl_Bridge";
            this.lbl_Bridge.Size = new System.Drawing.Size(124, 17);
            this.lbl_Bridge.Text = "Bridge: not connected";
            // 
            // lbl_RotaryKnob
            // 
            this.lbl_RotaryKnob.Name = "lbl_RotaryKnob";
            this.lbl_RotaryKnob.Size = new System.Drawing.Size(155, 17);
            this.lbl_RotaryKnob.Text = "Rotary Knob: not connected";
            // 
            // btn_SetupMode
            // 
            this.btn_SetupMode.Location = new System.Drawing.Point(19, 29);
            this.btn_SetupMode.Name = "btn_SetupMode";
            this.btn_SetupMode.Size = new System.Drawing.Size(202, 23);
            this.btn_SetupMode.TabIndex = 2;
            this.btn_SetupMode.Text = "Einrichtungsmodus aktivieren";
            this.btn_SetupMode.UseVisualStyleBackColor = true;
            this.btn_SetupMode.Click += new System.EventHandler(this.btn_SetupMode_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_SetupMode);
            this.groupBox1.Location = new System.Drawing.Point(23, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 353);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rotary Knob";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 435);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainView";
            this.Text = "Hue Rotary Knob - Setup Tool";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öffnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem hueBridgeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sucheBridgeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotaryKnobToolStripMenuItem;
        private System.Windows.Forms.Button btn_SetupMode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem anmeldenToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Bridge;
        private System.Windows.Forms.ToolStripStatusLabel lbl_RotaryKnob;
    }
}

