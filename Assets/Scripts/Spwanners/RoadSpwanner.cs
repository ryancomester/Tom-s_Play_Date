using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RoadSpwanner : MonoBehaviour
{
    public GameObject[] roads;
    public float zSpawn = 0f;
    public float prefabLength = 30f;
    public int numberOfPrefabs = 7;
    public Transform playerTransform;

    private List<GameObject> activePrefabs = new List<GameObject>();

    void Start()
    {
        for(int i = 0; i < numberOfPrefabs; i++)
        {
            if (i == 0)
                SpwanPrefab(0);
            else
                SpwanPrefab(Random.Range(0, roads.Length));
        }
    }

    void Update()
    {
        if(playerTransform.position.z > zSpawn - (numberOfPrefabs * prefabLength))
        {
            SpwanPrefab(Random.Range(0, roads.Length));
            Invoke("DeletePrefab", 2.5f);
            //DeletePrefab();
        }
    }

    public void SpwanPrefab(int roadIndex)
    {
        GameObject go = Instantiate(roads[roadIndex], transform.forward * zSpawn, transform.rotation);
        activePrefabs.Add(go);
        zSpawn += prefabLength;
    }

    private void DeletePrefab()
    {
        Destroy(activePrefabs[0]);
        activePrefabs.RemoveAt(0);
    }
}
