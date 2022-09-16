using System;
using System.Text;

namespace EjercicioIntegrador_PracticaPP
{
    public class Cliente
    {
        private string _aliasParaIncognito;
        private string _nombre;
        private ETipoCliente _tipoCliente;
        
        private Cliente()
        {
            this._nombre = "NN";
            this._aliasParaIncognito = "SinAlias";
            this._tipoCliente = ETipoCliente.SinTipo;
        }

        public Cliente(ETipoCliente tipoCliente):this()
        {
            this._tipoCliente = tipoCliente;
        }

        public Cliente(ETipoCliente tipoCliente, string nombre):this(tipoCliente)
        {
            this._nombre = nombre;
        }

        public string GetAlias()
        {
            if (this._aliasParaIncognito == "SinAlias")
            {
                CrearAlias();
            }
            return this._aliasParaIncognito;
        }

        private void CrearAlias()
        {
            Random rnd = new Random();
            int numAzar = rnd.Next(1000, 9999);
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this._tipoCliente}{numAzar}");
            this._aliasParaIncognito = sb.ToString();
                
        }

        private string RetornarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine();
            sb.AppendLine($"Nombre:{this._nombre}");
            sb.AppendLine($"Tipo:{this._tipoCliente}");
            sb.AppendLine($"Alias:{this.GetAlias()}");

            return sb.ToString();

       }

        public static string RetornarDatos(Cliente cliente)
        {
            return cliente.RetornarDatos();
           
        }








    }
}
