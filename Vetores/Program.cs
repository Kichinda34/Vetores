internal class Program
{
    private static void Main(string[] args)
    {
        int[] A = new int[5];
        int[] B = new int[5];
        int[] C = new int[10];

        LerArray(A, "Vetor A");
        LerArray(B, "Vetor B");

        C = Concatenar_Vetor(A, B);

        ImprimirArray(A, "Vetor A");
        ImprimirArray(B, "Vetor B");
        ImprimirArray(C, "Vetor C");

        void LerArray(int[] aux, string texto)
        {
            Console.WriteLine("Informe os valores do {0}: ", texto);
            for (int i = 0; i < aux.Length; i++)
            {
                Console.WriteLine("Vetor[{0}]= ", i);
                aux[i] = int.Parse(Console.ReadLine());
            }
        }

        void ImprimirArray(int[] aux, string texto)
        {
            Console.WriteLine("Os valores do {0}: ", texto);
            for (int i = 0; i < aux.Length; i++)
            {
                Console.WriteLine("\nVetor[{0}]= ", i);
            }
        }
    }
}