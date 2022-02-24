using System;

class Menu{
  public string choice = "0";
  public void menu(){
    
    Calculate calc = new Calculate();
    Wordle wordle = new Wordle();
    WordGuess wordGuess = new WordGuess();
    Console.WriteLine("1. Calculator");
    Console.WriteLine("2. Wordle");
    Console.WriteLine("3. Guess the Number");
    choice = Console.ReadLine();
    if(choice == "1"){
      calc.calculate();
    }
    if(choice == "2"){
      wordle.wordle();
    }
    if(choice == "3"){
      wordGuess.guess();
    }
    else{
      menu();
    }
    
  }
}


class Program {
  
  public static void Main (string[] args) {
    Menu menu = new Menu();
    menu.menu();

  }
}