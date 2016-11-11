using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engines;

namespace Costing_Engine
{

    public partial class frmCosting : Form
    {
        int costID;

        DataEngine d = new DataEngine();
        Accessor.BussinessCost l;

        public frmCosting()
        {
            InitializeComponent();
            cmbMaterial.DataSource = d.GetBusCost();
            l = new Accessor.BussinessCost();
            l = cmbMaterial.SelectedItem as Accessor.BussinessCost;
            txtDescription.Text = l.Description;
            costID = l.BussinessCostID;
            txtMaterialID.Text = l.MaterialID;
            string numPieces = string.Format("{0:C}", l.RatePerHour);
            maskedEditableLabelControl1.Text = numPieces;
        }

        private void btnSave_Click(Object sender, EventArgs e)
        {

            switch (MessageBox.Show("Save to Database?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    l = new Accessor.BussinessCost();
                    l.BussinessCostID = costID;
                    l.RatePerHour = decimal.Parse(maskedEditableLabelControl1.Text, System.Globalization.NumberStyles.Currency); ;
                    d.SaveBussinessCost(costID,l);
                    MessageBox.Show("Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    cmbMaterial.DataSource = d.GetBusCost();
                    //SetDisplay(false);
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;

            }
        }

        private void cmbMaterial_SelectedIndexChanged(Object sender, EventArgs e)
        {
            l = new Accessor.BussinessCost();
            l = cmbMaterial.SelectedItem as Accessor.BussinessCost;
            txtDescription.Text = l.Description;
            txtMaterialID.Text = l.MaterialID;
            costID = l.BussinessCostID;
            string numPieces = string.Format("{0:C}", l.RatePerHour);
            maskedEditableLabelControl1.Text = numPieces;
            //TODO FINISH bussiness COSt save and format
        }
    }
}
