using System;
using System.Collections.Generic;

namespace Test_8
{
    public class Problem11
    {
        public Problem11()
        {
        }

        public int[] merge(int[] arr1, int[] arr2)
        {
            int maxSize;
            int pointer1 = 0;
            int pointer2 = 0;
            List<int> arr = new List<int>();
            maxSize = arr1.Length + arr2.Length;

            if (arr1.Length == 0){
                return arr2;
            }
            if (arr2.Length == 0){
                return arr1;
            }

            for (int i = 0; i < maxSize; i++)
            {
                if ((pointer1 <= (arr1.Length - 1)) && pointer2 <= (arr2.Length - 1))
                {
                    if (arr1[pointer1] > arr2[pointer2])
                    {
                        arr.Add(arr2[pointer2]);
                        pointer2++;
                    }
                    else
                    {
                        arr.Add(arr1[pointer1]);
                        pointer1++;
                    }
                } else{
                    if (pointer1 == (arr1.Length)){
                        arr.Add(arr2[pointer2]);
                        pointer2++;
                    } else {
                        arr.Add(arr1[pointer1]);
                        pointer1++;
                    }
                }
            }


            return arr.ToArray();


        }
    }
}
