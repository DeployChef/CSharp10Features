﻿namespace DeconstructionDeclaration;

internal class Point
{
    public Point(int x, int y, int z)
    {
        X=x;
        Y=y;
        Z=z;
    }

    public int X { get; init; }

    public int Y { get; init; }

    public int Z { get; init; }

    internal void Deconstruct(out int x, out int y, out int z)
    {
        x=X;
        y=Y;
        z=Z;
    }
}