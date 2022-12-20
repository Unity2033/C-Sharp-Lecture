namespace Override
{
    // 오버라이딩
    // 상위 클래스에 있는 메소드를 하위 클래스에서
    // 재정의하여 사용하는 기능입니다.
    class Animal
    {
        public void Sound()
        {
            Console.WriteLine("동물의 울음 소리");
        }

        // 가상 함수
        // 상속하는 클래스 내에서 같은 형태의 함수로 재정의될 수 있는
        // 함수입니다.
        virtual public void Action()
        {
            Console.WriteLine("동물의 행동");
        }
    }

    class Dog : Animal
    {
        // 메소드 숨기기
        // 상위 클래스로부터 상속 받은 멤버와 이름은
        // 동일하지만, 완전히 다른 새로운 메소드를 정의할 때 
        // 사용하는 키워드입니다.
        new public void Sound()
        {
            Console.WriteLine("멍~멍~");
        }

        // 오버라이딩
        override public void Action()
        {
            Console.WriteLine("강아지의 행동");
        }

        public void Tracking()
        {
            Console.WriteLine("강아지가 추적합니다.");
        }
    }

    internal class Program
    {
        // 선택적 매개변수
        // 기본 값을 가지는 매개변수이며, 선택적 매개변수로
        // 선언된 매개변수는 인수를 전달하지 않아도 됩니다.
        static void Function(int x, int y = 100)
        {
            // 선택적 매개변수는 인수를 전달할 때 왼쪽에서부터
            // 값이 저장되기 때문에 오른쪽에서부터 선택적 매개변수를
            // 선언해주어야 합니다.
            Console.WriteLine("x의 값 : " + x);
            Console.WriteLine("y의 값 : " + y);
        }

        // 명명된 매개변수
        // 메소드를 호출할 때 필요한 매개변수 이름을 직접
        // 지정해서 사용하는 매개변수입니다.
        static void Information(string name, int age, char blood)
        {
            Console.WriteLine("name : " + name);
            Console.WriteLine("age : " + age);
            Console.WriteLine("blood : " + blood);
        }

        static void Main(string[] args)
        {
            #region 메소드 숨기기 & 오버라이딩
            // Animal animal = new Animal();
            // animal.Action(); // 동물의 행동
            // animal.Sound();  // 동물의 울음소리

            // Dog dog = new Dog();
            // dog.Action(); // 강아지의 행동
            // dog.Sound();  // 멍~멍~

            // Animal parent = new Dog();
            // 런타임 중에 어떤 함수를 호출할 지 결정하는 행위 
            // parent.Action(); // 강아지의 행동
            // parent.Sound(); // 동물의 울음소리
            #endregion

            // 선택적 매개변수
            Function(10); // x(10), y(100) 
            Function(50, 500); // x(50), y(500)

            // 명명된 매개변수
            Information("kim", 10, 'O');

            Information(age: 20, blood: 'A', name: "son");
        }
    }
}