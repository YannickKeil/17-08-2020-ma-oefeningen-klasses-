namespace KlassesExtended
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
            this.lblLeeftijd = new System.Windows.Forms.Label();
            this.lbPersonen = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblLeeftijd
            // 
            this.lblLeeftijd.AutoSize = true;
            this.lblLeeftijd.Location = new System.Drawing.Point(13, 115);
            this.lblLeeftijd.Name = "lblLeeftijd";
            this.lblLeeftijd.Size = new System.Drawing.Size(0, 13);
            this.lblLeeftijd.TabIndex = 1;
            // 
            // lbPersonen
            // 
            this.lbPersonen.FormattingEnabled = true;
            this.lbPersonen.Location = new System.Drawing.Point(12, 12);
            this.lbPersonen.Name = "lbPersonen";
            this.lbPersonen.Size = new System.Drawing.Size(120, 95);
            this.lbPersonen.TabIndex = 2;
            this.lbPersonen.SelectedIndexChanged += new System.EventHandler(this.lbPersonen_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbPersonen);
            this.Controls.Add(this.lblLeeftijd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLeeftijd;
        private System.Windows.Forms.ListBox lbPersonen;
    }
}

