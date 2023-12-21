
Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
int[,] matrix = CreateMatrix();
PrintMatrix(matrix);


int[,] CreateMatrix()
{

int[,] matrix = new int[row,col];
Random rnd = new Random();
for(int i = 0; i < matrix.GetLength(0); i++)
{
    Console.WriteLine();
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
     matrix[i,j]=rnd.Next(1,100);
        
    }
}
return matrix;
}
void PrintMatrix(int[,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i++)
{
    Console.WriteLine();
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
     if (matrix[i,j]/10 == 0) Console.Write($"  {matrix[i,j]} ");
     else Console.Write($" {matrix[i,j]} ");
    }
}
}