using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PropRandomizer : MonoBehaviour
{
    public List<GameObject> propsSpawnPoints;
    public List<GameObject> propsPrefabs;
    
    void Start()
    {
        SpwanProps();
    }

    void Update()
    {
        
    }

    void SpwanProps()
    {
        foreach (GameObject sp in propsSpawnPoints)
        {
            int rand = Random.Range(0, propsPrefabs.Count);
            GameObject prop = Instantiate(propsPrefabs[rand], sp.transform.position, Quaternion.identity);
            prop.transform.parent = sp.transform;
        }
    }
}
