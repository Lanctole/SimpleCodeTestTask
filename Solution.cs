namespace SimpleCodeTestTask;

public class Solution
{
    public static int counter = 0;

    public static int[] solution(string[] A, string[] B)
    {
        bool IsBlocked(string[] hostString, HashSet<string> hashSet)
        {
            for (int j = hostString.Length - 1; j >= 0; j--)
            {
                //counter++;
                var connect = string.Join(".", hostString.Skip(j));
                if (hashSet.Contains(connect)) return true;
            }
            return false;
        }

        var forbiddenHosts = new HashSet<string>(B);
        var allowedIndices = new List<int>();

        for (var i = 0; i < A.Length; i++)
        {
            var hostString = A[i].Split('.');
            if (!IsBlocked(hostString, forbiddenHosts))
            {
                allowedIndices.Add(i);
            }
        }
        return allowedIndices.ToArray();
    }
}