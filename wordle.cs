using System;


public class Wordle{
  public double equal = 0;
  public double one = 0;
  public double two = 0;
  public static bool quit = false;
  public static string done = "";
  public string perform;

  public void wordle(){
    Console.Clear();
    Random rand = new Random();
    int selWord = rand.Next(0,9);
    Menu menu = new Menu();
    Program prog = new Program();
    string answer = "";
    Console.WriteLine("Welcome to Wordle");
    Console.WriteLine("Type 'know' to show the letters you know");
    string[] words = {"world", "money", "zebra", "ready", "joker", "mound", "under", "pound", "after", "learn", "found", "words"};
    string selectedWord = words[selWord];
    
    string let1 = Convert.ToString(selectedWord[0]);
    string let2 = Convert.ToString(selectedWord[1]);
    string let3 = Convert.ToString(selectedWord[2]);
    string let4 = Convert.ToString(selectedWord[3]);
    string let5 = Convert.ToString(selectedWord[4]);

    string know1 = "Letter 1: Unknown";
    string know2 = "Letter 2: Unknown";
    string know3 = "Letter 3: Unknown";
    string know4 = "Letter 4: Unknown";
    string know5 = "Letter 5: Unknown";
    
    while(answer != "quit"){
      answer = Console.ReadLine();
      //Checks if the letter is in the correct spot
      if(answer != "know"){
      if(Convert.ToString(answer[0]) == let1){
        Console.WriteLine(let1 + " is in the right spot");
        know1 = let1;
      }
      else if(Convert.ToString(answer[1]) == let1){
        Console.WriteLine(let1 + " is in the word");
      }
      else if(Convert.ToString(answer[2]) == let1){
        Console.WriteLine(let1 + " is in the word");
      }
      else if(Convert.ToString(answer[3]) == let1){
        Console.WriteLine(let1 + " is in the word");
      }
      else if(Convert.ToString(answer[4]) == let1){
        Console.WriteLine(let1 + " is in the word");
      }
    
    
      if(Convert.ToString(answer[1]) == let2){
        Console.WriteLine(let2 + " is in the right spot");
        know2 = let2;
      }
      else if(Convert.ToString(answer[0]) == let2){
        Console.WriteLine(let2 + " is in the word");
      }
      else if(Convert.ToString(answer[2]) == let2){
        Console.WriteLine(let2 + " is in the word");
      }
      else if(Convert.ToString(answer[3]) == let2){
        Console.WriteLine(let2 + " is in the word");
      }
      else if(Convert.ToString(answer[4]) == let2){
        Console.WriteLine(let2 + " is in the word");
      }

      
      if(Convert.ToString(answer[2]) == let3){
        Console.WriteLine(let3 + " is in the right spot");
        know3 = let3;
      }
      else if(Convert.ToString(answer[0]) == let3){
        Console.WriteLine(let3 + " is in the word");
      }
      else if(Convert.ToString(answer[1]) == let3){
        Console.WriteLine(let3 + " is in the word");
      }
      else if(Convert.ToString(answer[3]) == let3){
        Console.WriteLine(let3 + " is in the word");
      }
      else if(Convert.ToString(answer[4]) == let3){
        Console.WriteLine(let3 + " is in the word");
      }

      
      if(Convert.ToString(answer[3]) == let4){
        Console.WriteLine(let4 + " is in the right spot");
        know4 = let4;
      }
      else if(Convert.ToString(answer[0]) == let4){
        Console.WriteLine(let4 + " is in the word");
      }
      else if(Convert.ToString(answer[1]) == let4){
        Console.WriteLine(let4 + " is in the word");
      }
      else if(Convert.ToString(answer[2]) == let4){
        Console.WriteLine(let4 + " is in the word");
      }
      else if(Convert.ToString(answer[4]) == let4){
        Console.WriteLine(let4 + " is in the word");
      }


      
      if(Convert.ToString(answer[4]) == let5){
        Console.WriteLine(let5 + " is in the right spot");
        know5 = let5;
      }
      else if(Convert.ToString(answer[0]) == let5){
        Console.WriteLine(let5 + " is in the word");
      }
      else if(Convert.ToString(answer[1]) == let5){
        Console.WriteLine(let5 + " is in the word");
      }
      else if(Convert.ToString(answer[2]) == let5){
        Console.WriteLine(let5 + " is in the word");
      }
      else if(Convert.ToString(answer[3]) == let5){
        Console.WriteLine(let5 + " is in the word");
      }

      
      //Checks if the letter is correct but in a different spot
      //Checks if the word is correct in general
      if(answer == selectedWord){
        Console.Clear();
        Console.WriteLine("You got it, good job!");
        answer = "quit";
      }
    }
    //If know is typed in the console
    else{
      Console.WriteLine(know1);
      Console.WriteLine(know2);
      Console.WriteLine(know3);
      Console.WriteLine(know4);
      Console.WriteLine(know5);
    }
    }
    menu.menu();
  }
}