using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frontEndNum
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            
         
            Console.ReadLine();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InterfazNumeros());
        }
    }
}
