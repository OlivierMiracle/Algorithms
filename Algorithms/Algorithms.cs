public static class Algorithms
{
    #region LinearSearch

    public static int LinearSearch(int[] A, int x)
    {
        int i = -1;

        for (int j = 0; j < A.Length; j++)
        {
            if (A[j] == x)
            {
                i = j;
            }
        }
        
        return i;
    }
    
    public static int BetterLinearSearch(int[] A, int x)
    {
        for (int j = 0; j < A.Length; j++)
        {
            if (A[j] == x) return j;
        }
        
        return -1;
    }
    
    public static int LinearSearchWithSentinel(int[] A, int x)
    {
        int n = A.Length - 1;
        int last = A[n];
        A[n] = x;

        int j = 0;

        for (; A[j] != x; j++) { }

        A[n] = last;

        if (j < n || A[n] == x) return j;

        return -1;
    }

    public static int BinarySearch(int[] A, int x)
    {
        int p = 0;
        int r = A.Length;

        while (p <= r)
        {
            int q = (p + r) / 2;
            if(A[q] == x) return q;
            if (A[q] > x) r = q - 1;
            if (A[q] < x) p = q + 1;
        }

        return -1;
    }
    
    public static int BinarySearchRecursive(int[] A, int p, int r, int x)
    {
        if(p > r) return -1;

        int q = (p + r) / 2;
        if(A[q] == x) return q;
        if (A[q] > x) return BinarySearchRecursive(A, p, q-1, x);
        if (A[q] < x) return BinarySearchRecursive(A, q+1, r , x);

        return -1;
    }

    #endregion
    
}