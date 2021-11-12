using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContentSpawnner : MonoBehaviour
{
    private int initAmmount = 1;
    //private float initStartZ = 15f;
    [Header("Values For The Side Content")]
    [SerializeField]private float sideContentSize = 3.1f;
    [SerializeField] private float xPosLeft = -19.3f;
    [SerializeField] private float xPosRight = 19.29f;
    [SerializeField]private float lastZPos = 15f;

    public List<GameObject> sideContents;
    void Start()
    {
        for(int i =0; i< initAmmount; i++)
        {
            //int rand = Random.Range(0, sideContents.Count);
            /*GameObject sideConetentleft = sideContents[Random.Range(0, sideContents.Count)];
            GameObject sideContentRight = sideContents[Random.Range(0, sideContents.Count)];

            float zPosition = lastZPos + sideContentSize;

            Instantiate(sideConetentleft, new Vector3(xPosLeft, 0.025f, zPosition), sideConetentleft.transform.rotation);
            Instantiate(sideContentRight, new Vector3(xPosRight, 0.025f, zPosition), new Quaternion(0, 180, 0, 0));

            lastZPos += sideContentSize;*/

            SpawnSideContent();
        }
    }

    void Update()
    {
        
    }

    public void SpawnSideContent()
    {
        GameObject sideConetentleft = sideContents[Random.Range(0, sideContents.Count)];
        GameObject sideContentRight = sideContents[Random.Range(0, sideContents.Count)];

        float zPosition = lastZPos + sideContentSize;

        Instantiate(sideConetentleft, new Vector3(xPosLeft, 0.025f, zPosition), sideConetentleft.transform.rotation);
        Instantiate(sideContentRight, new Vector3(xPosRight, 0.025f, zPosition), new Quaternion(0, 180, 0, 0));

        lastZPos += sideContentSize;
    }
}
