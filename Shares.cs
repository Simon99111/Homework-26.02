public class Shares
{
    public static int Input(string msg)
    {
        Console.Write(msg + " ");
        int size = Convert.ToInt32(Console.ReadLine());
        return size;
    }

    public static double InputXY(string msg)
    {
        Console.Write(msg + " ");
        double size = Convert.ToDouble(Console.ReadLine());
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

    public static double CoordinateX (double B1, double K1, double B2, double K2)
    {
        double result = (B2-B1)/(K1-K2);
        return result;
    }

    public static double CoordinateY (double B1, double K1, double B2, double K2)
    {
        double result = (K1*(B2-B1)/(K1-K2))+B1;
        return result;
    }
}