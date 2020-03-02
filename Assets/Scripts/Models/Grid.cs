using Assets.Scripts.Models;
using System;
using System.Collections.Generic;

public class Grid
{
    private readonly Detachment[,] _grid;

    public int Width { get; }
    public int Height { get; }

    public event Action Changed;

    public Grid(int width, int height)
    {
        Width = width;
        Height = height;

        _grid = new Detachment[Width, Height];
    }

    public Detachment this[int i, int j] 
    {
        get => _grid[i, j];
        set {
            _grid[i, j] = value;

            if (Changed != null)
                Changed();
        }
    }

    public Detachment this[(int i, int j) position] 
    {
        get => this[position.i, position.j];
        set => this[position.i, position.j] = value;
    }

    public IEnumerable<(int, int)> PlayerSide 
    {
        get {
            int i = 0;

            while (i < Height)
                yield return (0, i++);
        }
    }

    public IEnumerable<(int, int)> EnemySide 
    {
        get {
            int i = 0;

            while (i < Height)
                yield return (Width - 1, i++);
        }
    }

    public IEnumerable<(int X, int Y)> Neighbours(int x, int y)
    {
        if (IsInRange(x + 1, y)) yield return (x + 1, y);
        if (IsInRange(x, y + 1)) yield return (x, y + 1);
        if (IsInRange(x - 1, y)) yield return (x - 1, y);
        if (IsInRange(x, y - 1)) yield return (x, y - 1);
    }

    public bool IsInRange((int X, int Y) position) =>
        IsInRange(position.X, position.Y);

    public bool IsInRange(int x, int y) =>
        0 <= x && x < Width &&
        0 <= y && y < Height;

    public void Remove(Detachment detachment)
    {
        for (int x = 0; x < Width; x++)
        for (int y = 0; y < Height; y++)
            if (_grid[x, y] == detachment)
                this[x, y] = null;
    }
}
