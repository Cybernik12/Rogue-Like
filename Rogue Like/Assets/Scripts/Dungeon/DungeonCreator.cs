using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonCreator : MonoBehaviour
{

    [SerializeField] private int dungeonWidth;
    [SerializeField] private int dungeonLength;
    [SerializeField] private int roomWidthMin;
    [SerializeField] private int roomLengthMin;
    [SerializeField] private int maxIterations;
    [SerializeField] private int corridorWidth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CreateDungeon();
    }

    private void CreateDungeon()
    {
        DungeonGenerator generator = new DungeonGenerator(dungeonWidth, dungeonLength);
        var listOfRooms = generator.CalculateRooms(maxIterations, roomWidthMin, roomLengthMin);
    }
}
