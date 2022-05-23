using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    [HideInInspector]
    public Vector2Int PosIndex;
    [HideInInspector]
    public Board Board;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void TrackFish(Vector2Int pos, Board board)
    {
        this.PosIndex = pos;
        this.Board = board;
    }
}
