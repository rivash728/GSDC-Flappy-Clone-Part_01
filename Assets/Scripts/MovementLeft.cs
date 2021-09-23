using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementLeft : MonoBehaviour
{
    public float speed;
    float groundLen;
    
    BoxCollider2D floorCollider;

    
    // Start is called before the first frame update
    void Start()
    {
        floorCollider = GetComponent<BoxCollider2D>();
        groundLen = floorCollider.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        // Will move Ground along the X Axis
        transform.position = new Vector2(
            transform.position.x - speed * Time.deltaTime, 
            transform.position.y);

        // Checks if ground reaches targeted length to repeat
        if (transform.position.x <= -groundLen)
        {
        transform.position = new Vector2(
            transform.position.x + 2 * groundLen, 
            transform.position.y);
        }
    }

}
