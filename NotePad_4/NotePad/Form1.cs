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
using System.Drawing.Printing;

namespace NotePad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool saved = false;
        string filepath = "";
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fd.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = cd.Color;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save As";
            sfd.Filter = "Rich Text | *.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(sfd.FileName);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open";
            ofd.Filter = "Text Files | *.txt";
            ofd.FileName = String.Empty;    //No Initial File Selected//
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Stream fs;
                fs = ofd.OpenFile();
                StreamReader reader = new StreamReader(fs);
                richTextBox1.Text = reader.ReadToEnd();
                reader.Close();
            
                //richTextBox1.LoadFile(ofd.FileName);
            }
        }

        private void wrodWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wrodWrapToolStripMenuItem.Checked == true)
            {
                richTextBox1.WordWrap = true;
            }
            else
            {
                richTextBox1.WordWrap = false;
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog pdi = new PrintDialog();
            PrintDocument pdo = new PrintDocument();
            pdi.Document = pdo;
            if (pdi.ShowDialog() == DialogResult.OK)
            {
                pdo.Print();
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                richTextBox1.SelectAll();
            }
            else
            {
                MessageBox.Show("Nothing To Select");
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Save As";
                sfd.Filter = "Rich Text | *.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SaveFile(sfd.FileName);
                }
                richTextBox1.Clear();
              //  sfd.ShowDialog();
            }
           

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (saved == false)
            {
                SaveFileDialog Sav_Dlg = new SaveFileDialog();
                Sav_Dlg.DefaultExt = "txt";
                if (Sav_Dlg.ShowDialog() == DialogResult.OK)
                {
                    filepath = Sav_Dlg.FileName;
                    richTextBox1.SaveFile(filepath, RichTextBoxStreamType.PlainText);
                    saved = true;
                    this.Text = Path.GetFileNameWithoutExtension(filepath) + " - Notepad";
                }
            }
            else
            {
                richTextBox1.SaveFile(filepath, RichTextBoxStreamType.PlainText);
            }
   



        }

            
          
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
