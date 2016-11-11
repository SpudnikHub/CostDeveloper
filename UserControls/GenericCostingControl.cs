using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Engines;


namespace UserControls
{
    public partial class GenericCostingControl: UserControl
    {
        #region Properties

        DataEngine d = new DataEngine();
        Accessor.LengthAccess l;
        Accessor.AreaAccess a;
        public enum myCostType { Lenght, Area, Volume };   //Channel Cost Enumeration
        private myCostType costType = new myCostType();
        public myCostType CostType
        {
            get { return costType; }
            set { costType = value; }
        }
        int costID;
        private Font TextFont = new Font("Ariel", 7);

        #region Combobox Public Members
        public string SelectedText
        {
            get { return cmbMaterial.Text; }
        }

        public string SelectedValue
        {
            get { return cmbMaterial.SelectedValue.ToString(); }
        }
        public event EventHandler SelectedIndexChanged;
        #endregion Combobox Public Members

        #region Save Button Public Member
        private Button saveBtn;
        public Button SaveBtn
        {
            get
            {
                return btnSave;
            }

            set
            {
                btnSave = value;
            }
        }

        #endregion Save Button Public Member
        public event EventHandler ButtonClick;

        #region Top Panel
        private ComboBox cmbMat;
        private TextBox descriptiontxt;
        private TextBox materialIDtxt;
        private TableLayoutPanel lowerPanel;
        public ComboBox CmbMat
        {
            get
            {
                return cmbMaterial;
            }

            set
            {
                cmbMaterial = value;
            }
        }

        public TextBox Descriptiontxt
        {
            get
            {
                return txtDescription;
            }

            set
            {
                txtDescription = value;
            }
        }

        public TextBox MaterialIDtxt
        {
            get
            {
                return txtMaterialID;
            }

            set
            {
                txtMaterialID = value;
            }
        }
        #endregion Top Panel

        #region Mid Panel

        private Label middlePanelNumOnelbl;
        private Label middlePanelNumTwolbl;
        private Label middlePanelNumThreelbl;

        private Label numMidPanelNumOne;
        private Label numMidPanelNumTwo;
        private Label middlePaneltxt;
        private TextBox numMidPanelNumberOneText;
        private TextBox numMidPanelNumberTwoText;
        private TextBox txtMiddlePanelText;

        public Label MiddlePanelNumOnelbl
        {
            get
            {
                return lblMiddlePanelNumOne;
            }

            set
            {
                lblMiddlePanelNumOne = value;
            }
        }

        public Label MiddlePanelNumTwolbl
        {
            get
            {
                return lblMiddlePanelNumTwo;
            }

            set
            {
                lblMiddlePanelNumTwo = value;
            }
        }

        public Label MiddlePanelNumThreelbl
        {
            get
            {
                return lblMiddlePanelNumThree;
            }

            set
            {
                lblMiddlePanelNumThree = value;
            }
        }

        public Label NumMidPanelNumOne
        {
            get
            {
                return numMidPanelNumberOne;
            }

            set
            {
                numMidPanelNumberOne = value;
            }
        }

        public Label NumMidPanelNumTwo
        {
            get
            {
                return numMidPanelNumberTwo;
            }

            set
            {
                numMidPanelNumberTwo = value;
            }
        }

        public Label MiddlePaneltxt
        {
            get
            {
                return txtMiddlePanel;
            }

            set
            {
                txtMiddlePanel = value;
            }
        }

        #endregion Mid Panel

        #region Lower Panel
        private Label lowerPanelNumOnelbl;
        private Label lowerPanelNumTwolbl;
        private TextBox lowerPanelNumOnetxt;
        private TextBox lowerPanelNumTwotxt;

        public Label LowerPanelNumOnelbl
        {
            get
            {
                return lblLowerPanelNumOne;
            }

            set
            {
                lblLowerPanelNumOne = value;
            }
        }

        public Label LowerPanelNumTwolbl
        {
            get
            {
                return lblLowerPanelNumTwo;
            }

            set
            {
                lblLowerPanelNumTwo = value;
            }
        }

        public TextBox LowerPanelNumOnetxt
        {
            get
            {
                return txtLowerPanelNumOne;
            }

            set
            {
                txtLowerPanelNumOne = value;
            }
        }

