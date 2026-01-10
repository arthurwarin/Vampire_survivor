using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class MapController : MonoBehaviour
{
    public List<GameObject> terrainChunks;
    public GameObject player;
    public float checkerRadius;
    Vector3 _noTerrainPosition;
    public LayerMask terrainMask;
    PlayerMovement pm;
    public GameObject currentChunk;

    void Start()
    {
        pm = FindAnyObjectByType<PlayerMovement>();
    }

    void Update()
    {
        ChunkChecker();
    }

    void ChunkChecker()
    {
        if (!currentChunk)
        {
            return;
        }
        
        if (pm.movDirection.x > 0 && pm.movDirection.y == 0) // right
        {
            if (!Physics2D.OverlapCircle(player.transform.position + new Vector3(20, 0, 0), checkerRadius, terrainMask))
            {
                _noTerrainPosition = player.transform.position + new Vector3(20, 0, 0);
                SpawnChunk();
            }
        }
        else if (pm.movDirection.x < 0 && pm.movDirection.y == 0) // left
        {
            if (!Physics2D.OverlapCircle(player.transform.position + new Vector3(-20, 0, 0), checkerRadius, terrainMask))
            {
                _noTerrainPosition = player.transform.position + new Vector3(-20, 0, 0);
                SpawnChunk();
            }
        }
        else if (pm.movDirection.x == 0 && pm.movDirection.y > 0) // up
        {
            if (!Physics2D.OverlapCircle(player.transform.position + new Vector3(0, 20, 0), checkerRadius, terrainMask))
            {
                _noTerrainPosition = player.transform.position + new Vector3(0, 20, 0);
                SpawnChunk();
            }
        }
        else if (pm.movDirection.x == 0 && pm.movDirection.y < 0) //down
        {
            if (!Physics2D.OverlapCircle(player.transform.position + new Vector3(0, -20, 0), checkerRadius, terrainMask))
            {
                _noTerrainPosition = player.transform.position + new Vector3(0, -20, 0);
                SpawnChunk();
            }
        }
        else if (pm.movDirection.x > 0 && pm.movDirection.y > 0) // right up
        {
            if (!Physics2D.OverlapCircle(player.transform.position + new Vector3(20, 20, 0), checkerRadius, terrainMask))
            {
                _noTerrainPosition = player.transform.position + new Vector3(20, 20, 0);
                SpawnChunk();
            }
        }
        else if (pm.movDirection.x > 0 && pm.movDirection.y < 0) // right down
        {
            if (!Physics2D.OverlapCircle(player.transform.position + new Vector3(20, -20, 0), checkerRadius, terrainMask))
            {
                _noTerrainPosition = player.transform.position + new Vector3(20, -20, 0);
                SpawnChunk();
            }
        }
        else if (pm.movDirection.x < 0 && pm.movDirection.y > 0) // left up
        {
            if (!Physics2D.OverlapCircle(player.transform.position + new Vector3(-20, 20, 0), checkerRadius, terrainMask))
            {
                _noTerrainPosition = player.transform.position + new Vector3(-20, 20, 0);
                SpawnChunk();
            }
        }
        else if (pm.movDirection.x < 0 && pm.movDirection.y < 0) // left down
        {
            if (!Physics2D.OverlapCircle(player.transform.position + new Vector3(-20, -20, 0), checkerRadius, terrainMask))
            {
                _noTerrainPosition = player.transform.position + new Vector3(-20, -20, 0);
                SpawnChunk();
            }
        }
    }

    void SpawnChunk()
    {
        int rand = Random.Range(0, terrainChunks.Count);
        Instantiate(terrainChunks[rand], _noTerrainPosition, Quaternion.identity);
    }
}
