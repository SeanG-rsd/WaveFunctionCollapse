using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Builder : MonoBehaviour
{
    [SerializeField] private int Width;
    [SerializeField] private int Height;

    private Node[] grid;
    private Node[] possible;

    public List<Node> possibleNodes;

    private List<Vector2Int> toCollpase = new();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) BuildGrid();
    }

    private void BuildGrid()
    {


        do
        {


        } while (toCollpase.Count > 0);
    }

    private void BuildVisual()
    {

    }

    public int GetIndex(int x, int y)
    {
        return y * Height + x;
    }
}
