using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W12_AnimationControl : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        animator.SetInteger("Control", 1);
    }
}
