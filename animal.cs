
using System;

public class Animal
{
    // Propriedades do animal
    public string Nome { get; private set; }
    public int Idade { get; private set; }

    // Construtor da classe
    public Animal(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    // Método que poderá ser sobrescrito
    public virtual void EmitirSom()
    {
        Console.WriteLine("O animal está emitindo um som.");
    }
}
