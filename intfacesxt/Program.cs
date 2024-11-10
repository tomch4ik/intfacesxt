namespace intfacesxt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 8, 0, 5, 20, 7, 10 };
            Array array = new Array(numbers);
            int valueToCompare = 6;
            int lessCount = array.Less(valueToCompare);
            int greaterCount = array.Greater(valueToCompare);
            Console.WriteLine($"Количество элементов меньше {valueToCompare}: {lessCount}");
            Console.WriteLine($"Количество элементов больше {valueToCompare}: {greaterCount}");
            array.ShowEven();
            array.ShowOdd();
            Console.WriteLine($"Количество уникальных значений: {array.CountDistinct()}");
            Console.WriteLine($"Количество элементов равных {valueToCompare}: {array.EqualToValue(valueToCompare)}");
        }
    }
}

