//Silva Fragoso Cristian Alan
ArbolGeneral arbol = new ArbolGeneral("A");
Nodo nodoB = arbol.Insertar(arbol.Raiz, "B");
Nodo nodoC = arbol.Insertar(nodoB, "C");
Nodo nodoD = arbol.Insertar(nodoB, "D");
Nodo nodoE = arbol.Insertar(nodoB, "E");
Nodo nodoF = arbol.Insertar(nodoC, "F");
Nodo nodoG = arbol.Insertar(nodoC, "G");
Nodo nodoH = arbol.Insertar(nodoD, "H");
Nodo nodoI = arbol.Insertar(arbol.Buscar("F"), "I");
//Nodo nodoI = arbol.Insertar(nodoC, "H");

string arbolCompleto = arbol.ObtenerArbol();
Console.WriteLine(arbolCompleto);