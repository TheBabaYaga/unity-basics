using UnityEngine;

public class Jump : MonoBehaviour
{
    public bool isJumpPressed;
    public Rigidbody2D rb;
    public float jumpSpeed = 1000f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            isJumpPressed = true;
        }
    }

    void FixedUpdate()
    {
        if (isJumpPressed)
        {
            Debug.Log("Jump!");
            isJumpPressed = false;
            rb.AddForce(Vector2.up * (jumpSpeed * Time.fixedDeltaTime));
        }
    }
}
