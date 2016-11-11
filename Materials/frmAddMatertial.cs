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

namespace Materials
{
    public partial class frmAddMatertial : Form
    {
        Accessor.MaterialTypes a;
        DataEngine d = new DataEngine();

        public frmAddMatertial()
        {
            InitializeComponent();
            SetDisplay();

        }

        private void SetDisplay()
        {
            cmbMaterialTypes.DataSource = d.GetMaterialTypes();
            a = cmbMaterialTypes.SelectedItem as Accessor.MaterialTypes;
            txtName.Text = "Enter Name";
            txtDescription.Text = "Enter Description";
        }

        private void btnSave_Click(Object sender, EventArgs e)
        {
            Accessor.MaterialProperties m = new Accessor.MaterialProperties();
            switch (MessageBox.Show("Save to Database?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    m.MaterialName = txtName.Text;
                    m.MaterialID = d.GenerateKeyMaterial(m.MaterialName);
                    m.Destcription = txtDescription.Text;
                    a = cmbMaterialTypes.SelectedItem as Accessor.MaterialTypes;
                    m.TypeID = a.TypeID;
                    d.SaveMaterial(m, a.TypeID);
                    MessageBox.Show("Saved Successfully");
                    SetDisplay();
                    break;
                case DialogResult.No:
                    SetDisplay();
                    break;
                default:
                    break;
            }
        }

        private void btnCancel_Click(Object sender, EventArgs e)
        {

        }

        private void cmbMaterialTypes_SelectedIndexChanged(Object sender, EventArgs e)
        {

        }
    }
}
