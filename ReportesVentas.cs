using System;
using System.Collections.Generic;
using System.Linq;

namespace Cafeteria.Reportes
{
    /// <summary>
    /// Clase para generar reportes de ventas
    /// </summary>
    public class GeneradorReportesVentas
    {
        private List<Venta> ventas;

        public GeneradorReportesVentas(List<Venta> ventas)
        {
            this.ventas = ventas;
        }

        /// <summary>
        /// Genera un reporte de ventas por período
        /// </summary>
        public ReporteVentas GenerarReportePorPeriodo(DateTime fechaInicio, DateTime fechaFin)
        {
            var ventasFiltradas = ventas
                .Where(v => v.Fecha >= fechaInicio && v.Fecha <= fechaFin)
                .ToList();

            return new ReporteVentas
            {
                FechaInicio = fechaInicio,
                FechaFin = fechaFin,
                TotalVentas = ventasFiltradas.Count,
                MontoTotal = ventasFiltradas.Sum(v => v.Monto),
                VentasDetalladas = ventasFiltradas
            };
        }

        /// <summary>
        /// Genera un reporte de ventas por producto
        /// </summary>
        public List<ReporteProducto> GenerarReportePorProducto()
        {
            return ventas
                .GroupBy(v => v.Producto)
                .Select(g => new ReporteProducto
                {
                    Producto = g.Key,
                    CantidadVendida = g.Count(),
                    MontoTotal = g.Sum(v => v.Monto),
                    PrecioPromedio = g.Average(v => v.Monto)
                })
                .ToList();
        }
    }

    /// <summary>
    /// Clase que representa una venta
    /// </summary>
    public class Venta
    {
        public int Id { get; set; }
        public string Producto { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
    }

    /// <summary>
    /// Clase que representa el reporte de ventas
    /// </summary>
    public class ReporteVentas
    {
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int TotalVentas { get; set; }
        public decimal MontoTotal { get; set; }
        public List<Venta> VentasDetalladas { get; set; }
    }

    /// <summary>
    /// Clase que representa el reporte por producto
    /// </summary>
    public class ReporteProducto
    {
        public string Producto { get; set; }
        public int CantidadVendida { get; set; }
        public decimal MontoTotal { get; set; }
        public decimal PrecioPromedio { get; set; }
    }
}
