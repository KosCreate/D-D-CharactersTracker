using Microsoft.Extensions.Configuration;         // For IConfigurationBuilder and ConfigurationManager
namespace DnD_CharacterTrackerApp {
    internal static class Program {
        public static IConfiguration? Configuration { private set; get; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            var builder = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            Configuration = builder.Build();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new CharacterSheetTrackerApp());
        }
    }
}