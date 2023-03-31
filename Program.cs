String nome, sobrenome;
Console.Write("Digite seu nome: ");
nome = Console.ReadLine()!;

Console.Write("Digite seu sobrenome: ");
sobrenome = Console.ReadLine()!;

Console.WriteLine($"Seu nome completo é {nome} {sobrenome}.");
Console.WriteLine($"Seu nome de catálago é {sobrenome.ToUpper()}, {nome}.");