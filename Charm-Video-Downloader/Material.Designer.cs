
namespace form_summon
{
    partial class Material
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
            components = new System.ComponentModel.Container();
            ReaLTaiizor.Controls.MaterialButton AddUrlButton;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Material));
            materialTabControl1 = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            labelDownloadSpeed = new ReaLTaiizor.Controls.MetroLabel();
            MainProgressbar = new ReaLTaiizor.Controls.MaterialProgressBar();
            ClearListButton = new ReaLTaiizor.Controls.MaterialButton();
            RemoveItemButton = new ReaLTaiizor.Controls.MaterialButton();
            DownloadListBox = new ListBox();
            LinkAdderBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            CancelButton = new ReaLTaiizor.Controls.MaterialButton();
            StartDownloadButton = new ReaLTaiizor.Controls.MaterialButton();
            tabPage2 = new TabPage();
            groupBox2 = new GroupBox();
            metroRadioButton3 = new ReaLTaiizor.Controls.MetroRadioButton();
            metroRadioButton4 = new ReaLTaiizor.Controls.MetroRadioButton();
            groupBox1 = new GroupBox();
            metroRadioButton2 = new ReaLTaiizor.Controls.MetroRadioButton();
            metroRadioButton1 = new ReaLTaiizor.Controls.MetroRadioButton();
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            AddUrlButton = new ReaLTaiizor.Controls.MaterialButton();
            materialTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // AddUrlButton
            // 
            AddUrlButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AddUrlButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            AddUrlButton.Depth = 0;
            AddUrlButton.HighEmphasis = true;
            AddUrlButton.Icon = null;
            AddUrlButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            AddUrlButton.Location = new Point(917, 9);
            AddUrlButton.Margin = new Padding(4, 6, 4, 6);
            AddUrlButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            AddUrlButton.Name = "AddUrlButton";
            AddUrlButton.NoAccentTextColor = Color.Empty;
            AddUrlButton.Size = new Size(64, 36);
            AddUrlButton.TabIndex = 1;
            AddUrlButton.Text = "Add";
            AddUrlButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            AddUrlButton.UseAccentColor = false;
            AddUrlButton.UseVisualStyleBackColor = true;
            AddUrlButton.Click += AddUrlButton_Click;
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabPage1);
            materialTabControl1.Controls.Add(tabPage2);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.ImageList = imageList1;
            materialTabControl1.Location = new Point(4, 74);
            materialTabControl1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(1083, 548);
            materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(labelDownloadSpeed);
            tabPage1.Controls.Add(MainProgressbar);
            tabPage1.Controls.Add(ClearListButton);
            tabPage1.Controls.Add(RemoveItemButton);
            tabPage1.Controls.Add(DownloadListBox);
            tabPage1.Controls.Add(LinkAdderBox);
            tabPage1.Controls.Add(CancelButton);
            tabPage1.Controls.Add(StartDownloadButton);
            tabPage1.Controls.Add(AddUrlButton);
            tabPage1.ImageKey = "home_24dp_5F6368.png";
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1075, 520);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "MainPage";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelDownloadSpeed
            // 
            labelDownloadSpeed.Font = new Font("Segoe UI", 12F);
            labelDownloadSpeed.IsDerivedStyle = true;
            labelDownloadSpeed.Location = new Point(6, 446);
            labelDownloadSpeed.Name = "labelDownloadSpeed";
            labelDownloadSpeed.Size = new Size(676, 23);
            labelDownloadSpeed.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            labelDownloadSpeed.StyleManager = null;
            labelDownloadSpeed.TabIndex = 13;
            labelDownloadSpeed.Text = "Downloadspeed:";
            labelDownloadSpeed.ThemeAuthor = "Taiizor";
            labelDownloadSpeed.ThemeName = "MetroLight";
            // 
            // MainProgressbar
            // 
            MainProgressbar.Depth = 0;
            MainProgressbar.Location = new Point(6, 476);
            MainProgressbar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            MainProgressbar.Name = "MainProgressbar";
            MainProgressbar.Size = new Size(739, 36);
            MainProgressbar.TabIndex = 12;
            MainProgressbar.UseAccentColor = false;
            // 
            // ClearListButton
            // 
            ClearListButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClearListButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            ClearListButton.Depth = 0;
            ClearListButton.HighEmphasis = true;
            ClearListButton.Icon = null;
            ClearListButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            ClearListButton.Location = new Point(689, 433);
            ClearListButton.Margin = new Padding(4, 6, 4, 6);
            ClearListButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ClearListButton.Name = "ClearListButton";
            ClearListButton.NoAccentTextColor = Color.Empty;
            ClearListButton.Size = new Size(100, 36);
            ClearListButton.TabIndex = 11;
            ClearListButton.Text = "Clear List";
            ClearListButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            ClearListButton.UseAccentColor = false;
            ClearListButton.UseVisualStyleBackColor = true;
            ClearListButton.Click += ClearListButton_Click;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            RemoveItemButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            RemoveItemButton.Depth = 0;
            RemoveItemButton.HighEmphasis = true;
            RemoveItemButton.Icon = null;
            RemoveItemButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            RemoveItemButton.Location = new Point(797, 433);
            RemoveItemButton.Margin = new Padding(4, 6, 4, 6);
            RemoveItemButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.NoAccentTextColor = Color.Empty;
            RemoveItemButton.Size = new Size(192, 36);
            RemoveItemButton.TabIndex = 8;
            RemoveItemButton.Text = "Remove selected Item";
            RemoveItemButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            RemoveItemButton.UseAccentColor = false;
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // DownloadListBox
            // 
            DownloadListBox.Font = new Font("Segoe UI", 9F);
            DownloadListBox.FormattingEnabled = true;
            DownloadListBox.ItemHeight = 15;
            DownloadListBox.Location = new Point(6, 60);
            DownloadListBox.Name = "DownloadListBox";
            DownloadListBox.Size = new Size(983, 364);
            DownloadListBox.TabIndex = 7;
            // 
            // LinkAdderBox
            // 
            LinkAdderBox.AnimateReadOnly = false;
            LinkAdderBox.AutoCompleteMode = AutoCompleteMode.None;
            LinkAdderBox.AutoCompleteSource = AutoCompleteSource.None;
            LinkAdderBox.BackgroundImageLayout = ImageLayout.None;
            LinkAdderBox.CharacterCasing = CharacterCasing.Normal;
            LinkAdderBox.Depth = 0;
            LinkAdderBox.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Pixel);
            LinkAdderBox.HideSelection = true;
            LinkAdderBox.LeadingIcon = null;
            LinkAdderBox.Location = new Point(6, 9);
            LinkAdderBox.MaxLength = 32767;
            LinkAdderBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            LinkAdderBox.Name = "LinkAdderBox";
            LinkAdderBox.PasswordChar = '\0';
            LinkAdderBox.PrefixSuffixText = null;
            LinkAdderBox.ReadOnly = false;
            LinkAdderBox.RightToLeft = RightToLeft.No;
            LinkAdderBox.SelectedText = "";
            LinkAdderBox.SelectionLength = 0;
            LinkAdderBox.SelectionStart = 0;
            LinkAdderBox.ShortcutsEnabled = true;
            LinkAdderBox.Size = new Size(904, 36);
            LinkAdderBox.TabIndex = 6;
            LinkAdderBox.TabStop = false;
            LinkAdderBox.TextAlign = HorizontalAlignment.Left;
            LinkAdderBox.TrailingIcon = null;
            LinkAdderBox.UseSystemPasswordChar = false;
            LinkAdderBox.UseTallSize = false;
            // 
            // CancelButton
            // 
            CancelButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CancelButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            CancelButton.Depth = 0;
            CancelButton.HighEmphasis = true;
            CancelButton.Icon = null;
            CancelButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            CancelButton.Location = new Point(912, 476);
            CancelButton.Margin = new Padding(4, 6, 4, 6);
            CancelButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            CancelButton.Name = "CancelButton";
            CancelButton.NoAccentTextColor = Color.Empty;
            CancelButton.Size = new Size(77, 36);
            CancelButton.TabIndex = 5;
            CancelButton.Text = "Cancel";
            CancelButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            CancelButton.UseAccentColor = false;
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // StartDownloadButton
            // 
            StartDownloadButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            StartDownloadButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            StartDownloadButton.Depth = 0;
            StartDownloadButton.HighEmphasis = true;
            StartDownloadButton.Icon = null;
            StartDownloadButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            StartDownloadButton.Location = new Point(752, 476);
            StartDownloadButton.Margin = new Padding(4, 6, 4, 6);
            StartDownloadButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            StartDownloadButton.Name = "StartDownloadButton";
            StartDownloadButton.NoAccentTextColor = Color.Empty;
            StartDownloadButton.Size = new Size(152, 36);
            StartDownloadButton.TabIndex = 4;
            StartDownloadButton.Text = "Start Download";
            StartDownloadButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            StartDownloadButton.UseAccentColor = false;
            StartDownloadButton.UseVisualStyleBackColor = true;
            StartDownloadButton.Click += StartDownloadButton_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.ImageKey = "settings_24dp_5F6368.png";
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1075, 520);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Settings";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(metroRadioButton3);
            groupBox2.Controls.Add(metroRadioButton4);
            groupBox2.Location = new Point(6, 132);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(202, 120);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Choose Color";
            // 
            // metroRadioButton3
            // 
            metroRadioButton3.BackgroundColor = Color.White;
            metroRadioButton3.BorderColor = Color.FromArgb(155, 155, 155);
            metroRadioButton3.Checked = false;
            metroRadioButton3.CheckSignColor = Color.FromArgb(65, 177, 225);
            metroRadioButton3.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            metroRadioButton3.DisabledBorderColor = Color.FromArgb(205, 205, 205);
            metroRadioButton3.Font = new Font("Microsoft Sans Serif", 10F);
            metroRadioButton3.Group = 0;
            metroRadioButton3.IsDerivedStyle = true;
            metroRadioButton3.Location = new Point(95, 46);
            metroRadioButton3.Name = "metroRadioButton3";
            metroRadioButton3.Size = new Size(55, 17);
            metroRadioButton3.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroRadioButton3.StyleManager = null;
            metroRadioButton3.TabIndex = 1;
            metroRadioButton3.Text = "Dark";
            metroRadioButton3.ThemeAuthor = "Taiizor";
            metroRadioButton3.ThemeName = "MetroLight";
            // 
            // metroRadioButton4
            // 
            metroRadioButton4.BackgroundColor = Color.White;
            metroRadioButton4.BorderColor = Color.FromArgb(155, 155, 155);
            metroRadioButton4.Checked = false;
            metroRadioButton4.CheckSignColor = Color.FromArgb(65, 177, 225);
            metroRadioButton4.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            metroRadioButton4.DisabledBorderColor = Color.FromArgb(205, 205, 205);
            metroRadioButton4.Font = new Font("Microsoft Sans Serif", 10F);
            metroRadioButton4.Group = 0;
            metroRadioButton4.IsDerivedStyle = true;
            metroRadioButton4.Location = new Point(34, 46);
            metroRadioButton4.Name = "metroRadioButton4";
            metroRadioButton4.Size = new Size(55, 17);
            metroRadioButton4.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroRadioButton4.StyleManager = null;
            metroRadioButton4.TabIndex = 0;
            metroRadioButton4.Text = "Light";
            metroRadioButton4.ThemeAuthor = "Taiizor";
            metroRadioButton4.ThemeName = "MetroLight";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(metroRadioButton2);
            groupBox1.Controls.Add(metroRadioButton1);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(202, 120);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Choose Theme";
            // 
            // metroRadioButton2
            // 
            metroRadioButton2.BackgroundColor = Color.White;
            metroRadioButton2.BorderColor = Color.FromArgb(155, 155, 155);
            metroRadioButton2.Checked = false;
            metroRadioButton2.CheckSignColor = Color.FromArgb(65, 177, 225);
            metroRadioButton2.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            metroRadioButton2.DisabledBorderColor = Color.FromArgb(205, 205, 205);
            metroRadioButton2.Font = new Font("Microsoft Sans Serif", 10F);
            metroRadioButton2.Group = 0;
            metroRadioButton2.IsDerivedStyle = true;
            metroRadioButton2.Location = new Point(95, 46);
            metroRadioButton2.Name = "metroRadioButton2";
            metroRadioButton2.Size = new Size(55, 17);
            metroRadioButton2.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroRadioButton2.StyleManager = null;
            metroRadioButton2.TabIndex = 1;
            metroRadioButton2.Text = "Dark";
            metroRadioButton2.ThemeAuthor = "Taiizor";
            metroRadioButton2.ThemeName = "MetroLight";
            // 
            // metroRadioButton1
            // 
            metroRadioButton1.BackgroundColor = Color.White;
            metroRadioButton1.BorderColor = Color.FromArgb(155, 155, 155);
            metroRadioButton1.Checked = false;
            metroRadioButton1.CheckSignColor = Color.FromArgb(65, 177, 225);
            metroRadioButton1.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            metroRadioButton1.DisabledBorderColor = Color.FromArgb(205, 205, 205);
            metroRadioButton1.Font = new Font("Microsoft Sans Serif", 10F);
            metroRadioButton1.Group = 0;
            metroRadioButton1.IsDerivedStyle = true;
            metroRadioButton1.Location = new Point(34, 46);
            metroRadioButton1.Name = "metroRadioButton1";
            metroRadioButton1.Size = new Size(55, 17);
            metroRadioButton1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroRadioButton1.StyleManager = null;
            metroRadioButton1.TabIndex = 0;
            metroRadioButton1.Text = "Light";
            metroRadioButton1.ThemeAuthor = "Taiizor";
            metroRadioButton1.ThemeName = "MetroLight";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "settings_24dp_5F6368.png");
            imageList1.Images.SetKeyName(1, "home_24dp_5F6368.png");
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = Charm_Video_Downloader.Properties.Resources.CVD_logo;
            pictureBox1.Location = new Point(302, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Material
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 625);
            Controls.Add(pictureBox1);
            Controls.Add(materialTabControl1);
            DrawerAutoShow = true;
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Material";
            Padding = new Padding(4, 74, 4, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Charm Video Downloader";
            Load += Material_Load;
            materialTabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ImageList imageList1;
        private ReaLTaiizor.Controls.MaterialButton AddUrlButton;
        private ReaLTaiizor.Controls.MaterialButton CancelButton;
        private ReaLTaiizor.Controls.MaterialButton StartDownloadButton;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit LinkAdderBox;
        private ListBox DownloadListBox;
        private ReaLTaiizor.Controls.MaterialButton RemoveItemButton;
        private ReaLTaiizor.Controls.MaterialButton ClearListButton;
        private ReaLTaiizor.Controls.MaterialProgressBar MainProgressbar;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ReaLTaiizor.Controls.MetroRadioButton metroRadioButton3;
        private ReaLTaiizor.Controls.MetroRadioButton metroRadioButton4;
        private ReaLTaiizor.Controls.MetroRadioButton metroRadioButton2;
        private ReaLTaiizor.Controls.MetroRadioButton metroRadioButton1;
        private ReaLTaiizor.Controls.MetroLabel labelDownloadSpeed;
    }
}