using System;
using System.ComponentModel;

namespace ZhongShanTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1、机器人互相对战 2、自由对战 3、人机对战");
            var num = Console.ReadLine();
            switch (num)
            {
                case "1":
                    RobotAndRobot();
                    break;
                case "2":
                    ManAndMan();
                    break;
                case "3":
                    ManAndRobot();
                    break;
                default:
                    Console.WriteLine("输入错误请重启");
                    break;
            }
            Console.ReadKey();
        }

        public static void ManAndRobot()
        {
            var toothpickService = new ToothpickService();
            var playerA = new Player("A");
            var playerB = new Player("B");
            while (true)
            {
                Console.WriteLine($"第{ToothpickData.times}轮：");
                toothpickService.DisplayNum();
            Arow: Console.WriteLine("A玩家取第几行？");
                var row = Console.ReadLine();
                if (int.Parse(row) < 1 || int.Parse(row) > 3)
                {
                    Console.WriteLine("行数必须在1-3之间！");
                    goto Arow;
                }

                Console.WriteLine("A玩家取几根牙签？");
                var num = Console.ReadLine();
                if (int.Parse(num) <= 0)
                {
                    Console.WriteLine("取出的牙签数必须大于0");
                    goto Arow;
                }
                var leftNum = toothpickService.QueryNumByRow(int.Parse(row));
                if (int.Parse(num) > leftNum)
                {
                    Console.WriteLine("取出的牙签数必须小于等于本行的牙签数");
                    goto Arow;
                }

                if (!playerA.TakeOutToothpick(int.Parse(row), int.Parse(num)))
                {
                    break;
                }

                if (!playerB.TakeOutToothpick())
                {
                    break;
                }

                ToothpickData.times++;

            }
        }

        public static void ManAndMan()
        {
            var toothpickService = new ToothpickService();
            var playerA = new Player("A");
            var playerB = new Player("B");
            while (true)
            {
                Console.WriteLine($"第{ToothpickData.times}轮：");
                toothpickService.DisplayNum();
            Arow: Console.WriteLine("A玩家取第几行？");
                var row = Console.ReadLine();
                if (int.Parse(row) < 1 || int.Parse(row) > 3)
                {
                    Console.WriteLine("行数必须在1-3之间！");
                    goto Arow;
                }

                Console.WriteLine("A玩家取几根牙签？");
                var num = Console.ReadLine();
                if (int.Parse(num) <= 0)
                {
                    Console.WriteLine("取出的牙签数必须大于0");
                    goto Arow;
                }
                var leftNum = toothpickService.QueryNumByRow(int.Parse(row));
                if (int.Parse(num) > leftNum)
                {
                    Console.WriteLine("取出的牙签数必须小于等于本行的牙签数");
                    goto Arow;
                }

                if (!playerA.TakeOutToothpick(int.Parse(row), int.Parse(num)))
                {
                    break;
                }

                toothpickService.DisplayNum();

            Brow: Console.WriteLine("B玩家取第几行？");
                var row2 = Console.ReadLine();
                if (int.Parse(row2) < 1 || int.Parse(row2) > 3)
                {
                    Console.WriteLine("行数必须在1-3之间！");
                    goto Brow;
                }

                Console.WriteLine("B玩家取几根牙签？");
                var num2 = Console.ReadLine();
                if (int.Parse(num2) <= 0)
                {
                    Console.WriteLine("取出的牙签数必须大于0");
                    goto Brow;
                }
                var leftNum2 = toothpickService.QueryNumByRow(int.Parse(row2));
                if (int.Parse(num2) > leftNum2)
                {
                    Console.WriteLine("取出的牙签数必须小于等于本行的牙签数");
                    goto Brow;
                }

                if (!playerB.TakeOutToothpick(int.Parse(row2), int.Parse(num2)))
                {
                    break;
                }

                ToothpickData.times++;
            }
        }

        public static void RobotAndRobot()
        {
            var toothpickService = new ToothpickService();
            var playerA = new Player("A");
            var playerB = new Player("B");
            while (true)
            {
                Console.WriteLine($"第{ToothpickData.times}轮：");
                toothpickService.DisplayNum();
                if (!playerA.TakeOutToothpick())
                {
                    break;
                }

                if (!playerB.TakeOutToothpick())
                {
                    break;
                }

                ToothpickData.times++;
            }
        }

    }
}
