using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    public int damage = 1;
    public float speed;

    public float endPoint;

    private void Update()
    {
        transform.Translate(Vector2.left * speed* Time.deltaTime);

        if (transform.position.x <= endPoint)
        {
            Destroy(gameObject);
        }
    }




    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<TrainMove>().health -= damage;
            Destroy(gameObject);
        }


    }
}
