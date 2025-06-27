using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.carro;

internal class Carro 
{

   private string _name;
   public void Ligar()
    {
        Console.WriteLine("Carro LIGADO");
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
