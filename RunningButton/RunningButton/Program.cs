using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunningButton
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
            Application.Run(new Form1());
            MessageBox.Show("first branch","Test");
            msBox mb = new msBox();
            mb.showMSB("Новая ветка","ветка");
            mb.showMSB("Nhf nfnf","sdfsd");
        }

    }
}
