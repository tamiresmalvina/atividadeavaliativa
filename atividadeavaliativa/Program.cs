//Variável para controle do loop
string? continuar;

do
{

    //Coleta de dados
    Console.WriteLine("Digite o seu nome:");
    string? nome = Console.ReadLine();
    Console.WriteLine("Digite a sua idade:");
    double idade = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite a sua altura (em metros):");
    double altura = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite o seu peso (em quilogramas):");
    double peso = Convert.ToDouble(Console.ReadLine());

    //Cálculo do IMC
    double calculoImc = peso / (altura * altura);

    string imc;
    if (calculoImc < 18.5)
    {
        imc = "abaixo do peso";
    }
    else if (calculoImc <= 24.9)
    {
        imc = "peso normal";
    }
    else if (calculoImc <= 29.9)
    {
        imc = "sobrepeso";
    }
    else if (calculoImc <= 34.9)
    {
        imc = "obesidade grau I";
    }
    else if (calculoImc <= 39.9)
    {
        imc = "obesidade grau II";
    }
    else
    {
        imc = "obesidade grau III";
    }

    //Determina a faixa etária
    string faixaEtaria;
    if (idade < 12)
    {
        faixaEtaria = "Criança";
    }
    else if (idade < 18)
    {
        faixaEtaria = "Adolescente";
    }
    else if (idade < 60)
    {
        faixaEtaria = "Adulto";
    }
    else
    {
        faixaEtaria = "Idoso";
    }

    //Gerar o relatório
    Console.WriteLine("\n--------------- Relatório do IMC e Idade \n---------------");
    Console.WriteLine("Nome: " + nome + ".");
    Console.WriteLine($"Idade: {idade} anos.");
    Console.WriteLine("Faixa etária: " + faixaEtaria + ".");
    Console.WriteLine($"Peso: {peso} quilogramas.");
    Console.WriteLine("Altura: " + altura + " metros.");
    Console.WriteLine($"IMC: O seu IMC equivale a {calculoImc:F1} e está classificado como {imc}.");

    //Perguntar para continuar
    Console.WriteLine("Deseja gerar um novo relatório? (s/n)");
    continuar = Console.ReadLine()?.ToLower();
}while (continuar == "s");
Console.WriteLine("Obrigada por usar a nossa calculadora de IMC e idade!");