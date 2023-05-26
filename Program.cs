double x, y;
string local;

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("*** Quadrante Cartesiano ***");
Console.WriteLine();
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Entre com o ponto desejado.");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("Coordenada x: ");
x = Convert.ToDouble(Console.ReadLine());
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Red;
Console.Write("Coordenada y: ");
y = Convert.ToDouble(Console.ReadLine());
Console.ResetColor();

if (x == 0 && y == 0) local = "a origem";
else if (x == 0) local = "o eixo das ordenadas";
else if (y == 0) local = "o eixo das abscissas";
else if (y > 0)

{
if (x > 0)
local = "o quadrante 1";
else
local = "o quadrante 2";
}
else
{
if (x < 0)
local = "o quadrante 3";
else
local = "o quadrante 4";
}

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"\nO ponto ({x}, {y}) fica n{local}.");
Console.ResetColor();



