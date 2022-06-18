//namespace Arboles{
    public class Nodo{
        //Props
        public string Dato{get; set;}
        public Nodo Hijo{get; set;}
        public Nodo Hermano{get; set;}
        //Constructors
        public Nodo(string dato, Nodo hijo = null, Nodo hermano = null){
            Dato = dato;
            Hijo = hijo;
            Hermano = hermano;
        }
    }
//}