
//checks if input is a palindrome
//Test cases:
    // racecar
    // RaceCar
    // Level
    //A man, a plan, a canal, Panama!"



using System;
using System.Text.RegularExpressions;

class Palindrome
{


    static void Main(){

        string palindrome = "";
      
        
        while(true){
        Console.WriteLine("Enter a palindrome (q to quit): ");
        palindrome = Console.ReadLine();
        if(palindrome == "q"){
            Console.WriteLine("Bye Bye");
            break;
        }
        
        if(isPalindrome(palindrome)){
            Console.WriteLine("It is a palindrome");
        }
        else{
            Console.WriteLine("It is NOT a palindrome");


        }
        }


    }

    private static bool isPalindrome(string palindrome){
        palindrome = palindrome.ToLower();
        palindrome = palindrome.Trim();
        palindrome = Regex.Replace(palindrome, "[^a-zA-Z0-9]", "");

        int left = 0;
        int right = palindrome.Length - 1;

        while(left < right){
            if(palindrome[left] != palindrome[right]){
                return false;
            }
            left ++;
            right--;
        }

        //Console.WriteLine(palindrome);

        return true;
    }


}


