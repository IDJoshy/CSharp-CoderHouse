using SistemaGestionUI.Forms;

namespace SistemaGestionUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            bool result;
            var mutex = new System.Threading.Mutex(true, "UniqueAppId", out result);

            if (!result)
            {
                MessageBox.Show("Ya hay una instancia de este programa en curso.");
                return;
            }

            GC.KeepAlive(mutex);

            ApplicationConfiguration.Initialize();
            Application.Run(new MainMenu());
        }
    }
}