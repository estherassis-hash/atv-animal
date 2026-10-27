
using System;

public class Gato : Animal
{
    // Construtor do gato
    public Gato(string nome, int idade)
        : base(nome, idade)
    {
    }

    // Sobrescrevendo o método da classe pai
    public override void EmitirSom()
    {
        Console.WriteLine("O gato está miando: Miau!");
    }
}
