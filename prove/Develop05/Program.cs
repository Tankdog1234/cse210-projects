using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        int userInput = -1;
        while(userInput != 5)
        {
            userInput = menu.Display();
        } 
    }
}