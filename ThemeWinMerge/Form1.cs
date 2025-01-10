using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace ThemeWinMerge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Color copyColour;
        bool suspendLayout = false;
        private Timer tmrStart = new Timer();
        enum vartype_e
        {
            varnull,
            varstring,
            varint,
            varhex,
        }

        private class items
        {
            public string basename = String.Empty;
            public string itemname = String.Empty;
            public string value = String.Empty;
            public vartype_e vartype;
            public bool iscolour;
            public Color originalcolour;
            public Color newcolour;
        }
        private List<items> listofitems = new List<items> { };
        enum category_e
        {
            line,
            syntax,
            markers,
            dir,
        }

        enum type_e
        {
            none,
            background,
            deleted,
            text,
        }

        private class mapping
        {
            public string itemname = String.Empty;
            public string guiname = string.Empty;
            public type_e type;
            public category_e category;
        }

        private List<mapping> mappingList = new List<mapping> { };

        private void PopulateMapping()
        {
            mappingList.Add(new mapping { category = category_e.line, type = type_e.background, guiname = "Difference", itemname = "DifferenceColor" });
            mappingList.Add(new mapping { category = category_e.line, type = type_e.deleted, guiname = "Difference", itemname = "DifferenceDeletedColor" });
            mappingList.Add(new mapping { category = category_e.line, type = type_e.text, guiname = "Difference", itemname = "DifferenceTextColor" });
            mappingList.Add(new mapping { category = category_e.line, type = type_e.background, guiname = "Selected Difference", itemname = "SelectedDifferenceColor" });
            mappingList.Add(new mapping { category = category_e.line, type = type_e.deleted, guiname = "Selected Difference", itemname = "SelectedDifferenceDeletedColor" });
            mappingList.Add(new mapping { category = category_e.line, type = type_e.text, guiname = "Selected Difference", itemname = "SelectedDifferenceTextColor" });
            mappingList.Add(new mapping { category = category_e.line, type = type_e.background, guiname = "Ignored Difference", itemname = "TrivialDifferenceColor" });
            mappingList.Add(new mapping { category = category_e.line, type = type_e.deleted, guiname = "Ignored Difference", itemname = "TrivialDifferenceDeletedColor" });
            mappingList.Add(new mapping { category = category_e.line, type = type_e.text, guiname = "Ignored Difference", itemname = "TrivialDifferenceTextColor" });
            mappingList.Add(new mapping { category = category_e.line, type = type_e.background, guiname = "Moved", itemname = "SelectedMovedBlockColor" });
            mappingList.Add(new mapping { category = category_e.line, type = type_e.deleted, guiname = "Moved", itemname = "SelectedMovedBlockDeletedColor" });
            mappingList.Add(new mapping { category = category_e.line, type = type_e.text, guiname = "Moved", itemname = "SelectedMovedBlockTextColor" });
            mappingList.Add(new mapping { category = category_e.line, type = type_e.background, guiname = "Selected Moved", itemname = "MovedBlockColor" });
            mappingList.Add(new mapping { category = category_e.line, type = type_e.deleted, guiname = "Selected Moved", itemname = "MovedBlockDeletedColor" });
            mappingList.Add(new mapping { category = category_e.line, type = type_e.text, guiname = "Selected Moved", itemname = "MovedBlockTextColor" });
            mappingList.Add(new mapping { category = category_e.line, type = type_e.background, guiname = "Same As the next (3 pane)", itemname = "SNPColor" });
            mappingList.Add(new mapping { category = category_e.line, type = type_e.deleted, guiname = "Same As the next (3 pane)", itemname = "SNPDeletedColor" });
            mappingList.Add(new mapping { category = category_e.line, type = type_e.text, guiname = "Same As the next (3 pane)", itemname = "SNPTextColor" });
            mappingList.Add(new mapping { category = category_e.line, type = type_e.background, guiname = "Same as The Next (selected)", itemname = "SelectedSNPColor" });
            mappingList.Add(new mapping { category = category_e.line, type = type_e.deleted, guiname = "Same as The Next (selected)", itemname = "SelectedSNPDeletedColor" });
            mappingList.Add(new mapping { category = category_e.line, type = type_e.text, guiname = "Same as The Next (selected)", itemname = "SelectedSNPTextColor" });
            mappingList.Add(new mapping { category = category_e.line, type = type_e.background, guiname = "Word Difference", itemname = "WordDifferenceColor" });
            mappingList.Add(new mapping { category = category_e.line, type = type_e.deleted, guiname = "Word Difference", itemname = "WordDifferenceDeletedColor" });
            mappingList.Add(new mapping { category = category_e.line, type = type_e.text, guiname = "Word Difference", itemname = "WordDifferenceTextColor" });
            mappingList.Add(new mapping { category = category_e.line, type = type_e.background, guiname = "Selected Word Diff", itemname = "SelectedWordDifferenceColor" });
            mappingList.Add(new mapping { category = category_e.line, type = type_e.deleted, guiname = "Selected Word Diff", itemname = "SelectedWordDifferenceDeletedColor" });
            mappingList.Add(new mapping { category = category_e.line, type = type_e.text, guiname = "Selected Word Diff", itemname = "SelectedWordDifferenceTextColor" });

            mappingList.Add(new mapping { category = category_e.syntax, type = type_e.none, guiname = "Keywords", itemname = "Color07" });
            mappingList.Add(new mapping { category = category_e.syntax, type = type_e.none, guiname = "Function names", itemname = "Color08" });
            mappingList.Add(new mapping { category = category_e.syntax, type = type_e.none, guiname = "Comments", itemname = "Color09" });
            mappingList.Add(new mapping { category = category_e.syntax, type = type_e.none, guiname = "Numbers", itemname = "Color10" });
            mappingList.Add(new mapping { category = category_e.syntax, type = type_e.none, guiname = "Operators", itemname = "Color11" });
            mappingList.Add(new mapping { category = category_e.syntax, type = type_e.none, guiname = "Strings", itemname = "Color12" });
            mappingList.Add(new mapping { category = category_e.syntax, type = type_e.none, guiname = "Preprocessor", itemname = "Color13" });
            mappingList.Add(new mapping { category = category_e.syntax, type = type_e.none, guiname = "User1", itemname = "Color20" });
            mappingList.Add(new mapping { category = category_e.syntax, type = type_e.none, guiname = "User2", itemname = "Color21" });

            mappingList.Add(new mapping { category = category_e.markers, type = type_e.none, guiname = "Search Marker", itemname = "Color22" });
            mappingList.Add(new mapping { category = category_e.markers, type = type_e.none, guiname = "User Defined Marker1", itemname = "Color23" });
            mappingList.Add(new mapping { category = category_e.markers, type = type_e.none, guiname = "User Defined Marker2", itemname = "Color24" });
            mappingList.Add(new mapping { category = category_e.markers, type = type_e.none, guiname = "User Defined Marker3", itemname = "Color25" });

            mappingList.Add(new mapping { category = category_e.dir, type = type_e.background, guiname = "Dir Item Equal", itemname = "DirItemEqualColor" });
            mappingList.Add(new mapping { category = category_e.dir, type = type_e.text, guiname = "Dir Item Equal Text", itemname = "DirItemEqualTextColor" });
            mappingList.Add(new mapping { category = category_e.dir, type = type_e.background, guiname = "Dir Item Diff", itemname = "DirItemDiffColor" });
            mappingList.Add(new mapping { category = category_e.dir, type = type_e.text, guiname = "Dir Item Diff Text", itemname = "DirItemDiffTextColor" });
            mappingList.Add(new mapping { category = category_e.dir, type = type_e.background, guiname = "Dir Item Not Exist", itemname = "DirItemNotExistAtAllColor" });
            mappingList.Add(new mapping { category = category_e.dir, type = type_e.text, guiname = "Dir Item Not Exist Text", itemname = "DirItemNotExistAllTextColor" });
            mappingList.Add(new mapping { category = category_e.dir, type = type_e.background, guiname = "Dir Item Filtered", itemname = "DirItemFilteredColor" });
            mappingList.Add(new mapping { category = category_e.dir, type = type_e.background, guiname = "Dir Margin", itemname = "DirMarginColor" });

        }

        /// <summary>
        /// works either way round, searches both itemname and guiname, returns whole mapping so caller can choose which to use
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private mapping GetMappingFor(string s)
        {
            foreach (mapping m in mappingList)
            {
                if (m.itemname == s)
                    return m;
                if (m.guiname == s)
                    return m;
            }
            return null;
        }

        private string ItemFullName(items i)
        {
            return (i.basename + '/' + i.itemname);
        }
        private items GetItemByFullName(string s)
        {
            foreach (items i in listofitems)
            {
                if (ItemFullName(i) == s)
                    return i;
            }
            return null;
        }

        private string DisplayNameFor(mapping m)
        {
            if (m is null)
                return "";
            if (m.type == type_e.none)
            {
                return m.guiname;
            }
            else
            {
                switch (m.type)
                {
                    case type_e.background:
                        return "background/" + m.guiname;
                    case type_e.deleted:
                        return "deleted/" + m.guiname;
                    case type_e.text:
                        return "text/" + m.guiname;

                }
            }
            return "";
        }

        private void ParseFile(string filetext)
        {
            string[] lines = filetext.Split('\r');
            listofitems.Clear();
            foreach (string s in lines)
            {
                items item = new items();
                item.basename = s.Replace("\n", "");
                item.vartype = vartype_e.varnull;
                if (s.Contains("="))
                {
                    string[] q = s.Split('=');
                    if (q[0].Contains("Color"))
                    {
                        string[] p = s.Split('/');
                        item.basename = p[0].Replace("\n", "");
                        item.itemname = p[1].Split('=')[0];
                        item.value = s.Split('=')[1];

                        int result;
                        if (item.value.Contains("0x"))
                        {
                            item.vartype = vartype_e.varhex;
                            if (item.itemname.Contains("Color"))
                            {
                                item.iscolour = true;
                                item.originalcolour = NumberToColour(item.value, item.vartype);
                                item.newcolour = item.originalcolour;
                            }
                        }
                        else if (int.TryParse(item.value, out result))
                        {
                            item.vartype = vartype_e.varint;
                        }
                        else
                        {
                            item.vartype = vartype_e.varstring;
                        }
                    }
                }
                if (item.basename != String.Empty)
                {
                    listofitems.Add(item);
                }
            }
        }

        private string CreateFile(string schemename)
        {
            const string nl = "\r\n";
            string s = "; " + schemename + nl + "[WinMerge]" + nl;
            foreach (items item in listofitems)
            {
                s += item.basename + "/" + item.itemname + "=" + item.value + nl;
            }

            return s;
        }

        /// <summary>
        /// WinMerge ini files store colour as decimal or hex 0xBBGGRR, not RGB order
        /// </summary>
        /// <param name="val"></param>
        /// <param name="vartype"></param>
        /// <returns></returns>
        private Color NumberToColour(string val, vartype_e vartype)
        {
            switch (vartype)
            {
                case vartype_e.varint:
                    Color c = Color.FromArgb(Convert.ToInt32(val) | Convert.ToInt32("FF000000", 16));
                    return c;

                case vartype_e.varhex:
                    int r = Convert.ToInt32(val.Substring(6, 2), 16);
                    int g = Convert.ToInt32(val.Substring(4, 2), 16);
                    int b = Convert.ToInt32(val.Substring(2, 2), 16);
                    Color d = Color.FromArgb(r, g, b);
                    return d;
            }

            return Color.Black;
        }

        private string ColourToHex(Color c)
        {
            return "0x" + c.B.ToString("x2") + c.G.ToString("x2") + c.R.ToString("x2"); //lower case to match what WinMerge saves to minimise diffs
        }

        private void PopulatePanel()
        {
            if (suspendLayout)
                return;
            Cursor = Cursors.WaitCursor;
            panel1.SuspendLayout();
            panel1.Controls.Clear();
            foreach (items i in listofitems)
            {
                if (i.iscolour)
                {
                    mapping m = GetMappingFor(i.itemname);

                    if (m != null && MatchesFilter(m))
                    {
                        ucColourPanel p = new ucColourPanel();
                        p.SuspendLayout();
                        p.name = DisplayNameFor(m);
                        p.Name = "ucColourPanel" + panel1.Controls.Count;
                        p.colour = i.newcolour;
                        p.fullitemname = ItemFullName(i);
                        p.copyEvent += new EventHandler(CopyEventHandler);
                        p.colourUpdatedEvent += new EventHandler(ColourUpdatedEventHandler);
                        p.revertEvent += new EventHandler(ColourRevertEventHandler);
                        if (p.name != String.Empty)
                        {
                            panel1.Controls.Add(p);
                        }
                        p.ResumeLayout(false); //technique to speed up layout, see https://stackoverflow.com/a/45761460
                    }
                }
            }
            panel1.ResumeLayout(true);
            lblCount.Text = "Count :" + panel1.Controls.Count.ToString();
            Cursor = Cursors.Default;
        }

        //Speeds up repaint, from https://stackoverflow.com/a/3718648
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private void CopyEventHandler(object sender, EventArgs e)
        {
            ucColourPanel cp;
            if (sender is ucColourPanel)
            {
                cp = (ucColourPanel)sender;
                pnlCopy.BackColor = cp.colour;
                copyColour = cp.colour;
            }
        }

        private void ColourUpdatedEventHandler(object sender, EventArgs e)
        {
            ucColourPanel cp;
            if (sender is ucColourPanel)
            {
                cp = (ucColourPanel)sender;
                //find item with fullitemname, update colour
                items i = GetItemByFullName(cp.fullitemname);
                if (i != null)
                {
                    i.newcolour = cp.colour;
                }

            }
        }
        private void ColourRevertEventHandler(object sender, EventArgs e)
        {
            ucColourPanel cp;
            if (sender is ucColourPanel)
            {
                cp = (ucColourPanel)sender;
                //find item with fullitemname, update colour
                items i = GetItemByFullName(cp.fullitemname);
                if (i != null)
                {
                    i.newcolour = i.originalcolour;
                    cp.colour = i.originalcolour;
                }
            }
        }

        private bool MatchesFilter(mapping m)
        {
            if (((chkLine.Checked && m.category == category_e.line) ||
            (chkSyntax.Checked && m.category == category_e.syntax) ||
            (chkMarkers.Checked && m.category == category_e.markers) ||
            (chkDir.Checked && m.category == category_e.dir)) &&
            ((chkBackground.Checked && m.type == type_e.background) ||
            (chkDeleted.Checked && m.type == type_e.deleted) ||
            (chkText.Checked && m.type == type_e.text) ||
            (m.type == type_e.none)))
                return true;

            return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateMapping();
            tmrStart.Tick += new EventHandler(tmrStart_Tick);
            tmrStart.Interval = 10;
            tmrStart.Start();
        }

        private void tmrStart_Tick(object sender, EventArgs e)
        {
            if (sender == tmrStart)
            {
                chkAllDisplayOptions.CheckState = CheckState.Checked;
                tmrStart.Stop();
                tmrStart.Dispose();
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.AddExtension = true;
            ofd.Multiselect = false;
            ofd.CheckPathExists = true;
            ofd.ValidateNames = true;
            ofd.DefaultExt = "ini";
            ofd.Filter = "WinMerge Ini (*.ini)|*.ini";
            ofd.FilterIndex = 1;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.Text = "Theme WinMerge - " + Path.GetFileName(ofd.FileName);
                Cursor = Cursors.WaitCursor;
                try
                {
                    string s = File.ReadAllText(ofd.FileName);
                    ParseFile(s);
                    PopulatePanel();
                    Cursor = Cursors.Default;
                }
                catch (Exception ex)
                {
                    Cursor = Cursors.Default;
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void chkAllDisplayOptions_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAllDisplayOptions.CheckState == CheckState.Checked)
            {
                suspendLayout = true;
                chkLine.Checked = true;
                chkSyntax.Checked = true;
                chkMarkers.Checked = true;
                chkDir.Checked = true;
                chkBackground.Checked = true;
                chkDeleted.Checked = true;
                chkText.Checked = true;
            }
            else if (chkAllDisplayOptions.CheckState == CheckState.Unchecked)
            {
                suspendLayout = true;
                chkLine.Checked = false;
                chkSyntax.Checked = false;
                chkMarkers.Checked = false;
                chkDir.Checked = false;
                chkBackground.Checked = false;
                chkDeleted.Checked = false;
                chkText.Checked = false;
            }
            suspendLayout = false;
            PopulatePanel();
        }

        private void chkAllDisplayOptions_CheckStateChanged(object sender, EventArgs e)
        {
        }

        private void chkLine_CheckedChanged(object sender, EventArgs e)
        {
            SetAllDisplayOptionsState();
            PopulatePanel();
        }
        private void SetAllDisplayOptionsState()
        {
            if (suspendLayout)
                return;

            if (chkLine.CheckState == chkSyntax.CheckState && chkSyntax.CheckState == chkMarkers.CheckState && chkMarkers.CheckState == chkDir.CheckState
                && chkDir.CheckState == chkBackground.CheckState && chkBackground.CheckState == chkDeleted.CheckState && chkDeleted.CheckState == chkText.CheckState
                )
            {
                if (chkLine.CheckState == CheckState.Checked)
                {
                    chkAllDisplayOptions.CheckState = CheckState.Checked;
                }
                else
                {
                    chkAllDisplayOptions.CheckState = CheckState.Unchecked;
                }
            }
            else
            {
                chkAllDisplayOptions.CheckState = CheckState.Indeterminate;
            }
        }

        private void chkSyntax_CheckedChanged(object sender, EventArgs e)
        {
            SetAllDisplayOptionsState();
            PopulatePanel();
        }

        private void chkMarkers_CheckedChanged(object sender, EventArgs e)
        {
            SetAllDisplayOptionsState();
            PopulatePanel();
        }

        private void chkDir_CheckedChanged(object sender, EventArgs e)
        {
            SetAllDisplayOptionsState();
            PopulatePanel();
        }

        private void chkBackground_CheckedChanged(object sender, EventArgs e)
        {
            SetAllDisplayOptionsState();
            PopulatePanel();
        }

        private void chkDeleted_CheckedChanged(object sender, EventArgs e)
        {
            SetAllDisplayOptionsState();
            PopulatePanel();
        }

        private void chkText_CheckedChanged(object sender, EventArgs e)
        {
            SetAllDisplayOptionsState();
            PopulatePanel();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
        }

        private void pnlCopy_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = pnlCopy.BackColor;
            if (DialogResult.OK == colorDialog1.ShowDialog())
            {
                Color c = colorDialog1.Color;
                pnlCopy.BackColor = c;
                copyColour = c;
            }
        }

        private string CreateFileContents()
        {
            string s = String.Empty;
            foreach (items i in listofitems)
            {
                if (i.vartype != vartype_e.varnull)
                {
                    s += ItemFullName(i) + '=';
                    if (i.iscolour)
                    {
                        s += ColourToHex(i.newcolour);
                    }
                    else
                    {
                        s += i.value;
                    }
                }
                else
                {
                    s += i.basename;
                }
                s += Environment.NewLine;
            }
            return s;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ValidateNames = true;
            sfd.DefaultExt = "ini";
            sfd.Filter = "WinMerge Ini (*.ini)|*.ini";
            sfd.FilterIndex = 1;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Cursor = Cursors.WaitCursor;
                string s = CreateFileContents();
                try
                {
                    File.WriteAllText(sfd.FileName, s);
                    Cursor = Cursors.Default;
                }
                catch (Exception ex)
                {
                    Cursor = Cursors.Default;
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void chkSelectAllShown_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control ct in panel1.Controls)
            {
                ucColourPanel cp = (ucColourPanel)ct;
                if (cp != null)
                {
                    cp.isSelected = chkSelectAllShown.Checked;
                }
            }
        }

        private void AdjustAllColours(primary_e primary, int amount)
        {
            foreach (Control ct in panel1.Controls)
            {
                ucColourPanel cp = (ucColourPanel)ct;
                if (cp != null && cp.isSelected)
                {
                    cp.colour = coloradjust(cp.colour, primary, amount);
                }
            }
        }
        private void btnRedUp_Click(object sender, EventArgs e)
        {
            AdjustAllColours(primary_e.red, 2);
        }
        private void btnRedDown_Click(object sender, EventArgs e)
        {
            AdjustAllColours(primary_e.red, -2);
        }
        private void btnGreenUp_Click(object sender, EventArgs e)
        {
            AdjustAllColours(primary_e.green, 2);
        }

        private void btnGreenDown_Click(object sender, EventArgs e)
        {
            AdjustAllColours(primary_e.green, -2);
        }

        private void btnBlueUp_Click(object sender, EventArgs e)
        {
            AdjustAllColours(primary_e.blue, 2);
        }

        private void btnBlueDown_Click(object sender, EventArgs e)
        {
            AdjustAllColours(primary_e.blue, -2);
        }

        private void btnBlackUp_Click(object sender, EventArgs e)
        {
            AdjustAllColours(primary_e.red, -2);
            AdjustAllColours(primary_e.green, -2);
            AdjustAllColours(primary_e.blue, -2);
        }

        private void btnBlackDown_Click(object sender, EventArgs e)
        {
            AdjustAllColours(primary_e.red, 2);
            AdjustAllColours(primary_e.green, 2);
            AdjustAllColours(primary_e.blue, 2);
        }

        enum primary_e
        {
            red,
            green,
            blue
        }

        private Color coloradjust(Color c, primary_e primary, int amount)
        {
            int new_r = c.R;
            int new_g = c.G;
            int new_b = c.B;

            switch (primary)
            {
                case primary_e.red:
                    if (c.R + amount > 255 && amount > 0)
                    { new_r = 255; }
                    else if (c.R + amount < 0)
                    { new_r = 0; }
                    else { new_r += amount; }
                    break;
                case primary_e.green:
                    if (c.G + amount > 255 && amount > 0)
                    { new_g = 255; }
                    else if (c.G + amount < 0)
                    { new_g = 0; }
                    else { new_g += amount; }
                    break;
                case primary_e.blue:
                    if (c.B + amount > 255 && amount > 0)
                    { new_b = 255; }
                    else if (c.B + amount < 0)
                    { new_b = 0; }
                    else { new_b += amount; }
                    break;
            }
            return Color.FromArgb(new_r, new_g, new_b);
        }

        //https://tannerhelland.com/2014/07/01/simple-algorithms-adjusting-image-temperature-tint.html
        private void btnTempUp_Click(object sender, EventArgs e)
        {
            AdjustAllColours(primary_e.red, 2);
            AdjustAllColours(primary_e.blue, -2);
        }

        private void btnTempDown_Click(object sender, EventArgs e)
        {
            AdjustAllColours(primary_e.red, -2);
            AdjustAllColours(primary_e.blue, 2);
        }
    }
}
