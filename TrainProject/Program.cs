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
        //    // API kullan�m� �rne�i
        //    var service = new TrainReservationService();

        //    var request = new RezervasyonRequest
        //    {
        //        Tren = new Tren
        //        {
        //            Ad = "Ba�kent Ekspres",
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

        //    // Sonu�lar� ekrana yazd�r
        //    Console.WriteLine("Rezervasyon Yap�labilir: " + response.RezervasyonYapilabilir);

        //    if (response.RezervasyonYapilabilir)
        //    {
        //        Console.WriteLine("Yerle�im Ayr�nt�lar�:");
        //        foreach (var yerlesim in response.YerlesimAyrinti)
        //        {
        //            Console.WriteLine("Vagon Ad�: " + yerlesim.VagonAdi + ", Ki�i Say�s�: " + yerlesim.KisiSayisi);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Rezervasyon yap�lamad�.");
        //    }

        //    Console.ReadLine();
        }
    }
}
