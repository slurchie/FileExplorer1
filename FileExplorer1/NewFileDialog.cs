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
using System.Diagnostics;

namespace FileExplorer1
{
    public partial class NewFileDialog : Form
    {
        string ext;
        string dir;
        public NewFileDialog(string ext, string dir)
        {
            InitializeComponent();
            this.ext = ext;
            this.dir = dir;
            if (!string.IsNullOrEmpty(ext))
            {
                ext_txt.TextChanged += ext_txt_TextChanged;
            }
        }
        private void ext_txt_TextChanged(object sender, EventArgs e)
        {
            ext_txt.Text = $".{ext}";
        }

        private void NewFileDialog_Load(object sender, EventArgs e)
        {
            ext_txt.Text = $".{ext}";
            if (ext == "\\")
            {
                Text = "Новая Папка";
                labelFileName.Text = "Имя Папки:";
            }

        }
    }
}
