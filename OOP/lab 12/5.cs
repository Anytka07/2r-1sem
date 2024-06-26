﻿using System;
using System.Text.RegularExpressions;

class Ex5
{
    static void Main()
    {
        string pattern = @"(\s|^)(([A-Z,a-z,0-9])+\W*([A-Z,a-z,0-9])+)@(([A-Z,a-z,0-9]+[_,-]*[A-Z,a-z,0-9]+)\.([A-Z,a-z,0-9]+[_,-]*[A-Z,a-z,0-9]+\.?)*)\w+";


        /*
            (\s|^)
<<<<<<< HEAD
            (
=======
            (  <user>
>>>>>>> Добавьте файлы проекта.
                ([A-Z,a-z,0-9])+
                \W*
                ([A-Z,a-z,0-9])+
            )
            @
<<<<<<< HEAD
            (
=======
            (  <host>
>>>>>>> Добавьте файлы проекта.
                (
                    [A-Z,a-z,0-9]+
                    [_,-]*
                    [A-Z,a-z,0-9]+
                )
                \.
                (
                    [A-Z,a-z,0-9]+
                    [_,-]*
                    [A-Z,a-z,0-9]+
                    \.?
                )*
            )
            \w+
         */



        string[]? action = Console.ReadLine()?.Split(' ');


        for (int i = 0; i < action?.Length; i++)
        {
            if (Regex.IsMatch(action[i], pattern))
            {
                Console.WriteLine(action[i]);
            }
        }

        Console.ReadKey();
    }
}
