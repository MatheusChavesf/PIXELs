using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Saw : MonoBehaviour
{
    public float speed;
    public float moveTime;
    private bool dirRight = true;
    private float timer;
    

    
    void Update()
    {
        if(dirRight)
        {
            //se verdadeiro a serra vai para direita
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else
        {
            //se verdadeiro a serra vai para esquerda
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        timer += Time.deltaTime;
        if(timer >= moveTime)
        {
            dirRight = !dirRight;
            timer = 0f;
        }
    }
}
