namespace note
{
    partial class Findandtreplacement
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfind = new System.Windows.Forms.TextBox();
            this.txtreplace = new System.Windows.Forms.TextBox();
            this.btn_findnext = new System.Windows.Forms.Button();
            this.btn_replace = new System.Windows.Forms.Button();
            this.btn_replaceall = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find What";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Replace With";
            // 
            // txtfind
            // 
            this.txtfind.Location = new System.Drawing.Point(110, 10);
            this.txtfind.Name = "txtfind";
            this.txtfind.Size = new System.Drawing.Size(181, 20);
            this.txtfind.TabIndex = 2;
            // 
            // txtreplace
            // 
            this.txtreplace.Location = new System.Drawing.Point(110, 47);
            this.txtreplace.Name = "txtreplace";
            this.txtreplace.Size = new System.Drawing.Size(181, 20);
            this.txtreplace.TabIndex = 3;
            // 
            // btn_findnext
            // 
            this.btn_findnext.Location = new System.Drawing.Point(412, 10);
            this.btn_findnext.Name = "btn_findnext";
            this.btn_findnext.Size = new System.Drawing.Size(75, 23);
            this.btn_findnext.TabIndex = 4;
            this.btn_findnext.Text = "Find Next";
            this.btn_findnext.UseVisualStyleBackColor = true;
            this.btn_findnext.Click += new System.EventHandler(this.btn_findnext_Click);
            // 
            // btn_replace
            // 
            this.btn_replace.Location = new System.Drawing.Point(412, 40);
            this.btn_replace.Name = "btn_replace";
            this.btn_replace.Size = new System.Drawing.Size(75, 23);
            this.btn_replace.TabIndex = 5;
            this.btn_replace.Text = "Replace";
            this.btn_replace.UseVisualStyleBackColor = true;
            this.btn_replace.Click += new System.EventHandler(this.btn_replace_Click);
            // 
            // btn_replaceall
            // 
            this.btn_replaceall.Location = new System.Drawing.Point(412, 69);
            this.btn_replaceall.Name = "btn_replaceall";
            this.btn_replaceall.Size = new System.Drawing.Size(75, 23);
            this.btn_replaceall.TabIndex = 6;
            this.btn_replaceall.Text = "Replace All";
            this.btn_replaceall.UseVisualStyleBackColor = true;
            this.btn_replaceall.Click += new System.EventHandler(this.btn_replaceall_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(412, 98);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(16, 113);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Match Case";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Findandtreplacement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(603, 172);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_replaceall);
            this.Controls.Add(this.btn_replace);
            this.Controls.Add(this.btn_findnext);
            this.Controls.Add(this.txtreplace);
            this.Controls.Add(this.txtfind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Findandtreplacement";
            this.Text = "Findandtreplacement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfind;
        private System.Windows.Forms.TextBox txtreplace;
        private System.Windows.Forms.Button btn_findnext;
        private System.Windows.Forms.Button btn_replace;
        private System.Windows.Forms.Button btn_replaceall;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}