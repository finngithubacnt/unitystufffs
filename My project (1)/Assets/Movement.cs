using UnityEngine;

public class Movement : MonoBehaviour
{
    public KeyCode left;
    public KeyCode right;
    public KeyCode up;
    public KeyCode down;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(left))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, GetComponent<Rigidbody2D>().velocity.y);
        }
        if (Input.GetKey(right))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
        }
        if (Input.GetKey(up))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2( GetComponent<Rigidbody2D>().velocity.x,speed);
        }

        if (Input.GetKey(down))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2( GetComponent<Rigidbody2D>().velocity.x,-speed);
        }
    }
}