        public TextBox LowerPanelNumTwotxt
        {
            get
            {
                return txtLowerPanelNumTwo;
            }

            set
            {
                txtLowerPanelNumTwo = value;
            }
        }

        public TableLayoutPanel LowerPanel
        {
            get
            {
                return tableLayoutPanel2;
            }

            set
            {
                tableLayoutPanel2 = value;
            }
        }




        #endregion Lower Panel

        public override string Text
        {
            get { return numMidPanelNumberOne.Text; }
            set { numMidPanelNumberOne.Text = value; }
        }


        #endregion Properties

        #region Constructor
        public GenericCostingControl()
        {
            InitializeComponent();
            // NumMidPanelNumberOneText Events
            numMidPanelNumberOneText = new TextBox();
            numMidPanelNumberOneText.KeyDown += new KeyEventHandler(numMidPanelNumberOneText_Keydown);
            numMidPanelNumberOneText.KeyPress += new KeyPressEventHandler(numMidPanelNumberOneText_KeyPress);
            numMidPanelNumberOneText.Leave += new System.EventHandler(numMidPanelNumberOneText_Leave);
            numMidPanelNumberOneText.Hide();
            // numMidPanelNumberTwoText Events
            numMidPanelNumberTwoText = new TextBox();
            numMidPanelNumberTwoText.KeyDown += new KeyEventHandler(numMidPanelNumberTwoText_Keydown);
            numMidPanelNumberTwoText.KeyPress += new KeyPressEventHandler(numMidPanelNumberTwoText_KeyPress);
            numMidPanelNumberTwoText.Leave += new System.EventHandler(numMidPanelNumberTwoText_Leave);
            numMidPanelNumberTwoText.Hide();
            // txtMiddlePanelText eVENTS
            txtMiddlePanelText = new TextBox();
            txtMiddlePanelText.KeyDown += new KeyEventHandler(txtMiddlePanelText_Keydown);
            txtMiddlePanelText.KeyPress += new KeyPressEventHandler(txtMiddlePanelText_KeyPress);
            txtMiddlePanelText.Leave += new System.EventHandler(txtMiddlePanelText_Leave);
            txtMiddlePanelText.Hide();
            // Combobox Event
            this.Load += new EventHandler(MyCombobox_Load);
            this.cmbMaterial.SelectedIndexChanged += new EventHandler(cmbMaterial_SelectedIndexChanged);

        }
        #endregion Constructor

        #region Methods

        private void ApplyEdit()
        {
            switch (CostType)
            {
                case myCostType.Lenght: //Length
                    l = new Accessor.LengthAccess();
                    l.MaterialID = txtMaterialID.Text;
                    l.NumPieces = Convert.ToDecimal(numMidPanelNumberOne.Text);
                    l.TotalLength = Convert.ToDecimal(numMidPanelNumberTwo.Text);
                    l.TotalCost = decimal.Parse(txtMiddlePanel.Text, System.Globalization.NumberStyles.Currency);
                    l.LengthPerPiece = decimal.Parse(txtLowerPanelNumOne.Text);
                    l.PricePerMeter = decimal.Parse(txtLowerPanelNumTwo.Text, System.Globalization.NumberStyles.Currency);

                    d.SaveLength(costID, l);
                    //SetDisplay(false);
                    break;
                case myCostType.Area:
                    a = new Accessor.AreaAccess();
                    a.MaterialID = txtMaterialID.Text;
                    a.TotalLenght = Convert.ToDecimal(numMidPanelNumberOne.Text);
                    a.TotalWidth = Convert.ToDecimal(numMidPanelNumberTwo.Text);
                    a.TotalCost = decimal.Parse(txtMiddlePanel.Text, System.Globalization.NumberStyles.Currency);
                    a.TotalArea = Convert.ToDecimal(txtLowerPanelNumOne.Text);
                    a.PricePSqrMeter = decimal.Parse(txtLowerPanelNumTwo.Text, System.Globalization.NumberStyles.Currency);

                    d.SaveArea(costID, a);
                    //SetDisplay(false);
                    //todo call savearea
                    //TODO ENTER VOLUME CASE
                    break;
                default:
                    break;
            }
        }

