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
    public partial class VolumeControl : GenericCostingControl
    {
        #region Properties
        DataEngine d = new DataEngine();
        Accessor.VolumeAccess l;
        int costID;
        #endregion Properties

        #region Constructor
        public VolumeControl()
        {
            InitializeComponent();
            this.CostType = myCostType.Volume;
            CmbMat.SelectedIndexChanged += new EventHandler(CmbMat_SelectedIndexChanged);
            CmbMat.DataSource = d.GetVolume();
            ButtonClick += new EventHandler(VolumeControl_ButtonClick);

            SetDisplay();
        }
        #endregion Constructor

        #region Methods
        private void SetDisplay()
        {
            l = new Accessor.VolumeAccess();
            l = CmbMat.SelectedItem as Accessor.VolumeAccess;
            costID = l.VolumeCostID;
            Descriptiontxt.Text = l.Description;
            MaterialIDtxt.Text = l.MaterialID;
            //Middel pane
            MiddlePanelNumTwolbl.Text = "Total Volume";
            MiddlePaneltxt.Text = "Total Cost";
            MiddlePanelNumOnelbl.Visible = false;
            MiddlePanelNumOnelbl.Visible = false;

            string totVolume = string.Format("{0:0.00}", l.TotalVolume);
            NumMidPanelNumTwo.Text = totVolume;

            string totCost = string.Format("{0:C}", l.TotalCost);
            MiddlePaneltxt.Text = totCost;

            //Lower pane


            LowerPanelNumTwolbl.Visible = false;
            LowerPanelNumTwotxt.Visible = false;
            LowerPanelNumOnelbl.Text = "Price per Liter";

            string pricePerM = string.Format("{0:C}", l.PricePerLitre);
            LowerPanelNumOnetxt.Text = pricePerM;

        }

        private void ApplyEdit()
        {
            //TODO Check if the value is not INVALID
            l = new Accessor.VolumeAccess();
            l.MaterialID = MaterialIDtxt.Text;
            l.TotalVolume = Convert.ToDecimal(NumMidPanelNumTwo.Text);
            l.TotalCost = decimal.Parse(MiddlePaneltxt.Text, System.Globalization.NumberStyles.Currency);
            l.PricePerLitre = decimal.Parse(LowerPanelNumOnetxt.Text, System.Globalization.NumberStyles.Currency);

            d.SaveVolume(costID, l);
            CmbMat.DataSource = d.GetVolume();
        }

        #endregion Methods

        #region Events
        private void CmbMat_SelectedIndexChanged(object sender, EventArgs e)
        {
            l = CmbMat.SelectedItem as Accessor.VolumeAccess;
            SetDisplay();
        }
        protected void VolumeControl_ButtonClick(object sender, EventArgs e)
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
