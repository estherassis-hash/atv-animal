
using System;

public class Cachorro : Animal
{
    // Construtor do cachorro
    public Cachorro(string nome, int idade)
        : base(nome, idade)
    {
    }

    // Sobrescrevendo o método da classe pai
    public override void EmitirSom()
    {
        Console.WriteLine("O cachorro está latindo: Au au!");
    }
}
