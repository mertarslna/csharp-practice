using Microsoft.Data.Sqlite;

var connection = new SqliteConnection("Data Source=veritabani.db");
connection.Open();

var command = connection.CreateCommand();
command.CommandText =
@"
CREATE TABLE IF NOT EXISTS users (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    name TEXT
);

INSERT INTO users (name)
VALUES ('Mert');
";

command.ExecuteNonQuery();
connection.Close();

Console.WriteLine("Veri eklendi!");