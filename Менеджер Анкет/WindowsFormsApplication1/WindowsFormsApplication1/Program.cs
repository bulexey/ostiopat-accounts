using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainwindow());
        }
    }
    public class record
    {
        public string name;
        public string bday;
        public string occupation;
        public string adress;
        public string mail;
        public string phone;
        public string symptoms;
        public string history;
        public string treatment;
        public string diagnosis;
        public string chronic;
        public string dates;
        public string requests;
        public string infosource;
    }
}
