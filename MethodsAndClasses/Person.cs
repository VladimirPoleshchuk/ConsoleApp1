using System;
namespace HelloPerson
{
class Person
    {
        public string name;
        public int age;
        public int weight;

        public Person() { }
        public Person(string n, int a, int w)
        {
            name= n;
            age = a;
            weight = w;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Name:{name}, Age: {age} , Weight: {weight} kg.");
        }

     }

    class Program
    {
        static void Main()
        {
            Person tom = new Person("Tom", 20, 65);
            Person ulia = new Person();
            

            tom.GetInfo();

            ulia.name = "Ulia";
            ulia.age = 18;
            ulia.weight = 55;
            ulia.GetInfo();
        }
    }


}
