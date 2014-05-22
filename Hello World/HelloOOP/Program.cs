﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloOOP
{
  // this is a class named Program. because there is no accessModifier specified, it's access defaults to "internal".
  class Program
  {
    // this is a static method and happens to be the method that is called to start the program
    static void Main(string[] args)
    {
      // Declare two variables (object references)
      Greeter walmartEmployee, klingonWarrior;

      // Instantiate (create) the objects
      walmartEmployee = new Greeter("Welcome to Walmart!",
                                    "Thank you for shopping at Walmart!!");
      klingonWarrior = new Greeter("nuqneH! yI'el!",
                                   "Qapla'!");

      // Use the objects
      Console.WriteLine("The Walmart Employee sample:");
      Speak(walmartEmployee, "Dan");

      Console.WriteLine("The Klingon Warrior sample:");
      Speak(klingonWarrior, "Worf");
    }

    // this is a method
    static void Speak(Greeter someone, string name)
    {
      Console.WriteLine(someone.SayGreeting(name));
      Console.WriteLine(someone.SayGoodbye());
      Console.WriteLine(); // blank line
    }
  }
}
