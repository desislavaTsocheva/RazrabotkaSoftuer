using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextPad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void mnuSaveAs_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "text files|*.txt|word files|*.docx|all files|*.*";
            saveFileDialog1.FilterIndex = 3;
            saveFileDialog1.ShowDialog();
            rtbText.SaveFile(saveFileDialog1.FileName,RichTextBoxStreamType.RichText);
        }
        private void mnuOpen_Click(object sender, EventArgs e)
        {
           openFileDialog1.Filter = "text files|*.txt|word files|*.doc,*docx|all files|*.*";
           openFileDialog1.ShowDialog();
           rtbText.LoadFile(openFileDialog1.FileName,RichTextBoxStreamType.RichText);
        }
    }
}
