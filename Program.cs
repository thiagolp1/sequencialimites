int inicio, fim;
string mensagem = "";

Console.Write("Primeiro número:");
inicio = Convert.ToInt32(Console.ReadLine());

Console.Write("Ultimo número:");
fim = Convert.ToInt32(Console.ReadLine());

try
{
    if (fim <= inicio)
    {
        throw new Exception("O segundo número não pode ser menor que o primeiro");
    }

    while (fim >= inicio)
    {
        mensagem += $"{inicio} ";
        inicio +=1;
    }

    Console.WriteLine($"{mensagem}");

}

catch (Exception e)
{
    Console.WriteLine(e.Message);
}
