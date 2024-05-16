// EXAMEN DE EDD-LABORATORIO-N° 1

//#1 PEDIR LADOS DE UN RECTANGULO Y DIBUJAR EN PANTALLA

//int lado, ancho;
//while (true)
//{
//    Console.Write("Ingrese el LADO del rectangulo: ");
//    if (int.TryParse(Console.ReadLine(), out lado) && lado > 0)
//    {
//        break;
//    }

//    else
//    {
//        Console.WriteLine("DATO INVALIDO. VUELVA A INGRESAR DATO.");

//    }
//}

//while (true)
//{
//    Console.WriteLine("Ingrese la ANCHO del rectangulo: ");
//    if (int.TryParse(Console.ReadLine(), out ancho) && ancho > 0)
//    {
//        break;
//    }

//    else
//    {
//        Console.WriteLine("DATO INVALIDO. VUELVA A INGRESAR DATO.");
//    }
//}

//for (int i = 0; i < lado; i++)
//{
//    for (int j = 0; j < ancho; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}



// 2# PEDIR UN NÚMERO Y CONSTRUIR UN HEXÁGONO



Console.WriteLine("INGRESE EL TAMAÑO DEL HEXÁGONO: ");
int sizeTam = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < sizeTam; i++)
{
    for (int j = 0; j < sizeTam - i; j++)
    {
        Console.Write(" ");
    }
    for (int k = 0; k < 2 * i + 1; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

for (int i = sizeTam - 2; i >= 0; i--)
{
    for (int j = 0; j < sizeTam - i; j++)
    {
        Console.Write(" ");
    }
    for (int k = 0; k < 2 * i + 1; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
