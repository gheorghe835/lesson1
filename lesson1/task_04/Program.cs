﻿int a = 6;
int b = 75;
int c = 9;
int d = 4;
int e = 12;

int max = a;

if (b > max) { max = b; }
if (c > max) { max = c; }
if (d > max) { max = d; }
if (e > max) { max = e; }

Console.WriteLine($"  Maximum is :: {max}");