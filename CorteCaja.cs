using System;
using System.Collections.Generic;
using System.Linq;

namespace Cafeteria.Ventas
{
    /// <summary>
    /// Clase para gestionar el corte de caja
    /// </summary>
    public class CorteCaja
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public decimal MontoInicial { get; set; }
        public decimal MontoFinal { get; set; }
        public decimal TotalVentas { get; set; }
        public decimal Diferencia { get; set; }
        public string Estado { get; set; }
        public List<Venta> VentasDelDia { get; set; }

        public CorteCaja()
        {
            VentasDelDia = new List<Venta>();
            Estado = "Abierto";
        }

        /// <summary>
        /// Calcula el corte de caja basado en las ventas
        /// </summary>
        public void CalcularCorte(decimal montoInicial, List<Venta> ventas)
        {
            MontoInicial = montoInicial;
            VentasDelDia = ventas;
            TotalVentas = ventas.Sum(v => v.Monto);
            MontoFinal = MontoInicial + TotalVentas;
            Diferencia = 0;
            Fecha = DateTime.Now;
        }

        /// <summary>
        /// Genera un reporte del corte de caja
        /// </summary>
        public string GenerarReporte()
        {
            return $"Corte de Caja - {Fecha:dd/MM/yyyy}\n" +
                   $"Monto Inicial: ${MontoInicial:N2}\n" +
                   $"Total Ventas: ${TotalVentas:N2}\n" +
                   $"Monto Final: ${MontoFinal:N2}\n" +
                   $"Diferencia: ${Diferencia:N2}\n" +
                   $"Estado: {Estado}";
        }

        /// <summary>
        /// Cierra el corte de caja
        /// </summary>
        public void CerrarCorte()
        {
            Estado = "Cerrado";
        }
    }
}
