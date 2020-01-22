using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextEditer
{
    public partial class TextEditor : Form
    {
        public TextEditor()
        {
            InitializeComponent();
        }

        // テキストを開く処理
        private void 開くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "テキストファイル(*.txt)|*.txt";
            dialog.Title = "開く";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                TextArea.Text = File.ReadAllText(dialog.FileName);
            }
            else
            {
                MessageBox.Show("FileOpenError");
            }

        }
        // テキストを保存する処理
        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "テキストファイル(*.txt)|*.txt";
            dialog.Title = "保存";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dialog.FileName, TextArea.Text);
            }
            else
            {
            }
        }
        // ツールを終了する処理
        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("マルチツールを終了いたします", "終了", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Close();
            }
            else
            {
            }
        }
        // デジタル時計を表示する処理
        private void デジタル時計ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DigitalClockクラスのインスタンスを作成する
            DigitalClock dc = new DigitalClock();

            dc.Show(this);

            //dc.Dispose();
        }

        private void 電卓ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calculator cl = new calculator();
            cl.Show(this);
            //cl.Dispose();
        }
    }
}
