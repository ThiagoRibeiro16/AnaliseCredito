Console.Clear();

double emprestimo, renda, valorPar, valorRenda;
int parcelas;

Console.Write("Qual o valor do empréstimo: ");
emprestimo = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Quantas parcelas: ");
parcelas = Convert.ToInt16(Console.ReadLine()!);

Console.Write("Qual sua renda: ");
renda = Convert.ToDouble(Console.ReadLine()!);

valorPar = emprestimo / Convert.ToDouble(parcelas);
valorRenda = renda * 0.30;

if (valorRenda >= valorPar)
{

    Console.WriteLine("Liberado!");

    Console.WriteLine($" valor da parcela: {valorPar}");
    Console.WriteLine($" valor de 30% salario: {valorRenda}");


}

else
{
    Console.WriteLine("Negado!");

    Console.WriteLine($" valor da parcela: {valorPar}");
    Console.WriteLine($" valor de 30% salario: {valorRenda}");     

}
