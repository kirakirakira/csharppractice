// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

for (var n = 0; n < args.Length; n++)
{
    Console.WriteLine($"args[{n}] = {args[n]}");
}

return 0;
