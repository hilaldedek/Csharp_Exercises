using System;
using System.Xml.XPath;
namespace HelloWorld
{
  class Authentication
  {

        static void Main(string[] args)
    {
      string username="hilal";
      string email="hdedek03@gmail.com";
      string password="123";
      string? data;
      string? enteredPassword;
      bool buffer=true;
      do{
        Console.Write("Please enter your username or email: ");
        data=Console.ReadLine();
        if((data==email)||(data==username)){
            Console.Write("Please enter your password: ");
            enteredPassword=Console.ReadLine();
            if(password==enteredPassword){
                Console.WriteLine("Succesfully logged in!");
                buffer=true;
            }
            else{
                Console.WriteLine("Your password is wrong!");
            }
        }
        else{
            Console.WriteLine("Username or email wrong!");
        }
      }while(buffer==false);
    }
  }
}
