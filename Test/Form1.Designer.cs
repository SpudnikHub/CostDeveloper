namespace Test
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.genericAtlanticCostingControl2 = new UserControls.GenericAtlanticCostingControl();
            this.genericAtlanticCostingControl1 = new UserControls.GenericAtlanticCostingControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(186, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // genericAtlanticCostingControl2
            // 
            this.genericAtlanticCostingControl2.BackColor = System.Drawing.SystemColors.GrayText;
            this.genericAtlanticCostingControl2.FrameType = UserControls.GenericAtlanticCostingControl.myFrameType.SquareTwoFifty;
            this.genericAtlanticCostingControl2.Location = new System.Drawing.Point(-2, 42);
            this.genericAtlanticCostingControl2.MaterialID = null;
            this.genericAtlanticCostingControl2.Name = "genericAtlanticCostingControl2";
            this.genericAtlanticCostingControl2.Size = new System.Drawing.Size(550, 392);
            this.genericAtlanticCostingControl2.TabIndex = 2;
            // 
            // genericAtlanticCostingControl1
            // 
            this.genericAtlanticCostingControl1.BackColor = System.Drawing.SystemColors.GrayText;
            this.genericAtlanticCostingControl1.FrameType = UserControls.GenericAtlanticCostingControl.myFrameType.SquareTwoFifty;
            this.genericAtlanticCostingControl1.Location = new System.Drawing.Point(0, 34);
            this.genericAtlanticCostingControl1.MaterialID = null;
            this.genericAtlanticCostingControl1.Name = "genericAtlanticCostingControl1";
            this.genericAtlanticCostingControl1.Size = new System.Drawing.Size(550, 392);
            this.genericAtlanticCostingControl1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 446);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.genericAtlanticCostingControl2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.GenericAtlanticCostingControl genericAtlanticCostingControl1;
        private System.Windows.Forms.ComboBox comboBox1;
        private UserControls.GenericAtlanticCostingControl genericAtlanticCostingControl2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

