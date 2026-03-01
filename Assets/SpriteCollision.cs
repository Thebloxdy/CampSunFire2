// Move sprite bottom left to upper right.  It does not stop moving.
// The Rigidbody2D gives the position for the cube.

using UnityEngine;
using System.Collections;

public class SpriteCollision : MonoBehaviour
{
    public Texture2D tex;

    private Vector2 velocity;
    private Rigidbody2D rb2D;
    private Sprite mySprite;
    private SpriteRenderer sr;

    void Awake()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D> ();
        velocity = new Vector2(1.75f, 1.1f);
    }
    void FixedUpdate()
    {
        rb2D.MovePosition(rb2D.position + velocity * Time.fixedDeltaTime);
    }
}