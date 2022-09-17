using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using Newtonsoft.Json;
using System.ComponentModel;

namespace Sistema_POS
{
    public static class Print
    {
        public static List<BindingList<Database.ProductTemp>> ComprasEfectuadas = new List<BindingList<Database.ProductTemp>>();
        public static InformacionEmpresa Informacion = new InformacionEmpresa();
        public static void Load()
        {
            if (!Directory.Exists(Path.Combine("Facturas")))
            {
                Directory.CreateDirectory(Path.Combine("Facturas"));
            }

            if (!File.Exists(Path.Combine("ComprasEfectuadas.json")))
            {
                File.WriteAllText(Path.Combine("ComprasEfectuadas.json"), JsonConvert.SerializeObject(new List<BindingList<Database.ProductTemp>>()));
            }

            ComprasEfectuadas = JsonConvert.DeserializeObject<List<BindingList<Database.ProductTemp>>> (File.ReadAllText(Path.Combine("ComprasEfectuadas.json")));

            if (!File.Exists(Path.Combine("Informacion.json")))
            {
                File.WriteAllText(Path.Combine("Informacion.json"), JsonConvert.SerializeObject(new InformacionEmpresa
                {
                    RIF = "",
                    NombreEmpresa = "",
                    Direccion = "",
                    Telefono = ""
                }, Formatting.Indented));
            }

            Informacion = JsonConvert.DeserializeObject<InformacionEmpresa>(File.ReadAllText(Path.Combine("Informacion.json")));
        }

        public static void SaveInformation(string RIF, string NombreEmpresa, string Direccion, string Telefono)
        {
            Informacion = new InformacionEmpresa
            {
                RIF = RIF,
                NombreEmpresa = NombreEmpresa,
                Direccion = Direccion,
                Telefono = Telefono
            };

            File.WriteAllText(Path.Combine("Informacion.json"), JsonConvert.SerializeObject(Informacion, Formatting.Indented));
        }

        public static void GuardarCompra()
        {
            ComprasEfectuadas.Add(Database.TemporaryData.CarritoLista);

            File.WriteAllText(Path.Combine("ComprasEfectuadas.json"), JsonConvert.SerializeObject(ComprasEfectuadas, Formatting.Indented));
        }

        public static void PrintPDF(string clientName = null, string CI = null, string telefono = null, bool sendWhatsapp = false)
        {
            string pdfRead = Properties.Resources.Plantilla.ToString();

            pdfRead = pdfRead.Replace("@Title", ComprasEfectuadas.Count().ToString());

            pdfRead = pdfRead.Replace("@NombreEmpresa", Informacion.NombreEmpresa);
            pdfRead = pdfRead.Replace("@RIF", Informacion.RIF);
            pdfRead = pdfRead.Replace("@Direccion", Informacion.Direccion);
            pdfRead = pdfRead.Replace("@Telefono", Informacion.Telefono);

            pdfRead = pdfRead.Replace("@Nombre", clientName ?? "N/A");
            pdfRead = pdfRead.Replace("@Cedula", CI ?? "N/A");
            pdfRead = pdfRead.Replace("@ClienteTelefono", telefono ?? "N/A");

            pdfRead = pdfRead.Replace("@NroFactura", ComprasEfectuadas.Count().ToString());
            pdfRead = pdfRead.Replace("@FechaFactura", DateTime.Now.ToString("MM/dd/yyyy HH:mm"));

            string pdfList = "";

            float total = 0;
            float iva = 0;
            float baseImp = 0;
            float exento = 0;

            foreach (Database.ProductTemp producto in Database.TemporaryData.CarritoLista)
            {
                pdfList += $"<tbody style={"text-align: center"}> <tr> <td>{producto.ProductoNombre}</td> <td>{producto.Cantidad}</td> <td>{producto.Impuesto}</td> <td>{producto.PrecioUnitario.ToString("N2")}</td> <td>{producto.PrecioTotal.ToString("N2")}</td> </tr> </tbody>";

                total += producto.PrecioTotal;

                if (producto.Impuesto == "Exento")
                {
                    exento += (producto.PrecioUnitario * producto.Cantidad);
                }
                else
                {
                    iva += (Fun.GetIVA(producto.PrecioUnitario, producto.Impuesto) * producto.Cantidad);
                    baseImp += (Fun.GetBaseImponible(producto.PrecioUnitario, producto.Impuesto) * producto.Cantidad);
                }
            }

            string pagosList = "";

            foreach (Database.PayTemp pay in Database.TemporaryData.PayTemps)
            {
                pagosList += $"<li>{pay.PayMethod}: {pay.Amount.ToString("N2")}</li>";
            }

            pdfRead = pdfRead.Replace("@ListaPagos", pagosList);
            pdfRead = pdfRead.Replace("@ListaProductos", pdfList);

            pdfRead = pdfRead.Replace("@BaseImponible", baseImp.ToString("N2"));
            pdfRead = pdfRead.Replace("@IVA", iva.ToString("N2"));
            pdfRead = pdfRead.Replace("@Exento", exento.ToString("N2"));
            pdfRead = pdfRead.Replace("@Total", total.ToString("N2"));


            using (FileStream stream = new FileStream(Path.Combine("Facturas", ComprasEfectuadas.Count().ToString() + ".pdf"), FileMode.Create))
            {
                Document document = new Document(PageSize.A4, 15, 15, 15, 15);
                PdfWriter pdfWriter = PdfWriter.GetInstance(document, stream);
                document.Open();
                //document.Add(new Paragraph(htmltest));

                using (StringReader reader = new StringReader(pdfRead))
                {
                    XMLWorkerHelper.GetInstance().ParseXHtml(pdfWriter, document, reader);
                }

                document.Close();
                stream.Close();
            }
        }
    }

    public class InformacionEmpresa
    {
        public string NombreEmpresa { get; set; }
        public string RIF { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
    }
}
