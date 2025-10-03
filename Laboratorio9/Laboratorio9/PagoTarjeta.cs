using System;

namespace Laboratorio9
{
    public class PagoTarjeta
    {
        private double precio;
        private long numeroTarjeta;
        public PagoTarjeta(double precio, long numeroTarjeta)
        {
            this.precio = precio;
            this.numeroTarjeta = numeroTarjeta;
        }
        public override string ToString()
        {
            return $"Pago con tarjeta #: {numeroTarjeta}, Monto: ${precio}";
        }
    }
}
