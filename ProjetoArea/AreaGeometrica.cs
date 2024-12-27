

using System.Diagnostics.Contracts;

namespace Area1;

public class AreaGeometrica
{
public static int areaquadrado(int num1, int num2)
{
   return num1 * num2;
}

public static int areaparalelogramo(int num1, int num2)
{
    return num1 * num2;
}

public static int areatriangulo(int num1, int num2, int num3)
{
    return num1 * num2 / num3;
}

public static void Main()
{
    Console.WriteLine("4 x 4 = " + areaquadrado(4, 4));
    Console.WriteLine("10 x 7 = " + areaparalelogramo(10, 7));
    Console.WriteLine("8 x 10 / 2 = " + areatriangulo(8, 10, 2));
}

}

