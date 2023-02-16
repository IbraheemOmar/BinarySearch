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
    if (arr[lo] == myTarget)
    {
        return lo;
    }
    
    return -1;


}

// editable
int myTarget = 1;

int[] arr = { 1 };


//

int result = BinarySearch(arr, myTarget);

if (result == -1)
{
    Console.WriteLine("target Doesnt Exist in the array");
}
else
{
    Console.WriteLine($"the target exists at the index of {result}");
}
