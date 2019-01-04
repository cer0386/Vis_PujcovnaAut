using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.DomainModel
{
    public class VyrazeneAutoJ
    {
        public String SPZ { get; set; }
        public DateTime STK{ get; set; }
        public int pocetNehod { get; set; }
        public DateTime vyrazeni { get; set; }


        public VyrazeneAutoJ()
        {
        }

        public VyrazeneAutoJ(string spz, DateTime stk, int pocetNehod, DateTime vyrazeni)
        {
            this.SPZ = spz;
            this.STK = stk;
            this.pocetNehod = pocetNehod;
            this.vyrazeni = vyrazeni;
        }

        public void zapis(VyrazeneAutoJ a1)
        {
            string cesta = @"C:/PujcovnaLog/vyrazeneAuta.json";
            List<VyrazeneAutoJ> autaZJ = new List<VyrazeneAutoJ>();

            if (!Directory.Exists(@"C:/PujcovnaLog"))
            {
                Directory.CreateDirectory(@"C:/PujcovnaLog");
            }

            using (StreamWriter w = File.AppendText(cesta))
            {
            }
            using (StreamReader r = new StreamReader(cesta))
            {
                string json1 = r.ReadToEnd();
                Console.WriteLine(json1);
                autaZJ = JsonConvert.DeserializeObject<List<VyrazeneAutoJ>>(json1);
            }


            if (autaZJ == null)
            {
                autaZJ = new List<VyrazeneAutoJ>();
            }

            autaZJ.Add(a1);

            using (StreamWriter file = File.CreateText(cesta))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, autaZJ);
            }


            

        }

        public List<VyrazeneAutoJ> nactiAuta()
        {
            string cesta = @"C:/PujcovnaLog/vyrazeneAuta.json";
            List<VyrazeneAutoJ> data = new List<VyrazeneAutoJ>();
            if (!Directory.Exists(@"C:/PujcovnaLog"))
            {
                Directory.CreateDirectory(@"C:/PujcovnaLog");
            }
            using (StreamWriter w = File.AppendText(cesta))
            {
            }

            using (StreamReader r = new StreamReader(cesta))
            {
                string json1 = r.ReadToEnd();
                data = JsonConvert.DeserializeObject<List<VyrazeneAutoJ>>(json1);

            }

            return data;
        }
    }
}
