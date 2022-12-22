namespace Delegate
{
    class Watch
    {
        // readonly : 런타임 시점에 결정되는 상수
        // 상수를 초기화하지 않아도 사용할 수 있습니다.
        readonly int count = 50;

        public Watch() // 생성자
        {
            // 생성자에서 단 한번만 값을 초기화할 수 있습니다.
            count = 100;
            Console.WriteLine("count의 값 : " + count);
        }
    }

    // 델리게이트 선언
    // delegate [반환형] [델리게이트 이름] (매개변수)
    delegate void Calculator(int x, int y);

    // 델리게이트는 메소드의 반환형과 매개 변수의 타입이 일치해야 사용할 수 있습니다.
    class Weapon
    {
        public void Stat(int x, int y)
        {
            int result = x + y;
            Console.WriteLine("Stat 메소드의 값 : " + result);
        }

        public void Price(int x, int y)
        {
            int result = x - y;
            Console.WriteLine("Price 메소드의 값 : " + result);
        }

        public void Damage(int x, int y)
        {
            int result = x * y;
            Console.WriteLine("Damage 메소드의 값 : " + result);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 상수
            // 프로그램이 실행되는 동안 변하지 않는 값

            // const : 컴타임 시점에 결정되는 상수
            // 상수를 선언과 동시에 초기화를 해주어야 합니다.

            // pi 3.14
            // gravity 9.81

            // const int data = 50; 
            // const int value = 10;

            // Console.WriteLine("value의 값 : " + value);
            // Watch watch = new Watch();
            #endregion

            #region 델리게이트(대리자)
            // 메서드를 대신해서 호출하는 기법입니다.  
            //Weapon weapon = new Weapon();

            // 델리게이트 정의
            //Calculator calculator;

            // 델리게이트 변수에 Stat의 주소를 저장합니다.
            // calculator = weapon.Stat;
            //calculator(10, 20);

            //calculator = weapon.Price;
            //calculator(10, 20);

            //calculator = weapon.Damage;
            //calculator(10, 20);
            #endregion

            // 델리게이트 체인
            // 하나의 델리게이트에 여러 개의 메소드를 연결시키는 기법입니다.

            Weapon weapon = new Weapon();

            Calculator calculator;

            // 델리게이트 비어있는 상태 메소드를 추가할 수 없습니다.
            calculator = weapon.Stat;
            calculator += weapon.Price;
            calculator += weapon.Damage;

            calculator(10, 20);

            // 델리게이트에 등록된 메소드를 뺍니다.
            calculator -= weapon.Damage;

            calculator(10, 20);
        }
    }
}