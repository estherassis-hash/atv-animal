
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Criando um objeto Cachorro
        Cachorro cachorro = new Cachorro("Rex", 5);

        // Criando um objeto Gato
        Gato gato = new Gato("Mimi", 3);

        // Criando uma lista de animais
        List<Animal> animais = new List<Animal>();

        // Adicionando os animais na lista
        animais.Add(cachorro);
        animais.Add(gato);

        // Percorrendo a lista
        foreach (Animal animal in animais)
        {
            Console.WriteLine("Nome: " + animal.Nome);
            Console.WriteLine("Idade: " + animal.Idade);

            // Chamando o método EmitirSom
            animal.EmitirSom();

            Console.WriteLine("--------------------");
        }
    }
}

