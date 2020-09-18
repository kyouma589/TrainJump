using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainMove : MonoBehaviour
{

    public float moveSpeed = 2f;
    public float jumpHeight = 2f;
    public Rigidbody2D player;

    // Start is called before the first frame update
    void Start()
    {
        
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("space") && Mathf.Abs(player.velocity.y) < 0.001f)
        {
            player.AddForce(new Vector2(0, jumpHeight),ForceMode2D.Impulse);
        }

    }
}
