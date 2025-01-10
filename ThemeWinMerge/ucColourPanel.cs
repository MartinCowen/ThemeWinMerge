using System;
using System.Drawing;
using System.Windows.Forms;

namespace ThemeWinMerge
{
    public partial class ucColourPanel : UserControl
    {
        public ucColourPanel()
        {
            InitializeComponent();
        }
        public string name
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }
        private string _fullitemname;
        public string fullitemname
        {
            get { return _fullitemname; }
            set { _fullitemname = value; }
        }
        public Color colour
        {
            get { return pnlSample.BackColor; }
            set { pnlSample.BackColor = value; }
        }
        public event EventHandler copyEvent;
        public event EventHandler colourUpdatedEvent;
        public event EventHandler revertEvent;
        public Color copyColour;
        public bool isSelected
        {
            get { return chkSelected.Checked; }
            set { chkSelected.Checked = value; }
        }

        private void pnlSample_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.BackColor = Color.FromKnownColor(KnownColor.ControlLightLight);    //show which item is being edited because the colour dialog position can't be controlled to be in the right place
                ColorDialog cd = new ColorDialog();
                cd.FullOpen = true;
                cd.Color = colour;
                if (DialogResult.OK == cd.ShowDialog())
                {
                    Color c = cd.Color;
                    pnlSample.BackColor = c;
                    colour = c;
                    colourUpdatedEvent(this, new EventArgs());
                }
                this.BackColor = Color.FromKnownColor(KnownColor.Control);
            }
        }

        private void pbPaste_Click(object sender, EventArgs e)
        {
            Form1 f = (Form1)this.ParentForm;
            pnlSample.BackColor = f.copyColour;
            colourUpdatedEvent(this, new EventArgs());
        }

        private void pbCopy_Click(object sender, EventArgs e)
        {
            colour = pnlSample.BackColor;
            copyEvent(this, new EventArgs());
        }

        private void pbRevert_Click(object sender, EventArgs e)
        {
            revertEvent(this, new EventArgs());
        }

        private Timer tmrMouseInBox = new Timer();
        private PictureBox pbMouseOver; //the current pb which the mouse is over

        private void tmrMouseInBox_Tick(object sender, EventArgs e)
        {
            //https://stackoverflow.com/a/31530083
            Rectangle rc = pbMouseOver.RectangleToScreen(pbMouseOver.ClientRectangle);
            if (!rc.Contains(Cursor.Position))
            {
                if (sender == tmrMouseInBox)
                {
                    HighlightPictureBox(pbMouseOver, false);
                    tmrMouseInBox.Stop();
                    tmrMouseInBox.Dispose();
                }
            }
        }

        private void pbPaste_MouseMove(object sender, MouseEventArgs e)
        {
            tmrMouseInBox.Start();
            HighlightPictureBox(pbMouseOver, true);
        }

        private void pbPaste_MouseEnter(object sender, EventArgs e)
        {
            pbMouseOver_MouseEnter(pbPaste);
        }

        private void pbMouseOver_MouseEnter(PictureBox pb)
        {
            //MouseLeave doesn't catch all leave events, see https://stackoverflow.com/a/31530083 for this better technique
            tmrMouseInBox.Tick += new EventHandler(tmrMouseInBox_Tick);
            tmrMouseInBox.Interval = 250;
            tmrMouseInBox.Start();
            if (pbMouseOver != null)    //clean up when going straight from one pb to another
            {
                HighlightPictureBox(pbMouseOver, false);
            }
            pbMouseOver = pb;
            HighlightPictureBox(pbMouseOver, true);
        }

        private void HighlightPictureBox(PictureBox pb, bool isHighlighted)
        {
            if (isHighlighted)
            {
                pb.BackColor = Color.White;//highlight colour
            }
            else
            {
                pb.BackColor = Color.Transparent;//let the form color show through
            }
        }

        private void pbCopy_MouseEnter(object sender, EventArgs e)
        {
            pbMouseOver_MouseEnter(pbCopy);
        }

        private void pbCopy_MouseMove(object sender, MouseEventArgs e)
        {
            tmrMouseInBox.Start();
            HighlightPictureBox(pbMouseOver, true);
        }

        private void pbRevert_MouseEnter(object sender, EventArgs e)
        {
            pbMouseOver_MouseEnter(pbRevert);
        }

        private void pbRevert_MouseMove(object sender, MouseEventArgs e)
        {
            tmrMouseInBox.Start();
            HighlightPictureBox(pbMouseOver, true);
        }
    }


}