        #region Graphics
        protected override void OnPaint(PaintEventArgs e)
        {
            using (Pen GrayPen = new Pen(Color.Gray, 2))
            {
                e.Graphics.DrawRectangle(GrayPen, 233, 5, 300, 300);   // Draw Outer Border
            }
            switch (CostType)
            {
                #region Length Display
                case myCostType.Lenght:
                    using (Pen BlackPen = new Pen(Color.Black, 1))
                    {
                        // Draw Plank
                        e.Graphics.DrawRectangle(BlackPen, 300, 25, 20, 260);

                        //Draw horizontal measure line
                        e.Graphics.DrawLine(BlackPen, 340, 25, 340, 285);
                        // measure line top arrow
                        e.Graphics.DrawLine(BlackPen, 340, 25, 350, 35);
                        e.Graphics.DrawLine(BlackPen, 340, 25, 330, 35);
                        // measure line bottom arraw

                        e.Graphics.DrawLine(BlackPen, 340, 285, 330, 275);
                        e.Graphics.DrawLine(BlackPen, 340, 285, 350, 275);
                    }
                    using (Pen BluePen = new Pen(Color.Blue, 1))
                    {
                        e.Graphics.DrawLine(BluePen, 325, 25, 350, 25);
                        e.Graphics.DrawLine(BluePen, 325, 285, 350, 285);
                    }
                    using (SolidBrush blackBrush = new SolidBrush(Color.Blue))
                    {
                        // Length Cost
                        DrawRotatedTextAt(e.Graphics, 270, "Length " + txtLowerPanelNumOne.Text + "m", 340, 180, TextFont, Brushes.Blue);

                        e.Graphics.DrawString("Price per Meter: " + txtLowerPanelNumTwo.Text, TextFont, blackBrush, 365, 145);
                    }

                    break;
                #endregion Length Display

                #region Area Display
                case myCostType.Area:
                    using (Pen BlackPen = new Pen(Color.Black, 1))
                    {
                        //Frame
                        e.Graphics.DrawRectangle(BlackPen, 320, 60, 150, 150);
                        //Measure Horizontal
                        e.Graphics.DrawLine(BlackPen, 320, 35, 470, 35);
                        //Arrow Left
                        e.Graphics.DrawLine(BlackPen, 320, 35, 330, 40);
                        e.Graphics.DrawLine(BlackPen, 320, 35, 330, 30);
                        //Arrow Right
                        e.Graphics.DrawLine(BlackPen, 470, 35, 460, 40);
                        e.Graphics.DrawLine(BlackPen, 470, 35, 460, 30);

                        //Measure Vertival
                        e.Graphics.DrawLine(BlackPen, 295, 60, 295, 210);
                        //Arrow Top
                        e.Graphics.DrawLine(BlackPen, 295, 60, 300, 70);
                        e.Graphics.DrawLine(BlackPen, 295, 60, 290, 70);
                        //Arrow Bottom
                        e.Graphics.DrawLine(BlackPen, 295, 210, 300, 200);
                        e.Graphics.DrawLine(BlackPen, 295, 210, 290, 200);

                    }
                    using (Pen BluePen = new Pen(Color.Blue, 1))
                    {
                        //Horizontal
                        e.Graphics.DrawLine(BluePen, 310, 60, 280, 60);
                        e.Graphics.DrawLine(BluePen, 310, 210, 280, 210);
                        //Vertical
                        e.Graphics.DrawLine(BluePen, 470, 50, 470, 20);
                        e.Graphics.DrawLine(BluePen, 320, 50, 320, 20);

                    }
                    using (SolidBrush blackBrush = new SolidBrush(Color.Blue))
                    {
                        DrawRotatedTextAt(e.Graphics, 270, "Length " + numMidPanelNumberOne.Text + "m", 280, 155, TextFont, Brushes.Blue);
                        DrawRotatedTextAt(e.Graphics, 0, "Width " + numMidPanelNumberTwo.Text + "m", 375, 20, TextFont, Brushes.Blue);
                        DrawRotatedTextAt(e.Graphics, 0, "Area " + txtLowerPanelNumOne.Text + "sq/m", 365, 125, TextFont, Brushes.Blue);
                    }
                    break;
                #endregion Area Display

                #region Volume Display
                case myCostType.Volume:
                    using (Pen BluePen = new Pen(Color.Blue, 4))
                    {
                        for (int i = 80; i < 180; i = i + 4)
                        {
                            e.Graphics.DrawEllipse(BluePen, 320, i, 149, 75);
                        }
                        using (Pen BlackPen = new Pen(Color.Black, 1))
                        {
                            //Draw Cylinder
                            e.Graphics.DrawEllipse(BlackPen, 320, 60, 150, 75);
                            e.Graphics.DrawEllipse(BlackPen, 320, 178, 150, 75);
                            e.Graphics.DrawLine(BlackPen, 320, 95, 320, 210);
                            e.Graphics.DrawLine(BlackPen, 470, 95, 470, 210);
                            //Draw Measure lines
                            e.Graphics.DrawLine(BlackPen, 315, 110, 280, 110);
                            e.Graphics.DrawLine(BlackPen, 315, 220, 280, 220);
                            //Draw Vertical line
                            e.Graphics.DrawLine(BlackPen, 295, 110, 295, 220);
                            //Upper Arrow
                            e.Graphics.DrawLine(BlackPen, 295, 110, 300, 120);
                            e.Graphics.DrawLine(BlackPen, 295, 110, 290, 120);
                            //Lower Arrow
                            e.Graphics.DrawLine(BlackPen, 295, 220, 290, 210);
                            e.Graphics.DrawLine(BlackPen, 295, 220, 300, 210);
                        }
                        using (SolidBrush blackBrush = new SolidBrush(Color.Blue))
                        {
                            DrawRotatedTextAt(e.Graphics, 270, "Volume :" + numMidPanelNumberOne.Text + "L", 280, 195, TextFont, Brushes.Blue);

                        }
                    }
                    break;
                #endregion Volume Display
                default:
                    break;
            }


        }
        /// <summary>
        /// Method to rotate text 
        /// </summary>
        /// <param name="gr"></param>
        /// <param name="angle"></param>
        /// <param name="txt"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="the_font"></param>
        /// <param name="the_brush"></param>
        private void DrawRotatedTextAt(Graphics gr, float angle, string txt, int x, int y, Font the_font, Brush the_brush)
        {
            // Save the graphics state.
            GraphicsState state = gr.Save();
            gr.ResetTransform();

            // Rotate.
            gr.RotateTransform(angle);

            // Translate to desired position. Be sure to append
            // the rotation so it occurs after the rotation.
            gr.TranslateTransform(x, y, MatrixOrder.Append);

            // Draw the text at the origin.
            gr.DrawString(txt, the_font, the_brush, 0, 0);

            // Restore the graphics state.
            gr.Restore(state);
        }
        #endregion Graphics

