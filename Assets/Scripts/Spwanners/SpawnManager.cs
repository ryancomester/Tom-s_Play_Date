using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    RoadSpwanner roadSpwanner;
    ContentSpawnner sideContentSpawner;

    void Start()
    {
        roadSpwanner = GetComponent<RoadSpwanner>();
        sideContentSpawner = GetComponent<ContentSpawnner>();
    }

    public void SpawnTriggerEntered()
    {
        roadSpwanner.MoveRoad();
        //sideContentSpawner.SpawnSideContent();
    }
}
