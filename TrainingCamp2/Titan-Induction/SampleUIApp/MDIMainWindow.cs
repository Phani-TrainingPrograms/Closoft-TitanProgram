using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleUIApp
{
    public partial class MDIMainWindow : Form
    {
        private int childFormNumber = 0;

        public MDIMainWindow()
        {
            InitializeComponent();
        }

        private void addNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Display the MainForm which has the input data
            MainForm frm = new MainForm();//instance of the form
            frm.MdiParent = this;//set the form to be child to the this Window
            frm.Show();//Display the Window.
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutTEAL frm = new AboutTEAL();
            frm.MdiParent = this;
            frm.Show();
        }

        private void findEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayAll frm = new DisplayAll();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
