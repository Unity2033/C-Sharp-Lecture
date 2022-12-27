using System;
using System.Collections; // 컬렉션 네임스페이스
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ConsoleGame
{
    internal class Program
    {      
        static void Main(string[] args)
        {
            // 콜렉션
            // 데이터를 저장하는 자료구조와 데이터를 처리하는
            // 알고리즘을 구조화하여 클래스로 나타낸 형태입니다.

            // List 

            #region ArrayList
            /*
            ArrayList arrayList = new ArrayList();

            // Add()		args	{string[0]}	string[]

            //  0     1      2       3        4
            // [1] [64.5f] ['V'] ["under"] [false]
            arrayList.Add(1);
            arrayList.Add(64.5f);
            arrayList.Add('V');
            arrayList.Add("under");
            arrayList.Add(false);

            // Insert(,)
            // (저장하고 싶은 index), (저장할 값) 
            arrayList.Insert(1, 33.987);
           
            // Remove()
            arrayList.Remove(64.5f);

            // RemoveAt()
            arrayList.RemoveAt(0);

            // size 
            int size = arrayList.Count;

            foreach (var element in arrayList)
            {
                Console.WriteLine(element);            
            }
            */
            #endregion

            // Dictionary
            // Class Champion
            Dictionary<string, int> item = new Dictionary<string, int>();

            // Add()
            // key(string), value(int)
            item.Add("Sword", 10000);
            item.Add("Hat", 1000);
            item.Add("Shose", 5000);
            item.Add("Gloves", 3000);

            // Remove()
            item.Remove("Shose");

            // Key 정보 탐색
            bool findKey = item.ContainsKey("Hat");

            // Value 정보 탐색
            bool findValue = item.ContainsValue(1000);

            Console.WriteLine(item["Riven"]);



            // Stack

            // Queue
        }
    }
}
