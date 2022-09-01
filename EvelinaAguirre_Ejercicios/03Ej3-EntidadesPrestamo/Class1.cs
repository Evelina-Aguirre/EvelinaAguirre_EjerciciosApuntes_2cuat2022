using System;
using System.Text;

namespace _03Ej3_EntidadesPrestamo
{
    public class Cuenta
    {
        /*  Ejercicio I01 - Creo que necesito un préstamo
            Consigna
            Crear una aplicación de consola y una biblioteca de clases que contenga la clase Cuenta. x

            Deberá tener los atributos:

            titular que contendrá la razón social del titular de la cuenta.x
            cantidad que será un número decimal que representa al monto actual de dinero en la cuenta.x
            
            Construir los siguientes métodos para la clase:

            a- Un constructor que permita inicializar todos los atributos.x
            b - Un método getter para cada atributo.x
            c -mostrar retornará una cadena de texto con todos los datos de la cuenta.x
            d -Ingresar recibirá un monto para acreditar a la cuenta. Si el monto ingresado es negativo, no se hará nada.
            e -Retirar recibirá un monto para debitar de la cuenta. La cuenta puede quedar en negativo.
            */

        public string razonSocialTitular;
        public decimal cantidadActualCuenta;

        //a - Constructor
        public Cuenta(string razonSocialTitular, decimal cantidadActualCuenta )
        {
            this.razonSocialTitular = razonSocialTitular;
            this.cantidadActualCuenta = cantidadActualCuenta;
        }
        
        //b -Getters 
        public string RazonSocialTitular
        {
            get
            {
                return this.razonSocialTitular;
            }
        }

        public decimal CantidadActualCuenta
        {
            get
            {
                return this.cantidadActualCuenta;
            }
        }
        //c - Método mostrar
        public void Mostrar()
        {
            Console.WriteLine($"***************************************************\n");
            Console.WriteLine($"Razón Social: {this.razonSocialTitular}");
            Console.WriteLine($"Saldo: {this.cantidadActualCuenta}\n");
            Console.WriteLine($"***************************************************\n\n");
            
        }

        //d - Método ingresar
        public decimal Ingresar(decimal monto)
        {
            decimal resultado = 0;
            
            if(monto <0)
            {
                resultado = this.cantidadActualCuenta;
            }
            resultado = this.cantidadActualCuenta + monto;
            
            return resultado;
            
        }

        //e- Método retirar
        public decimal Retirar(decimal monto)
        {
            return this.cantidadActualCuenta - monto;
        }




    }
}
