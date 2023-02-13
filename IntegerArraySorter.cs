namespace KatasCSharp;

public class IntegerArraySorter
{
    public int[] SortArray(int[] array)
    {
       var oddNumbersQueue = GetOddNumbers(array);

       for (var index = 0; index < array.Length; index++)
       {
           if (array[index] % 2 != 0)
           {
               array[index] = oddNumbersQueue.Dequeue();
           }
       }
       return array;
    }

    private Queue<int> GetOddNumbers(int[] array)
    {
        return new Queue<int>(Array
            .FindAll(array, number => number % 2 != 0)
            .Order()
            .ToArray());
    }
}