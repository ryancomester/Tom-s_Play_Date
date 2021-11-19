using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    public Animator anim;

    void Update()
    {
        //checks weather the game is started and if so the float value is set as 1.5f.
        if (!PlayerManager.isGameStarted)
        {
            anim.SetFloat("Movement", 0f);
        }
        else
        {
            anim.SetFloat("Movement", 1.5f);
        }
    }

    public void JumpAmin()
    {
        anim.SetTrigger("Jump");
    }
}
