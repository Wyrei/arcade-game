using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anime : MonoBehaviour
{
    public float speed = 3;
    private Animator animator;
    public float LR = 3;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        animator.SetFloat("speed", 0);
        animator.SetFloat("LR", 0);
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetFloat("speed", 1);

        }
        if (Input.GetKey(KeyCode.S))
        {
            animator.SetFloat("speed", -1);

        }
        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetTrigger("jump");
            

        }
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetFloat("LR", -1);


        }
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetFloat("LR", 1);


        }
    }
}
