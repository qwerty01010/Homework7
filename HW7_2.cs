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

void SearchElementOfArray(int [,] array, int msrch, int nsrch){
    int searchElement = 0;
    bool done = true;
    for (var i = 0; i < array.GetLength(0); i++){
        for (var j = 0; j < array.GetLength(1); j++){
            
            if (i == msrch & j == nsrch)
            {
                searchElement = array[i,j];
                Console.WriteLine("Искомый элемент = "+searchElement);
                done = true;
            }
            else done = false;
        }
    }
    if(done==false) Console.WriteLine("Элемента нет");
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

Console.WriteLine("Введите индекс строки искомого элемента");
if (!int.TryParse(Console.ReadLine()!, out var msrch))
{
     Console.WriteLine("Все плохо");
}

Console.WriteLine("Введите индекс столбца искомого элемента");
if (!int.TryParse(Console.ReadLine()!, out var nsrch))
{
     Console.WriteLine("Все плохо");
}
SearchElementOfArray(result,msrch,nsrch);