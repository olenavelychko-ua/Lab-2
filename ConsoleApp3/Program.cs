using System;

class Program
{
    static void Main(string[] args)
    {
        Lamb sheep = new Lamb(5, 3, "black");

        /*var result1 = sheep.ShallowCopy();
        result1.color = "green";

        var result2 = sheep.DeepCopy();
        result2.weight = 34;

        var copy = sheep;
        copy.height = 28;*/

        Console.WriteLine(sheep);
       /* Console.WriteLine(result1);
        Console.WriteLine(result2);
        Console.WriteLine(copy);*/


    }
}