using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{

    public partial class search : Form
    {
        public EventHandler ListBox1_DoubleClick { get; set; }
        public search()


        {
            InitializeComponent();
            
            DirectoryInfo dir = new DirectoryInfo(System.IO.Directory.GetCurrentDirectory());
            FileInfo[] files = dir.GetFiles("*.dat");
            foreach (FileInfo fi in files)
            {
                listBox1.Items.Add(fi.ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void search_Load(object sender, EventArgs e)
        {
            this.listBox1.MouseDoubleClick += new MouseEventHandler(listBox1_MouseDoubleClick);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo(System.IO.Directory.GetCurrentDirectory());
            FileInfo[] files = dir.GetFiles("*"+textBox1.Text+"*.dat");
            foreach (FileInfo fi in files)
            {
                listBox1.Items.Add(fi.ToString());
            }

        }
        void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            string link = System.IO.Directory.GetCurrentDirectory() + "/" + listBox1.SelectedItem.ToString();
            var myfile1 = File.Create(System.IO.Directory.GetCurrentDirectory() + "/temp1.txt");
            myfile1.Close();
            using (StreamWriter writer = new StreamWriter(System.IO.Directory.GetCurrentDirectory() + "/temp1.txt"))
            {
                writer.Write(link);
                writer.Close();
            }

            editing newform = new editing();
            newform.Show();
            Close();
            

        }

        
    }
}
