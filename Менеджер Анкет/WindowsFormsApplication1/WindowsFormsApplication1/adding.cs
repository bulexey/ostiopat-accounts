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
    public partial class adding : Form
    {

        public adding()
        {
            InitializeComponent();
           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Вы не заполнили ФИО");
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Вы не заполнили дату рождения");
                return;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Вы не заполнили род деятельности");
                return;
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("Вы не заполнили адрес");
                return;
            }
            
            if (textBox6.Text == "")
            {
                MessageBox.Show("Вы не заполнили телефон");
                return;
            }
            if (textBox7.Text == "")
            {
                MessageBox.Show("Вы не заполнили симптомы");
                return;
            }
            if (textBox8.Text == "")
            {
                MessageBox.Show("Вы не заполнили историю заболевания");
                return;
            }
            if (textBox9.Text == "")
            {
                MessageBox.Show("Вы не заполнили историю лечения");
                return;
            }
            if (textBox10.Text == "")
            {
                MessageBox.Show("Вы не заполнили диагноз");
                return;
            }
            if (textBox11.Text.Trim() == "")
            {
                MessageBox.Show("Вы не заполнили хронические заболевания. Если их нет, введите это вручную.");
                return;
            }
            if (textBox12.Text == "")
            {
                MessageBox.Show("Вы не заполнили желаемые даты приёма");
                return;
            }

            if (textBox14.Text == "")
            {
                MessageBox.Show("Вы не заполнили, откуда клиент узнал о Вас");
                return;
            }


            string filename = textBox1.Text.Trim()+".dat";
            var myfile = File.Create(System.IO.Directory.GetCurrentDirectory() + "/" + filename);
            myfile.Close();
            var writer = new BinaryWriter(File.Open(System.IO.Directory.GetCurrentDirectory() + "/" + filename, FileMode.OpenOrCreate));
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
            writer.Write(textBox14.Text.Trim());
            writer.Close();
            

            Close();
           
            
            
        }

        private void adding_Load(object sender, EventArgs e)
        {

        }
    }
}
