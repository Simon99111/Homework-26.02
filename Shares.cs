public class Shares
{
    public static int Input(string msg)
    {
        Console.Write(msg + " ");
        int size = Convert.ToInt32(Console.ReadLine());
        return size;
    }

    public static int[] InputArray(int length)
    {
        int[] arr = new int[length];
        for (int i = 0; i < length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        return arr;
    }

    public static int Positive(int[] arr)
    {
        int pos = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0) pos = pos + 1;
        }
        return pos;
    }
}