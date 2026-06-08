using System;
using System.Collections.Generic;

namespace Cafeteria.Ventas
{
    /// <summary>
    /// Clase para gestionar el registro de ventas
    /// </summary>
    public class RegistroVentas
    {
        private List<Venta> ventas;

        public RegistroVentas()
        {
            ventas = new List<Venta>();
        }

        /// <summary>
        /// Registra una nueva venta
        /// </summary>
        public void RegistrarVenta(Venta venta)
        {
            if (venta == null)
                throw new ArgumentNullException(nameof(venta));

            ventas.Add(venta);
        }

        /// <summary>
        /// Obtiene todas las ventas registradas
        /// </summary>
        public List<Venta> ObtenerVentas()
        {
            return new List<Venta>(ventas);
        }

        /// <summary>
        /// Obtiene el total de ventas
        /// </summary>
        public decimal ObtenerTotalVentas()
        {
            decimal total = 0;
            foreach (var venta in ventas)
            {
                total += venta.Monto;
            }
            return total;
        }
    }

    public class Venta
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public string Descripcion { get; set; }
    }
}
