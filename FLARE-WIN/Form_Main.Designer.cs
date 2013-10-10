namespace FLARE_WIN
{
    partial class Form_Main
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage_home = new System.Windows.Forms.TabPage();
            this.tabPage_export = new System.Windows.Forms.TabPage();
            this.tabPage_query = new System.Windows.Forms.TabPage();
            this.tabPage_month = new System.Windows.Forms.TabPage();
            this.tabPage_option = new System.Windows.Forms.TabPage();
            this.tabPage_setup = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.Export = new System.Windows.Forms.ToolStripButton();
            this.Query = new System.Windows.Forms.ToolStripButton();
            this.Month = new System.Windows.Forms.ToolStripButton();
            this.Option = new System.Windows.Forms.ToolStripButton();
            this.Users = new System.Windows.Forms.ToolStripButton();
            this.Help = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tabPage_users = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.toolStripMenu.SuspendLayout();
            this.tabPage_users.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.tabControlMain);
            this.splitContainerMain.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainerMain.Panel2.Controls.Add(this.toolStripMenu);
            this.splitContainerMain.Size = new System.Drawing.Size(1008, 662);
            this.splitContainerMain.SplitterDistance = 56;
            this.splitContainerMain.TabIndex = 1;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage_home);
            this.tabControlMain.Controls.Add(this.tabPage_export);
            this.tabControlMain.Controls.Add(this.tabPage_query);
            this.tabControlMain.Controls.Add(this.tabPage_month);
            this.tabControlMain.Controls.Add(this.tabPage_option);
            this.tabControlMain.Controls.Add(this.tabPage_setup);
            this.tabControlMain.Controls.Add(this.tabPage_users);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 71);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1006, 507);
            this.tabControlMain.TabIndex = 2;
            // 
            // tabPage_home
            // 
            this.tabPage_home.Location = new System.Drawing.Point(4, 22);
            this.tabPage_home.Name = "tabPage_home";
            this.tabPage_home.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_home.Size = new System.Drawing.Size(998, 481);
            this.tabPage_home.TabIndex = 0;
            this.tabPage_home.Text = "主畫面";
            this.tabPage_home.UseVisualStyleBackColor = true;
            this.tabPage_home.Click += new System.EventHandler(this.tabPage_home_Click);
            // 
            // tabPage_export
            // 
            this.tabPage_export.Location = new System.Drawing.Point(4, 22);
            this.tabPage_export.Name = "tabPage_export";
            this.tabPage_export.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_export.Size = new System.Drawing.Size(998, 481);
            this.tabPage_export.TabIndex = 1;
            this.tabPage_export.Text = "及時轉檔";
            this.tabPage_export.UseVisualStyleBackColor = true;
            // 
            // tabPage_query
            // 
            this.tabPage_query.Location = new System.Drawing.Point(4, 22);
            this.tabPage_query.Name = "tabPage_query";
            this.tabPage_query.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_query.Size = new System.Drawing.Size(998, 481);
            this.tabPage_query.TabIndex = 2;
            this.tabPage_query.Text = "資料查詢";
            this.tabPage_query.UseVisualStyleBackColor = true;
            // 
            // tabPage_month
            // 
            this.tabPage_month.Location = new System.Drawing.Point(4, 22);
            this.tabPage_month.Name = "tabPage_month";
            this.tabPage_month.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_month.Size = new System.Drawing.Size(998, 481);
            this.tabPage_month.TabIndex = 3;
            this.tabPage_month.Text = "月報轉檔";
            this.tabPage_month.UseVisualStyleBackColor = true;
            // 
            // tabPage_option
            // 
            this.tabPage_option.Location = new System.Drawing.Point(4, 22);
            this.tabPage_option.Name = "tabPage_option";
            this.tabPage_option.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_option.Size = new System.Drawing.Size(998, 481);
            this.tabPage_option.TabIndex = 4;
            this.tabPage_option.Text = "選項設定";
            this.tabPage_option.UseVisualStyleBackColor = true;
            // 
            // tabPage_setup
            // 
            this.tabPage_setup.Location = new System.Drawing.Point(4, 22);
            this.tabPage_setup.Name = "tabPage_setup";
            this.tabPage_setup.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_setup.Size = new System.Drawing.Size(998, 481);
            this.tabPage_setup.TabIndex = 5;
            this.tabPage_setup.Text = "參數設定";
            this.tabPage_setup.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 578);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1006, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Export,
            this.Query,
            this.Month,
            this.Option,
            this.toolStripButton1,
            this.Users,
            this.Help});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(1006, 71);
            this.toolStripMenu.TabIndex = 0;
            this.toolStripMenu.Text = "toolStrip1";
            this.toolStripMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripMenu_ItemClicked);
            // 
            // Export
            // 
            this.Export.Image = global::FLARE_WIN.Properties.Resources.export;
            this.Export.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Export.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(60, 68);
            this.Export.Text = "即時轉檔";
            this.Export.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Export.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Query
            // 
            this.Query.Image = global::FLARE_WIN.Properties.Resources.folder_find;
            this.Query.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Query.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Query.Name = "Query";
            this.Query.Size = new System.Drawing.Size(60, 68);
            this.Query.Text = "資料查詢";
            this.Query.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Query.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Month
            // 
            this.Month.Image = global::FLARE_WIN.Properties.Resources.calendar;
            this.Month.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Month.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(60, 68);
            this.Month.Text = "月報轉檔";
            this.Month.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Month.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Option
            // 
            this.Option.Image = global::FLARE_WIN.Properties.Resources.options;
            this.Option.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Option.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Option.Name = "Option";
            this.Option.Size = new System.Drawing.Size(60, 68);
            this.Option.Text = "選項設定";
            this.Option.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Option.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Users
            // 
            this.Users.Image = global::FLARE_WIN.Properties.Resources.users;
            this.Users.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Users.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(60, 68);
            this.Users.Text = "權限管理";
            this.Users.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Users.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Help
            // 
            this.Help.Image = global::FLARE_WIN.Properties.Resources.help;
            this.Help.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Help.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(60, 68);
            this.Help.Text = "系統說明";
            this.Help.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Help.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::FLARE_WIN.Properties.Resources.configure;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(60, 68);
            this.toolStripButton1.Text = "參數設定";
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tabPage_users
            // 
            this.tabPage_users.Controls.Add(this.button1);
            this.tabPage_users.Location = new System.Drawing.Point(4, 22);
            this.tabPage_users.Name = "tabPage_users";
            this.tabPage_users.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_users.Size = new System.Drawing.Size(998, 481);
            this.tabPage_users.TabIndex = 6;
            this.tabPage_users.Text = "權限管理";
            this.tabPage_users.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 662);
            this.Controls.Add(this.splitContainerMain);
            this.IsMdiContainer = true;
            this.Name = "Form_Main";
            this.Text = "燃燒塔 報表系統";
            this.splitContainerMain.Panel2.ResumeLayout(false);
            this.splitContainerMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.tabPage_users.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage_home;
        private System.Windows.Forms.TabPage tabPage_export;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton Help;
        private System.Windows.Forms.ToolStripButton Users;
        private System.Windows.Forms.ToolStripButton Option;
        private System.Windows.Forms.ToolStripButton Export;
        private System.Windows.Forms.ToolStripButton Query;
        private System.Windows.Forms.ToolStripButton Month;
        private System.Windows.Forms.TabPage tabPage_query;
        private System.Windows.Forms.TabPage tabPage_month;
        private System.Windows.Forms.TabPage tabPage_option;
        private System.Windows.Forms.TabPage tabPage_setup;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TabPage tabPage_users;
        private System.Windows.Forms.Button button1;


    }
}

