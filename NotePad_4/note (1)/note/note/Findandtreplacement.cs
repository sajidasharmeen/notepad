using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace note
{
    public partial class Findandtreplacement : Form
    {
        RichTextBox rich = new RichTextBox();
        public Findandtreplacement(RichTextBox rich )
        {
            InitializeComponent();
            this.rich = rich;
        }

        private void btn_findnext_Click(object sender, EventArgs e)
        {
            if (rich.Text.Contains(txtfind.Text))
            {
                int index = rich.Text.IndexOf(txtfind.Text);
                rich.Select(index, txtfind.Text.Length);

                this.Hide();

            }
            
        }

        private void btn_replace_Click(object sender, EventArgs e)
        {
            if (rich.Text.Contains(txtfind.Text))
            {

                int index = rich.Text.IndexOf(txtfind.Text);

               rich.Select(index, txtfind.Text.Length);

               string sel = rich.SelectedText;

                rich.Text = rich.Text.Replace(sel, txtreplace.Text);
                //rich.Text = rich.SelectedText.Replace(txtfind.Text, txtreplace.Text);
                //FindForm f = new findform(this);
                //f.show();
              
            }
        }

        private void btn_replaceall_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
