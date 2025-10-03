using System;

namespace Laboratorio9
{
    public class Pago
    {
        public void SolicitarPago()
        {
            Console.WriteLine("Ingrese el precio del producto:");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double precio) && precio > 0)
            {
                Console.Clear();
                Console.WriteLine("El precio registrado es: " +"$" + $"{precio}\n");
            }
            else
            {
                Console.WriteLine("Precio Invalido");
            }

            Console.WriteLine("Seleccione el metodo de pago: \n1. Efectivo \n2. Tarjeta\n");
            string metodoPago = Console.ReadLine();
            if (metodoPago == "1")
            {
                    Console.Clear();
                    Console.WriteLine("El precio registrado es: " + "$" + $"{precio}\n");
                    PagoEfectivo pagoEfectivo = new PagoEfectivo(precio);
                    Console.WriteLine(pagoEfectivo);
            }
            else if (metodoPago == "2")

            {      
                Console.Clear();
                Console.WriteLine("El precio registrado es: " + "$" + $"{precio}\n");
                Console.Write("Ingrese el numero de tarjeta: ");
                string inputTarjeta = Console.ReadLine();
                if (long.TryParse(inputTarjeta, out long numeroTarjeta) && inputTarjeta.Length == 16)
                {
                   PagoTarjeta pagoTarjeta = new PagoTarjeta(precio, numeroTarjeta);
                   Console.WriteLine(pagoTarjeta);
                }
                else
                {
                   Console.WriteLine("Numero de tarjeta invalido");
                }
                }
            else
            {
                Console.WriteLine("Metodo de pago invalido. Seleccione 1 para Efectivo o 2 para Tarjeta.");
            }
        }
    }
    
}
