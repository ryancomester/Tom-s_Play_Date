using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharCrontroller : MonoBehaviour
{
    public float movementSpeed = 10f;

    void Start()
    {
        
    }

    void Update()
    {
        float hMovement = Input.GetAxis("Horizontal") * movementSpeed / 2;
        float vMovement = Input.GetAxis("Vertical") * movementSpeed;

        transform.Translate(new Vector3(hMovement, 0, vMovement) * Time.deltaTime);
    }
}
