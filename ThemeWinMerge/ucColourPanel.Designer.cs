
namespace ThemeWinMerge
{
    partial class ucColourPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucColourPanel));
            this.lblName = new System.Windows.Forms.Label();
            this.pnlSample = new System.Windows.Forms.Panel();
            this.pbPaste = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pbCopy = new System.Windows.Forms.PictureBox();
            this.pbRevert = new System.Windows.Forms.PictureBox();
            this.chkSelected = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPaste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCopy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRevert)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoEllipsis = true;
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(234, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "label1";
            // 
            // pnlSample
            // 
            this.pnlSample.BackColor = System.Drawing.Color.White;
            this.pnlSample.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSample.Location = new System.Drawing.Point(240, 0);
            this.pnlSample.Name = "pnlSample";
            this.pnlSample.Size = new System.Drawing.Size(100, 22);
            this.pnlSample.TabIndex = 1;
            this.pnlSample.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlSample_MouseClick);
            // 
            // pbPaste
            // 
            this.pbPaste.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbPaste.BackgroundImage")));
            this.pbPaste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbPaste.Location = new System.Drawing.Point(346, 3);
            this.pbPaste.Name = "pbPaste";
            this.pbPaste.Size = new System.Drawing.Size(16, 16);
            this.pbPaste.TabIndex = 5;
            this.pbPaste.TabStop = false;
            this.toolTip1.SetToolTip(this.pbPaste, "Paste");
            this.pbPaste.Click += new System.EventHandler(this.pbPaste_Click);
            this.pbPaste.MouseEnter += new System.EventHandler(this.pbPaste_MouseEnter);
            this.pbPaste.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbPaste_MouseMove);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 1000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ShowAlways = true;
            // 
            // pbCopy
            // 
            this.pbCopy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCopy.BackgroundImage")));
            this.pbCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbCopy.Location = new System.Drawing.Point(368, 3);
            this.pbCopy.Name = "pbCopy";
            this.pbCopy.Size = new System.Drawing.Size(16, 16);
            this.pbCopy.TabIndex = 7;
            this.pbCopy.TabStop = false;
            this.toolTip1.SetToolTip(this.pbCopy, "Copy");
            this.pbCopy.Click += new System.EventHandler(this.pbCopy_Click);
            this.pbCopy.MouseEnter += new System.EventHandler(this.pbCopy_MouseEnter);
            this.pbCopy.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbCopy_MouseMove);
            // 
            // pbRevert
            // 
            this.pbRevert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbRevert.BackgroundImage")));
            this.pbRevert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbRevert.Location = new System.Drawing.Point(390, 3);
            this.pbRevert.Name = "pbRevert";
            this.pbRevert.Size = new System.Drawing.Size(16, 16);
            this.pbRevert.TabIndex = 8;
            this.pbRevert.TabStop = false;
            this.toolTip1.SetToolTip(this.pbRevert, "Revert");
            this.pbRevert.Click += new System.EventHandler(this.pbRevert_Click);
            this.pbRevert.MouseEnter += new System.EventHandler(this.pbRevert_MouseEnter);
            this.pbRevert.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbRevert_MouseMove);
            // 
            // chkSelected
            // 
            this.chkSelected.AutoSize = true;
            this.chkSelected.Location = new System.Drawing.Point(412, 5);
            this.chkSelected.Name = "chkSelected";
            this.chkSelected.Size = new System.Drawing.Size(15, 14);
            this.chkSelected.TabIndex = 6;
            this.toolTip1.SetToolTip(this.chkSelected, "Select");
            this.chkSelected.UseVisualStyleBackColor = true;
            // 
            // ucColourPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbRevert);
            this.Controls.Add(this.pbCopy);
            this.Controls.Add(this.chkSelected);
            this.Controls.Add(this.pbPaste);
            this.Controls.Add(this.pnlSample);
            this.Controls.Add(this.lblName);
            this.Name = "ucColourPanel";
            this.Size = new System.Drawing.Size(430, 23);
            ((System.ComponentModel.ISupportInitialize)(this.pbPaste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCopy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRevert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlSample;
        private System.Windows.Forms.PictureBox pbPaste;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox chkSelected;
        private System.Windows.Forms.PictureBox pbCopy;
        private System.Windows.Forms.PictureBox pbRevert;
    }
}
