/*
Callen Thomason
9/17/2026
Mini Challenge # 10 - Restaurant Picker
With this project I really wanted to focus on keeping my main as clean as possible. To do this I created methods that handle all the loops and do most of the heavy lifting.
I used a switch to allow the user to select what category of restuarant they want, then assigned each category a unique string. 
I then called a method within the method to generate a random number and output a random index position to the console. 
I also used a bool method to return true or false for the play again feature. 
Peer Reviewer: 
Review: 
*/

Console.Clear(); 

Console.WriteLine("Welcome to restaurant picker"); 

do{
Console.Write("Do you want Mexican, Burgers, or Chinese: "); 
 Picker.Category(Console.ReadLine().ToLower()); 
}while(Picker.playAgain()); 