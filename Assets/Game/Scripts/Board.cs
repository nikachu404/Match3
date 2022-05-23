using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class Board : MonoBehaviour
{
    [SerializeField]
    private int _width;
    [SerializeField]
    private int _height;
    [SerializeField]
    private GameObject _tilePrefab;
    [SerializeField]
    private Fish[] _arrayFish;
    private Fish[,] _trackAllFish;

    [ContextMenu("Start")]
    private void Start()
    {
        _trackAllFish = new Fish[_width,_height];
        SetupTiles();
        SetupFishFirstRaw();
    }

    private void SetupTiles()
    {
        for (int x = 0; x < _width; x++)
        {
            for (int y = 0; y < _height; y++)
            {
                Vector2 pos = new(x, y);
                GameObject tile = Instantiate(_tilePrefab, pos, Quaternion.identity);
                tile.transform.parent = transform;
                tile.name = "Tile - " + x + ", " + y;
            }
        }
    }

    private void SetupFishFirstRaw()
    {
        for (int x = 0; x < _width; x++)
        {
            int y = _height - 1;
            int spawnRandomFish = Random.Range(0, _arrayFish.Length);
            SpawnFish(new Vector2Int(x, y), _arrayFish[spawnRandomFish]);
        }
    }

    private void SpawnFish(Vector2Int pos, Fish fishToSpawn)
    {
        Fish fish = Instantiate(fishToSpawn, new Vector3(pos.x, pos.y, 0f), Quaternion.identity);
        fish.transform.parent = transform;
        fish.name = "Fish - " + pos.x + ", " + pos.y;
        _trackAllFish[pos.x, pos.y] = fish;
    }
}