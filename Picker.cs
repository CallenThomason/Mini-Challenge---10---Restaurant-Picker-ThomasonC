using System.Runtime.CompilerServices;

public static class Picker
{
 public static void Category(string answer)
    {
         string[] food = new string[10];
         bool validAns = false;  
        do{
        switch (answer)
        {
           
            case "mexican":
             food = ["Chipotle", "TacoBell", "Del Taco", "Casa Bonita", "Tacqueria San Jose", "Dons", "Tacqueria de Ripon", "QDOBA", "Jalepenos", "My Grandmas House"]; 
             validAns = true;
            break; 
            case "burgers":
            food = ["McDonalds", "In-N-Out", "Jack in the Box", "Carl's Jr", "Brothers", "Fast Eddies", "Sno-Whites", "Wendys", "Nations", "My back yard"]; 
            validAns = true;
            break; 
            case "chinese":
            food = ["Panda Express", "P.F. Chang's", "Pei Wei", "Din Tai", "Jade Garden", "Golden Dragon", "House of Nanking", "Mission Chinese Food", "Yang Chow", "China Garden"]; 
            validAns = true;
            break;
            default:
            Console.WriteLine("Invalid Answer. Please Answer Mexican, Burgers, or Chinese: "); 
            answer = Console.ReadLine().ToLower(); 
            break; 
        }  //end of switch
        }while(!validAns); //end of do while
        PickerPlace(food); 
    }//end of method Category
private static void PickerPlace(String[] arr)
    {
       Random rnd = new Random(); 
        int randomNum = rnd.Next(0, 10); 
        Console.WriteLine("You should go to " + arr[randomNum]); 
    } 



public static bool playAgain()
{
     Console.Write("Do You want to try a differnt place? Y/N:  ");
    string ans = Console.ReadLine().ToUpper();  
    while(ans != "Y" && ans != "N")
        {
          Console.Write("Invalid input, answer Y or N :  ");
             ans = Console.ReadLine().ToUpper(); 

        }
        if(ans == "Y")
        {
          return true;   
        }
        return false; 
}
}