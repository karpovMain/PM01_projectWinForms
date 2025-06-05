using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace statisticRequest
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (var auth = new loginForm())
            {
                if (auth.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new mainForm());
                }
            }
        }
    }
}
