using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    public float JumpForce;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            anim.SetTrigger("jump");
            collision.gameObject.GetComponent<Rigidbody2D>()
            .AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
        }
    }
}
