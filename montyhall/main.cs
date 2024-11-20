using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
  class Program
  {
    static void Main(string[] args)
    { 
      Console.Write("\n 수학체험전에 오신걸 환영합니다!\n\n 제작자 SNS           Instargram : otter._.king \n                                Made by. 김인성 \n\n 시행 횟수를 입력하세요 : ");
      string times = Console.ReadLine();
      int a = Int32.Parse(times);
      
      Random _Random = new Random();

      string[] door = new string[3];
      int car, select;
      int open = 0;
      int count = 0;
      int pass = 0;

      float carSelect_notChange;
      float carSelect_Change;

      // 1
      while (count < a)
      {
        car = _Random.Next(0, 3); // car = 0, 1, 2

        for (int i = 0; i < door.Length; i++)
        {
          if (i == car)
          {
            door[i] = "Car";
          }
          else
          {
            door[i] = "Goat";
          }
        }

        Console.WriteLine("문을 선택하세요.");
        select = _Random.Next(1, 4);
        Console.WriteLine("> {0}", select); // 랜덤 선택 (1, 2, 3)
        Console.WriteLine();

        if (select == car + 1) // 차를 골랐을 때
        {
          int temp = _Random.Next(1, 3);
          open = (car + temp) % 3;
        }
        else // 염소를 골랐을 때
        {
          for (int i = 0; i < door.Length; i++)
          {
            if (door[i] == "Goat" && select != i + 1)
            {
              open = i;
            }
          }
        }

        Console.WriteLine("[{0}] {1}\n", open + 1, door[open]);
        Console.WriteLine("선택을 바꾸시겠습니까?");
        /*
        for (int i = 0; i < door.Length; i++)
        {
          if (i != open && i != select - 1)
          {
            select = i + 1;
            break;
          }
        }
        */
        Console.WriteLine("> {0}", select); // 같은 문 선택
        Console.WriteLine();

        if (select == car + 1)
        {
          Console.WriteLine("축하합니다. 당신은 차를 얻었습니다.");
          pass++;
        }
        else{
          Console.WriteLine("유감입니다. 염소를 선택하셨습니다.");
        }

        for (int i = 0; i < door.Length; i++)
        {
          Console.WriteLine("[{0}] {1}", i + 1, door[i]);
        }
        Console.WriteLine();

        count++;
      }

      carSelect_notChange = (float)pass / count * 100;

      count = 0;
      pass = 0;

      // 2
      while (count < a)
      {
        car = _Random.Next(0, 3); // car = 0, 1, 2

        for (int i = 0; i < door.Length; i++)
        {
          if (i == car)
          {
            door[i] = "Car";
          }
          else
          {
            door[i] = "Goat";
          }
        }

        Console.WriteLine("문을 선택하세요.");
        select = _Random.Next(1, 4);
        Console.WriteLine("> {0}", select); // 랜덤 선택 (1, 2, 3)
        Console.WriteLine();

        if (select == car + 1) // 차를 골랐을 때
        {
          int temp = _Random.Next(1, 3);
          open = (car + temp) % 3;
        }
        else // 염소를 골랐을 때
        {
          for (int i = 0; i < door.Length; i++)
          {
            if (door[i] == "Goat" && select != i + 1)
            {
              open = i;
            }
          }
        }

        Console.WriteLine("[{0}] {1}\n", open + 1, door[open]);
        Console.WriteLine("선택을 바꾸시겠습니까?");
        for (int i = 0; i < door.Length; i++)
        {
          if (i != open && i != select - 1)
          {
            select = i + 1;
            break;
          }
        }
        Console.WriteLine("> {0}", select); // 다른 문 선택
        Console.WriteLine();

        if (select == car + 1)
        {
          Console.WriteLine("축하합니다. 당신은 차를 얻었습니다.");
          pass++;
        }
        else{
          Console.WriteLine("유감입니다. 염소를 선택하셨습니다.");
        }

        for (int i = 0; i < door.Length; i++)
        {
          Console.WriteLine("[{0}] {1}", i + 1, door[i]);
        }
        Console.WriteLine();

        count++;
      }

      carSelect_Change = (float)pass / count * 100;

      Console.WriteLine("선택을 바꾸지 않았을 때, 차를 얻을 확률 : {0}%", carSelect_notChange);
      Console.WriteLine("선택을 바꾸었을 때, 차를 얻을 확률 : {0}%", carSelect_Change);
      Console.ReadLine();
    }
  }
}