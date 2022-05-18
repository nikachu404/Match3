using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    public Vector2Int posIndex;
    public Board board;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetupFish(Vector2Int pos, Board board)
    {
        this.posIndex = pos;
        this.board = board;
    }
}
