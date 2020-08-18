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
    public partial class editing : Form
    {
        public editing()
        {
            InitializeComponent();

            var readerStreamNameReader = new StreamReader("./temp1.txt");
            var readerStreamName = readerStreamNameReader.ReadToEnd();
            var reader = new BinaryReader(File.Open(readerStreamName, FileMode.Open));

            record rec = new record();

            while (reader.PeekChar() > -1)
            {
                nametag.Text = reader.ReadString();
                textBox1.Text = reader.ReadString();
                textBox2.Text = reader.ReadString();
                textBox3.Text = reader.ReadString();
                textBox4.Text = reader.ReadString();
                textBox5.Text = reader.ReadString();
                textBox6.Text = reader.ReadString();
                textBox7.Text = reader.ReadString();
                textBox8.Text = reader.ReadString();
                textBox9.Text = reader.ReadString();
                textBox10.Text = reader.ReadString();
                textBox11.Text = reader.ReadString();
                textBox12.Text = reader.ReadString();
                textBox13.Text = reader.ReadString();
            }

            reader.Close();
            readerStreamNameReader.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "Удалить запись?";
            string caption = "Удаление записи";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                StreamReader reader = new StreamReader("temp1.txt");
                File.Delete(reader.ReadToEnd());                
                search newform = new search();
                newform.Show();
                this.Close();
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename = nametag.Text.Trim() + ".dat";
            var myfile = File.Create(System.IO.Directory.GetCurrentDirectory() + "/" + filename);
            myfile.Close();
            var writer = new BinaryWriter(File.Open(System.IO.Directory.GetCurrentDirectory() + "/" + filename, FileMode.OpenOrCreate));
            writer.Write(nametag.Text.Trim());
            writer.Write(textBox1.Text.Trim());
            writer.Write(textBox2.Text.Trim());
            writer.Write(textBox3.Text.Trim());
            writer.Write(textBox4.Text.Trim());
            writer.Write(textBox5.Text.Trim());
            writer.Write(textBox6.Text.Trim());
            writer.Write(textBox7.Text.Trim());
            writer.Write(textBox8.Text.Trim());
            writer.Write(textBox9.Text.Trim());
            writer.Write(textBox10.Text.Trim());
            writer.Write(textBox11.Text.Trim());
            writer.Write(textBox12.Text.Trim());
            writer.Write(textBox13.Text.Trim());            
            writer.Close();
            search newform = new search();
            newform.Show();
            Close();
        }
        
    }
}
