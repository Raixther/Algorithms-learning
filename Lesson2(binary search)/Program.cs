using System;

int Search(int[] arr, int SearchValue)
{
    int left = 0;

    int right = arr.Length - 1;

    while (left <= right)
    {

        int mid = (left + right) / 2;
        if (arr[mid] == SearchValue)
        {
            return mid;
        }
        else if (arr[mid] > SearchValue)
        {
            right = mid - 1;

        }
        else if (arr[mid] < SearchValue)
        {
            left = mid + 1;
        }
    }
    return -1;
}

int[] A = new int[] {2,4,5,7,8,9 };


Console.WriteLine(Search(A, 5));

Console.ReadKey();

//O = O(log(2) N) (Увеличение пространства поиска в 2 раза требует дополнительного шага для сжатия)

