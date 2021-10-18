using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{

    public Animator anim;

    void Start()
    {
        
    }

    void Update()
    {
        anim.SetFloat("Movement", Input.GetAxis("Vertical"));
    }
}
