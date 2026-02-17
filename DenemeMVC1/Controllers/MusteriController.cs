using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;

public class MusteriController : Controller
{
    private string connStr = "Data Source=Database.db";

    public IActionResult Ekle()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Ekle(Musteri m)
    {
        // Negatif yaşa sahip müşterilerin eklenmesini engelle
        if (m != null && m.Yas < 0)
        {
            TempData["EkleError"] = "Yaş 0'dan küçük olamaz.";
            return RedirectToAction("Ekle");
        }
        using var connection = new SqliteConnection(connStr);
        connection.Open();

        var cmd = connection.CreateCommand();
        cmd.CommandText = @"
        INSERT INTO Musteri (Ad, Soyad, Yas, Sehir, Meslek)
        VALUES ($ad,$soyad,$yas,$sehir,$meslek);
        ";

        cmd.Parameters.AddWithValue("$ad", m.Ad);
        cmd.Parameters.AddWithValue("$soyad", m.Soyad);
        cmd.Parameters.AddWithValue("$yas", m.Yas);
        cmd.Parameters.AddWithValue("$sehir", m.Sehir);
        cmd.Parameters.AddWithValue("$meslek", m.Meslek);

        cmd.ExecuteNonQuery();

        TempData["EkleSuccess"] = "Müşteri kaydedildi.";
        return RedirectToAction("Ekle");
    }

    [HttpPost]
    public IActionResult Sil(bool yasi0danKucuk)
    {
        // Sadece kullanıcı istediğinde silme yap
        if (!yasi0danKucuk)
        {
            TempData["SilInfo"] = "Silme işlemi iptal edildi.";
            return RedirectToAction("Ekle");
        }

        using var connection = new SqliteConnection(connStr);
        connection.Open();

        var cmd = connection.CreateCommand();
        // Yaşı 0'dan küçük olan müşterileri sil
        cmd.CommandText = "DELETE FROM Musteri WHERE Yas < 0;";
        int deleted = cmd.ExecuteNonQuery();

        TempData["SilInfo"] = $"{deleted} kayıt silindi (Yaş < 0).";
        return RedirectToAction("Ekle");
    }
}
