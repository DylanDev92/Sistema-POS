using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Sistema_POS.Database
{
    internal class TemporaryData
    {
        public static BindingList<ProductTemp> CarritoLista { get; set; } = new BindingList<ProductTemp>();

        public static BindingList<PayTemp> PayTemps { get; set; } = new BindingList<PayTemp>();

        public static BindingList<ListProductSave> ListSave { get; set; } = new BindingList<ListProductSave>();

        public static BindingList<ProductosComprados> MasVendidos { get; set; } = new BindingList<ProductosComprados>();

        public static void Load()
        {
            ListSave.Clear();

            if (!Directory.Exists(Path.Combine("ListaEspera")))
            {
                Directory.CreateDirectory(Path.Combine("ListaEspera"));
            }

            foreach (string file in Directory.GetFiles(Path.Combine("ListaEspera")))
            {
                try
                {
                    ListProductSave list = JsonConvert.DeserializeObject<ListProductSave>(File.ReadAllText(file));

                    if (list.ID == 0)
                    {
                        File.Delete(file);
                        continue;
                    }

                    if (list == null) continue;
                    ListSave.Add(new ListProductSave
                    {
                        DateTime = list.DateTime,
                        ID = list.ID,
                        ListaProductos = list.ListaProductos,
                        Client = list.Client,
                        Amount = list.Amount
                    });
                }
                catch
                {

                }
            }

            foreach (ListProductSave listProduct in ListSave.Where(x => x.ID == 0))
            {
                ListSave.Remove(listProduct);
            }
        }

        public static void DeleteEspera(int ID)
        {
            File.Delete(Path.Combine("ListaEspera", ID + ".json"));

            //CarritoLista.Clear();
            PayTemps.Clear();

            Load();
        }

        public static void SaveEspera(string client)
        {
            List<string> fileNames = new List<string>();
            foreach (var g in Directory.GetFiles(Path.Combine("ListaEspera")))
            {
                fileNames.Add(Path.GetFileNameWithoutExtension(g));
            }

            bool found = false;
            int ID = 1;
            while (true)
            {
                if (fileNames.Contains(ID.ToString()))
                {
                    ID++;
                }
                else
                {
                    break;
                }
            }

            

            float amount = 0;

            foreach (var product in CarritoLista)
            {
                amount = amount + product.PrecioTotal;
            }

            File.WriteAllText(Path.Combine("ListaEspera", ID + ".json"), JsonConvert.SerializeObject(new ListProductSave
            {
                DateTime = DateTime.Now,
                ID = ID,
                ListaProductos = CarritoLista,
                Client = client,
                Amount = amount
            }, Formatting.Indented));

            CarritoLista.Clear();
            PayTemps.Clear();

            Load();
        }

        public static void LoadComprados()
        {
            if (!File.Exists(Path.Combine("MasVendidos.json")))
            {
                File.WriteAllText(Path.Combine("MasVendidos.json"), JsonConvert.SerializeObject(new BindingList<ProductosComprados>(), Formatting.Indented));
            }

            MasVendidos = JsonConvert.DeserializeObject<BindingList<ProductosComprados>>(File.ReadAllText(Path.Combine("MasVendidos.json")));
        }

        public static void SaveComprados()
        {
            File.WriteAllText(Path.Combine("MasVendidos.json"), JsonConvert.SerializeObject(MasVendidos, Formatting.Indented));
        }
    }

    public class ProductosComprados
    {
        public string ID { get; set; }
        public string ProductName { get; set; }
        public float Selled { get; set; }
    }
    public class ListProductSave
    {
        public int ID { get; set; }
        public string Client { get; set; }
        public DateTime DateTime { get; set; }
        public BindingList<ProductTemp> ListaProductos { get; set; }
        public float Amount { get; set; }
    }
    public class PayTemp
    {
        public string PayMethod { get; set; }
        public float Amount { get; set; }
    }
    public class ProductTemp
    {
        public float PrecioUnitario { get; set; }
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
        public float Cantidad { get; set; }
    }
}
