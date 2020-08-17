namespace _17_08_2020_ma_oefeningen__klasses_
{
    partial class oef1
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
            this.btnBekijkGetal = new System.Windows.Forms.Button();
            this.btnVerhoog = new System.Windows.Forms.Button();
            this.btnVerlaag = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBekijkGetal
            // 
            this.btnBekijkGetal.Location = new System.Drawing.Point(50, 35);
            this.btnBekijkGetal.Name = "btnBekijkGetal";
            this.btnBekijkGetal.Size = new System.Drawing.Size(208, 44);
            this.btnBekijkGetal.TabIndex = 0;
            this.btnBekijkGetal.Text = "Lezen waarde teller";
            this.btnBekijkGetal.UseVisualStyleBackColor = true;
            this.btnBekijkGetal.Click += new System.EventHandler(this.btnBekijkGetal_Click);
            // 
            // btnVerhoog
            // 
            this.btnVerhoog.Location = new System.Drawing.Point(50, 85);
            this.btnVerhoog.Name = "btnVerhoog";
            this.btnVerhoog.Size = new System.Drawing.Size(208, 46);
            this.btnVerhoog.TabIndex = 1;
            this.btnVerhoog.Text = "Verhoog teller met 1";
            this.btnVerhoog.UseVisualStyleBackColor = true;
            this.btnVerhoog.Click += new System.EventHandler(this.btnVerhoog_Click);
            // 
            // btnVerlaag
            // 
            this.btnVerlaag.Location = new System.Drawing.Point(50, 137);
            this.btnVerlaag.Name = "btnVerlaag";
            this.btnVerlaag.Size = new System.Drawing.Size(208, 44);
            this.btnVerlaag.TabIndex = 2;
            this.btnVerlaag.Text = "Verminder teller met 1";
            this.btnVerlaag.UseVisualStyleBackColor = true;
            this.btnVerlaag.Click += new System.EventHandler(this.btnVerlaag_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(50, 187);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(208, 44);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Resettem teller naar 0";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(50, 237);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(208, 44);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Einde";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // oef1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 329);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnVerlaag);
            this.Controls.Add(this.btnVerhoog);
            this.Controls.Add(this.btnBekijkGetal);
            this.Name = "oef1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "oef1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBekijkGetal;
        private System.Windows.Forms.Button btnVerhoog;
        private System.Windows.Forms.Button btnVerlaag;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClose;
    }
}