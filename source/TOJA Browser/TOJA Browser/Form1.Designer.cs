namespace TOJA_Browser
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
            this.btnback = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnNewtab = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.webBrowser = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.closeTab = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.webBrowser.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(14, 9);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(38, 23);
            this.btnback.TabIndex = 0;
            this.btnback.Text = "←";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(58, 9);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(38, 23);
            this.btnForward.TabIndex = 1;
            this.btnForward.Text = "→";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Location = new System.Drawing.Point(660, 9);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(38, 23);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnNewtab
            // 
            this.btnNewtab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewtab.Location = new System.Drawing.Point(704, 9);
            this.btnNewtab.Name = "btnNewtab";
            this.btnNewtab.Size = new System.Drawing.Size(59, 23);
            this.btnNewtab.TabIndex = 3;
            this.btnNewtab.Text = "New Tab";
            this.btnNewtab.UseVisualStyleBackColor = true;
            this.btnNewtab.Click += new System.EventHandler(this.btnNewtab_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Location = new System.Drawing.Point(102, 12);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(444, 20);
            this.txtUrl.TabIndex = 4;
            this.txtUrl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrl_KeyPress);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.webBrowser);
            this.tabControl.Location = new System.Drawing.Point(13, 38);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(750, 375);
            this.tabControl.TabIndex = 5;
            // 
            // webBrowser
            // 
            this.webBrowser.Controls.Add(this.webBrowser1);
            this.webBrowser.Location = new System.Drawing.Point(4, 22);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Padding = new System.Windows.Forms.Padding(3);
            this.webBrowser.Size = new System.Drawing.Size(742, 349);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.Text = "tabPage1";
            this.webBrowser.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(736, 343);
            this.webBrowser1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(623, 9);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(31, 23);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "⟲";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // closeTab
            // 
            this.closeTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeTab.Location = new System.Drawing.Point(552, 9);
            this.closeTab.Name = "closeTab";
            this.closeTab.Size = new System.Drawing.Size(65, 23);
            this.closeTab.TabIndex = 7;
            this.closeTab.Text = "Close Tab";
            this.closeTab.UseVisualStyleBackColor = true;
            this.closeTab.Click += new System.EventHandler(this.closeTab_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(775, 425);
            this.Controls.Add(this.closeTab);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btnNewtab);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnback);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TOJA Browser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.webBrowser.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnNewtab;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage webBrowser;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button closeTab;
    }
}

