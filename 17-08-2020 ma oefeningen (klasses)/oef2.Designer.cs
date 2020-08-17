namespace _17_08_2020_ma_oefeningen__klasses_
{
    partial class oef2
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
            this.lVolume = new System.Windows.Forms.Label();
            this.lChannel = new System.Windows.Forms.Label();
            this.btnVolumeDown = new System.Windows.Forms.Button();
            this.btnVolumeUp = new System.Windows.Forms.Button();
            this.btnChannelDown = new System.Windows.Forms.Button();
            this.btnChannelUp = new System.Windows.Forms.Button();
            this.gbVolume = new System.Windows.Forms.GroupBox();
            this.gbChannel = new System.Windows.Forms.GroupBox();
            this.pbVolume = new System.Windows.Forms.ProgressBar();
            this.txtChannel = new System.Windows.Forms.TextBox();
            this.lChannelNr = new System.Windows.Forms.Label();
            this.gbVolume.SuspendLayout();
            this.gbChannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lVolume
            // 
            this.lVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lVolume.AutoSize = true;
            this.lVolume.Location = new System.Drawing.Point(94, 52);
            this.lVolume.Name = "lVolume";
            this.lVolume.Size = new System.Drawing.Size(89, 20);
            this.lVolume.TabIndex = 0;
            this.lVolume.Text = "Volume: 10";
            this.lVolume.Click += new System.EventHandler(this.lVolume_Click);
            // 
            // lChannel
            // 
            this.lChannel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lChannel.AutoSize = true;
            this.lChannel.Location = new System.Drawing.Point(94, 300);
            this.lChannel.Name = "lChannel";
            this.lChannel.Size = new System.Drawing.Size(102, 20);
            this.lChannel.TabIndex = 1;
            this.lChannel.Text = "Kannaal: een";
            // 
            // btnVolumeDown
            // 
            this.btnVolumeDown.Location = new System.Drawing.Point(41, 50);
            this.btnVolumeDown.Name = "btnVolumeDown";
            this.btnVolumeDown.Size = new System.Drawing.Size(34, 34);
            this.btnVolumeDown.TabIndex = 2;
            this.btnVolumeDown.Text = "-";
            this.btnVolumeDown.UseVisualStyleBackColor = true;
            this.btnVolumeDown.Click += new System.EventHandler(this.btnVolumeDown_Click);
            // 
            // btnVolumeUp
            // 
            this.btnVolumeUp.Location = new System.Drawing.Point(154, 50);
            this.btnVolumeUp.Name = "btnVolumeUp";
            this.btnVolumeUp.Size = new System.Drawing.Size(34, 34);
            this.btnVolumeUp.TabIndex = 3;
            this.btnVolumeUp.Text = "+";
            this.btnVolumeUp.UseVisualStyleBackColor = true;
            this.btnVolumeUp.Click += new System.EventHandler(this.btnVolumeUp_Click);
            // 
            // btnChannelDown
            // 
            this.btnChannelDown.Location = new System.Drawing.Point(41, 89);
            this.btnChannelDown.Name = "btnChannelDown";
            this.btnChannelDown.Size = new System.Drawing.Size(34, 34);
            this.btnChannelDown.TabIndex = 4;
            this.btnChannelDown.Text = "-";
            this.btnChannelDown.UseVisualStyleBackColor = true;
            this.btnChannelDown.Click += new System.EventHandler(this.btnChannelDown_Click);
            // 
            // btnChannelUp
            // 
            this.btnChannelUp.Location = new System.Drawing.Point(154, 89);
            this.btnChannelUp.Name = "btnChannelUp";
            this.btnChannelUp.Size = new System.Drawing.Size(34, 34);
            this.btnChannelUp.TabIndex = 5;
            this.btnChannelUp.Text = "+";
            this.btnChannelUp.UseVisualStyleBackColor = true;
            this.btnChannelUp.Click += new System.EventHandler(this.btnChannelUp_Click);
            // 
            // gbVolume
            // 
            this.gbVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbVolume.Controls.Add(this.btnVolumeDown);
            this.gbVolume.Controls.Add(this.btnVolumeUp);
            this.gbVolume.Location = new System.Drawing.Point(98, 152);
            this.gbVolume.Name = "gbVolume";
            this.gbVolume.Size = new System.Drawing.Size(240, 125);
            this.gbVolume.TabIndex = 6;
            this.gbVolume.TabStop = false;
            this.gbVolume.Text = "Volume";
            // 
            // gbChannel
            // 
            this.gbChannel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbChannel.Controls.Add(this.txtChannel);
            this.gbChannel.Controls.Add(this.btnChannelDown);
            this.gbChannel.Controls.Add(this.btnChannelUp);
            this.gbChannel.Location = new System.Drawing.Point(98, 351);
            this.gbChannel.Name = "gbChannel";
            this.gbChannel.Size = new System.Drawing.Size(240, 158);
            this.gbChannel.TabIndex = 7;
            this.gbChannel.TabStop = false;
            this.gbChannel.Text = "kanaal";
            this.gbChannel.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // pbVolume
            // 
            this.pbVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbVolume.Location = new System.Drawing.Point(98, 105);
            this.pbVolume.Name = "pbVolume";
            this.pbVolume.Size = new System.Drawing.Size(240, 23);
            this.pbVolume.TabIndex = 8;
            this.pbVolume.Click += new System.EventHandler(this.pbVolume_Click);
            // 
            // txtChannel
            // 
            this.txtChannel.Location = new System.Drawing.Point(21, 43);
            this.txtChannel.Name = "txtChannel";
            this.txtChannel.Size = new System.Drawing.Size(188, 26);
            this.txtChannel.TabIndex = 6;
            this.txtChannel.TextChanged += new System.EventHandler(this.txtChannel_TextChanged);
            // 
            // lChannelNr
            // 
            this.lChannelNr.AutoSize = true;
            this.lChannelNr.Location = new System.Drawing.Point(94, 328);
            this.lChannelNr.Name = "lChannelNr";
            this.lChannelNr.Size = new System.Drawing.Size(18, 20);
            this.lChannelNr.TabIndex = 9;
            this.lChannelNr.Text = "1";
            // 
            // oef2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 559);
            this.Controls.Add(this.lChannelNr);
            this.Controls.Add(this.pbVolume);
            this.Controls.Add(this.gbChannel);
            this.Controls.Add(this.gbVolume);
            this.Controls.Add(this.lChannel);
            this.Controls.Add(this.lVolume);
            this.MaximumSize = new System.Drawing.Size(462, 615);
            this.MinimumSize = new System.Drawing.Size(462, 615);
            this.Name = "oef2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "oef2";
            this.Load += new System.EventHandler(this.oef2_Load);
            this.gbVolume.ResumeLayout(false);
            this.gbChannel.ResumeLayout(false);
            this.gbChannel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lVolume;
        private System.Windows.Forms.Label lChannel;
        private System.Windows.Forms.Button btnVolumeDown;
        private System.Windows.Forms.Button btnVolumeUp;
        private System.Windows.Forms.Button btnChannelDown;
        private System.Windows.Forms.Button btnChannelUp;
        private System.Windows.Forms.GroupBox gbVolume;
        private System.Windows.Forms.GroupBox gbChannel;
        private System.Windows.Forms.TextBox txtChannel;
        private System.Windows.Forms.ProgressBar pbVolume;
        private System.Windows.Forms.Label lChannelNr;
    }
}