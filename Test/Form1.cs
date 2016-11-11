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
using System.Configuration;
using UserControls;

namespace Test
{
    public partial class Form1 : Form
    {
        DataEngine d = new DataEngine();
        Accessor.AtlanticCanvasLenght l;
        List<Accessor.AtlanticCanvasLenght> atl = DataEngine.GetAtlanticLength(1);

        public Form1()
        {
            InitializeComponent();
            genericAtlanticCostingControl2.FrameType = GenericAtlanticCostingControl.myFrameType.SquareTwoFifty;
            genericAtlanticCostingControl1.MaterialID = "";
            comboBox1.DataSource = atl;
            string canvas = ConfigurationManager.AppSettings["CanvasOverlap"];
            MessageBox.Show(canvas);


        }

        private void comboBox1_SelectedIndexChanged(Object sender, EventArgs e)
        {
            l = new Accessor.AtlanticCanvasLenght();
            l = comboBox1.SelectedItem as Accessor.AtlanticCanvasLenght;
        }

        private void comboBox1_SelectionChangeCommitted(Object sender, EventArgs e)
        {
            
            l = new Accessor.AtlanticCanvasLenght();
            l = comboBox1.SelectedItem as Accessor.AtlanticCanvasLenght;
            genericAtlanticCostingControl2.MaterialID = l.MaterialID;
            genericAtlanticCostingControl2.SetDisplay(); 
        }
    }
}
