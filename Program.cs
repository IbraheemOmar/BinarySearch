int BinarySearch(int[] arr, int myTarget)
{
    int lo = 0;
    int hi = arr.Length - 1;

    while (lo < hi)
    {
        int mid = lo + ((hi - lo) / 2);

        if (arr[mid] == myTarget)
        {
            return mid;
        }
        if (arr[mid] < myTarget)
        {
            lo = mid + 1;
        }
        else
        {
            hi = mid;
        }
    }
    return -1;


}

// editable
int myTarget = 4;

int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };


//

int result = BinarySearch(arr, myTarget);

if (result == -1)
{
    Console.WriteLine("target Doesnt Exist in the array");
}
else
{
    Console.WriteLine(result);
}
