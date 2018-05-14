namespace Browser
{
    partial class Browser
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
            this.components = new System.ComponentModel.Container();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.URL = new MetroFramework.Controls.MetroTextBox();
            this.Go = new MetroFramework.Controls.MetroButton();
            this.faderControlBox1 = new Fader_Theme.FaderControlBox();
            this.Back = new MetroFramework.Controls.MetroButton();
            this.Foward = new MetroFramework.Controls.MetroButton();
            this.link = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TabName = new System.Windows.Forms.Timer(this.components);
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(4, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1348, 748);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.webBrowser1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1340, 705);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Tab 1";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(1340, 705);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.Url = new System.Uri("http://Google.com", System.UriKind.Absolute);
            // 
            // URL
            // 
            this.URL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.URL.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.URL.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.URL.Location = new System.Drawing.Point(149, 27);
            this.URL.Name = "URL";
            this.URL.PromptText = "Enter URL Here";
            this.URL.Size = new System.Drawing.Size(1030, 35);
            this.URL.Style = MetroFramework.MetroColorStyle.Red;
            this.URL.TabIndex = 1;
            this.URL.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.URL.UseStyleColors = true;
            // 
            // Go
            // 
            this.Go.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Go.Highlight = true;
            this.Go.Location = new System.Drawing.Point(1106, 27);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(73, 34);
            this.Go.Style = MetroFramework.MetroColorStyle.Orange;
            this.Go.TabIndex = 3;
            this.Go.Text = "GO";
            this.Go.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // faderControlBox1
            // 
            this.faderControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.faderControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.faderControlBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faderControlBox1.Location = new System.Drawing.Point(1235, 7);
            this.faderControlBox1.Margin = new System.Windows.Forms.Padding(0);
            this.faderControlBox1.MaximumDisable = false;
            this.faderControlBox1.MinimumDisable = false;
            this.faderControlBox1.Name = "faderControlBox1";
            this.faderControlBox1.Size = new System.Drawing.Size(117, 30);
            this.faderControlBox1.TabIndex = 5;
            // 
            // Back
            // 
            this.Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Back.Highlight = true;
            this.Back.Location = new System.Drawing.Point(1186, 62);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(63, 37);
            this.Back.Style = MetroFramework.MetroColorStyle.Red;
            this.Back.TabIndex = 6;
            this.Back.Text = "<<";
            this.Back.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Foward
            // 
            this.Foward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Foward.Highlight = true;
            this.Foward.Location = new System.Drawing.Point(1251, 62);
            this.Foward.Name = "Foward";
            this.Foward.Size = new System.Drawing.Size(63, 37);
            this.Foward.Style = MetroFramework.MetroColorStyle.Red;
            this.Foward.TabIndex = 7;
            this.Foward.Text = ">>";
            this.Foward.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Foward.Click += new System.EventHandler(this.Foward_Click);
            // 
            // link
            // 
            this.link.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.link.AutoSize = true;
            this.link.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link.ForeColor = System.Drawing.Color.Red;
            this.link.Location = new System.Drawing.Point(546, 66);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(0, 17);
            this.link.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImage = global::Browser.Properties.Resources.home;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(1139, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 38);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TabName
            // 
            this.TabName.Enabled = true;
            this.TabName.Interval = 1000;
            this.TabName.Tick += new System.EventHandler(this.TabName_Tick);
            // 
            // Browser
            // 
            this.AcceptButton = this.Go;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1361, 819);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.link);
            this.Controls.Add(this.Foward);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.faderControlBox1);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Browser";
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = " Browser";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private MetroFramework.Controls.MetroTextBox URL;
        private MetroFramework.Controls.MetroButton Go;
        private Fader_Theme.FaderControlBox faderControlBox1;
        private MetroFramework.Controls.MetroButton Back;
        private MetroFramework.Controls.MetroButton Foward;
        private System.Windows.Forms.Label link;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer TabName;
    }
}

