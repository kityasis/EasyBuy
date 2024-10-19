using EasyBuy.Forms.Admin;
using EasyBuy.Forms.Cashier;
using System;
using System.Windows.Forms;

namespace EasyBuy
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
