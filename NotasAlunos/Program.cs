// See https://aka.ms/new-console-template for more information

/* if (concao a ser testada);
{
comando a ser execuato caso consição seja verdadeira 

}
*/

const string APROVADO = "Aprovado!";
const string REPROVADO = "Reprovado!";
const string EM_RECUPERACAO = "Em Recuperacao!";


Console.WriteLine("DIGITE A NOTA DO ALUNO");
decimal nota = Convert.ToDecimal(Console.ReadLine());

if (nota >= 5)
{
    Console.WriteLine(APROVADO);

}

else if (nota >= 4 && nota < 5)
{
    Console.WriteLine(EM_RECUPERACAO);
}


else
{
    Console.WriteLine(REPROVADO);
}



