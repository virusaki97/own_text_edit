namespace WindowsFormsApplication2
{
     partial class Form1
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
               this.menuStrip1 = new System.Windows.Forms.MenuStrip();
               this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
               this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
               this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
               this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
               this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
               this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.fontToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
               this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
               this.textColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.orangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.fontColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.whiteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
               this.blackToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
               this.richTextBox1 = new System.Windows.Forms.RichTextBox();
               this.menuStrip1.SuspendLayout();
               this.SuspendLayout();
               // 
               // menuStrip1
               // 
               this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
               this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
               this.menuStrip1.Location = new System.Drawing.Point(0, 0);
               this.menuStrip1.Name = "menuStrip1";
               this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
               this.menuStrip1.Size = new System.Drawing.Size(585, 25);
               this.menuStrip1.TabIndex = 0;
               this.menuStrip1.Text = "menuStrip1";
               // 
               // fileToolStripMenuItem
               // 
               this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
               this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
               this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
               this.fileToolStripMenuItem.Text = "&File";
               // 
               // newToolStripMenuItem
               // 
               this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
               this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
               this.newToolStripMenuItem.Name = "newToolStripMenuItem";
               this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
               this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
               this.newToolStripMenuItem.Text = "&New";
               this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
               // 
               // openToolStripMenuItem
               // 
               this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
               this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
               this.openToolStripMenuItem.Name = "openToolStripMenuItem";
               this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
               this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
               this.openToolStripMenuItem.Text = "&Open";
               this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
               // 
               // toolStripSeparator
               // 
               this.toolStripSeparator.Name = "toolStripSeparator";
               this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
               // 
               // saveToolStripMenuItem
               // 
               this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
               this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
               this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
               this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
               this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
               this.saveToolStripMenuItem.Text = "&Save";
               this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
               // 
               // toolStripMenuItem1
               // 
               this.toolStripMenuItem1.Name = "toolStripMenuItem1";
               this.toolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
               this.toolStripMenuItem1.Text = "Save As";
               this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
               // 
               // toolStripSeparator2
               // 
               this.toolStripSeparator2.Name = "toolStripSeparator2";
               this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
               // 
               // exitToolStripMenuItem
               // 
               this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
               this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
               this.exitToolStripMenuItem.Text = "E&xit";
               this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
               // 
               // editToolStripMenuItem
               // 
               this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
               this.editToolStripMenuItem.Name = "editToolStripMenuItem";
               this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 19);
               this.editToolStripMenuItem.Text = "&Edit";
               // 
               // undoToolStripMenuItem
               // 
               this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
               this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
               this.undoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
               this.undoToolStripMenuItem.Text = "&Undo";
               this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
               // 
               // redoToolStripMenuItem
               // 
               this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
               this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
               this.redoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
               this.redoToolStripMenuItem.Text = "&Redo";
               this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
               // 
               // toolStripSeparator3
               // 
               this.toolStripSeparator3.Name = "toolStripSeparator3";
               this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
               // 
               // cutToolStripMenuItem
               // 
               this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
               this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
               this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
               this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
               this.cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
               this.cutToolStripMenuItem.Text = "Cu&t";
               this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
               // 
               // copyToolStripMenuItem
               // 
               this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
               this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
               this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
               this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
               this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
               this.copyToolStripMenuItem.Text = "&Copy";
               this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
               // 
               // pasteToolStripMenuItem
               // 
               this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
               this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
               this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
               this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
               this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
               this.pasteToolStripMenuItem.Text = "&Paste";
               this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
               // 
               // toolStripSeparator4
               // 
               this.toolStripSeparator4.Name = "toolStripSeparator4";
               this.toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
               // 
               // selectAllToolStripMenuItem
               // 
               this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
               this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
               this.selectAllToolStripMenuItem.Text = "Select &All";
               // 
               // viewToolStripMenuItem
               // 
               this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.fontToolStripMenuItem1,
            this.toolStripSeparator1,
            this.textColorToolStripMenuItem,
            this.fontColorToolStripMenuItem});
               this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
               this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
               this.viewToolStripMenuItem.Text = "View";
               // 
               // fontToolStripMenuItem
               // 
               this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
               this.fontToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
               this.fontToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
               this.fontToolStripMenuItem.Text = "Font+";
               this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
               // 
               // fontToolStripMenuItem1
               // 
               this.fontToolStripMenuItem1.Name = "fontToolStripMenuItem1";
               this.fontToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
               this.fontToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
               this.fontToolStripMenuItem1.Text = "Font-";
               this.fontToolStripMenuItem1.Click += new System.EventHandler(this.fontToolStripMenuItem1_Click);
               // 
               // toolStripSeparator1
               // 
               this.toolStripSeparator1.Name = "toolStripSeparator1";
               this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
               // 
               // textColorToolStripMenuItem
               // 
               this.textColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whiteToolStripMenuItem,
            this.blackToolStripMenuItem,
            this.orangeToolStripMenuItem});
               this.textColorToolStripMenuItem.Name = "textColorToolStripMenuItem";
               this.textColorToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
               this.textColorToolStripMenuItem.Text = "Text Color";
               // 
               // whiteToolStripMenuItem
               // 
               this.whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
               this.whiteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
               this.whiteToolStripMenuItem.Text = "White";
               this.whiteToolStripMenuItem.Click += new System.EventHandler(this.whiteToolStripMenuItem_Click);
               // 
               // blackToolStripMenuItem
               // 
               this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
               this.blackToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
               this.blackToolStripMenuItem.Text = "Black";
               this.blackToolStripMenuItem.Click += new System.EventHandler(this.blackToolStripMenuItem_Click);
               // 
               // orangeToolStripMenuItem
               // 
               this.orangeToolStripMenuItem.Name = "orangeToolStripMenuItem";
               this.orangeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
               this.orangeToolStripMenuItem.Text = "Orange";
               this.orangeToolStripMenuItem.Click += new System.EventHandler(this.orangeToolStripMenuItem_Click);
               // 
               // fontColorToolStripMenuItem
               // 
               this.fontColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whiteToolStripMenuItem1,
            this.blackToolStripMenuItem1});
               this.fontColorToolStripMenuItem.Name = "fontColorToolStripMenuItem";
               this.fontColorToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
               this.fontColorToolStripMenuItem.Text = "Font Color";
               // 
               // whiteToolStripMenuItem1
               // 
               this.whiteToolStripMenuItem1.Name = "whiteToolStripMenuItem1";
               this.whiteToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
               this.whiteToolStripMenuItem1.Text = "White";
               this.whiteToolStripMenuItem1.Click += new System.EventHandler(this.whiteToolStripMenuItem1_Click);
               // 
               // blackToolStripMenuItem1
               // 
               this.blackToolStripMenuItem1.Name = "blackToolStripMenuItem1";
               this.blackToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
               this.blackToolStripMenuItem1.Text = "Black";
               this.blackToolStripMenuItem1.Click += new System.EventHandler(this.blackToolStripMenuItem1_Click);
               // 
               // richTextBox1
               // 
               this.richTextBox1.BackColor = System.Drawing.Color.Black;
               this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
               this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
               this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(0)))));
               this.richTextBox1.Location = new System.Drawing.Point(0, 25);
               this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
               this.richTextBox1.Name = "richTextBox1";
               this.richTextBox1.Size = new System.Drawing.Size(585, 406);
               this.richTextBox1.TabIndex = 1;
               this.richTextBox1.Text = "";
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(585, 431);
               this.Controls.Add(this.richTextBox1);
               this.Controls.Add(this.menuStrip1);
               this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
               this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
               this.MainMenuStrip = this.menuStrip1;
               this.Margin = new System.Windows.Forms.Padding(4);
               this.Name = "Form1";
               this.Text = "+TxT";
               this.menuStrip1.ResumeLayout(false);
               this.menuStrip1.PerformLayout();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.MenuStrip menuStrip1;
          private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
          private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
          private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
          private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
          private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
          private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
          private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
          private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
          private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
          private System.Windows.Forms.RichTextBox richTextBox1;
          private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
          private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem1;
          private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
          private System.Windows.Forms.ToolStripMenuItem textColorToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem whiteToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem orangeToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem fontColorToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem whiteToolStripMenuItem1;
          private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem1;
     }
}

