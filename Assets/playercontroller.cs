using UnityEngine;


public class playercontroller : MonoBehaviour
{
    public int dy = 0;
    public bool in_air = false;
    public int maxdy = 0;



    Rigidbody2D rb;

    void Awake()
    {
        rb = gameObject.AddComponent<Rigidbody2D>();
        rb.gravityScale = 0; // if you want to manually control gravity
        rb.freezeRotation = true;
    }
    void Update()
    {


        // Move left (A key)
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log(rb);
            Debug.Log("leftarraow pressed");
            float speed = 2f;
            rb.MovePosition(rb.position + Vector2.left * speed * Time.fixedDeltaTime * 1.5f);
        }
        // Move right (D key)
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log(rb);
            float speed = 2f;
            Debug.Log("rightpressed press");
            rb.MovePosition(rb.position + Vector2.left * -1 * Time.fixedDeltaTime * 1.5f * speed);
        }
        if (Input.GetKey(KeyCode.Space) && in_air == false)
        {
            rb.MovePosition(rb.position + Vector2.up * Time.fixedDeltaTime * 1.5f * 30f);
            in_air = true;
        }
        // Check vertical position
        if (transform.position.y < -1.4f)
        {
            dy = 0;
            in_air = false;
        }
        else
        {
            // Gravity/Upwards motion logic
            if (dy > 6)
            {
                dy = 6;
            }
            dy++;
            transform.Translate(Vector3.up * dy * -0.001f);
        }
    }
}