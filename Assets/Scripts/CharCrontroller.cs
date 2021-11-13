using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharCrontroller : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 10f;
    [SerializeField] private float jumpSpeed;
    [SerializeField] private float runningSpeed;

    PlayerAnim Anim;
    [SerializeField] SpawnManager spawnManager;

    void Start()
    {
        Anim = GetComponent<PlayerAnim>();
    }

    void Update()
    {
        float hMovement = Input.GetAxis("Horizontal") * movementSpeed / 2;
        float vMovement = Input.GetAxis("Vertical") * movementSpeed;
        float zMovement = Input.GetAxis("Jump") * jumpSpeed;

        //temp
        /*if (Input.GetButtonDown("Jump"))
        {
            Anim.Jump();
        }*/

        transform.Translate(new Vector3(hMovement, /*0*/ zMovement, /*vMovement*/runningSpeed) * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        spawnManager.SpawnTriggerEntered();
        //Debug.Log("spawn trigged");
    }
}
