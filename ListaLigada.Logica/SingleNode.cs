namespace ListaLigada.Logica
{
    public class SingleNode <T>
    {
        public T? Data { get; set; } //guarda varibales de diferentes tipos

        public SingleNode<T>? Next { get; set; }//dirección de memoria(puntero, guarda direcciones de memoria)

        public SingleNode(T data) { 
            Data = data;

        }
    }
}
