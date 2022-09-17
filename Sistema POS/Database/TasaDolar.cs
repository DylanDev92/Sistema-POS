using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace Sistema_POS.Database
{
    public static class TasaDolar
    {
        public static bool IsToDollar { get; set; }
        public static float Tasa { get; set; }
        public static BindingList<TasaMultiply> TasaList { get; set; } = new BindingList<TasaMultiply>();

        public static Label LabelTasa { get; set; }
        public static void Load()
        {
            if (!File.Exists(Path.Combine("Tasa.json")))
            {
                File.WriteAllText(Path.Combine("Tasa.json"), JsonConvert.SerializeObject(new TasaData { Tasa = 0.00f }, Formatting.Indented));
            }

            Tasa = JsonConvert.DeserializeObject<TasaData>(File.ReadAllText(Path.Combine("Tasa.json"))).Tasa;

            UpdateList();
        }

        public static void UpdateTasa(float newTasa)
        {
            Tasa = newTasa;
            File.WriteAllText(Path.Combine("Tasa.json"), JsonConvert.SerializeObject(new TasaData { Tasa = newTasa }, Formatting.Indented));

            LabelTasa.Text = "Tasa: " + newTasa.ToString("N2"); 

            UpdateList();
        }

        public static void UpdateList()
        {
            TasaList.Clear();
            for (int x = 1; x < 101; x++)
            {
                TasaList.Add(new TasaMultiply { Multiplicacion = x, Total = Tasa * x });
            }
        }

        public class TasaData
        {
            public float Tasa { get; set; }
        }
        public class TasaMultiply
        {
            public int Multiplicacion { get; set; }
            public float Total { get; set; }
        }
    }
}
