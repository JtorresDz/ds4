using System;

namespace Laboratorio84
{
    public class CuentaBancaria
    {
        private decimal saldo;
        public decimal Saldo
        {
            get { return saldo; }
            set 
            {   
                if(value >= 0)
                    saldo = value; 
                else
                    throw new ArgumentOutOfRangeException("El saldo no puede ser negativo");
            }
        }
    }
}