        private void LengthCalculation()
        {
            decimal totLenght = decimal.Parse(numMidPanelNumberOne.Text) * decimal.Parse(numMidPanelNumberTwo.Text);
            txtLowerPanelNumOne.Text = string.Format("{0:0.00}", totLenght);
            if (totLenght != 0 && decimal.Parse(txtMiddlePanel.Text, System.Globalization.NumberStyles.Currency) != 0)
            {
                txtLowerPanelNumTwo.ForeColor = System.Drawing.Color.Black;
                decimal pricePMeter = decimal.Parse(txtMiddlePanel.Text, System.Globalization.NumberStyles.Currency) / totLenght;
                txtLowerPanelNumTwo.Text = string.Format("{0:C}", pricePMeter);
            }
            else
            {
                txtLowerPanelNumTwo.ForeColor = System.Drawing.Color.Red;
                txtLowerPanelNumTwo.Text = "INVALID";
            }
            Invalidate();
        }

        private void AreaCalculation()
        {
            decimal totArea = decimal.Parse(numMidPanelNumberOne.Text) * decimal.Parse(numMidPanelNumberTwo.Text);
            txtLowerPanelNumOne.Text = string.Format("{0:0.00}", totArea);
            if (totArea != 0 && decimal.Parse(txtMiddlePanel.Text, System.Globalization.NumberStyles.Currency) != 0)
            {
                txtLowerPanelNumTwo.ForeColor = System.Drawing.Color.Black;
                decimal pricePerSqMeter = decimal.Parse(txtMiddlePanel.Text, System.Globalization.NumberStyles.Currency) / totArea;
                txtLowerPanelNumTwo.Text = string.Format("{0:C}", pricePerSqMeter);
            }
            else
            {
                txtLowerPanelNumTwo.ForeColor = System.Drawing.Color.Red;
                txtLowerPanelNumTwo.Text = "INVALID";
            }
            Invalidate();
        }

