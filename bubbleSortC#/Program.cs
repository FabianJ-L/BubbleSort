namespace bubbleSort;

public class bubbleSort
{
    public static int Main()
    {
        int[] arr = [1, 0, 7, 1, 6, 2, 9, 14, 2];

        int n = arr.Lenght();

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if(arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[1 + j];
                    arr[j + 1] = temp;
                }
            }
        }

        return 0;
    }
}