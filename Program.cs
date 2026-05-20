/*crear una aplicacion que guarde lo registros de notas de 25 estudiantes,

debe presentar un menu:
1. agrega 
2. mostrar 
3- Mostrar los 3 primeros lugares
4.mostar las notas en orden descendente
5-salir
*/

int[] notas = new int [25];

/*agregar*/

/*mostrar*/
Console.WriteLine("Mostrando notas.");
for (int i = 0; i < 25; i++)
{
    if (notas[i] < 70) Console.ForegroundColor = ConsoleColor.Red;
    else Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Nota {i + 1}: {notas[i]}");
    Console.ResetColor();
}

/*3 primeros lugares*/

/*mostrar descendente*/