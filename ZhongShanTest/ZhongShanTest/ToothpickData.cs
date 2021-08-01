using System;
using System.Collections.Generic;
using System.Text;

namespace ZhongShanTest
{
    public static class ToothpickData
    {
        //存储每一行的牙签数
        public static List<int> list { get; set; }

        //存储还有哪些行数有牙签的
        public static List<int> rowList { get; set; }

        //第几轮
        public static int times = 1;

        static ToothpickData()
        {
            //0是占位的，让list的索引对应行数
            list = new List<int>() { 0, 3, 5, 7 };
            //初始化，1，2，3行都有牙签
            rowList = new List<int>() { 1, 2, 3 };
        }

    }
}
