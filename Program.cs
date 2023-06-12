namespace _2D_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] my2DArray = new string[3, 2]; // 2D array
            my2DArray[0, 0] = "00";
            my2DArray[1, 0] = "10";
            my2DArray[2, 0] = "20";
            my2DArray[0, 1] = "01";
            my2DArray[1, 1] = "11";
            my2DArray[2, 1] = "21";

            Console.WriteLine(my2DArray.Length);
            Console.WriteLine();

            for (int row = 0;  row < my2DArray.GetLength(0); row++)
            {
                for(int col = 0; col < my2DArray.GetLength(1); col++)
                {
                    Console.Write(my2DArray[row,col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}