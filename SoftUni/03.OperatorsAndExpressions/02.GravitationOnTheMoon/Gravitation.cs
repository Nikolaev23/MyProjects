﻿/*The gravitational field of the Moon is approximately 17% of that on the Earth. 
 * Write a program that calculates the weight of a man on the moon by a given weight on the Earth. */
using System;

class Gravitation
{
    static void Main()
    {
        Console.WriteLine("Enter your weight :");
        double weight = double.Parse(Console.ReadLine());

        double gravitationWeight = weight * 0.17;
        Console.WriteLine("Your gravitation weight is : {0}",gravitationWeight);
    }
}

