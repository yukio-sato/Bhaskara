Console.ForegroundColor = ConsoleColor.White;
string frase = "Fórmula de Bhaskara\n";
for (int i = 0; i < frase.Length; i++)
{
    Console.Write(frase[i]);
    Thread.Sleep(55);
}
Console.ForegroundColor = ConsoleColor.DarkYellow;
frase = "Valor de A: ";
for (int i = 0; i < frase.Length; i++)
{
    Console.Write(frase[i]);
    Thread.Sleep(55);
}
double a = Convert.ToDouble(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.Cyan;
frase = "Valor de B: ";
for (int i = 0; i < frase.Length; i++)
{
    Console.Write(frase[i]);
    Thread.Sleep(55);
}
double b = Convert.ToDouble(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.Green;
frase = "Valor de C: ";
for (int i = 0; i < frase.Length; i++)
{
    Console.Write(frase[i]);
    Thread.Sleep(55);
}
double c = Convert.ToDouble(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.DarkBlue;
frase = $"(b)² - 4(a)(c)\n";
for (int i = 0; i < frase.Length; i++)
{
    Console.Write(frase[i]);
    Thread.Sleep(55);
}
frase = $"({b})² - 4({a})({c})\n";
for (int i = 0; i < frase.Length; i++)
{
    Console.Write(frase[i]);
    Thread.Sleep(55);
}
frase = $"{(b*b)} - 4({(a*c)})\n";
for (int i = 0; i < frase.Length; i++)
{
    Console.Write(frase[i]);
    Thread.Sleep(55);
}
frase = $"{(b*b)-4*(a*c)}\n";
for (int i = 0; i < frase.Length; i++)
{
    Console.Write(frase[i]);
    Thread.Sleep(55);
}
Console.ForegroundColor = ConsoleColor.DarkGreen;
frase = $"Resultado: {(b*b)-4*(a*c)}\n";
for (int i = 0; i < frase.Length; i++)
{
    Console.Write(frase[i]);
    Thread.Sleep(55);
}