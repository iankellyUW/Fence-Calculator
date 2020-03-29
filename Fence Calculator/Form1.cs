using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fence_Calculator
{
    
    public partial class Form1 : Form
    {
        FenceCalculator fence;
        public Form1()
        {
            InitializeComponent();
            fence = new FenceCalculator();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if(aCustom.Value != 0)
            {
                aExact.Checked = false;
                aTen.Checked = false;
                fence.setTen(false);
                fence.setExtra((int)aCustom.Value);
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            fence.setFenceLength((int)fLen.Value);
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pDist_ValueChanged(object sender, EventArgs e)
        {
            fence.setPostDistance((int)pDist.Value);
        }

        private void aButton_Click(object sender, EventArgs e)
        {
            double extraMaterials = 1.0;

            fence.calculate();
            tPost.Text = fence.getNumberPosts().ToString();
            nRails.Text = fence.getNumberRails().ToString();
            tSect.Text = fence.getNumberSections().ToString();
            nPicket.Text = fence.getNumberPickets().ToString();

            if(fence.getTen() == true)
            {
                extraMaterials += 0.1;
            } else if (fence.getExtra() != 0)
            {
                extraMaterials += (double)fence.getExtra() / 100;
            }

            fCane.Text  = (fence.getCaneBolts()).ToString();
            fHinge.Text = (fence.getHinges()).ToString();
            fLatch.Text = (fence.getLatches()).ToString();
            fPick.Text  = ((int)Math.Round((double)fence.getNumberPickets() * extraMaterials)).ToString();
            fPost.Text  = ((int)Math.Round((double)fence.getNumberPosts() * extraMaterials)).ToString();
            fRail.Text  = ((int)Math.Round((double)fence.getNumberRails() * extraMaterials)).ToString();
            fSect.Text  = (fence.getNumberSections()).ToString();
        }

        private void tPost_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pWidth_ValueChanged(object sender, EventArgs e)
        {
            fence.setPicketWidth((int)pWidth.Value);
            wInch.Text = ((double)pWidth.Value / 8).ToString() + '"';
        }

        private void pSpace_ValueChanged(object sender, EventArgs e)
        {
            fence.setPicketSpace((int)pSpace.Value);
            sInch.Text = ((double)pSpace.Value / 8).ToString() + '"';
        }

        private void sRails_ValueChanged(object sender, EventArgs e)
        {
            fence.setRails((int)sRails.Value);
        }

        private void n3Gate_ValueChanged(object sender, EventArgs e)
        {
            fence.set3Gates((int)n3Gate.Value);
        }

        private void n8Gate_ValueChanged(object sender, EventArgs e)
        {
            fence.set8Gates((int)n8Gate.Value);
        }

        private void aExact_CheckedChanged(object sender, EventArgs e)
        {
            aCustom.Value = 0;
            fence.setTen(false);
            fence.setExtra(0);
        }

        private void aTen_CheckedChanged(object sender, EventArgs e)
        {
            aCustom.Value = 0;
            fence.setTen(true);
            fence.setExtra(0);
        }
    }
}
