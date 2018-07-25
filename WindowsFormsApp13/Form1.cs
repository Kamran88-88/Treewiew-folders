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

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dialog = folderBrowserDialog1.ShowDialog();

            if (dialog == DialogResult.OK)
            {  
                DirectoryInfo directory = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                treeView1.Nodes.Add(directory.Name);

                foreach (var item in directory.GetDirectories())
                {
                treeView1.Nodes[0].Nodes.Add(item.Name);
                    foreach (var item1 in item.GetDirectories())
                    {
                        treeView1.Nodes[0].Nodes[0].Nodes.Add(item1.Name);
                    }
                }


            }
        }












        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
