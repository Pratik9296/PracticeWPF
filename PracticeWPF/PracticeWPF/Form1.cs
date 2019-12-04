using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PracticeWPF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "XMl Document (.xml) |*.xml";
            file.InitialDirectory = @"C:\Users\S\Desktop\documents";
            if (file.ShowDialog() == DialogResult.OK)
            {
                var selectedFilePath = file.FileName;
                textBox1.Text = selectedFilePath;
                XDocument xDoc = XDocument.Load(selectedFilePath);
                var nodeNames = xDoc.Root.Descendants().Where(x => (!x.HasElements)).Select(x => x.Name).Distinct();
            }
        }
    }
}
