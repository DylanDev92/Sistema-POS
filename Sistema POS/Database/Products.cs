using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_POS.Database
{
    internal class Products
    {
        public static BindingList<Product> ProductsList { get; set; } = new BindingList<Product>();

        public static void Load()
        {
            if (!Directory.Exists(Path.Combine("Productos")))
            {
                Directory.CreateDirectory(Path.Combine("Productos"));
            }

            if (!File.Exists(Path.Combine("Productos", "database.json")))
            {
                File.WriteAllText(Path.Combine("Productos", "database.json"), JsonConvert.SerializeObject(new List<Product>(), Formatting.Indented));
            }

            ProductsList = JsonConvert.DeserializeObject<BindingList<Product>>(File.ReadAllText(Path.Combine("Productos", "database.json")));
        }

        public static void Save()
        {
            File.WriteAllText(Path.Combine("Productos", "database.json"), JsonConvert.SerializeObject(ProductsList, Formatting.Indented));

            // Copia de seguridad

            File.WriteAllText(Path.Combine("Productos", "database" + DateTime.Now.Day.ToString() + "-" + DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + ".json"), JsonConvert.SerializeObject(ProductsList, Formatting.Indented));
        }
    }
    public class Product
    {
        public float PrecioTotal { get; set; }
        public float PrecioDolar { get; set; }
        public float IVA { get; set; }
        public float BaseImponible { get; set; }
        public float Exento { get; set; }
        public string ProductoNombre { get; set; }
        public string Codigo { get; set; }
        public string Impuesto { get; set; }
        public bool Peso { get; set; }
        public bool NoPrecio { get; set; }
    }
}
