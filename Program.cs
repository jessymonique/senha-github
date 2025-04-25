Console.Clear();

string senhaDigitada;
string senhaEsperada = "monique";

Console.Write("Digite sua senha..:");
senhaDigitada = Console.ReadLine()!;

if (senhaDigitada == senhaEsperada)
{ 
   // Sucesso no login 
   Console.ForegroundColor = ConsoleColor.Green;
   Console.WriteLine("Olá, usúario. Logado com sucesso.");
} 

else 
{
  // Fracasso no login 
  Console.ForegroundColor = ConsoleColor.Red;
 Console.WriteLine("Senha Inválida!");
}

Console.ResetColor();


