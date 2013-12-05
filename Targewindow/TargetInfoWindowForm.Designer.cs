namespace TargetInformation
{
    partial class TargetInfoWindowForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TargetInfoWindowForm));
            this.TargetNameLabel = new System.Windows.Forms.Label();
            this.TargetHPLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DistanceLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.topMostOnOff = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hpTitle = new System.Windows.Forms.Label();
            this.distanceTitle = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TargetNameLabel
            // 
            resources.ApplyResources(this.TargetNameLabel, "TargetNameLabel");
            this.TargetNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TargetNameLabel.Name = "TargetNameLabel";
            // 
            // TargetHPLabel
            // 
            resources.ApplyResources(this.TargetHPLabel, "TargetHPLabel");
            this.TargetHPLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TargetHPLabel.Name = "TargetHPLabel";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DistanceLabel
            // 
            resources.ApplyResources(this.DistanceLabel, "DistanceLabel");
            this.DistanceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DistanceLabel.Name = "DistanceLabel";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topMostOnOff,
            this.toolStripSeparator1,
            this.closeMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // topMostOnOff
            // 
            this.topMostOnOff.CheckOnClick = true;
            this.topMostOnOff.Name = "topMostOnOff";
            resources.ApplyResources(this.topMostOnOff, "topMostOnOff");
            this.topMostOnOff.Click += new System.EventHandler(this.topMostOnOff_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // closeMenuItem
            // 
            this.closeMenuItem.Name = "closeMenuItem";
            resources.ApplyResources(this.closeMenuItem, "closeMenuItem");
            this.closeMenuItem.Click += new System.EventHandler(this.closeMenuItem_Click);
            // 
            // hpTitle
            // 
            resources.ApplyResources(this.hpTitle, "hpTitle");
            this.hpTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.hpTitle.Name = "hpTitle";
            // 
            // distanceTitle
            // 
            resources.ApplyResources(this.distanceTitle, "distanceTitle");
            this.distanceTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.distanceTitle.Name = "distanceTitle";
            // 
            // TargetInfoWindowForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.distanceTitle);
            this.Controls.Add(this.hpTitle);
            this.Controls.Add(this.DistanceLabel);
            this.Controls.Add(this.TargetHPLabel);
            this.Controls.Add(this.TargetNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TargetInfoWindowForm";
            this.Load += new System.EventHandler(this.TargetInfoWindowForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RankingForm_MouseDown);
            this.MouseEnter += new System.EventHandler(this.RankingForm_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.RankingForm_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RankingForm_MouseMove);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TargetNameLabel;
        private System.Windows.Forms.Label TargetHPLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label DistanceLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem topMostOnOff;
        private System.Windows.Forms.ToolStripMenuItem closeMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label hpTitle;
        private System.Windows.Forms.Label distanceTitle;
    }
}

