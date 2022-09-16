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
            this._aliasParaIncognito = rnd.Next(1000,9999).ToString() + this._tipoCliente.ToString();
        }

        private string RetornarDatos()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine($"Nombre:{this._nombre}");
            sb.AppendLine($"Alias:{this._aliasParaIncognito}");
            sb.AppendLine($"Tipo de Cliente:{this._tipoCliente}");

            return sb.ToString();

        }

        public static string RetornarDatos(Cliente cliente)
        {
            string retorno = "";
            if(cliente is not null)
            retorno = cliente.RetornarDatos();
            return retorno;
        }








    }
}
