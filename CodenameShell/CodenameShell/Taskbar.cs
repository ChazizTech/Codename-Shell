using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        {
            Point btnPosition = PointToScreen(this.start.Location);

            Point startPoint = new Point(btnPosition.X, btnPosition.Y + this.start.Height);

            this.contextMenuStrip1.Show(startPoint);
        }
    }
}
