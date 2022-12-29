using System;

namespace ConsoleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 분할 클래스 
            // 클래스 구현이 길어질 경우 2개 이상의
            // 소스 파일로 분할하여 동시에 작업을 수행
            // 하거나, 관리의 편의를 위해 분할하는 클래스입니다.

            // NPC npc = new NPC();

            // npc.health = 100;
            // npc.Dialog();
            #endregion

            // action
            // 반환형 메소드가 없는 메소드를 저장할 수 있는 delegate
            Action<int> action = (int a) => Console.WriteLine("Action 입니다.");
            action(10);

            // Func
            // 반환형이 존재하는 메소드를 저장할 수 있는 delegate 
            // Func<매개변수, 반환형>

            Func<int, int> func = (int a) => a;

            Console.WriteLine("func의 값 : " + func(10));
        }
    }
}
