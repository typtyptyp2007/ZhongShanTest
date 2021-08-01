using System;
using System.Collections.Generic;
using System.Text;

namespace ZhongShanTest
{
    public class Player
    {
        private string name;
        private ToothpickService toothpickService;

        public Player(string name)
        {
            this.name = name;
            toothpickService = new ToothpickService();
        }

        public bool TakeOutToothpick(int row,int num)
        {
            Console.WriteLine($"用户{name} 取第{row}行，取{num}根牙签");

            toothpickService.TakeOut(row, num);

            if (toothpickService.CheckIfLose())
            {
                Console.WriteLine($"用户{name} 取到了最后一根牙签，是输家！");
                //终止游戏
                return false;
            }

            return true;
        }

        /// <summary>
        /// 取火柴操作
        /// </summary>
        /// <returns></returns>
        public bool TakeOutToothpick()
        {
            var random = new Random();
            //取哪一行
            var rowCount = toothpickService.QueryLeftRowNum();
            var rowListIndex = random.Next(0, rowCount);
            var row = ToothpickData.rowList[rowListIndex];

            //取几根牙签
            var toothPickNumByRow = ToothpickData.list[row];
            random = new Random();
            var toothPickNum = random.Next(1, toothPickNumByRow + 1);

            Console.WriteLine($"用户{name} 取第{row}行，取{toothPickNum}根牙签");

            toothpickService.TakeOut(row, toothPickNum);

            if (toothpickService.CheckIfLose())
            {
                Console.WriteLine($"用户{name} 取到了最后一根牙签，是输家！");
                //终止游戏
                return false;
            }

            return true;
        }

    }
}
