namespace RestWebinarSample
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.getAccessToken = new System.Windows.Forms.Button();
            this.grpTextBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.URLPopup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddSqlURL = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AddItemsLimit10 = new System.Windows.Forms.ToolStripMenuItem();
            this.AddItemsOffset10 = new System.Windows.Forms.ToolStripMenuItem();
            this.AddItemFull = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.methodVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.gETCAPIUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtJSON = new System.Windows.Forms.RichTextBox();
            this.JSONPopup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addSalesOrderJson = new System.Windows.Forms.ToolStripMenuItem();
            this.addARPSlipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtAccessToken = new System.Windows.Forms.TextBox();
            this.grpButtons = new System.Windows.Forms.GroupBox();
            this.btnPatch = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnItemStressTest = new System.Windows.Forms.Button();
            this.btnThreadTest = new System.Windows.Forms.Button();
            this.btnUnsafeSQL = new System.Windows.Forms.Button();
            this.btnPUT = new System.Windows.Forms.Button();
            this.btnPOST = new System.Windows.Forms.Button();
            this.btnGET = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grpTextBox.SuspendLayout();
            this.URLPopup.SuspendLayout();
            this.JSONPopup.SuspendLayout();
            this.grpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.getAccessToken);
            this.panel1.Controls.Add(this.grpTextBox);
            this.panel1.Controls.Add(this.grpButtons);
            this.panel1.Location = new System.Drawing.Point(5, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 436);
            this.panel1.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.Enabled = false;
            this.btnLogout.Location = new System.Drawing.Point(9, 388);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(149, 23);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Logout (revoke)";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // getAccessToken
            // 
            this.getAccessToken.Location = new System.Drawing.Point(9, 9);
            this.getAccessToken.Name = "getAccessToken";
            this.getAccessToken.Size = new System.Drawing.Size(149, 23);
            this.getAccessToken.TabIndex = 9;
            this.getAccessToken.Text = "Get Access Token";
            this.getAccessToken.UseVisualStyleBackColor = true;
            this.getAccessToken.Click += new System.EventHandler(this.getAccessToken_Click);
            // 
            // grpTextBox
            // 
            this.grpTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTextBox.Controls.Add(this.label3);
            this.grpTextBox.Controls.Add(this.label2);
            this.grpTextBox.Controls.Add(this.label1);
            this.grpTextBox.Controls.Add(this.txtURL);
            this.grpTextBox.Controls.Add(this.txtJSON);
            this.grpTextBox.Controls.Add(this.txtAccessToken);
            this.grpTextBox.Location = new System.Drawing.Point(170, 3);
            this.grpTextBox.Name = "grpTextBox";
            this.grpTextBox.Size = new System.Drawing.Size(565, 426);
            this.grpTextBox.TabIndex = 8;
            this.grpTextBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "JSON";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "URL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Access Token";
            // 
            // txtURL
            // 
            this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtURL.ContextMenuStrip = this.URLPopup;
            this.txtURL.Location = new System.Drawing.Point(122, 39);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(434, 20);
            this.txtURL.TabIndex = 9;
            // 
            // URLPopup
            // 
            this.URLPopup.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.URLPopup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddSqlURL,
            this.toolStripSeparator1,
            this.AddItemsLimit10,
            this.AddItemsOffset10,
            this.AddItemFull,
            this.toolStripSeparator2,
            this.methodVersion,
            this.gETCAPIUsersToolStripMenuItem});
            this.URLPopup.Name = "URLPopup";
            this.URLPopup.Size = new System.Drawing.Size(226, 148);
            this.URLPopup.Opening += new System.ComponentModel.CancelEventHandler(this.URLPopup_Opening);
            // 
            // AddSqlURL
            // 
            this.AddSqlURL.Name = "AddSqlURL";
            this.AddSqlURL.Size = new System.Drawing.Size(225, 22);
            this.AddSqlURL.Text = "GET SQL Sample";
            this.AddSqlURL.Click += new System.EventHandler(this.AddSqlURL_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(222, 6);
            // 
            // AddItemsLimit10
            // 
            this.AddItemsLimit10.Name = "AddItemsLimit10";
            this.AddItemsLimit10.Size = new System.Drawing.Size(225, 22);
            this.AddItemsLimit10.Text = "GET items with limit 10";
            this.AddItemsLimit10.Click += new System.EventHandler(this.AddItemsLimit10_Click);
            // 
            // AddItemsOffset10
            // 
            this.AddItemsOffset10.Name = "AddItemsOffset10";
            this.AddItemsOffset10.Size = new System.Drawing.Size(225, 22);
            this.AddItemsOffset10.Text = "GET items with offset 10";
            this.AddItemsOffset10.Click += new System.EventHandler(this.AddItemsOffset10_Click);
            // 
            // AddItemFull
            // 
            this.AddItemFull.Name = "AddItemFull";
            this.AddItemFull.Size = new System.Drawing.Size(225, 22);
            this.AddItemFull.Text = "GET an item with full expand";
            this.AddItemFull.Click += new System.EventHandler(this.AddItemFull_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(222, 6);
            // 
            // methodVersion
            // 
            this.methodVersion.Name = "methodVersion";
            this.methodVersion.Size = new System.Drawing.Size(225, 22);
            this.methodVersion.Text = "GET SerialNo";
            this.methodVersion.Click += new System.EventHandler(this.methodVersion_Click);
            // 
            // gETCAPIUsersToolStripMenuItem
            // 
            this.gETCAPIUsersToolStripMenuItem.Name = "gETCAPIUsersToolStripMenuItem";
            this.gETCAPIUsersToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.gETCAPIUsersToolStripMenuItem.Text = "GET CAPI Users";
            this.gETCAPIUsersToolStripMenuItem.Click += new System.EventHandler(this.gETCAPIUsersToolStripMenuItem_Click);
            // 
            // txtJSON
            // 
            this.txtJSON.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJSON.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJSON.ContextMenuStrip = this.JSONPopup;
            this.txtJSON.Location = new System.Drawing.Point(120, 65);
            this.txtJSON.Name = "txtJSON";
            this.txtJSON.Size = new System.Drawing.Size(434, 354);
            this.txtJSON.TabIndex = 7;
            this.txtJSON.Text = "";
            // 
            // JSONPopup
            // 
            this.JSONPopup.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.JSONPopup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSalesOrderJson,
            this.addARPSlipToolStripMenuItem});
            this.JSONPopup.Name = "JSONPopup";
            this.JSONPopup.Size = new System.Drawing.Size(159, 48);
            // 
            // addSalesOrderJson
            // 
            this.addSalesOrderJson.Name = "addSalesOrderJson";
            this.addSalesOrderJson.Size = new System.Drawing.Size(158, 22);
            this.addSalesOrderJson.Text = "Add Sales Order";
            this.addSalesOrderJson.Click += new System.EventHandler(this.addSalesOrderJson_Click);
            // 
            // addARPSlipToolStripMenuItem
            // 
            this.addARPSlipToolStripMenuItem.Name = "addARPSlipToolStripMenuItem";
            this.addARPSlipToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.addARPSlipToolStripMenuItem.Text = "Add ARP Slip";
            this.addARPSlipToolStripMenuItem.Click += new System.EventHandler(this.addARPSlipToolStripMenuItem_Click);
            // 
            // txtAccessToken
            // 
            this.txtAccessToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAccessToken.Location = new System.Drawing.Point(122, 13);
            this.txtAccessToken.Name = "txtAccessToken";
            this.txtAccessToken.Size = new System.Drawing.Size(434, 20);
            this.txtAccessToken.TabIndex = 6;
            // 
            // grpButtons
            // 
            this.grpButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpButtons.Controls.Add(this.btnPatch);
            this.grpButtons.Controls.Add(this.btnTest);
            this.grpButtons.Controls.Add(this.btnItemStressTest);
            this.grpButtons.Controls.Add(this.btnThreadTest);
            this.grpButtons.Controls.Add(this.btnUnsafeSQL);
            this.grpButtons.Controls.Add(this.btnPUT);
            this.grpButtons.Controls.Add(this.btnPOST);
            this.grpButtons.Controls.Add(this.btnGET);
            this.grpButtons.Enabled = false;
            this.grpButtons.Location = new System.Drawing.Point(3, 42);
            this.grpButtons.Name = "grpButtons";
            this.grpButtons.Size = new System.Drawing.Size(161, 337);
            this.grpButtons.TabIndex = 7;
            this.grpButtons.TabStop = false;
            // 
            // btnPatch
            // 
            this.btnPatch.Location = new System.Drawing.Point(6, 97);
            this.btnPatch.Name = "btnPatch";
            this.btnPatch.Size = new System.Drawing.Size(149, 23);
            this.btnPatch.TabIndex = 16;
            this.btnPatch.Text = "PATCH";
            this.btnPatch.UseVisualStyleBackColor = true;
            this.btnPatch.Click += new System.EventHandler(this.btnPatch_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(6, 291);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(149, 23);
            this.btnTest.TabIndex = 15;
            this.btnTest.Text = "TEST";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnItemStressTest
            // 
            this.btnItemStressTest.Location = new System.Drawing.Point(6, 216);
            this.btnItemStressTest.Name = "btnItemStressTest";
            this.btnItemStressTest.Size = new System.Drawing.Size(149, 23);
            this.btnItemStressTest.TabIndex = 14;
            this.btnItemStressTest.Text = "Item Stress Test";
            this.btnItemStressTest.UseVisualStyleBackColor = true;
            this.btnItemStressTest.Click += new System.EventHandler(this.btnItemStressTest_Click);
            // 
            // btnThreadTest
            // 
            this.btnThreadTest.Location = new System.Drawing.Point(6, 246);
            this.btnThreadTest.Name = "btnThreadTest";
            this.btnThreadTest.Size = new System.Drawing.Size(149, 23);
            this.btnThreadTest.TabIndex = 2;
            this.btnThreadTest.Text = "Thread Test";
            this.btnThreadTest.UseVisualStyleBackColor = true;
            this.btnThreadTest.Click += new System.EventHandler(this.btnThreadTest_Click);
            // 
            // btnUnsafeSQL
            // 
            this.btnUnsafeSQL.Location = new System.Drawing.Point(6, 187);
            this.btnUnsafeSQL.Name = "btnUnsafeSQL";
            this.btnUnsafeSQL.Size = new System.Drawing.Size(149, 23);
            this.btnUnsafeSQL.TabIndex = 13;
            this.btnUnsafeSQL.Text = "Unsafe SQL Test";
            this.btnUnsafeSQL.UseVisualStyleBackColor = true;
            this.btnUnsafeSQL.Click += new System.EventHandler(this.btnUnsafeSQL_Click);
            // 
            // btnPUT
            // 
            this.btnPUT.Location = new System.Drawing.Point(6, 68);
            this.btnPUT.Name = "btnPUT";
            this.btnPUT.Size = new System.Drawing.Size(149, 23);
            this.btnPUT.TabIndex = 12;
            this.btnPUT.Text = "PUT";
            this.btnPUT.UseVisualStyleBackColor = true;
            this.btnPUT.Click += new System.EventHandler(this.btnPUT_Click);
            // 
            // btnPOST
            // 
            this.btnPOST.Location = new System.Drawing.Point(6, 39);
            this.btnPOST.Name = "btnPOST";
            this.btnPOST.Size = new System.Drawing.Size(149, 23);
            this.btnPOST.TabIndex = 9;
            this.btnPOST.Text = "POST";
            this.btnPOST.UseVisualStyleBackColor = true;
            this.btnPOST.Click += new System.EventHandler(this.btnPOST_Click);
            // 
            // btnGET
            // 
            this.btnGET.Location = new System.Drawing.Point(6, 9);
            this.btnGET.Name = "btnGET";
            this.btnGET.Size = new System.Drawing.Size(149, 23);
            this.btnGET.TabIndex = 8;
            this.btnGET.Text = "GET";
            this.btnGET.UseVisualStyleBackColor = true;
            this.btnGET.Click += new System.EventHandler(this.btnGET_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 474);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REST Client Webinar Sample";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.grpTextBox.ResumeLayout(false);
            this.grpTextBox.PerformLayout();
            this.URLPopup.ResumeLayout(false);
            this.JSONPopup.ResumeLayout(false);
            this.grpButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpButtons;
        private System.Windows.Forms.Button btnPOST;
        private System.Windows.Forms.Button btnGET;
        private System.Windows.Forms.TextBox txtAccessToken;
        private System.Windows.Forms.RichTextBox txtJSON;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip JSONPopup;
        private System.Windows.Forms.ToolStripMenuItem addSalesOrderJson;
        private System.Windows.Forms.ContextMenuStrip URLPopup;
        private System.Windows.Forms.ToolStripMenuItem AddSqlURL;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem AddItemsLimit10;
        private System.Windows.Forms.ToolStripMenuItem AddItemsOffset10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem methodVersion;
        private System.Windows.Forms.ToolStripMenuItem AddItemFull;
        private System.Windows.Forms.ToolStripMenuItem gETCAPIUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addARPSlipToolStripMenuItem;
        private System.Windows.Forms.Button btnPUT;
        private System.Windows.Forms.Button btnUnsafeSQL;
        private System.Windows.Forms.Button btnThreadTest;
        private System.Windows.Forms.Button btnItemStressTest;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnPatch;
        private System.Windows.Forms.Button getAccessToken;
        private System.Windows.Forms.Button btnLogout;
    }
}

