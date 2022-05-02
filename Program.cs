using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public static partial class Program
    {
        // Form1 lol = new Form1();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
    
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
