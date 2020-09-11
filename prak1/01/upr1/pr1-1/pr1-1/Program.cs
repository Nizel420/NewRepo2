using System;

namespace pr1_1
{
  class Program
  {
    static void Main(string[] args)
    {
      Person p = new Person("Tony", "Allen", 32); Console.WriteLine(p);
    }
  }
  struct Person
  {
    public string firstName;
    public string lastName;
    public int age;
    public enum Genders : int { Male, Female };
    public Person(string _firstName, string _lastName, int _age)
    {
      firstName = _firstName;
      lastName = _lastName; age = _age;
    }
    public override string ToString()
    {
      return firstName + " " + lastName + ", age " + age;
    }
  }
}
