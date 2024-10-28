using ListaLigada.Logica;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Lista Ligada Simple");
        var singleList = new SingleList<string>();

        singleList.ADD("Alondra");
        singleList.ADD("Karla");
        singleList.ADD("Juan");
        singleList.ADD("Luis");
        singleList.ADD("Jose");
        Console.WriteLine(singleList);

        Console.ReadKey();
    }
}