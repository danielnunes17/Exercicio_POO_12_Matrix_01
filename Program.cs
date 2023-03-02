/*Fazer um programa para ler dois números inteiros M e N, e depois ler
uma matriz de M linhas por N colunas contendo números inteiros,
podendo haver repetições. Em seguida, ler um número inteiro X que
pertence à matriz. Para cada ocorrência de X, mostrar os valores à
esquerda, acima, à direita e abaixo de X, quando houver, conforme
exemplo:
3 4                                         Position 0,1:
10 8 15 12                                  Left: 10
21 11 23 8                                  Right: 15
14 5 13 19                                  Down: 11
8                                           Position 1,3:
                                            Left: 23
                                            Up: 12
                                            Down: 19 */

internal class Program
{
    private static void Main(string[] args)
    {
        string[] linha = Console.ReadLine().Split(" ");

        int m = int.Parse(linha[0]);
        int n = int.Parse(linha[1]);

        int[,] matrix = new int[m, n];
        for (int i = 0; i < m; i++)
        {
            string[] valor = Console.ReadLine().Split(" ");
            for (int j = 0; j < valor.Length; j++)
            {
                matrix[i, j] = int.Parse(valor[j]);
            }
        }

        int x = int.Parse(Console.ReadLine());
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i, j] == x)
                    Console.WriteLine("Position " + i + ", " + j + ": ");

                if (j > 0)
                    Console.WriteLine("Left: " + matrix[i, j - 1]);

                if (i > 0)
                    Console.WriteLine("Up: " + matrix[i - 1, j]);

                if (j < n - 1)
                    Console.WriteLine("Right: " + matrix[i, j + 1]);

                if (i < m - 1)
                    Console.WriteLine("Down: " + matrix[i + 1, j]);
            }
        }
    }
}