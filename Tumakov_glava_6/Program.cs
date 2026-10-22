//Тумаков - Лабораторная 6 главы
using Microsoft.VisualBasic;

//Упражнение 6.1
class Program1
{
    static (int CountVowels, int CountConsonants) CalculateLetters(string filePath)
    {
        string result = File.ReadAllText(filePath);

        char[] vovels = new char[] { 'а', 'о', 'у', 'ы', 'э', 'я', 'ё', 'ю', 'и', 'е' };
        char[] consonants = new char[] { 'б', 'в', 'г', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ' };


        int countVovels = 0;
        int countConsonants = 0;

        foreach (var item in result)
        {
            if (vovels.Contains(item))
            {
                countVovels++;
            }
        }
        foreach (var item in result)
        {
            if (consonants.Contains(item))
            {
                countConsonants++;
            }
        }

        return (countVovels, countConsonants);
    }
    static void Task1()
    {
        string filePath = "..\\..\\..\\Files\\test.txt";
        var result = CalculateLetters(filePath);
        

        Console.WriteLine("Количество гласных букв: " + result.CountVowels);
        Console.WriteLine("Количество согласных букв: " + result.CountConsonants);

    }
    static void Main(string[] args)
    {
        Task1();
        Console.ReadKey();
    }
}

//Упражнение 6.2
class Program2
{
    static void Main()
    {
        int[,] matrixA = {
            { 1, 2 },
            { 3, 4 }
        };

        int[,] matrixB = {
            { 5, 6 },
            { 7, 8 }
        };

        Console.WriteLine("Матрица A:");
        PrintMatrix(matrixA);

        Console.WriteLine("\nМатрица B:");
        PrintMatrix(matrixB);

        int[,] resultMatrix = MultiplyMatrices(matrixA, matrixB);

        Console.WriteLine("\nРезультат произведения Матрицы А на Матрицу В: ");
        PrintMatrix(resultMatrix);
    }

    
    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{matrix[i, j],4} ");
            }
            Console.WriteLine();
        }
    }

    static int[,] MultiplyMatrices(int[,] a, int[,] b)
    {
        int rowsA = a.GetLength(0);
        int colsA = a.GetLength(1);
        int rowsB = b.GetLength(0);
        int colsB = b.GetLength(1);
        if (colsA != rowsB)
        {
            throw new ArgumentException("Число столбцов первой матрицы должно быть равно числу строк второй.");
        }

        int[,] result = new int[rowsA, colsB];

        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < colsB; j++)
            {
                int sum = 0;
                string steps = "";

                for (int k = 0; k < colsA; k++)
                {
                    sum += a[i, k] * b[k, j];
 
                    steps += $"{a[i, k]}×{b[k, j]}";
                    if (k < colsA - 1)
                    {
                        steps += " + ";
                    }
                }

                result[i, j] = sum;

            }
        } 

        return result;
    }
}
