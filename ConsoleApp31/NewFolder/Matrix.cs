public class Matrix
{
    private int[,] matrix;

    public Matrix(int rows, int columns)
    {
        matrix = new int[rows, columns];
    }

    public void InputData()
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"Введіть елемент матриці [{i + 1},{j + 1}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    public void DisplayData()
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    public int FindMaximum()
    {
        int max = matrix[0, 0];
        foreach (int element in matrix)
        {
            if (element > max)
            {
                max = element;
            }
        }
        return max;
    }

    public int FindMinimum()
    {
        int min = matrix[0, 0];
        foreach (int element in matrix)
        {
            if (element < min)
            {
                min = element;
            }
        }
        return min;
    }
}
