
using Flowers;
using System;
using System.Windows.Forms;


namespace MDIandSDI
{
    public partial class FormMDI : Form
    {
        public FormMDI()
        {
            InitializeComponent();
        }

        private static int childIndex = 0;

        private void RefreshForm()
        {
            //do something
        }
        private void newSDIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFlowerMaker optionsForm = new FormFlowerMaker();
            optionsForm.FormClosed += (s, args) => RefreshForm();
            optionsForm.Show();
        }

        private void newMDIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childIndex++;
            FormFlowerMaker newChild = new FormFlowerMaker();
            newChild.MdiParent = this;
            newChild.Show();
            toolStripStatusLabel1.Text = "Next Child Index: " + childIndex;


        }

        private void closeMDIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFlowerMaker activeForm = (FormFlowerMaker)this.ActiveMdiChild;
            if (activeForm != null) activeForm.Close();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void vTileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void hTileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("V.5.200001\nArsenii Anastasia\n15.12.22", "Application Version 2.12");
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
        bool showToolBar = true;
        bool showStatusBar = true;
        private void toolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (showToolBar == true)
            {
                showToolBar = false;
                this.toolStrip1.Hide();
            }
            else
            {
                showToolBar = true;
                this.toolStrip1.Show();
            }
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (showStatusBar == true)
            {
                showStatusBar = false;
                this.statusStrip1.Hide();
            }
            else
            {
                showStatusBar = true;
                this.statusStrip1.Show();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Last window Index was " + childIndex);
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
          
        }

    }
}
