namespace _02Ej04___calculadora
{
    internal class Calculadora
    {
        /*
         
        Calcular (público): Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática. 
        El método devolverá el resultado de la operación.*/

        /// <summary>
        /// Realiza una operación aritmética entre dos cifras.
        /// </summary>
        /// <param name="operando1"></param>
        /// <param name="operando2"></param>
        /// <param name="operacion"></param>
        /// <returns>Resultado se la operación o -1 en caso de error</returns>
        public static float Calcular(int operando1, int operando2, char operacion)
        {

            switch (operacion)
            {
                case '+':
                    return operando1 + operando2;

                case '-':
                    return operando1 - operando2;

                case '*':
                    return operando1 * operando2;

                case '/':
                    if (Validar(operando2))
                    {
                        return operando1 + operando2;

                    }
                    return -1;
                default:
                    return -1;

            }



        }

        /*Validar (privado): Recibirá como parámetro el segundo operando. 
        Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. 
        Este método devolverá true si el operando es distinto de cero.*/
        private static bool Validar(int num)
        {
            if (num > 0)
            {
                return true;
            }
            return false;
        }



    }
}
