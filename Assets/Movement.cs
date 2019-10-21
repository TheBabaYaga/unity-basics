using UnityEngine;

public class Movement : MonoBehaviour
{
    public bool isMovingLeft;
    public bool isMovingRight;
    public Rigidbody2D rb;
    public float movementSpeed = 500f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            isMovingLeft = true;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            isMovingRight = true;
        }
    }

    void FixedUpdate()
    {
        if (isMovingLeft)
        {
            Debug.Log("Move left!");
            /*rb.AddForce(Vector2.left * (movementSpeed * Time.fixedDeltaTime));*/
            rb.velocity = new Vector2((-1 * movementSpeed) * Time.fixedDeltaTime, 0);
            isMovingLeft = false;
        }
        if (isMovingRight)
        {
            Debug.Log("Move right!");
            rb.velocity = new Vector2((1 * movementSpeed) * Time.fixedDeltaTime, 0);
            isMovingRight = false;
        }
    }
}