        private void VolumeCalcultion()
        {
            decimal totVolCost = decimal.Parse(txtMiddlePanel.Text, System.Globalization.NumberStyles.Currency);
            decimal totVol = decimal.Parse(numMidPanelNumberTwo.Text);
            if (totVolCost != 0 && totVol != 0)
            {
                txtLowerPanelNumOne.ForeColor = System.Drawing.Color.Black;
                decimal pricePerLiter = (1 / totVol);
                pricePerLiter = pricePerLiter * totVolCost;
                txtLowerPanelNumOne.Text = string.Format("{0:C}", pricePerLiter);
            }
            else
            {
                txtLowerPanelNumOne.ForeColor = System.Drawing.Color.Red;
                txtLowerPanelNumOne.Text = "INVALID";
            }
            Invalidate();
        }

        #endregion Methods

        #region Events

        void numMidPanelNumberOneText_KeyPress(Object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && numMidPanelNumberOneText.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        void numMidPanelNumberTwoText_KeyPress(Object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && numMidPanelNumberTwoText.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        void txtMiddlePanelText_KeyPress(Object sender, KeyPressEventArgs e)
            {
            char ch = e.KeyChar;

            if (ch == 46 && txtMiddlePanelText.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        void numMidPanelNumberOneText_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                numMidPanelNumberOne.Text = numMidPanelNumberOneText.Text;
                numMidPanelNumberOneText.Hide();
                numMidPanelNumberOne.Show();
            }
        }

        void numMidPanelNumberTwoText_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                numMidPanelNumberTwo.Text = numMidPanelNumberTwoText.Text;
                numMidPanelNumberTwoText.Hide();
                numMidPanelNumberTwo.Show();
            }
        }

