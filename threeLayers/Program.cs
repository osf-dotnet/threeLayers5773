using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace threeLayers
{
    class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    class MyData
    {
        List<Person> personList;
        public MyData()
        {
            personList = new List<Person>();
        }
        public bool AddPerson(Person p)
        {
            if (p == null)
                return false;
            personList.Add(p);
            return true;
        }
        public bool RemovePerson(int id)
        {
            Person p = personList.Find(v => v.ID == id);
            return personList.Remove(p);
        }
        public bool UpdatePerson(Person p)
        {
            int index = personList.FindIndex(v => v.ID == p.ID);
            if (index == -1)
                return false;
            personList[index] = p;
            return true;

        }
        public List<Person> GetAllPerson(Person p)
        {
            return personList;
        }
    }

    class Program
    {
        int x;
        Person p;
        public Program()
        {
            Console.WriteLine(1);
        }
        class MyClass
        {
            public void f1()
            {
             
            }
            public MyClass()
            {
                Console.WriteLine(2);
            }
        }
        static void Main(string[] args)
        {
            new Program.MyClass();
        }
    }
}
