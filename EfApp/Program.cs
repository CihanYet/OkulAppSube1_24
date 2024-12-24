using Microsoft.EntityFrameworkCore;

namespace EfApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //**INSERT**

            //var ogr = new Ogrenci { Ad = "Ahmet", Soyad = "Mehmet", Numara = "456" };

            //using (var ctx = new OkulDbContext())
            //{
            //    ctx.Ogrenciler.Add(ogr);
            //    int sonuc = ctx.SaveChanges();
            //    Console.WriteLine(sonuc > 0 ? "İşlem Başarılı" : "İşlem Başarısız!");
            //}

            //**UPDATE**

            //using (var ctx = new OkulDbContext())
            //{
            //    var ogr = ctx.Ogrenciler.Find(2);
            //    ogr.Numara = "789";
            //    ctx.Entry(ogr).State = EntityState.Modified;
            //    ctx.SaveChanges();
            //}

            //**SELECT**
            //using (var ctx = new OkulDbContext())
            //{
            //    var lst = ctx.Ogrenciler.ToList();
            //    foreach (var item in lst)
            //    {
            //        Console.WriteLine(item.ToString());
            //    }
            //}

            //***DELETE***

            //using (var ctx = new OkulDbContext())
            //{
            //    var ogr = ctx.Ogrenciler.Find(2);
            //    ctx.Ogrenciler.Remove(ogr);
            //    ctx.SaveChanges();
            //}
        }
    }
}