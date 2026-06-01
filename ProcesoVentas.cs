using System;
using System.Collections.Generic;

namespace Cafeteria.Ventas
{
    /// <summary>
    /// Clase que gestiona el proceso de ventas con correcciones de errores
    /// </summary>
    public class ProcesoVentas
    {
        private RegistroVentas registroVentas;
        private List<string> bitacora;

        public ProcesoVentas()
        {
            registroVentas = new RegistroVentas();
            bitacora = new List<string>();
        }

        /// <summary>
        /// Procesa una venta con validaciones
        /// </summary>
        public bool ProcesarVenta(int idProducto, decimal monto, string descripcion)
        {
            try
            {
                // Validar monto
                if (monto <= 0)
                {
                    RegistrarError("El monto de la venta debe ser mayor a cero");
                    return false;
                }

                // Crear venta
                var venta = new Venta
                {
                    Id = idProducto,
                    Fecha = DateTime.Now,
                    Monto = monto,
                    Descripcion = descripcion
                };

                // Registrar venta
                registroVentas.RegistrarVenta(venta);
                RegistrarExito($"Venta registrada: {descripcion} - ${monto:N2}");
                return true;
            }
            catch (Exception ex)
            {
                RegistrarError($"Error al procesar venta: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Valida que el proceso de venta sea correcto
        /// </summary>
        public bool ValidarProceso()
        {
            var ventas = registroVentas.ObtenerVentas();
            return ventas.Count > 0;
        }

        private void RegistrarError(string mensaje)
        {
            bitacora.Add($"[ERROR] {DateTime.Now:HH:mm:ss} - {mensaje}");
        }

        private void RegistrarExito(string mensaje)
        {
            bitacora.Add($"[EXITO] {DateTime.Now:HH:mm:ss} - {mensaje}");
        }

        public List<string> ObtenerBitacora()
        {
            return new List<string>(bitacora);
        }
    }
}
