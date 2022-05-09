using UnityEngine;

public class Line
{
    private Orientation orientation;
    public Orientation Orientation { get => orientation; set => orientation = value; }

    Vector2Int coordinates;
    public Vector2Int Coordinates { get => coordinates; set => coordinates = value; }

    public Line(Orientation orientation, Vector2Int coordinates)
    {
        this.orientation = orientation;
        this.coordinates = coordinates;
    }

}

public enum Orientation
{
    Horizontal = 0,
    Vertical = 1
}
