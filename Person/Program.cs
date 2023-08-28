using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

partial class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.FirstName = "John";
        person.LastName = "Doe";

        person.PrintFullName();
        Console.ReadLine();
    }
  }
}

