
namespace FileExplorer1
{
    partial class NewFileDialog
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
        private void InitializeComponent()
        {
            this.filname_txt = new System.Windows.Forms.TextBox();
            this.labelFileName = new System.Windows.Forms.Label();
            this.ext_txt = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filname_txt
            // 
            this.filname_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filname_txt.Location = new System.Drawing.Point(108, 17);
            this.filname_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filname_txt.Name = "filname_txt";
            this.filname_txt.Size = new System.Drawing.Size(264, 15);
            this.filname_txt.TabIndex = 0;
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(17, 16);
            this.labelFileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(73, 17);
            this.labelFileName.TabIndex = 1;
            this.labelFileName.Text = "File name:";
            // 
            // ext_txt
            // 
            this.ext_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ext_txt.Location = new System.Drawing.Point(376, 17);
            this.ext_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ext_txt.Name = "ext_txt";
            this.ext_txt.Size = new System.Drawing.Size(25, 15);
            this.ext_txt.TabIndex = 2;
            this.ext_txt.Text = ".txt";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(105, 14);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(302, 22);
            this.textBox3.TabIndex = 3;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(416, 12);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(49, 27);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // NewFileDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 52);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.filname_txt);
            this.Controls.Add(this.ext_txt);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.textBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NewFileDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New File";
            this.Load += new System.EventHandler(this.NewFileDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
      

        #endregion

        private System.Windows.Forms.TextBox filname_txt;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.TextBox ext_txt;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonOK;
    }
}