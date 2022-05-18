using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class Board : MonoBehaviour
{
    public int width;
    public int height;

    public GameObject tilePrefab;

    public Fish[] arrayFish;
    public Fish[,] allFish;

    // Start is called before the first frame update
    [ContextMenu("Start")]
    void Start()
    {

        allFish = new Fish[width,height];
        SetupTiles();
        SetupFishFirstRaw();
    }

    private void SetupTiles()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                Vector2 pos = new(x, y);
                GameObject tile = Instantiate(tilePrefab, pos, Quaternion.identity);
                tile.transform.parent = transform;
                tile.name = "Tile - " + x + ", " + y;
            }
        }
    }

    private void SetupFishFirstRaw()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = height - 1; y < height; y++)
            {
                int spawnRandomFish = Random.Range(0, arrayFish.Length);
                SpawnFish(new Vector2Int(x, y), arrayFish[spawnRandomFish]);
            }
        }
    }

    private void SpawnFish(Vector2Int pos, Fish fishToSpawn)
    {
        Fish fish = Instantiate(fishToSpawn, new Vector3(pos.x, pos.y, 0f), Quaternion.identity);
        fish.transform.parent = this.transform;
        fish.name = "Fish - " + pos.x + ", " + pos.y;

        allFish[pos.x, pos.y] = fish;

        fish.SetupFish(pos, this);
    }
}