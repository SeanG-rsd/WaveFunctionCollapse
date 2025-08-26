using System.Collections.Generic;
using UnityEditor.MemoryProfiler;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Node : ScriptableObject
{
    public Tile Tile;
    public string Name;

    public Connection Top;
    public Connection Botton;
    public Connection Left;
    public Connection Right;
}

public class Connection
{
    public List<Node> neighbors = new();
}
