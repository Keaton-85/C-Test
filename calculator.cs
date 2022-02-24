using System;
/*
This is for performing calculations
*/
public class Calculate{
  public double equal = 0;
  public double one = 0;
  public double two = 0;
  public static bool quit = false;
  public static string done = "";
  public string perform;

  public void calculate(){
    Menu menu = new Menu();
    Program prog = new Program();
    Console.WriteLine("What is the first number?");
    one = Int32.Parse(Console.ReadLine());
    Console.WriteLine("What is the second number?");
    two = Int32.Parse(Console.ReadLine());
    Console.WriteLine("add, sub, multi, or div?");
    perform = Console.ReadLine();
    if(perform ==  "add"){
      equal = one + two;
    }
    if(perform ==  "sub"){
      equal = one - two;
    }
    if(perform ==  "multi"){
      equal = one * two;
    }
    if(perform ==  "div"){
      equal = one / two;
    }
    Console.WriteLine("= " + equal);
    Console.WriteLine("Are you done?");
    done = Console.ReadLine();
    if(done == "yes" || done == "y" || done == "Yes" || done == "Y"){
      quit = false;
      Console.WriteLine("Ok");
      Console.Clear();
      menu.menu();
    }
    else{
      Console.Clear();
      Console.WriteLine("= " + equal);
      calculate();
      
    }

  }
}