﻿using System;
using System.Linq;

namespace PigLatin
{
    public class Program
    {
        //public void Main(string[] args)
        //{
            
        //    string userInput = GetInput("Please input a word or sentence to translate to pig Latin");

        //    string translation = ToPigLatin(userInput);
        //    Console.WriteLine(translation);
        //}

        public static string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine().ToLower().Trim();
            return input;
        }
        
        

        

        
        
    }
}