        void txtMiddlePanelText_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMiddlePanel.Text = txtMiddlePanelText.Text;
                txtMiddlePanelText.Hide();
                txtMiddlePanel.Show();
            }
        }

        void numMidPanelNumberOneText_Leave(Object sender, EventArgs e)
        {
            decimal formating;

            switch (CostType)
            {
                case myCostType.Lenght:
                    formating = decimal.Parse(numMidPanelNumberOneText.Text);
                    numMidPanelNumberOneText.Text = string.Format("{0:0.00}", formating);
                    LengthCalculation();
                    break;
                case myCostType.Area:
                    formating = decimal.Parse(numMidPanelNumberOneText.Text);
                    numMidPanelNumberOneText.Text = string.Format("{0:0.00}", formating);
                    AreaCalculation();
                    break;
                case myCostType.Volume:
                    numMidPanelNumberOne.Visible = false;
                    lblMiddlePanelNumOne.Visible = false;
                    break;
                default:
                    break;
            }
      
            numMidPanelNumberOne.Text = numMidPanelNumberOneText.Text;
            numMidPanelNumberOneText.Hide();
            numMidPanelNumberOne.Show();
        }

        void numMidPanelNumberTwoText_Leave(Object sender, EventArgs e)
        {
            decimal formating;
            switch (CostType)
            {
                case myCostType.Lenght:
                    formating = decimal.Parse(numMidPanelNumberTwoText.Text);
                    numMidPanelNumberTwoText.Text = string.Format("{0:0.00}", formating);
                    LengthCalculation();
                    break;
                case myCostType.Area:
                    formating = decimal.Parse(numMidPanelNumberTwoText.Text);
                    numMidPanelNumberTwoText.Text = string.Format("{0:0.00}", formating);
                    AreaCalculation();
                    break;
                case myCostType.Volume:
                    formating = decimal.Parse(numMidPanelNumberTwoText.Text);
                    numMidPanelNumberTwoText.Text = string.Format("{0:0.00}", formating);
                    VolumeCalcultion();
                    break;
                default:
                    break;
            }

            numMidPanelNumberTwo.Text = numMidPanelNumberTwoText.Text;
            numMidPanelNumberTwoText.Hide();
            numMidPanelNumberTwo.Show();
        }

        void txtMiddlePanelText_Leave(Object sender, EventArgs e)
        {
            decimal formating;

            switch (CostType)
            {
                case myCostType.Lenght:
                    formating = decimal.Parse(txtMiddlePanelText.Text);
                    txtMiddlePanelText.Text = string.Format("{0:C}", formating);
                    LengthCalculation();
                    break;
                case myCostType.Area:
                    formating = decimal.Parse(txtMiddlePanelText.Text);
                    txtMiddlePanelText.Text = string.Format("{0:C}", formating);
                    AreaCalculation();
                    break;
                case myCostType.Volume:
                    formating = decimal.Parse(txtMiddlePanelText.Text);
                    txtMiddlePanelText.Text = string.Format("{0:C}", formating);
                    VolumeCalcultion();
                    break;
                default:
                    break;
            }

            txtMiddlePanel.Text = txtMiddlePanelText.Text;
            txtMiddlePanel.Hide();
            txtMiddlePanelText.Show();
        }

        private void numMidPanelNumberOne_DoubleClick(Object sender, EventArgs e)
        {
            this.panel1.Controls.Add(numMidPanelNumberOneText);


            numMidPanelNumberOneText.Size = numMidPanelNumberOne.Size;
            numMidPanelNumberOneText.Location = numMidPanelNumberOne.Location;
            numMidPanelNumberOneText.Text = this.Text;
            numMidPanelNumberOne.Hide();
            numMidPanelNumberOneText.Show();
            numMidPanelNumberOneText.Focus();
        }

        private void numMidPanelNumberTwo_DoubleClick(Object sender, EventArgs e)
        {
            this.panel1.Controls.Add(numMidPanelNumberTwoText);

            numMidPanelNumberTwoText.Size = numMidPanelNumberTwo.Size;
            numMidPanelNumberTwoText.Location = numMidPanelNumberTwo.Location;
            numMidPanelNumberTwoText.Text = numMidPanelNumberTwo.Text;
            numMidPanelNumberTwo.Hide();
            numMidPanelNumberTwoText.Show();
            numMidPanelNumberTwoText.Focus();
        }

        private void txtMiddlePanel_DoubleClick(Object sender, EventArgs e)
        {
            this.panel1.Controls.Add(txtMiddlePanelText);

            txtMiddlePanelText.Size = txtMiddlePanel.Size;
            txtMiddlePanelText.Location = txtMiddlePanel.Location;
            txtMiddlePanelText.Text = txtMiddlePanel.Text;
            txtMiddlePanel.Hide();
            txtMiddlePanelText.Show();
            txtMiddlePanelText.Focus();
        }

        private void btnSave_Click(Object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
            {
                this.ButtonClick(this, e);
            }
        }

        private void cmbMaterial_SelectedIndexChanged(Object sender, EventArgs e)
        {
            if (SelectedIndexChanged != null)
            {
                SelectedIndexChanged(sender, e);
            }
        }

        void MyCombobox_Load(object sender, EventArgs e)
        {
            //TODO REMEMBER TO PUT A SWITCH IN
            switch (CostType)
            {
                case myCostType.Lenght:
                    cmbMaterial.DataSource = d.GetLength();
                    break;
                case myCostType.Area:
                    cmbMaterial.DataSource = d.GetArea();
                    break;
                case myCostType.Volume:
                    cmbMaterial.DataSource = d.GetVolume();
                    break;
                default:
                    break;
            }
        }

        //TODO EditMidOne_Click
        private void EditMidOne_Click(Object sender, EventArgs e)
        {

        }

        private void EditMidTwo_Click(Object sender, EventArgs e)
        {
            //TODO EditMidTwo_Click
        }

        private void EditMidThree_Click(Object sender, EventArgs e)
        {
            //TODO EditMidThree_Click
        }

        #endregion Events

    }
}
