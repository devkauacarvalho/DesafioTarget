Console.WriteLine("Digite o seu nome completo: ");
string nomeCompleto = Console.ReadLine();

// Verifica se o usuário inseriu um nome
if (!string.IsNullOrEmpty(nomeCompleto))
{
    int quantidadeLetrasA = 0;
    string nomeMaiusculo = nomeCompleto.ToUpper();

    if (nomeMaiusculo.Contains("A"))
    {
        Console.WriteLine($"Seu nome contém a letra A");

        // Para cada letra na string alocada em nomeMaiusculo,
        // verifica se é a Letra A e conta a quantidade de vezes que ela aparece.
        foreach (char letra in nomeMaiusculo)
        {
            if (letra == 'A')
            {
                quantidadeLetrasA++;
            }
        }

        Console.WriteLine($"A letra A aparece {quantidadeLetrasA} vezes no seu nome");
    }
    else
    {
        Console.WriteLine("Seu nome não possui a letra A");
    }
}
else
{
    Console.WriteLine("O nome não pode estar vazio.");
}