namespace Constructor
{
    internal class Program
    {
        class Parent
        {
            int age;
            protected int money;

            // 생성자
            // 클래스가 인스턴스가 생성되는 시점에서 
            // 자동으로 호출되는 특수한 멤버 메소드입니다.
            public Parent(string name)
            {
                Console.WriteLine(name + "Class 생성");
            }

            protected void Information()
            {
                Console.WriteLine("Parent Class 입니다.");
            }

        }

        // Child 클래스가 Parent 클래스를 상속합니다.
        class Child : Parent
        {
            // 기본 생성자
            // 생성자가 없을 때 컴파일러가 자동으로 생성해주는 
            // 생성자입니다.

            // base()
            // 상위 클래스의 생성자를 호출하는 메소드입니다.
            // Parent("") == base("")
            public Child() : base(" ")
            {
                Console.WriteLine("Child Class 생성");
            }

            // int age
            int money;

            public void Function()
            {
                // base는 상위 클래스를 가리키는 포인터입니다.
                // this는 자기 자신을 가리키는 포인터입니다.
                base.money += 1;  // 상위 클래스 money 변수
                this.money += 10; // 하위 클래스 money 변수

                // base 키워드와 this 키워드를 사용하지 않고 
                // 이름이 겹치는 멤버 변수를 호출했다면 this 포인터가 
                // 우선권을 가지게 됩니다.
                Console.WriteLine("money의 값 " + money);
            }
        }

        // 메소드의 오버로딩
        // 같은 이름의 함수를 매개 변수의 자료형과 매개변수의
        // 수로 구분하여 여러 개를 선언할 수 있는 기능입니다.

        class Vector
        {
            public void Coordinate(int x, int y)
            {
                Console.WriteLine("int x의 값 : " + x + " int y의 값 : " + y);
            }

            public void Coordinate(float x, float y)
            {
                Console.WriteLine("float x의 값 : " + x + " float y의 값 : " + y);
            }

            public void Coordinate(float x, float y, float z)
            {
                Console.WriteLine("x의 값 : " + x + "y의 값 : " + y + "z의 값 : " + z);

            }
        }

        static void Main(string[] args)
        {
            // 상속
            // 상위 클래스의 속성을 하위 클래스가
            // 사용할 수 있도록 설정해주는 기능입니다.
            Parent parent = new Parent("Parent");

            Child child = new Child();
            child.Function();

            // 메소드의 오버로딩
            Vector vector = new Vector();
            vector.Coordinate(10.5f, 20.5f);

            vector.Coordinate(10, 20);
        }
    }
}