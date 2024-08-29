using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesafioPOO.Models;

namespace DesafioPOO.Models;
public class Iphone : Smartphone
{
    public Iphone(string modelo) : base(modelo)
    {
    }

    public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
    {
    }

    // Sobrescrever o método "InstalarAplicativo"
    public override void InstalarAplicativo(string nomeApp)
    {
        Console.WriteLine($"Instalando o aplicativo {nomeApp} no iPhone.");
    }
}
