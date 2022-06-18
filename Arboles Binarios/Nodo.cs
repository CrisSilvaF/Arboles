//namespace Arboles{
    public class Nodo{
        //Props
        private int dato;
        private Nodo nodoIzquierdo;
        private Nodo nodoDerecho;

        public int Dato { get => dato; set => dato = value; }
        public Nodo NodoIzquierdo { get => nodoIzquierdo; set => nodoIzquierdo = value; }
        public Nodo NodoDerecho { get => nodoDerecho; set => nodoDerecho = value; }
        //Constructors
        public Nodo(int dato, Nodo nodoIzquierdo = null, Nodo nodoDerecho = null)
        {
            this.dato = dato;
            this.nodoIzquierdo = nodoIzquierdo;
            this.nodoDerecho = nodoDerecho;
        }
    }
//}