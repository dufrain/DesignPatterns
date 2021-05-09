using System;

namespace MicrosoftTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] A = { 4, 5, 6, 2 };
            //int[] A = { 4, 5, 6, 2 };
            //int[] A = { 4, 5, 6, 2 };
            //int[] A = { 1,1,3,3,5,6 };
            // Console.WriteLine(solution3(A));
            // var s = "aaBabcDaA";
            //Console.WriteLine(solution4(s));
            //int K = 3;
            //int[] A = {  };
            //var shiftedArray = ShiftArray(A, K);
            //foreach (var item in shiftedArray)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            string[] S = {"aaa","bbb","abc" };
            Console.WriteLine(MicrosoftTest2(S));
            Console.ReadKey();
        }

        private static int MicrosoftTest2(string[] A)
        {
            var max = 0;
            int[] letters = new int[26];
            foreach (var word in A)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    Array.Clear(letters, 0, letters.Length - 1);
                    if (A[i] == word)
                    {
                        continue;
                    }
                    var newWord = word + A[i];
                    var j = 0;
                    var isBadWord = false;
                    while (j < newWord.Length && !isBadWord)
                    {
                        if(letters[(int)newWord[j] - 97]++ > 0)
                        {
                            isBadWord = true;
                            Console.WriteLine(newWord + " bad");
                        }
                        j++;
                    }
                    if (!isBadWord)
                    {
                        Console.WriteLine(newWord + " Good, length="+newWord.Length);
                        max = Math.Max(max, newWord.Length);
                    }
                }
            }
            return max;
        }

        private static int MicrosoftTest1(string S)
        {
            int[] letters = new int[26];
            for (int i = 0; i < S.Length; i++)
            {
                letters[(int)S[i]-97]++;
            }
            int sum = 0;
            for (int i = 1; i < letters.Length; i++)
            {
                while (Array.IndexOf(letters, letters[i])!=-1 &&
                    Array.IndexOf(letters, letters[i]) != i  &&
                    letters[i]!=0)
                {
                    letters[i]--;
                    sum++;
                }  
            }
            return sum;
        }

        private static int[] ShiftArray(int[] A, int K)
        {
            if (K == A.Length || A.Length == 0)
            {
                return A;
            }
            var length = A.Length;
            K = K % length;
            var C = new int[K];
            for (int i = 0; i < K; i++)
            {
                C[i] = A[A.Length - (K - i)];
            }
            int[] B = new int[A.Length];
            for (int i = 0; i < A.Length-K; i++)
            {
                B[i+K] = A[i];
            }
            for (int i = 0; i < K; i++)
            {
                B[i] = C[i];
            }
            return B;
        }

        public static int MaxBinaryGap(int N)
        {
            var maxZeroCounter = 0;
            string binary = Convert.ToString(N, 2);
            binary = binary.Trim('0');
            if (binary.Length == 1)
            {
                return maxZeroCounter;
            }
            var n = 0;
            while (n < binary.Length - 1)
            {
                var zeroCounter = 0;
                while (n < binary.Length - 1 && binary[n] == '0')
                {
                    n++;
                    zeroCounter++;
                }
                maxZeroCounter = Math.Max(zeroCounter, maxZeroCounter);
                while (n < binary.Length - 1 && binary[n] == '1')
                {
                    n++;
                }
            }
            return maxZeroCounter;
        }


            // get largets pair of lowercase and uppercase letter in a string
            public static string solution4(string S)
        {
            char[] A = S.ToCharArray();
            Array.Sort(A);
            Array.Reverse(A);
            var n = 0;
            while (
                n < A.Length &&
                char.IsLower(A[n]) &&
                Array.Find(A, x => (int)A[n] - (int)x == 32) == 0)
            {
                n++;
            }
            if (n == A.Length || char.IsUpper(A[n]))
            {
                return "NO";
            }
            return char.ToUpper(A[n]).ToString();
        }

        // largest pair of positive and negative integers in array 
        public static int solution3(int[] A)
        {
            Array.Sort(A);
            var n = 0;
            while (
                n < A.Length &&
                A[n] < 0 && 
                Array.Find(A, x => x + A[n] == 0) == 0)
            {
                n++;
            }
            return Math.Abs(A[n]);
        }


        // smallets integer that doesnt exist in an array - with sort
        public static int solution(int[] A)
        {
            if (A.Length == 1)
            {
                if (A[0] == 1)
                {
                    return 2;
                }
                return 1;
            }
            Array.Sort(A);
            var n = 0;
            while (
                n < A.Length - 1 &&
                A[n] < 1)
            {
                n++;
            }
            if (n == A.Length - 1 || A[n] > 1)
            {
                return 1;
            }
            while (
                (n < A.Length-1) &&
                (   
                    A[n] == A[n + 1] - 1 || 
                    A[n] == A[n + 1] )
                )
            {
                n++;
            }
            if (A[n] < 1)
                return 1;

            return A[n]+1;
        }
    }
}
