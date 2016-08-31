using System;
using System.Collections.Generic;

namespace ToolBox.Algrithm
{
    public class IntConventor
    {
        readonly List<GNum> m_List = new List<GNum>();
        public string ConvertToChineseCap(string inputString)
        {
            var str = "";
            var num = Convert.ToInt32(inputString);
            var dicNum = new Dictionary<int, string>
            {
                {1, "一"},
                {2, "二"},
                {3, "三"},
                {4, "四"},
                {5, "五"},
                {6, "六"},
                {7, "七"},
                {8, "八"},
                {9, "九"},
                {0, "零"},
            };
            var unitList = new List<string> { "", "十", "百", "千", "万", "十万" };
            var convertNum = ConvertNum(num, 0);

            var flag = 0;
            for (var i = convertNum.Count - 1; i >= 0; i--)
            {
                if (convertNum[i].Num != 0)
                {
                    flag = 0;
                    str += dicNum[convertNum[i].Num] + unitList[convertNum[i].Unite - 1];
                }
                else
                {
                    if (flag == 0 && convertNum[i].Unite != 1)
                    {
                        str += "零";
                    }
                    flag += 1;
                }
            }
            if (flag == convertNum.Count - 1)
            {
                str = str.Remove(str.IndexOf("零", StringComparison.Ordinal));
            }
            return str ==""?"零":str;
        }

        private List<GNum> ConvertNum(int num, int count)
        {
            var result = num % 10;
            count++;
            m_List.Add(new GNum(result, count));
            num /= 10;
            if (num > 0) ConvertNum(num, count);
            return m_List;
        }
    }
}

public class GNum
{
    public GNum(int num, int unite)
    {
        Num = num;
        Unite = unite;
    }

    public int Num { get; set; }

    public int Unite { get; set; }

}
