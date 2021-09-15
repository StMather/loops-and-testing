using System;
using System.Collections.Generic;
using System.Text;

namespace Warm_up_loops
{
    public class ForLoop
    {
        /// <summary>
        /// Return lowest number in array
        /// </summary>
        /// <param name="arr">System.Int32[]</param>
        /// <returns>Returns lowest number in array.  If array is empty, returns null</returns>
        public int? GetLowest(int[] arr)
        {
            if (arr.Length == 0)
            {
                return null;
            }
            int x = int.MaxValue;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i]< x)
                {
                    x = arr[i];
                }
            }
            return x;

        }

        /// <summary>
        /// Return highest number in array
        /// </summary>
        /// <param name="arr">System.Int32[]</param>
        /// <returns>Returns highest number in array.  If array is empty, returns null</returns>
        public int? GetHighest(int[] arr)
        {
            if (arr.Length==0)
            {
                return null;
            }
            int x = int.MinValue;
            for (int i = 0;i < arr.Length; i++)
            {
                
                if (arr[i]> x)
                {
                    x  =  arr[i];

                }
            }
                    return x;
        }

        /// <summary>
        /// Return highest number in jagged array
        /// </summary>
        /// <param name="arr">System.Int32[][]</param>
        /// <returns>Returns highest number in array.  If there are no numbers provided, returns null</returns>
        public int? GetHighest(int[][] arr)
        {
            int? x = null;
            for (int i = 0; i < arr.Length; i++)
            { 
                
                
                
                if (arr[i].Length == 0) { }
                else
                {
                    for (int j = 0; j < arr[i].Length; j++)
                    {
                        if(x == null)
                        {
                            x = arr[i][j];
                        }
                        if (arr[i][j] > x)
                        {
                            x = arr[i][j];

                        }
                    }
                }
                
            }
         
           
            return x;
        }
    }
}
