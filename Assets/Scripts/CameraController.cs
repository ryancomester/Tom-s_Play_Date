using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform player;

    [SerializeField] private float xOffset;
    [SerializeField] private float yOffset;
    [SerializeField] private float zOffset;

    void Start()
    {
        //adds player gamobject which is Tom the running player.
        player = GameObject.Find("Player").transform;
    }

    void Update()
    {
        //adds camera position to follow tom
        transform.position = new Vector3(player.position.x + xOffset, player.position.y + yOffset, player.position.z + zOffset);
    }
}
