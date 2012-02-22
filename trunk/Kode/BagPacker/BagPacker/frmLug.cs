using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BagPacker
{
    public partial class frmLug : Form
    {
        public frmLug()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Initilize the comboboxes
            cboLugDistUnit.Items.Add("cm");
            cboLugDistUnit.Items.Add("inch");
            cboLugDistUnit.SelectedIndex = 0;
            cboLugWeightUnit.Items.Add("kg");
            cboLugWeightUnit.Items.Add("pounds");
            cboLugWeightUnit.SelectedIndex = 0;
        }

        private void cboLugDistUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Change label to the selected value
            lblLugDistUnit1.Text = cboLugDistUnit.SelectedItem.ToString();
            lblLugDistUnit2.Text = cboLugDistUnit.SelectedItem.ToString();
            lblLugDistUnit3.Text = cboLugDistUnit.SelectedItem.ToString();
        }

        private void btnInfoSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLugName.Text) || string.IsNullOrWhiteSpace(txtLugDepth.Text) || string.IsNullOrWhiteSpace(txtLugHeigth.Text) || string.IsNullOrWhiteSpace(txtLugWeigth.Text) || string.IsNullOrWhiteSpace(txtLugWidth.Text))
            {
                MessageBox.Show("An error has happend. You haven't type all the needed informations.", "Not all information is typed. The changes are not saved.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

            }
        }

        
    }
}
