using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
     public partial class Form1 : Form
     {
          static string last = "";
          static int size = 12;
          public Form1()
          {
               InitializeComponent();
          }

          private void newToolStripMenuItem_Click(object sender, EventArgs e)
          {
               richTextBox1.Clear();
          }

          private void exitToolStripMenuItem_Click(object sender, EventArgs e)
          {
               Application.Exit();
          }

          private void openToolStripMenuItem_Click(object sender, EventArgs e)
          {
              
               OpenFileDialog ofd = new OpenFileDialog();
               ofd.Filter = "Text Files (.txt)|*.txt";
               ofd.Title = "Open a file...";
               if (ofd.ShowDialog() == DialogResult.OK)
               {
                    System.IO.StreamReader sr = new System.IO.StreamReader(ofd.FileName);
                    richTextBox1.Text = sr.ReadToEnd();
                    last = ofd.FileName;
                    sr.Close();
               }
          }

          private void saveToolStripMenuItem_Click(object sender, EventArgs e)
          {
               if (last.Length == 0)
               {
                    SaveFileDialog svf = new SaveFileDialog();
                    svf.Filter = "Text Files(.txt)|*.txt";
                    svf.Title = "Save file...";
                    if (svf.ShowDialog() == DialogResult.OK)
                    {
                         string tmp;
                         System.IO.StreamWriter sw = new System.IO.StreamWriter(svf.FileName);
                         tmp = richTextBox1.Text;
                         tmp = richTextBox1.Text.Replace("\n", "\r\n");
                         sw.Write(tmp);
                         sw.Close();
                    }
               }
               else
               {
                    string tmp;
                    System.IO.StreamWriter sw = new System.IO.StreamWriter(last);
                    tmp = richTextBox1.Text;
                    tmp = richTextBox1.Text.Replace("\n", "\r\n");
                    sw.Write(tmp);
                    sw.Close();
               }
          }

          private void undoToolStripMenuItem_Click(object sender, EventArgs e)
          {
               richTextBox1.Undo();
          }

          private void redoToolStripMenuItem_Click(object sender, EventArgs e)
          {
               richTextBox1.Redo();
          }

          private void cutToolStripMenuItem_Click(object sender, EventArgs e)
          {
               richTextBox1.Cut();
          }

          private void copyToolStripMenuItem_Click(object sender, EventArgs e)
          {
               richTextBox1.Copy();
          }

          private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
          {
               richTextBox1.SelectAll();
          }

          private void toolStripMenuItem1_Click(object sender, EventArgs e)
          {
               SaveFileDialog svf = new SaveFileDialog();
               svf.Filter = "Text Files(.txt)|*.txt";
               svf.Title = "Save file...";
               if (svf.ShowDialog() == DialogResult.OK)
               {
                    string tmp;
                    System.IO.StreamWriter sw = new System.IO.StreamWriter(svf.FileName);
                    tmp = richTextBox1.Text;
                    tmp = richTextBox1.Text.Replace("\n", "\r\n");
                    sw.Write(tmp);
                    sw.Close();
               }
          }

          private void fontToolStripMenuItem_Click(object sender, EventArgs e)
          {
               ++size;
               richTextBox1.SelectAll();
               richTextBox1.SelectionFont = new Font("Microsoft Sans Serif", size, FontStyle.Regular);
               richTextBox1.Select(0, 0);
               richTextBox1.SelectionStart = richTextBox1.Text.Length;
               richTextBox1.SelectionLength = 0;
          }

          private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
          {
               --size;
               richTextBox1.SelectAll();
               richTextBox1.SelectionFont = new Font("Microsoft Sans Serif", size, FontStyle.Regular);
               richTextBox1.Select(0, 0);
               richTextBox1.SelectionStart = richTextBox1.Text.Length;
               richTextBox1.SelectionLength = 0;
          }

          private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
          {
               richTextBox1.SelectAll();
               richTextBox1.SelectionColor = System.Drawing.Color.White;
               richTextBox1.SelectionFont = new Font("Microsoft Sans Serif", size, FontStyle.Regular);
               richTextBox1.Select(0, 0);
               richTextBox1.SelectionStart = richTextBox1.Text.Length;
               richTextBox1.SelectionLength = 0;

          }

          private void blackToolStripMenuItem_Click(object sender, EventArgs e)
          {
               richTextBox1.SelectAll();
               richTextBox1.SelectionColor = System.Drawing.Color.Black;
               richTextBox1.SelectionFont = new Font("Microsoft Sans Serif", size, FontStyle.Regular);
               richTextBox1.Select(0, 0);
               richTextBox1.SelectionStart = richTextBox1.Text.Length;
               richTextBox1.SelectionLength = 0;

          }

          private void orangeToolStripMenuItem_Click(object sender, EventArgs e)
          {
               richTextBox1.SelectAll();
               richTextBox1.SelectionColor = System.Drawing.Color.Orange;
               richTextBox1.SelectionFont = new Font("Microsoft Sans Serif", size, FontStyle.Regular);
               richTextBox1.Select(0, 0);
               richTextBox1.SelectionStart = richTextBox1.Text.Length;
               richTextBox1.SelectionLength = 0;
          }

          private void whiteToolStripMenuItem1_Click(object sender, EventArgs e)
          {
               richTextBox1.BackColor = Color.White;
          }

          private void blackToolStripMenuItem1_Click(object sender, EventArgs e)
          {
               richTextBox1.BackColor = Color.Black;
          }
     }
}