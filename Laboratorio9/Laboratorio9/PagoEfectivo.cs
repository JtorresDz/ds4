using System;


namespace Laboratorio9
{
    public class PagoEfectivo
    {
        private double precio;
        public PagoEfectivo(double precio)
        {
            this.precio = precio;
        }
        public override string ToString()
        {
            return $"Pago con efectivo por el monto: ${precio}";
        }
    }
}
