using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TrainMove : MonoBehaviour
{
    //public bool gameStart = false;

    public Text startText;

    public float moveSpeed = 2f;
    public float jumpHeight = 2f;
    public Rigidbody2D player;

    public int health = 1;

    // Start is called before the first frame update
    void Start()
    {
        
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
            if (health <= 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }

            if (Input.GetKeyDown("space") && Mathf.Abs(player.velocity.y) < 0.001f)
            {
                player.AddForce(new Vector2(0, jumpHeight), ForceMode2D.Impulse);
            }
        
       

       

    }
}
