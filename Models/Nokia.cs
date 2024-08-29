using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesafioPOO.Models;

namespace DesafioPOO.Models;
public class Nokia : Smartphone
{
    public Nokia(string modelo) : base(modelo)
    {
    }

    public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
    {
    }
    public override void InstalarAplicativo(string nomeApp)
    {
        Console.WriteLine($"Instalando o aplicativo {nomeApp} no iPhone.");
    }
    //public override void InstalarAplicativo(string nomeApp)
    //{
      //  throw new NotImplementedException();
    //}
    private string GetDebuggerDisplay() => ToString();
}

