using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace celular_com_poo.models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
       // TODO: Sobrescrever o método "InstalarAplicativo" 
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando aplicativo {nome} no Nokia");
        }
    }
}