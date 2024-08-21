using Dapper;
using DnD_CharacterTrackerApp.Models;
using System.Data;
using System.Data.SQLite;

namespace DnD_CharacterTrackerApp.DBConnection {
    public class SqliteDataAccess {
        public static List<CharacterModel>? LoadCharacters() {
            try {
                using IDbConnection dbConnection = new SQLiteConnection(LoadConnectionString());
                IEnumerable<CharacterModel> output = dbConnection.Query<CharacterModel>("select * from \"Character\"", new DynamicParameters());
                return output.ToList();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public static void SaveCharacter(CharacterModel characterModel) {
            try {
                using IDbConnection dbConnection = new SQLiteConnection(LoadConnectionString());
                dbConnection.Execute("insert into \"Character\" (Name, Race, Class, SubClass, Age, Height, AC, HP)" +
                    "values (@Name, @Race, @Class, @SubClass, @Age, @Height, @AC, @HP)", characterModel);
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        private static string LoadConnectionString() {
            // Log whether the configuration is loaded or null
            Console.WriteLine($"CONFIGURATION NULL : {Program.Configuration == null}");

            // Proper way to access nested sections in appsettings.json
            string connectionString = Program.Configuration!["ConnectionStrings:DefaultConnection"]!;

            // If the connection string is still null, log that
            if (string.IsNullOrEmpty(connectionString)) {
                Console.WriteLine("Connection string is null or empty!");
                connectionString = "Default value or handle error here.";
            }

            // Print the connection string (for debugging)
            Console.WriteLine($"Connection String: {connectionString}");

            return connectionString;
        }
    }
}
