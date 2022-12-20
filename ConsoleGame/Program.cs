using System;

namespace ConsoleGame
{
    // 인터페이스
    // 클래스들이 구현해야하는 동작을 지정하는 용도로
    // 사용되는 추상 자료형입니다.

    interface IMonitor
    {     
        // 인터페이스는 메소드를 선언만 할 수 있습니다.
        // 인터페이스의 기본 접근 지정자는 public으로 설정됩니다.
        void Power();
    }

    interface IMouse
    {
        // 인터페이스는 멤버 변수를 가질 수 없습니다.
        // 인터페이스는 프로퍼티를 가질 수 있습니다.
        // int value;
        // int Damage { set; get; }
        void Click();
    }

    // C#에서는 다중 상속이 지원되지 않습니다.
    class Computer : IMonitor, IMouse
    {
        public void Click()
        {
            Console.WriteLine("마우스 클릭");
        }

        public void Power()
        {
            Console.WriteLine("모니터 전원 On");
        }
    }


    interface IObject
    {
        void HealthManager();      
    }

    class Player : IObject
    {
        public int hp;

        public void HealthManager()
        {
            hp -= 50;
            Console.WriteLine("Player의 체력이 감소되었습니다. hp : " + hp);
        }
    }

    class Monster : IObject
    {
        public int hp;

        public void HealthManager()
        {
            hp -= 25;
            Console.WriteLine("Monster의 체력이 감소되었습니다. hp : " + hp);
        }
    }

    class Damage // <- 데미지를 처리하는 클래스입니다.
    {
        public void DecreaseHP(IObject iobject)
        {
            iobject.HealthManager();
        }   
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 인터페이스

            // Computer computer = new Computer();
            // computer.Power();
            // computer.Click();

            // 인터페이스는 객체로 인스턴스할 수 없습니다.
            // IMouse mouse = new IMouse();

            // 인터페이스는 참조 변수로 사용할 수 있습니다.
            // IMouse lg = new Computer();
            // lg.Click();
            #endregion

            Monster goblin = new Monster(); // 고블린 (몬스터)
            goblin.hp = 100;                // 고블린 체력 : 100

            Monster slime = new Monster(); // 슬라임 (몬스터)
           
            Player player = new Player(); // 플레이어 (플레이어)
            player.hp = 100;              // 플레이어 체력 : 100

            Damage damage = new Damage();
            damage.DecreaseHP(goblin);
            damage.DecreaseHP(player);

        }
    }
}
