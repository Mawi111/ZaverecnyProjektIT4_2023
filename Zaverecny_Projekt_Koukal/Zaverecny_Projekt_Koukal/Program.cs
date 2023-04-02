namespace Zaverecny_Projekt_Koukal
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            
            //SqlRepo.AddUser("vojta", "123", 1, 1);
            //SqlRepo.AddUser("mandys", "lucka", 2, 2);

            //return;

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}