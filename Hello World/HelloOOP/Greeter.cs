using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloOOP
{
  // this is a class named Greeter. It is public, which means any other class can create a new instance of it.
  public class Greeter
  {
    #region Fields and Properties
    // traditional Field + Property combination

    // this is a field
    private string _GreetingMessage;

    // this is a property
    public string GreetingMessage
    {
      get
      {
        return _GreetingMessage;
      }
      private set
      {
        _GreetingMessage = value;
      }
    }

    // Auto-implemented Property (field as a "backing store" is "auto-generated")
    // this is a property that has thegetter and setter implemented automatically
    public string FarewellMessage { get; private set; }
    #endregion

    #region Constructors
    // this is a method
    public Greeter(string greeting, string farewell)
    {
      GreetingMessage = greeting;
      FarewellMessage = farewell;
    }
    #endregion

    #region Methods
    // this is a method
    public string SayGreeting(string name)
    {
      return name + ", " + GreetingMessage;
    }

    // this is a method
    public string SayGreeting()
    {
      return GreetingMessage;
    }

    // this is a method
    public string SayGoodbye(string name)
    {
      return name + " - " + FarewellMessage;
    }

    // this is a method
    public string SayGoodbye()
    {
      return FarewellMessage;
    }
    #endregion
  }
}
