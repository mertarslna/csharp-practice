using Microsoft.Data.Sqlite;

var connection = new SqliteConnection("Data Source=Database.db");
connection.Open();

var tableCmd = connection.CreateCommand();
tableCmd.CommandText =
@"
CREATE TABLE IF NOT EXISTS Musteri (
    ID INTEGER PRIMARY KEY AUTOINCREMENT,
    Ad TEXT,
    Soyad TEXT,
    Yas INTEGER,
    Sehir TEXT,
    Meslek TEXT
);

DELETE FROM Musteri 
WHERE Ad = 'Mert' AND Soyad = 'Arslan';

INSERT INTO Musteri (Ad, Soyad, Yas, Sehir, Meslek)
VALUES ('Mert', 'Arslan', 22, 'Antalya', 'Bilgisayar Mühendisi');
";

tableCmd.ExecuteNonQuery();

// Kullanıcıdan veri al
Console.Write("Ad: ");
string ad = Console.ReadLine();

Console.Write("Soyad: ");
string soyad = Console.ReadLine();

Console.Write("Yaş: ");
int yas = int.Parse(Console.ReadLine());

Console.Write("Şehir: ");
string sehir = Console.ReadLine();

Console.Write("Meslek: ");
string meslek = Console.ReadLine();

// Kullanıcıdan alınan veriyi veritabanına ekle
var insertCmd = connection.CreateCommand();
insertCmd.CommandText =
@"
INSERT INTO Musteri (Ad, Soyad, Yas, Sehir, Meslek)
VALUES ($ad, $soyad, $yas, $sehir, $meslek);
";

insertCmd.Parameters.AddWithValue("$ad", ad);
insertCmd.Parameters.AddWithValue("$soyad", soyad);
insertCmd.Parameters.AddWithValue("$yas", yas);
insertCmd.Parameters.AddWithValue("$sehir", sehir);
insertCmd.Parameters.AddWithValue("$meslek", meslek);

insertCmd.ExecuteNonQuery();

connection.Close();

Console.WriteLine("Veriler başarıyla eklendi!");