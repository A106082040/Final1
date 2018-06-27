using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
                richTextBox1.LoadFile(op.FileName, RichTextBoxStreamType.PlainText);
            this.Text = op.FileName;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "文件檔(*.txt) | *.txt | 所有檔案(*.*) | *.* ";
            if (sv.ShowDialog() == DialogResult.OK)
                richTextBox1.SaveFile(sv.FileName, RichTextBoxStreamType.PlainText);
            this.Text = sv.FileName;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            richTextBox1.Paste();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        string[] s = { "第二失望的", "物理的鳥", "假3D", "離開Unity你什麼都不是", "沒有野心", "玩你的妹", "第一人稱不夠真實", "沒人拉著你" };

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int i = r.Next(0, 8);
            richTextBox1.SelectionLength = 0;
            richTextBox1.SelectedText = s[i];
            richTextBox1.Focus();
        }
    }
}
