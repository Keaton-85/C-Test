using System;

class NumberGuess{
  Menu menu = new Menu();
  public void guess(){
    string num = "0";
    Random rand = new Random();
    int selNum = rand.Next(0,10);
    Console.WriteLine("Welcome to guess the number");
    Console.WriteLine("Level 1: Numbers 1-10");
    while(selNum != Int32.Parse(num)){
      num = Console.ReadLine();
      if(selNum != Int32.Parse(num)){
        Console.WriteLine("You're Wrong!");
      }
      if(selNum != Int32.Parse(num) && Int32.Parse(num) == 7){
        Console.WriteLine("Is that even a number...");
      }
    }
    Console.Clear();
    Console.WriteLine("You win!");
    menu.menu();
    
    
  }
}