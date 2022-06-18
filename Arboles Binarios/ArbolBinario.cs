public class ArbolBinario
{
    Nodo raiz;
    public ArbolBinario(int dato)
    {
        raiz = new Nodo(dato);
    }

    public Nodo Raiz { get { return raiz; } }

    public void Insertar(int dato, Nodo nodo = null)
    {
        if (nodo == null)
        {
            nodo = raiz;
        }

        if (dato > nodo.Dato)
        {
            if (nodo.NodoDerecho == null)
            {
                nodo.NodoDerecho = new Nodo(dato);
            }
            else
            {
                Insertar(dato, nodo.NodoDerecho);
            }
        }

        if (dato < nodo.Dato)
        {
            if (nodo.NodoIzquierdo == null)
            {
                nodo.NodoIzquierdo = new Nodo(dato);
            }
            else
            {
                Insertar(dato, nodo.NodoIzquierdo);
            }
        }

    }

    public void Mostrar(Nodo nodo)
    {
        Console.Write(nodo.Dato);
        if (nodo.NodoIzquierdo != null || nodo.NodoDerecho != null)
        {
            Console.Write("[");
            if (nodo.NodoIzquierdo != null)
            {
                Console.Write("L: ");
                Mostrar(nodo.NodoIzquierdo);
                if (nodo.NodoDerecho != null)
                {
                    Console.Write(", ");
                }
            }

            if (nodo.NodoDerecho != null)
            {
                Console.Write("R: ");
                Mostrar(nodo.NodoDerecho);
            }
            Console.Write("]");
        }
    }

    public void Preorden(Nodo nodo)
    {
        Console.Write($"{nodo.Dato}\t");
        if (nodo.NodoIzquierdo != null)
        {
            Preorden(nodo.NodoIzquierdo);
        }

        if (nodo.NodoDerecho != null)
        {
            Preorden(nodo.NodoDerecho);
        }
    }

    public void InOrden(Nodo nodo)
    {

        if (nodo.NodoIzquierdo != null)
        {
            InOrden(nodo.NodoIzquierdo);
        }

        Console.Write($"{nodo.Dato}\t");

        if (nodo.NodoDerecho != null)
        {
            InOrden(nodo.NodoDerecho);
        }

    }

    public void Posorden(Nodo nodo)
    {

        if (nodo.NodoIzquierdo != null)
        {
            Posorden(nodo.NodoIzquierdo);
        }

        if (nodo.NodoDerecho != null)
        {
            Posorden(nodo.NodoDerecho);
        }
        Console.Write($"{nodo.Dato}\t");
    }
}