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
    public partial class LengthControl : GenericCostingControl
    {
        #region Properties
        DataEngine d = new DataEngine();
        Accessor.LengthAccess l;
        int costID;
        #endregion Properties

        #region Constructor
        public LengthControl()
        {
            InitializeComponent();

            this.CostType = myCostType.Lenght;
            CmbMat.SelectedIndexChanged += new EventHandler(CmbMat_SelectedIndexChanged);
            CmbMat.DataSource = d.GetLength();
            ButtonClick += new EventHandler(LengthControl_ButtonClick);

            SetDisplay();
        }
        #endregion Contructor

        #region Events
        private void CmbMat_SelectedIndexChanged(object sender, EventArgs e)
        {
            l = CmbMat.SelectedItem as Accessor.LengthAccess;
            SetDisplay();
        }
        protected void LengthControl_ButtonClick(object sender, EventArgs e)
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

        #region Methods
        private void SetDisplay()
        {
            l = new Accessor.LengthAccess();
            l = CmbMat.SelectedItem as Accessor.LengthAccess;
            costID = l.LengthCostID;
            Descriptiontxt.Text = l.Description;
            MaterialIDtxt.Text = l.MaterialID;
            //Middel pane
            MiddlePanelNumOnelbl.Text = "Number of Pieces";
            MiddlePanelNumTwolbl.Text = "Length Per Piece(Meters";
            MiddlePanelNumThreelbl.Text = "Cost of all Pieces";

           string numPieces = string.Format("{0:0.00}", l.NumPieces);
            NumMidPanelNumOne.Text = numPieces;

            string lenghtPerPiece = string.Format("{0:0.00}", l.LengthPerPiece);
            NumMidPanelNumTwo.Text = lenghtPerPiece;

            string costAllPieces = string.Format("{0:C}", l.TotalCost);
            MiddlePaneltxt.Text = costAllPieces;

            //Lower pane
            LowerPanelNumOnelbl.Text = "Total Length";
            LowerPanelNumTwolbl.Text = "Price per Meter";

            string totLength = string.Format("{0:0.00}", l.TotalLength);
            LowerPanelNumOnetxt.Text = totLength;

            string pricePerM = string.Format("{0:C}", l.PricePerMeter);
            LowerPanelNumTwotxt.Text = pricePerM;

        }
        private void ApplyEdit()
        {
            l = new Accessor.LengthAccess();
            l.MaterialID = MaterialIDtxt.Text;
            l.NumPieces = Convert.ToDecimal(NumMidPanelNumOne.Text);
            l.TotalLength = Convert.ToDecimal(NumMidPanelNumTwo.Text);
            l.TotalCost = decimal.Parse(MiddlePaneltxt.Text, System.Globalization.NumberStyles.Currency);
            l.LengthPerPiece = decimal.Parse(LowerPanelNumOnetxt.Text);
            l.PricePerMeter = decimal.Parse(LowerPanelNumTwotxt.Text, System.Globalization.NumberStyles.Currency);

            d.SaveLength(costID, l);
            CmbMat.DataSource = d.GetLength();
        }

        #endregion Methods

    }
}
