using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    public Animator anim;

    void Update()
    {
        anim.SetFloat("Movement", Input.GetAxis("Vertical"));
    }

    public void Jump()
    {
        anim.SetTrigger("Jump");
    }
}
