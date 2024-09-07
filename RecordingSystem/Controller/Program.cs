namespace RecordingSystem.Model
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new StartupSelector());
        }

        public static readonly string CIPHER = "knox2024";
        //public static readonly string PROGRAM_PATH = @"S:\Staff Work\Responsibility of All\Staff Reporting System\Program Output\";
        public static readonly string PROGRAM_PATH = @"C:\Users\jamie\Subjects\";



    }
}