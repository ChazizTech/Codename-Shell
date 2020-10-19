namespace CodenameShell
{
    partial class Shell
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.start = new System.Windows.Forms.Button();
            this.startMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.programsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertProgramsHereLaterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskbarRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.taskManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shutdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.startMenu.SuspendLayout();
            this.taskbarRightClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Transparent;
            this.start.Location = new System.Drawing.Point(3, 3);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(51, 28);
            this.start.TabIndex = 0;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.Start_Click);
            // 
            // startMenu
            // 
            this.startMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programsToolStripMenuItem,
            this.toolStripSeparator1,
            this.runToolStripMenuItem,
            this.shutdownToolStripMenuItem,
            this.toolStripMenuItem2});
            this.startMenu.Name = "contextMenuStrip1";
            this.startMenu.Size = new System.Drawing.Size(181, 120);
            // 
            // programsToolStripMenuItem
            // 
            this.programsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertProgramsHereLaterToolStripMenuItem});
            this.programsToolStripMenuItem.Name = "programsToolStripMenuItem";
            this.programsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.programsToolStripMenuItem.Text = "&Programs";
            this.programsToolStripMenuItem.Click += new System.EventHandler(this.ProgramsToolStripMenuItem_Click);
            // 
            // insertProgramsHereLaterToolStripMenuItem
            // 
            this.insertProgramsHereLaterToolStripMenuItem.DropDown = this.taskbarRightClick;
            this.insertProgramsHereLaterToolStripMenuItem.Enabled = false;
            this.insertProgramsHereLaterToolStripMenuItem.Name = "insertProgramsHereLaterToolStripMenuItem";
            this.insertProgramsHereLaterToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.insertProgramsHereLaterToolStripMenuItem.Text = "*insert programs here later*";
            this.insertProgramsHereLaterToolStripMenuItem.Paint += new System.Windows.Forms.PaintEventHandler(this.InsertProgramsHereLaterToolStripMenuItem_Paint);
            // 
            // taskbarRightClick
            // 
            this.taskbarRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taskManagerToolStripMenuItem});
            this.taskbarRightClick.Name = "taskbarRightClick";
            this.taskbarRightClick.OwnerItem = this.insertProgramsHereLaterToolStripMenuItem;
            this.taskbarRightClick.Size = new System.Drawing.Size(149, 26);
            // 
            // taskManagerToolStripMenuItem
            // 
            this.taskManagerToolStripMenuItem.Name = "taskManagerToolStripMenuItem";
            this.taskManagerToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.taskManagerToolStripMenuItem.Text = "Task Manager";
            this.taskManagerToolStripMenuItem.Click += new System.EventHandler(this.TaskManagerToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.runToolStripMenuItem.Text = "&Run";
            // 
            // shutdownToolStripMenuItem
            // 
            this.shutdownToolStripMenuItem.Name = "shutdownToolStripMenuItem";
            this.shutdownToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.shutdownToolStripMenuItem.Text = "&Shutdown";
            this.shutdownToolStripMenuItem.Click += new System.EventHandler(this.shutdownToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = " ";
            // 
            // Shell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 34);
            this.ContextMenuStrip = this.taskbarRightClick;
            this.Controls.Add(this.start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Shell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Taskbar";
            this.startMenu.ResumeLayout(false);
            this.taskbarRightClick.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.ContextMenuStrip startMenu;
        private System.Windows.Forms.ToolStripMenuItem programsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertProgramsHereLaterToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip taskbarRightClick;
        private System.Windows.Forms.ToolStripMenuItem taskManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shutdownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

