using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engines;

namespace UserControls
{
    public partial class AreaControl : GenericCostingControl
    {
        #region Properties
        DataEngine d = new DataEngine();
        Accessor.AreaAccess a;
        int costID;
        #endregion Properties

        #region Constructor
        public AreaControl()
        {
            InitializeComponent();
            this.CostType = myCostType.Area;
            CmbMat.SelectedIndexChanged += new EventHandler(CmbMat_SelectedIndexChanged);
            CmbMat.DataSource = d.GetArea();
            ButtonClick += new EventHandler(areaControl_ButtonClick);

            SetDisplay();
        }
        #endregion Constructor

        #region Methods
        private void SetDisplay()
        {
            a = new Accessor.AreaAccess();
            a = CmbMat.SelectedItem as Accessor.AreaAccess;
            costID = a.AreaCostID;
            Descriptiontxt.Text = a.Description;
            MaterialIDtxt.Text = a.MaterialID;
            //Middel pane
            MiddlePanelNumOnelbl.Text = "Total Lenght";
            MiddlePanelNumTwolbl.Text = "Total Width";
            MiddlePanelNumThreelbl.Text = "Total Cost";

            string totL = string.Format("{0:0.00}", a.TotalLenght);
            NumMidPanelNumOne.Text = totL;

            string totW = string.Format("{0:0.00}", a.TotalWidth);
            NumMidPanelNumTwo.Text = totW;

            string totC = string.Format("{0:C}", a.TotalCost);
            MiddlePaneltxt.Text = totC;

            //Lower pane
            LowerPanelNumOnelbl.Text = "Total Area";
            LowerPanelNumTwolbl.Text = "Price per Square Meter";

            string totArea = string.Format("{0:0.00}", a.TotalArea);
            LowerPanelNumOnetxt.Text = totArea;

            string pricePerSQM = string.Format("{0:C}", a.PricePSqrMeter);
            LowerPanelNumTwotxt.Text = pricePerSQM;
        }

        private void ApplyEdit()
        {
            a = new Accessor.AreaAccess();
            a.MaterialID = MaterialIDtxt.Text;
            a.TotalLenght = Convert.ToDecimal(NumMidPanelNumOne.Text);
            a.TotalWidth = Convert.ToDecimal(NumMidPanelNumTwo.Text);
            a.TotalCost = decimal.Parse(MiddlePaneltxt.Text, System.Globalization.NumberStyles.Currency);
            a.TotalArea = Convert.ToDecimal(LowerPanelNumOnetxt.Text);
            a.PricePSqrMeter = decimal.Parse(LowerPanelNumTwotxt.Text, System.Globalization.NumberStyles.Currency);

            d.SaveArea(costID, a);
            CmbMat.DataSource = d.GetArea();

        }

        #endregion Methods

        #region Events
        private void CmbMat_SelectedIndexChanged(object sender, EventArgs e)
        {
            a = CmbMat.SelectedItem as Accessor.AreaAccess;
            SetDisplay();
        }
        protected void areaControl_ButtonClick(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Save to Database?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    ApplyEdit();
                    MessageBox.Show("Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //SetDisplay(false);
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
        }

        #endregion Events


    }
}
