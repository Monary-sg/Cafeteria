using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Linq;

namespace Cafeteria.Reportes
{
    /// <summary>
    /// Clase para exportar reportes en diferentes formatos
    /// </summary>
    public class ExportadorReportes
    {
        /// <summary>
        /// Exporta un reporte a formato CSV
        /// </summary>
        public static string ExportarCSV(ReporteVentas reporte)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Reporte de Ventas");
            sb.AppendLine($"Período: {reporte.FechaInicio:dd/MM/yyyy} - {reporte.FechaFin:dd/MM/yyyy}");
            sb.AppendLine($"Total de Ventas: {reporte.TotalVentas}");
            sb.AppendLine($"Monto Total: {reporte.MontoTotal:C}");
            sb.AppendLine();
            sb.AppendLine("ID,Producto,Monto,Fecha");

            foreach (var venta in reporte.VentasDetalladas)
            {
                sb.AppendLine($"{venta.Id},{venta.Producto},{venta.Monto:C},{venta.Fecha:dd/MM/yyyy HH:mm:ss}");
            }

            return sb.ToString();
        }

        /// <summary>
        /// Exporta un reporte a formato XML
        /// </summary>
        public static string ExportarXML(ReporteVentas reporte)
        {
            XDocument doc = new XDocument(
                new XElement("ReporteVentas",
                    new XElement("Periodo",
                        new XElement("FechaInicio", reporte.FechaInicio.ToString("yyyy-MM-dd")),
                        new XElement("FechaFin", reporte.FechaFin.ToString("yyyy-MM-dd"))
                    ),
                    new XElement("Resumen",
                        new XElement("TotalVentas", reporte.TotalVentas),
                        new XElement("MontoTotal", reporte.MontoTotal)
                    ),
                    new XElement("Ventas",
                        reporte.VentasDetalladas.ConvertAll(v =>
                            new XElement("Venta",
                                new XElement("Id", v.Id),
                                new XElement("Producto", v.Producto),
                                new XElement("Monto", v.Monto),
                                new XElement("Fecha", v.Fecha.ToString("yyyy-MM-dd HH:mm:ss"))
                            )
                        )
                    )
                )
            );

            return doc.ToString();
        }

        /// <summary>
        /// Exporta un reporte a formato JSON
        /// </summary>
        public static string ExportarJSON(ReporteVentas reporte)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("{");
            sb.AppendLine($"  \"periodo\": {{");
            sb.AppendLine($"    \"fechaInicio\": \"{reporte.FechaInicio:yyyy-MM-dd}\",");
            sb.AppendLine($"    \"fechaFin\": \"{reporte.FechaFin:yyyy-MM-dd}\"");
            sb.AppendLine("  },");
            sb.AppendLine($"  \"resumen\": {{");
            sb.AppendLine($"    \"totalVentas\": {reporte.TotalVentas},");
            sb.AppendLine($"    \"montoTotal\": {reporte.MontoTotal}");
            sb.AppendLine("  },");
            sb.AppendLine("  \"ventas\": [");

            for (int i = 0; i < reporte.VentasDetalladas.Count; i++)
            {
                var venta = reporte.VentasDetalladas[i];
                sb.Append($"    {{ \"id\": {venta.Id}, \"producto\": \"{venta.Producto}\", \"monto\": {venta.Monto}, \"fecha\": \"{venta.Fecha:yyyy-MM-dd HH:mm:ss}\" }}");
                if (i < reporte.VentasDetalladas.Count - 1)
                    sb.Append(",");
                sb.AppendLine();
            }

            sb.AppendLine("  ]");
            sb.AppendLine("}");

            return sb.ToString();
        }

        /// <summary>
        /// Guarda un reporte en un archivo
        /// </summary>
        public static void GuardarReporte(string contenido, string rutaArchivo, string formato)
        {
            try
            {
                File.WriteAllText(rutaArchivo, contenido, Encoding.UTF8);
            }
            catch (Exception ex)
            {
                throw new IOException($"Error al guardar el archivo: {ex.Message}");
            }
        }
    }
}
