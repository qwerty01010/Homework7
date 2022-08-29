void PrintArray(int [,] array) {
  for (var i = 0; i < array.GetLength(0); i++){
        for (var j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
}

int [,] CreateArrayWithRandomNumbers(int m, int n){
    int [,] result = new int [m,n];
    var random = new Random ();

    for (var i = 0; i < result.GetLength(0); i++){
        for (var j = 0; j < result.GetLength(1); j++){
            result[i,j] = random.Next(0,10);
        }
    }
    
    return result;
}
void SumElement(int [,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sumOfElements = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            sumOfElements += array[i,j];                       
        }
        double arithmeticMean = sumOfElements/array.GetLength(0);
        Console.Write ($"Среднее арифметическое элементов {j+1} столбца =");
        Console.Write ("{0,5:F2}", arithmeticMean);
        Console.WriteLine ();
    }
}

Console.WriteLine("Введите число строк (m)");
if (!int.TryParse(Console.ReadLine()!, out var m))
{
    Console.WriteLine("Все плохо");
}


Console.WriteLine("Введите число столбцов (n)");
if (!int.TryParse(Console.ReadLine()!, out var n))
{
    Console.WriteLine("Все плохо");
}

var result = CreateArrayWithRandomNumbers(m,n);
PrintArray(result);
Console.WriteLine();
SumElement(result);

