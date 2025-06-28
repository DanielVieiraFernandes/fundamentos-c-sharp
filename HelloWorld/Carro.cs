using HelloWorld.Teste;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.carro;

internal class Carro 
{

   private string _name;

    private Biscoito _biscoito = new();
   public void Ligar()
    {
        Console.WriteLine("Carro LIGADO");

        _biscoito.Temperatura();
    }

   public void Desligar()
    {
        Console.WriteLine("Carro DESLIGADO");
    }

   public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }
}
