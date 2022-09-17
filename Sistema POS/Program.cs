using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_POS
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Database.TasaDolar.Load();

            Database.Products.Load();

            Database.TemporaryData.Load();

            Database.TemporaryData.LoadComprados();

            Print.Load();

            MainForm mainForm = new MainForm();

            MainFormInteract = mainForm;

            Application.Run(mainForm);
        }

        public static MainForm MainFormInteract { get; set; }
    }
}
