static string Info(string nome, int idade)
{
    if (idade < 18)
    {
        Console.WriteLine("Você é menor de idade");
    }
    else
    {
        Console.WriteLine("Você é maior de idade");
    }
        return $"Seu nome é {nome} e tem {idade} anos.";
}

string resultado = Info("Apolo",16);
Console.WriteLine(resultado);
