using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCrontrol : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement();
    }
    private void movement()
    {
        float horizontalmove = Input.GetAxis("Horizontal");
        if(horizontalmove != 0)
        {
            rb.velocity = new Vector2(horizontalmove * speed, rb.velocity.y);
        }
    }
}
