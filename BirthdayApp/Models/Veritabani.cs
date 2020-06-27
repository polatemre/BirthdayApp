using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BirthdayApp.Models
{
    public static class Veritabani
    {
        private static Dictionary<string, DavetiyeModel> _liste; //dictionary yapmamızdaki sebep listenin içerisindeki her bir elemana bir key vermek. 
        //Objenin ierisindeki ad alanının kendisi oluyor. Her elemanın ad alanı aynı zamanda keyini oluşturuyor.
        static Veritabani()
        {
            _liste = new Dictionary<string, DavetiyeModel>();

            _liste.Add("Hasan", new DavetiyeModel()
            {
                Ad = "Hasan",
                Eposta = "hasan@gmail.com",
                KatilmaDurumu = true
            });

            _liste.Add("Mehmet", new DavetiyeModel()
            {
                Ad = "Mehmet",
                Eposta = "mehmet@gmail.com",
                KatilmaDurumu = false
            });

            _liste.Add("Berrin", new DavetiyeModel()
            {
                Ad = "Berrin",
                Eposta = "berrin@gmail.com",
                KatilmaDurumu = true
            });
        }

        public static void Add(DavetiyeModel model)
        {
            string key = model.Ad.ToLower();
            if (_liste.ContainsKey(key))
            {
                _liste[key] = model;
            }
            else
            {
                _liste.Add(key, model);

            }
        }

        public static IEnumerable<DavetiyeModel> Liste
        {
            get { return _liste.Values; }
        }
    }
}