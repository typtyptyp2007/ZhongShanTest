using System;
using System.Collections.Generic;
using System.Text;

namespace ZhongShanTest
{
    public class ToothpickService
    {

        /// <summary>
        /// 查询剩余牙签的行的数量
        /// </summary>
        /// <returns></returns>
        public int QueryLeftRowNum()
        {
            return ToothpickData.rowList.Count;
        }

        /// <summary>
        /// 取出牙签后的数量记录
        /// </summary>
        /// <param name="row"></param>
        /// <param name="num"></param>
        public void TakeOut(int row,int num)
        {
            var numByRow = ToothpickData.list[row];
            if (num <= 0)
            {
                throw new Exception("取出的牙签数必须大于0");
            }
            if (numByRow < num)
            {
                throw new Exception("剩余牙签数小于取出的牙签数，程序异常");
            }

            var leftNum = numByRow - num;
            if (leftNum == 0)
            {
                //移除没有牙签的行数
                ToothpickData.rowList.Remove(row);
            }

            ToothpickData.list[row] = leftNum;
        }

        /// <summary>
        /// 查询本行有几根牙签
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public int QueryNumByRow(int row)
        {
            return ToothpickData.list[row];
        }

        /// <summary>
        /// 检查是否所有牙签被取完
        /// </summary>
        /// <returns></returns>
        public bool CheckIfLose()
        {
            return ToothpickData.rowList.Count == 0;
        }

        /// <summary>
        /// 显示当前每行剩余牙签数
        /// </summary>
        public void DisplayNum()
        {
            Console.WriteLine("======================");
            for (int i = 1; i < ToothpickData.list.Count; i++)
            {
                Console.WriteLine($"第{i}行：{ToothpickData.list[i]}根牙签");
            }
            Console.WriteLine("======================");
        }

    }
}
