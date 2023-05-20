using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace TrainProject
{
    class Program
    {
        static void Main(string[] args)
        {
        //    // API kullanýmý örneði
        //    var service = new TrainReservationService();

        //    var request = new RezervasyonRequest
        //    {
        //        Tren = new Tren
        //        {
        //            Ad = "Baþkent Ekspres",
        //            Vagonlar = new List<Vagon>
        //            {
        //                new Vagon { Ad = "Vagon 1", Kapasite = 100, DoluKoltukAdet = 68 },
        //                new Vagon { Ad = "Vagon 2", Kapasite = 90, DoluKoltukAdet = 50 },
        //                new Vagon { Ad = "Vagon 3", Kapasite = 80, DoluKoltukAdet = 80 }
        //            }
        //        },
        //        RezervasyonYapilacakKisiSayisi = 3,
        //        KisilerFarkliVagonlaraYerlestirilebilir = true
        //    };

        //    RezervasyonResponse response = service.RezervasyonYap(request);

        //    // Sonuçlarý ekrana yazdýr
        //    Console.WriteLine("Rezervasyon Yapýlabilir: " + response.RezervasyonYapilabilir);

        //    if (response.RezervasyonYapilabilir)
        //    {
        //        Console.WriteLine("Yerleþim Ayrýntýlarý:");
        //        foreach (var yerlesim in response.YerlesimAyrinti)
        //        {
        //            Console.WriteLine("Vagon Adý: " + yerlesim.VagonAdi + ", Kiþi Sayýsý: " + yerlesim.KisiSayisi);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Rezervasyon yapýlamadý.");
        //    }

        //    Console.ReadLine();
        }
    }
}
