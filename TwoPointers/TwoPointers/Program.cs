

int[] array1 = { 1, 4, 7 };
int[] array2 = { 2, 3, 8, 9 };
SortArray(array1, array2);

void SortArray(int[] arr1, int[] arr2)
{
    int n = arr1.Length;
    int m = arr2.Length;
    int[] resultArray = new int[m + n];
    int index = 0;

    int i = 0;
    int j = 0;

    while (i < n && j < m)
    {
        if (arr1[i] < arr2[j])
        {
            resultArray[index++] = arr1[i++];
        }
        else
        {
            resultArray[index++] = arr2[j++];
        }
    }

    while (i < n)
    {
        resultArray[index++] = arr1[i++];
    }
    while (j < m)
    {
        resultArray[index++] = arr2[j++];
    }

    foreach (var item in resultArray)
    {
        Console.Write(item);
    }
}
