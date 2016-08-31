using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
//using PaintDotNet.Threading;
//using PaintDotNet.UI.Media;
//using PaintDotNet.UI.Media;

namespace ToolBox.Algrithm
{
    public class InverseString
    {
        public string Inverse(string inputString)
        {
            var str = "";
            for (var i = inputString.Length - 1; i >= 0; i--)
            {
                str += inputString[i];
            }
            return str;
        }

        public bool IsPowerOfThree(int num)
        {
            if (1 == num) return true;
            if (num >= 3)
            {
                if (num % 3 == 0)
                {
                    num /= 3;
                    return IsPowerOfThree(num);
                }
            }
            return false;
        }

        //Haminweight
        private int count = 0;
        public int NumOfOne(int num)
        {
            switch (num)
            {
                case 0:
                    count = 0;
                    break;
                case 1:
                    count = 1;
                    break;
                default:
                    count = NumOfOne(num%2) + NumOfOne(num/2);
                    break;
            }
            return count;
        }

        public string ReversString(string str)
        {
            int i = 0, j = str.Length - 1;
            var charArray = str.ToCharArray();
            while (j > i )
            {
                var tmp = charArray[i];
                charArray[i] = charArray[j];
                charArray[j] = tmp;
                
                i++;
                j--;
            }
            return new string(charArray);
        }

        public int RemoveDuplicates(int[] nums)
        {
            var array = new List<int>();
            if (nums.Length <= 0) return array.Count;
            int[] flag = {nums[0]};
            array.Add(flag[0]);
            foreach (int t in nums.Where(t => flag[0] != t))
            {
                flag[0] = t;
                array.Add(flag[0]);
            }
            return array.Count;

        }
    }
}
