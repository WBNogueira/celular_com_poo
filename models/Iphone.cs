using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace celular_com_poo.models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando aplicativo {nome} no Iphone");
        }
    }
}