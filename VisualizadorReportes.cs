using System;
using System.Collections.Generic;
using System.Linq;

namespace Cafeteria.Reportes
{
    /// <summary>
    /// Clase para mejorar la visualización de reportes en consola
    /// </summary>
    public class VisualizadorReportes
    {
        private const string LINEA_SEPARADORA = "═════════════════════════════════════════════════════════════════";
        private const string LINEA_MENOR = "───────────────────────────────────────────────────────────────";

        /// <summary>
        /// Imprime un reporte de ventas de forma formateada
        /// </summary>
        public static void MostrarReporteVentas(ReporteVentas reporte)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(LINEA_SEPARADORA);
            Console.WriteLine("           📊 REPORTE DE VENTAS");
            Console.WriteLine(LINEA_SEPARADORA);
            Console.ResetColor();

            // Período
            Console.WriteLine($"\n📅 PERÍODO: {reporte.FechaInicio:dd/MM/yyyy} - {reporte.FechaFin:dd/MM/yyyy}");
            Console.WriteLine(LINEA_MENOR);

            // Resumen
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n💰 RESUMEN GENERAL:");
            Console.ResetColor();
            Console.WriteLine($"   Total de Ventas: {reporte.TotalVentas}");
            Console.WriteLine($"   Monto Total: ${reporte.MontoTotal:F2}");
            Console.WriteLine($"   Venta Promedio: ${(reporte.MontoTotal / reporte.TotalVentas):F2}");

            // Detalles
            Console.WriteLine($"\n📋 DETALLE DE VENTAS:");
            Console.WriteLine(LINEA_MENOR);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{'ID',-5} {'PRODUCTO',-20} {'MONTO',10} {'FECHA',20}");
            Console.ResetColor();
            Console.WriteLine(LINEA_MENOR);

            foreach (var venta in reporte.VentasDetalladas)
            {
                Console.WriteLine($"{venta.Id,-5} {venta.Producto,-20} ${venta.Monto,9:F2} {venta.Fecha,20:dd/MM/yyyy HH:mm:ss}");
            }

            Console.WriteLine(LINEA_SEPARADORA);
        }

        /// <summary>
        /// Imprime un reporte de productos de forma formateada
        /// </summary>
        public static void MostrarReporteProductos(List<ReporteProducto> reportes)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(LINEA_SEPARADORA);
            Console.WriteLine("           📊 REPORTE POR PRODUCTO");
            Console.WriteLine(LINEA_SEPARADORA);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{'PRODUCTO',-20} {'CANTIDAD',10} {'MONTO TOTAL',15} {'PRECIO PROMEDIO',15}");
            Console.ResetColor();
            Console.WriteLine(LINEA_MENOR);

            decimal montoGrandTotal = 0;
            int cantidadGrandTotal = 0;

            foreach (var reporte in reportes.OrderByDescending(r => r.MontoTotal))
            {
                Console.WriteLine($"{reporte.Producto,-20} {reporte.CantidadVendida,10} ${reporte.MontoTotal,14:F2} ${reporte.PrecioPromedio,14:F2}");
                montoGrandTotal += reporte.MontoTotal;
                cantidadGrandTotal += reporte.CantidadVendida;
            }

            Console.WriteLine(LINEA_MENOR);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{'TOTAL',-20} {cantidadGrandTotal,10} ${montoGrandTotal,14:F2}");
            Console.ResetColor();
            Console.WriteLine(LINEA_SEPARADORA);
        }

        /// <summary>
        /// Imprime un gráfico de barras ASCII con las ventas
        /// </summary>
        public static void MostrarGraficoBarras(List<ReporteProducto> reportes)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(LINEA_SEPARADORA);
            Console.WriteLine("           📈 GRÁFICO DE VENTAS POR PRODUCTO");
            Console.WriteLine(LINEA_SEPARADORA);
            Console.ResetColor();

            if (reportes.Count == 0)
            {
                Console.WriteLine("No hay datos para mostrar.");
                return;
            }

            decimal maxMonto = reportes.Max(r => r.MontoTotal);
            int anchoBarra = 50;

            foreach (var reporte in reportes.OrderByDescending(r => r.MontoTotal))
            {
                int longitudBarra = (int)((reporte.MontoTotal / maxMonto) * anchoBarra);
                string barra = new string('█', longitudBarra);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{reporte.Producto,-20} ");
                Console.Write(barra);
                Console.ResetColor();
                Console.WriteLine($" ${reporte.MontoTotal:F2}");
            }

            Console.WriteLine(LINEA_SEPARADORA);
        }
    }
}
