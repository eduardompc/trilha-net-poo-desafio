using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesafioPOO.Models;

namespace DesafioPOO.Models;

public abstract class Smartphone
{
    public string Numero { get; set; }

    private string modelo;

    public string GetModelo()
    {
        return modelo;
    }

    public void SetModelo(string value) => modelo = value;

    protected Smartphone(string modelo)
    {
        SetModelo(modelo);
    }

    public string Imei { get; set; }
    public int Memoria { get; set; }


    public Smartphone(string numero, string modelo, string imei, int memoria)
    {
        Numero = numero;
        SetModelo(modelo);
        Imei = imei;
        Memoria = memoria;

    }
    public void Ligar()
    {
        Console.WriteLine("Ligando...");
    }

    public void ReceberLigacao()
    {
        Console.WriteLine("Recebendo ligação...");
    }
    public abstract void InstalarAplicativo(string nomeApp);

}
