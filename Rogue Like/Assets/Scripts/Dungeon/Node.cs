using System;
using System.Collections.Generic;
using UnityEngine;
public abstract class Node
{
    private List<Node> childrenNodeList;

    public List<Node> ChildrenNodeList { get => childrenNodeList; }

    private bool visted;
    public bool Visted { get => visted; set => visted = value; }

    [SerializeField] private Vector2Int bottomLeftAreaCorner;
    public Vector2Int BottomLeftAreaCorner { get => bottomLeftAreaCorner; set => bottomLeftAreaCorner = value; }

    [SerializeField] private Vector2Int bottomRightAreaCorner;
    public Vector2Int BottomRightAreaCorner { get => bottomRightAreaCorner; set => bottomRightAreaCorner = value; }

    [SerializeField] private Vector2Int topRightAreaCorner;
    public Vector2Int TopRightAreaCorner { get => topRightAreaCorner; set => topRightAreaCorner = value; }

    [SerializeField] private Vector2Int topLeftAreaCorner;
    public Vector2Int TopLeftAreaCorner { get => topLeftAreaCorner; set => topLeftAreaCorner = value; }


    [SerializeField] private Node parent;
    public Node Parent { get => parent; set => parent = value; }

    [SerializeField] private int treeLayerIndex;
    public int TreeLayerIndex { get => treeLayerIndex; set => treeLayerIndex = value; }

    public Node(Node parentNode)
    {
        childrenNodeList = new List<Node>();
        this.Parent = parentNode;

        if (parentNode != null)
        {
            parentNode.AddChild(this);
        }
    }

    public void AddChild(Node node)
    {
        childrenNodeList.Add(node);
    }

    public void RemoveChild(Node node)
    {
        childrenNodeList.Remove(node);
    }
}