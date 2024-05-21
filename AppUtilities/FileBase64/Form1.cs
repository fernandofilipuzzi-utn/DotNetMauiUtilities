using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileBase64
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path=openFileDialog1.FileName;
                try
                {
                    byte[] binaryData = File.ReadAllBytes(path);

                    string base64String = Convert.ToBase64String(binaryData);

                    textBox1.Text = base64String;
                }
                finally{ 
                    
                }
            }
        }
    }
}
