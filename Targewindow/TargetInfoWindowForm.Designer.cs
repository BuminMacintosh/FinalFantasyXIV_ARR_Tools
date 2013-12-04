namespace Targewindow
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
            this.TargetNameLabel.AutoSize = true;
            this.TargetNameLabel.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TargetNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TargetNameLabel.Location = new System.Drawing.Point(-1, 0);
            this.TargetNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TargetNameLabel.Name = "TargetNameLabel";
            this.TargetNameLabel.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.TargetNameLabel.Size = new System.Drawing.Size(111, 24);
            this.TargetNameLabel.TabIndex = 0;
            this.TargetNameLabel.Text = "ターゲットネーム";
            // 
            // TargetHPLabel
            // 
            this.TargetHPLabel.AutoSize = true;
            this.TargetHPLabel.Font = new System.Drawing.Font("Meiryo UI", 11F);
            this.TargetHPLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TargetHPLabel.Location = new System.Drawing.Point(42, 28);
            this.TargetHPLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TargetHPLabel.Name = "TargetHPLabel";
            this.TargetHPLabel.Size = new System.Drawing.Size(106, 19);
            this.TargetHPLabel.TabIndex = 1;
            this.TargetHPLabel.Text = "65535/65535";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DistanceLabel
            // 
            this.DistanceLabel.AutoSize = true;
            this.DistanceLabel.Font = new System.Drawing.Font("Meiryo UI", 11F);
            this.DistanceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DistanceLabel.Location = new System.Drawing.Point(42, 47);
            this.DistanceLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DistanceLabel.Name = "DistanceLabel";
            this.DistanceLabel.Size = new System.Drawing.Size(68, 19);
            this.DistanceLabel.TabIndex = 3;
            this.DistanceLabel.Text = "1234.56";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topMostOnOff,
            this.toolStripSeparator1,
            this.closeMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(167, 54);
            // 
            // topMostOnOff
            // 
            this.topMostOnOff.CheckOnClick = true;
            this.topMostOnOff.Name = "topMostOnOff";
            this.topMostOnOff.Size = new System.Drawing.Size(166, 22);
            this.topMostOnOff.Text = "常に前面表示(&T)";
            this.topMostOnOff.Click += new System.EventHandler(this.topMostOnOff_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // closeMenuItem
            // 
            this.closeMenuItem.Name = "closeMenuItem";
            this.closeMenuItem.Size = new System.Drawing.Size(166, 22);
            this.closeMenuItem.Text = "閉じる(&C)";
            this.closeMenuItem.Click += new System.EventHandler(this.closeMenuItem_Click);
            // 
            // hpTitle
            // 
            this.hpTitle.AutoSize = true;
            this.hpTitle.Font = new System.Drawing.Font("Meiryo UI", 11F);
            this.hpTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.hpTitle.Location = new System.Drawing.Point(14, 28);
            this.hpTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.hpTitle.Name = "hpTitle";
            this.hpTitle.Size = new System.Drawing.Size(29, 19);
            this.hpTitle.TabIndex = 4;
            this.hpTitle.Text = "HP";
            // 
            // distanceTitle
            // 
            this.distanceTitle.AutoSize = true;
            this.distanceTitle.Font = new System.Drawing.Font("Meiryo UI", 11F);
            this.distanceTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.distanceTitle.Location = new System.Drawing.Point(23, 47);
            this.distanceTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.distanceTitle.Name = "distanceTitle";
            this.distanceTitle.Size = new System.Drawing.Size(20, 19);
            this.distanceTitle.TabIndex = 5;
            this.distanceTitle.Text = "D";
            // 
            // TargetInfoWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(218, 74);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.distanceTitle);
            this.Controls.Add(this.hpTitle);
            this.Controls.Add(this.DistanceLabel);
            this.Controls.Add(this.TargetHPLabel);
            this.Controls.Add(this.TargetNameLabel);
            this.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TargetInfoWindowForm";
            this.Text = "TargetInfo";
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

