using System;

public static class Dumper
{

    public static T Dump<T>(this T value, string v="")
    {
        Console.WriteLine(v+ " " + value.ToString());
        return value;
    }
}