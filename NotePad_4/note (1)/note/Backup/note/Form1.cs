using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace note
{
    public partial class Form1 : Form
    {
        bool saved = false;
        string filepath="";
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (richTextBox1.TextLength > 0)
            {
                //Alert for save changes
                DialogResult d = MessageBox.Show("Do you want to save changes?", "Notepad", MessageBoxButtons.YesNoCancel);
                if (d == DialogResult.Yes)
                {
                    if (saved == false)
                    {
                        SaveFileDialog savefileDlg = new SaveFileDialog();
                        savefileDlg.Filter = "Text Documents(*.txt)|*.txt";
                        if (savefileDlg.ShowDialog() == DialogResult.OK)
                        {
                            filepath = savefileDlg.FileName;
                            richTextBox1.SaveFile(filepath, RichTextBoxStreamType.PlainText);
                            saved = true;
                        }
                    }
                    else
                    {
                        //Editor.SaveFile(filepath, RichTextBoxStreamType.PlainText);
                        richTextBox1.SaveFile(filepath, RichTextBoxStreamType.PlainText);
                    }
                }
                else if (d == DialogResult.No)
                {

                }
                else
                {

                }

            }
            else
            {
                richTextBox1.Clear();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog savefileDlg = new SaveFileDialog();
            savefileDlg.Filter = "Text Documents(*.txt)|*.txt";
            if (savefileDlg.ShowDialog() == DialogResult.OK)
            {
                filepath = savefileDlg.FileName;
               richTextBox1.SaveFile(filepath, RichTextBoxStreamType.PlainText);
                saved = true;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendialog = new OpenFileDialog();
            opendialog.Filter="Text Documents(*.txt)|*.txt";
            if (opendialog.ShowDialog()==DialogResult.OK)
            {
                filepath = opendialog.FileName;
                richTextBox1.LoadFile( filepath, RichTextBoxStreamType.PlainText);
                this.Text = Path.GetFileNameWithoutExtension(filepath) + " - Notepad";
                saved = true;  //so that user appends any text on this on Saving
            }


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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
            cutToolStripMenuItem.Enabled = false;
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
            cutToolStripMenuItem.Enabled = false;
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Findandtreplacement f1 = new Findandtreplacement(richTextBox1);
            f1.Show();

        }

        private void wordwrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wordwrapToolStripMenuItem.Enabled == true)
                richTextBox1.WordWrap = true;
            else
                richTextBox1.WordWrap = false;
            
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.ShowColor = true;
            if (font.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = font.Color;
                richTextBox1.Font = font.Font;
            
            
            }
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = true;
            statusStrip1.Items.Add("Lines " + richTextBox1.Lines.Length);            
        }
        
    }
}
