using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics; //<--- for "Process Start"
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CodenameShell
{
    public partial class Shell : Form
    {
        public Shell()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        { //that felling when it doesn't give any errors :D
            Point btnPosition = PointToScreen(this.start.Location);
            Point startPoint = new Point(btnPosition.X, btnPosition.Y + this.start.Height);
            this.startMenu.Show(startPoint);
        }

        private void TaskManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("taskmgr.exe");
        }

        private void ProgramsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.GetFolderPath(Environment.SpecialFolder.StartMenu);
        }

        private void InsertProgramsHereLaterToolStripMenuItem_Paint(object sender, PaintEventArgs e)
        {
            Environment.GetFolderPath(Environment.SpecialFolder.StartMenu);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void taskManagerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start("taskmgr.exe");
        }

        private void shutdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shell shutdownPrompt = new.shutdownPrompt;
            shutdownPrompt.Show();
        }
    }
}
