namespace _17_08_2020_ma_oefeningen__klasses_
{
    partial class oef4
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
            this.tbLengte = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbBreedte = new System.Windows.Forms.TextBox();
            this.tbDiepte = new System.Windows.Forms.TextBox();
            this.btnVolume = new System.Windows.Forms.Button();
            this.lVolume = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbLengte
            // 
            this.tbLengte.Location = new System.Drawing.Point(73, 71);
            this.tbLengte.Name = "tbLengte";
            this.tbLengte.Size = new System.Drawing.Size(100, 26);
            this.tbLengte.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbBreedte
            // 
            this.tbBreedte.Location = new System.Drawing.Point(206, 71);
            this.tbBreedte.Name = "tbBreedte";
            this.tbBreedte.Size = new System.Drawing.Size(100, 26);
            this.tbBreedte.TabIndex = 2;
            // 
            // tbDiepte
            // 
            this.tbDiepte.Location = new System.Drawing.Point(354, 71);
            this.tbDiepte.Name = "tbDiepte";
            this.tbDiepte.Size = new System.Drawing.Size(100, 26);
            this.tbDiepte.TabIndex = 3;
            // 
            // btnVolume
            // 
            this.btnVolume.Location = new System.Drawing.Point(73, 189);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(136, 42);
            this.btnVolume.TabIndex = 4;
            this.btnVolume.Text = "bereken Volume";
            this.btnVolume.UseVisualStyleBackColor = true;
            this.btnVolume.Click += new System.EventHandler(this.btnVolume_Click);
            // 
            // lVolume
            // 
            this.lVolume.AutoSize = true;
            this.lVolume.Location = new System.Drawing.Point(403, 189);
            this.lVolume.Name = "lVolume";
            this.lVolume.Size = new System.Drawing.Size(104, 20);
            this.lVolume.TabIndex = 5;
            this.lVolume.Text = "volume in liter";
            this.lVolume.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "lengte in meter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "breedte in meter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "diepte in meter";
            // 
            // oef4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lVolume);
            this.Controls.Add(this.btnVolume);
            this.Controls.Add(this.tbDiepte);
            this.Controls.Add(this.tbBreedte);
            this.Controls.Add(this.tbLengte);
            this.Name = "oef4";
            this.Text = "oef4";
            this.Load += new System.EventHandler(this.oef4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLengte;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbBreedte;
        private System.Windows.Forms.TextBox tbDiepte;
        private System.Windows.Forms.Button btnVolume;
        private System.Windows.Forms.Label lVolume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}