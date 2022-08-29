void PrintArray(double[,] array) {
  for (var i = 0; i < array.GetLength(0); i++){
        for (var j = 0; j < array.GetLength(1); j++){
            Console.Write("{0,6:F2}", array[i,j]);
        }
        Console.WriteLine();
    }
}
double [,] CreateArrayWithRandomNumbers(int m, int n){
    double [,] result = new double [m,n];
    var random = new Random ();

    for (var i = 0; i < result.GetLength(0); i++){
        for (var j = 0; j < result.GetLength(1); j++){
            result[i,j] = random.NextDouble()*100;
        }
    }
    
    return result;
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