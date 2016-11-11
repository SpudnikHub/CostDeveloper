namespace UserControls
{
    partial class MaskedEditableLabelControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDisplay
            // 
            this.labelDisplay.AutoSize = true;
            this.labelDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDisplay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelDisplay.Location = new System.Drawing.Point(0, 0);
            this.labelDisplay.MinimumSize = new System.Drawing.Size(70, 20);
            this.labelDisplay.Name = "labelDisplay";
            this.labelDisplay.Size = new System.Drawing.Size(70, 20);
            this.labelDisplay.TabIndex = 2;
            this.labelDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelDisplay.DoubleClick += new System.EventHandler(this.labelDisplay_DoubleClick);
            // 
            // MaskedEditableLabelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.labelDisplay);
            this.MinimumSize = new System.Drawing.Size(70, 20);
            this.Name = "MaskedEditableLabelControl";
            this.Size = new System.Drawing.Size(70, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDisplay;
    }
}
