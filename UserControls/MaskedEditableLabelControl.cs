using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControls
{
    public partial class MaskedEditableLabelControl : UserControl
    {
        private TextBox editableTextbox;
        public MaskedEditableLabelControl()
        {
            InitializeComponent();
            editableTextbox = new TextBox();
            this.Controls.Add(editableTextbox);
            editableTextbox.KeyDown += new KeyEventHandler(editableTextbox_Keydown);
            editableTextbox.KeyPress += new KeyPressEventHandler(editableTextbox_KeyPress);
            editableTextbox.Leave += new System.EventHandler(editableTextbox_Leave);
            editableTextbox.Hide();

        }

        void editableTextbox_KeyPress(Object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && editableTextbox.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        void editableTextbox_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                labelDisplay.Text = editableTextbox.Text;
                editableTextbox.Hide();
                labelDisplay.Show();
            }
        }

        void editableTextbox_Leave(Object sender, EventArgs e)
        {
            labelDisplay.Text = editableTextbox.Text;
            editableTextbox.Hide();
            labelDisplay.Show();
        }

        public override string Text
        {
            get { return labelDisplay.Text; }
            set { labelDisplay.Text = value; }
        }

        private void labelDisplay_DoubleClick(Object sender, EventArgs e)
        {
            editableTextbox.Size = this.Size;
            editableTextbox.Text = this.Text;
            labelDisplay.Hide();
            editableTextbox.Show();
            editableTextbox.Focus();
        }
    }
}
