ArbolBinario arbol = new ArbolBinario(120);
int[] numeros = { 87, 140, 43, 99, 130, 22, 65, 56, 93, 135, 10, 150, 1, 150, 2000 };

foreach (int numero in numeros)
{
    arbol.Insertar(numero);
}

Console.Write("Preorden: ");
arbol.Preorden(arbol.Raiz);
Console.WriteLine();
Console.Write("Inorden: ");
arbol.InOrden(arbol.Raiz);
Console.WriteLine();
Console.Write("Posorden: ");
arbol.Posorden(arbol.Raiz);
Console.WriteLine();