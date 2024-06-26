﻿using System;
using static System.Collections.Specialized.BitVector32;
using System.Text.RegularExpressions;

class Ex6
{
    static void Main()
    {
        string word = "is";
        string temp = "This is my cat! And this is my dog. We happily live in Paris – the most beautiful city in the world! Isn’t it great? Well it is :)";

        string pattern = $@"([A-Z][A-Z,a-z,0-9]*(\s?\w*|[,]|[-])*)*(\b({word})\b)((\s?\w*|[,]|[-])*[A-Z,a-z,0-9]*[!,\.,?])";


        /*
        ( // все перед словом
            [A-Z]
            [A-Z,a-z,0-9]*
            (
                \s?
                \w*|
                [,]|
                [-]
            )*
        )*
        (  // слова
            \b
            (
                {word}
            )
            \b
        )
        ( // все після слова
            (
                \s?
                \w*|
                [,]|
                [-]
            )*
            [A-Z,a-z,0-9]*
            [!,\.,?]
        )
         */


        Regex regex = new(pattern);
        MatchCollection matches = regex.Matches(temp);

        foreach (Match match in matches.Cast<Match>())
        {
            Console.WriteLine(match.Value);
        }

        Console.ReadKey();
    }
}
