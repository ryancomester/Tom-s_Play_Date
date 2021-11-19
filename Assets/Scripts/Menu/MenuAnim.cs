using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAnim : MonoBehaviour
{
    public Animator anim;

    void Update()
    {
        anim.SetFloat("Movement", 0f);

    }
}
