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
namespace kopyalama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string kdosya = "";
        string kdosyaismi="";
        string ydosya = "";

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
           
            openFileDialog1.Title = "Kopyalanacak dosyayı seçin.";
            openFileDialog1.FileName = "";
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                kdosyaismi= openFileDialog1.SafeFileName.ToString();
                kdosya = openFileDialog1.FileName.ToString();
                textBox1.Text = kdosya;
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                ydosya = folderBrowserDialog1.SelectedPath.ToString();
                textBox2.Text = ydosya;
            }
            
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            File.Copy(kdosya, ydosya + "\\" + kdosyaismi);
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            kopyalananlar.Items.Add(kdosya);


            progressBar1.Minimum = 0;
                progressBar1.Maximum = kdosya.Length;
                progressBar1.Value = kdosya.Length;
            
            
        }
    }
}
