static string[] InputMatrix()
{  
    Console.WriteLine("Введите количество элементов(число)");
    int size = int.Parse(Console.ReadLine());
    string[] array = new string[size];
        for(int i =0; i < size; i++)
        {
        Console.WriteLine($"Введите {i+1}й элемент");
        array[i] = Console.ReadLine();
        }
    return array;
}

static void PrintMatrix(string[] matrix)
{
    for(int i = 0; i < matrix.Length; i++)
    {
        if (i!=matrix.Length-1)
        {
        Console.Write($"{matrix[i]}, ");
        }
        else
        {
        Console.WriteLine($"{matrix[i]}.");
        }
    }
}

static string[] OutputMatrix(string[] matrix)
{   
    int N=0;
    for(int i =0; i < matrix.Length; i++)
    {   
        int length = matrix[i].Length;
        if(length<=3)
        {
        N+=1;
        } 
    }
    string[] array = new string[N];
    int j = 0;
    for(int i =0; i < matrix.Length; i++)
    {   
        int length = matrix[i].Length;
        if(length<=3)
        {
        array[j] = matrix[i];
        j+=1;
        } 
    }
    return array;
}

string[] MatrixForEnter = InputMatrix();
Console.WriteLine();
Console.Write("Вы ввели: ");
PrintMatrix(MatrixForEnter);
Console.Write("Элементы, имеющие до трёх символов включительно: ");
PrintMatrix(OutputMatrix(MatrixForEnter));
Console.WriteLine();
