using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform player;

    [SerializeField] private float xOffset = -0.27f;
    [SerializeField] private float yOffset = 2.66f;
    [SerializeField] private float zOffset = -2.85f;

    void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    void Update()
    {
        transform.position = new Vector3(player.position.x + xOffset, player.position.y + yOffset, player.position.z + zOffset);
    }
}
