using System.Text;
using System.Threading.Tasks;
using System;

namespace FirstProject
{
  public class Person
  {
    public string Name;
    public int Age;
    public bool HasPet;

    public void Greeting ()
    {
      Console.Write ("Hi! My name is " + Name + " and my age is " + Age +
		     " " + HasPet + "\n");
    }
  }

  class Program
  {
    static void Main (string[]args)
    {
      Person person = new Person ();

        person.Name = "Ali";
        person.Age = 26;
        person.HasPet = true;

        person.Greeting ();

      Person person2 = new Person ();

        person2.Name = "Oscar";
        person2.Age = 19;
        person2.HasPet = false;

        person2.Greeting ();
    }
  }

}
