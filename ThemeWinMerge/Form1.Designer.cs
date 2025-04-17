
namespace ThemeWinMerge
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnOpen = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gbDisplayOptions = new System.Windows.Forms.GroupBox();
            this.chkHook = new System.Windows.Forms.CheckBox();
            this.chkAllDisplayOptions = new System.Windows.Forms.CheckBox();
            this.chkText = new System.Windows.Forms.CheckBox();
            this.chkDeleted = new System.Windows.Forms.CheckBox();
            this.chkBackground = new System.Windows.Forms.CheckBox();
            this.chkDir = new System.Windows.Forms.CheckBox();
            this.chkMarkers = new System.Windows.Forms.CheckBox();
            this.chkSyntax = new System.Windows.Forms.CheckBox();
            this.chkLine = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pnlCopy = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkSelectAllShown = new System.Windows.Forms.CheckBox();
            this.gbColourChange = new System.Windows.Forms.GroupBox();
            this.btnTempDown = new System.Windows.Forms.Button();
            this.btnTempUp = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBlackDown = new System.Windows.Forms.Button();
            this.btnBlackUp = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBlueDown = new System.Windows.Forms.Button();
            this.btnBlueUp = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGreenDown = new System.Windows.Forms.Button();
            this.btnGreenUp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRedDown = new System.Windows.Forms.Button();
            this.btnRedUp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.gbDisplayOptions.SuspendLayout();
            this.gbColourChange.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(19, 10);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(128, 38);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open Ini File";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(19, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 788);
            this.panel1.TabIndex = 2;
            // 
            // gbDisplayOptions
            // 
            this.gbDisplayOptions.Controls.Add(this.chkHook);
            this.gbDisplayOptions.Controls.Add(this.chkAllDisplayOptions);
            this.gbDisplayOptions.Controls.Add(this.chkText);
            this.gbDisplayOptions.Controls.Add(this.chkDeleted);
            this.gbDisplayOptions.Controls.Add(this.chkBackground);
            this.gbDisplayOptions.Controls.Add(this.chkDir);
            this.gbDisplayOptions.Controls.Add(this.chkMarkers);
            this.gbDisplayOptions.Controls.Add(this.chkSyntax);
            this.gbDisplayOptions.Controls.Add(this.chkLine);
            this.gbDisplayOptions.Location = new System.Drawing.Point(479, 54);
            this.gbDisplayOptions.Name = "gbDisplayOptions";
            this.gbDisplayOptions.Size = new System.Drawing.Size(312, 137);
            this.gbDisplayOptions.TabIndex = 3;
            this.gbDisplayOptions.TabStop = false;
            this.gbDisplayOptions.Text = "Display Options";
            // 
            // chkHook
            // 
            this.chkHook.AutoSize = true;
            this.chkHook.Location = new System.Drawing.Point(7, 114);
            this.chkHook.Name = "chkHook";
            this.chkHook.Size = new System.Drawing.Size(89, 17);
            this.chkHook.TabIndex = 8;
            this.chkHook.Text = "System Hook";
            this.chkHook.UseVisualStyleBackColor = true;
            this.chkHook.CheckedChanged += new System.EventHandler(this.chkHook_CheckedChanged);
            // 
            // chkAllDisplayOptions
            // 
            this.chkAllDisplayOptions.AutoSize = true;
            this.chkAllDisplayOptions.Location = new System.Drawing.Point(100, 0);
            this.chkAllDisplayOptions.Name = "chkAllDisplayOptions";
            this.chkAllDisplayOptions.Size = new System.Drawing.Size(37, 17);
            this.chkAllDisplayOptions.TabIndex = 7;
            this.chkAllDisplayOptions.Text = "All";
            this.chkAllDisplayOptions.ThreeState = true;
            this.chkAllDisplayOptions.UseVisualStyleBackColor = true;
            this.chkAllDisplayOptions.CheckedChanged += new System.EventHandler(this.chkAllDisplayOptions_CheckedChanged);
            this.chkAllDisplayOptions.CheckStateChanged += new System.EventHandler(this.chkAllDisplayOptions_CheckStateChanged);
            // 
            // chkText
            // 
            this.chkText.AutoSize = true;
            this.chkText.Location = new System.Drawing.Point(218, 68);
            this.chkText.Name = "chkText";
            this.chkText.Size = new System.Drawing.Size(47, 17);
            this.chkText.TabIndex = 6;
            this.chkText.Text = "Text";
            this.chkText.UseVisualStyleBackColor = true;
            this.chkText.CheckedChanged += new System.EventHandler(this.chkText_CheckedChanged);
            // 
            // chkDeleted
            // 
            this.chkDeleted.AutoSize = true;
            this.chkDeleted.Location = new System.Drawing.Point(218, 44);
            this.chkDeleted.Name = "chkDeleted";
            this.chkDeleted.Size = new System.Drawing.Size(63, 17);
            this.chkDeleted.TabIndex = 5;
            this.chkDeleted.Text = "Deleted";
            this.chkDeleted.UseVisualStyleBackColor = true;
            this.chkDeleted.CheckedChanged += new System.EventHandler(this.chkDeleted_CheckedChanged);
            // 
            // chkBackground
            // 
            this.chkBackground.AutoSize = true;
            this.chkBackground.Location = new System.Drawing.Point(218, 20);
            this.chkBackground.Name = "chkBackground";
            this.chkBackground.Size = new System.Drawing.Size(84, 17);
            this.chkBackground.TabIndex = 4;
            this.chkBackground.Text = "Background";
            this.chkBackground.UseVisualStyleBackColor = true;
            this.chkBackground.CheckedChanged += new System.EventHandler(this.chkBackground_CheckedChanged);
            // 
            // chkDir
            // 
            this.chkDir.AutoSize = true;
            this.chkDir.Location = new System.Drawing.Point(7, 91);
            this.chkDir.Name = "chkDir";
            this.chkDir.Size = new System.Drawing.Size(68, 17);
            this.chkDir.TabIndex = 3;
            this.chkDir.Text = "Directory";
            this.chkDir.UseVisualStyleBackColor = true;
            this.chkDir.CheckedChanged += new System.EventHandler(this.chkDir_CheckedChanged);
            // 
            // chkMarkers
            // 
            this.chkMarkers.AutoSize = true;
            this.chkMarkers.Location = new System.Drawing.Point(7, 67);
            this.chkMarkers.Name = "chkMarkers";
            this.chkMarkers.Size = new System.Drawing.Size(64, 17);
            this.chkMarkers.TabIndex = 2;
            this.chkMarkers.Text = "Markers";
            this.chkMarkers.UseVisualStyleBackColor = true;
            this.chkMarkers.CheckedChanged += new System.EventHandler(this.chkMarkers_CheckedChanged);
            // 
            // chkSyntax
            // 
            this.chkSyntax.AutoSize = true;
            this.chkSyntax.Location = new System.Drawing.Point(6, 43);
            this.chkSyntax.Name = "chkSyntax";
            this.chkSyntax.Size = new System.Drawing.Size(58, 17);
            this.chkSyntax.TabIndex = 1;
            this.chkSyntax.Text = "Syntax";
            this.chkSyntax.UseVisualStyleBackColor = true;
            this.chkSyntax.CheckedChanged += new System.EventHandler(this.chkSyntax_CheckedChanged);
            // 
            // chkLine
            // 
            this.chkLine.AutoSize = true;
            this.chkLine.Location = new System.Drawing.Point(6, 19);
            this.chkLine.Name = "chkLine";
            this.chkLine.Size = new System.Drawing.Size(46, 17);
            this.chkLine.TabIndex = 0;
            this.chkLine.Text = "Line";
            this.chkLine.UseVisualStyleBackColor = true;
            this.chkLine.CheckedChanged += new System.EventHandler(this.chkLine_CheckedChanged);
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // pnlCopy
            // 
            this.pnlCopy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCopy.Location = new System.Drawing.Point(262, 27);
            this.pnlCopy.Name = "pnlCopy";
            this.pnlCopy.Size = new System.Drawing.Size(100, 21);
            this.pnlCopy.TabIndex = 4;
            this.pnlCopy.Click += new System.EventHandler(this.pnlCopy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "copy";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(656, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 38);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkSelectAllShown
            // 
            this.chkSelectAllShown.AutoSize = true;
            this.chkSelectAllShown.Location = new System.Drawing.Point(434, 31);
            this.chkSelectAllShown.Name = "chkSelectAllShown";
            this.chkSelectAllShown.Size = new System.Drawing.Size(37, 17);
            this.chkSelectAllShown.TabIndex = 7;
            this.chkSelectAllShown.Text = "All";
            this.chkSelectAllShown.UseVisualStyleBackColor = true;
            this.chkSelectAllShown.CheckedChanged += new System.EventHandler(this.chkSelectAllShown_CheckedChanged);
            // 
            // gbColourChange
            // 
            this.gbColourChange.Controls.Add(this.btnTempDown);
            this.gbColourChange.Controls.Add(this.btnTempUp);
            this.gbColourChange.Controls.Add(this.label6);
            this.gbColourChange.Controls.Add(this.btnBlackDown);
            this.gbColourChange.Controls.Add(this.btnBlackUp);
            this.gbColourChange.Controls.Add(this.label5);
            this.gbColourChange.Controls.Add(this.btnBlueDown);
            this.gbColourChange.Controls.Add(this.btnBlueUp);
            this.gbColourChange.Controls.Add(this.label4);
            this.gbColourChange.Controls.Add(this.btnGreenDown);
            this.gbColourChange.Controls.Add(this.btnGreenUp);
            this.gbColourChange.Controls.Add(this.label3);
            this.gbColourChange.Controls.Add(this.btnRedDown);
            this.gbColourChange.Controls.Add(this.btnRedUp);
            this.gbColourChange.Controls.Add(this.label2);
            this.gbColourChange.Location = new System.Drawing.Point(479, 212);
            this.gbColourChange.Name = "gbColourChange";
            this.gbColourChange.Size = new System.Drawing.Size(312, 243);
            this.gbColourChange.TabIndex = 8;
            this.gbColourChange.TabStop = false;
            this.gbColourChange.Text = "Colour Change All Selected";
            // 
            // btnTempDown
            // 
            this.btnTempDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTempDown.Location = new System.Drawing.Point(187, 126);
            this.btnTempDown.Name = "btnTempDown";
            this.btnTempDown.Size = new System.Drawing.Size(31, 28);
            this.btnTempDown.TabIndex = 14;
            this.btnTempDown.Text = "↓";
            this.btnTempDown.UseVisualStyleBackColor = true;
            this.btnTempDown.Click += new System.EventHandler(this.btnTempDown_Click);
            // 
            // btnTempUp
            // 
            this.btnTempUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTempUp.Location = new System.Drawing.Point(187, 99);
            this.btnTempUp.Name = "btnTempUp";
            this.btnTempUp.Size = new System.Drawing.Size(31, 28);
            this.btnTempUp.TabIndex = 13;
            this.btnTempUp.Text = "↑";
            this.btnTempUp.UseVisualStyleBackColor = true;
            this.btnTempUp.Click += new System.EventHandler(this.btnTempUp_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(154, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Temp";
            // 
            // btnBlackDown
            // 
            this.btnBlackDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlackDown.Location = new System.Drawing.Point(187, 56);
            this.btnBlackDown.Name = "btnBlackDown";
            this.btnBlackDown.Size = new System.Drawing.Size(31, 28);
            this.btnBlackDown.TabIndex = 11;
            this.btnBlackDown.Text = "↓";
            this.btnBlackDown.UseVisualStyleBackColor = true;
            this.btnBlackDown.Click += new System.EventHandler(this.btnBlackDown_Click);
            // 
            // btnBlackUp
            // 
            this.btnBlackUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlackUp.Location = new System.Drawing.Point(187, 29);
            this.btnBlackUp.Name = "btnBlackUp";
            this.btnBlackUp.Size = new System.Drawing.Size(31, 28);
            this.btnBlackUp.TabIndex = 10;
            this.btnBlackUp.Text = "↑";
            this.btnBlackUp.UseVisualStyleBackColor = true;
            this.btnBlackUp.Click += new System.EventHandler(this.btnBlackUp_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(154, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Black";
            // 
            // btnBlueDown
            // 
            this.btnBlueDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlueDown.Location = new System.Drawing.Point(50, 200);
            this.btnBlueDown.Name = "btnBlueDown";
            this.btnBlueDown.Size = new System.Drawing.Size(31, 28);
            this.btnBlueDown.TabIndex = 8;
            this.btnBlueDown.Text = "↓";
            this.btnBlueDown.UseVisualStyleBackColor = true;
            this.btnBlueDown.Click += new System.EventHandler(this.btnBlueDown_Click);
            // 
            // btnBlueUp
            // 
            this.btnBlueUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlueUp.Location = new System.Drawing.Point(50, 173);
            this.btnBlueUp.Name = "btnBlueUp";
            this.btnBlueUp.Size = new System.Drawing.Size(31, 28);
            this.btnBlueUp.TabIndex = 7;
            this.btnBlueUp.Text = "↑";
            this.btnBlueUp.UseVisualStyleBackColor = true;
            this.btnBlueUp.Click += new System.EventHandler(this.btnBlueUp_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(17, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Blue";
            // 
            // btnGreenDown
            // 
            this.btnGreenDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGreenDown.Location = new System.Drawing.Point(50, 126);
            this.btnGreenDown.Name = "btnGreenDown";
            this.btnGreenDown.Size = new System.Drawing.Size(31, 28);
            this.btnGreenDown.TabIndex = 5;
            this.btnGreenDown.Text = "↓";
            this.btnGreenDown.UseVisualStyleBackColor = true;
            this.btnGreenDown.Click += new System.EventHandler(this.btnGreenDown_Click);
            // 
            // btnGreenUp
            // 
            this.btnGreenUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGreenUp.Location = new System.Drawing.Point(50, 99);
            this.btnGreenUp.Name = "btnGreenUp";
            this.btnGreenUp.Size = new System.Drawing.Size(31, 28);
            this.btnGreenUp.TabIndex = 4;
            this.btnGreenUp.Text = "↑";
            this.btnGreenUp.UseVisualStyleBackColor = true;
            this.btnGreenUp.Click += new System.EventHandler(this.btnGreenUp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(17, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Green";
            // 
            // btnRedDown
            // 
            this.btnRedDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedDown.Location = new System.Drawing.Point(50, 56);
            this.btnRedDown.Name = "btnRedDown";
            this.btnRedDown.Size = new System.Drawing.Size(31, 28);
            this.btnRedDown.TabIndex = 2;
            this.btnRedDown.Text = "↓";
            this.btnRedDown.UseVisualStyleBackColor = true;
            this.btnRedDown.Click += new System.EventHandler(this.btnRedDown_Click);
            // 
            // btnRedUp
            // 
            this.btnRedUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedUp.Location = new System.Drawing.Point(50, 29);
            this.btnRedUp.Name = "btnRedUp";
            this.btnRedUp.Size = new System.Drawing.Size(31, 28);
            this.btnRedUp.TabIndex = 1;
            this.btnRedUp.Text = "↑";
            this.btnRedUp.UseVisualStyleBackColor = true;
            this.btnRedUp.Click += new System.EventHandler(this.btnRedUp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(17, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Red";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(188, 32);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(47, 13);
            this.lblCount.TabIndex = 9;
            this.lblCount.Text = "Count: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 850);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.gbColourChange);
            this.Controls.Add(this.chkSelectAllShown);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlCopy);
            this.Controls.Add(this.gbDisplayOptions);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOpen);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Theme WinMerge";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.gbDisplayOptions.ResumeLayout(false);
            this.gbDisplayOptions.PerformLayout();
            this.gbColourChange.ResumeLayout(false);
            this.gbColourChange.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.FlowLayoutPanel panel1;
        private System.Windows.Forms.GroupBox gbDisplayOptions;
        private System.Windows.Forms.CheckBox chkLine;
        private System.Windows.Forms.CheckBox chkDir;
        private System.Windows.Forms.CheckBox chkMarkers;
        private System.Windows.Forms.CheckBox chkSyntax;
        private System.Windows.Forms.CheckBox chkAllDisplayOptions;
        private System.Windows.Forms.CheckBox chkText;
        private System.Windows.Forms.CheckBox chkDeleted;
        private System.Windows.Forms.CheckBox chkBackground;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel pnlCopy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkSelectAllShown;
        private System.Windows.Forms.GroupBox gbColourChange;
        private System.Windows.Forms.Button btnRedDown;
        private System.Windows.Forms.Button btnRedUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBlueDown;
        private System.Windows.Forms.Button btnBlueUp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGreenDown;
        private System.Windows.Forms.Button btnGreenUp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBlackDown;
        private System.Windows.Forms.Button btnBlackUp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnTempDown;
        private System.Windows.Forms.Button btnTempUp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkHook;
    }
}

