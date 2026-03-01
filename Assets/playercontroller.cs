using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public int dy = 0;
    public bool in_air = false;
    void Update()
    {
        // Move left (A key)
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("hefuei");
            transform.Translate(Vector3.left * 0.01f);
        }
        // Move right (D key)
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("d press");
            transform.Translate(Vector3.right * 0.01f);
        }

        if (Input.GetKey(KeyCode.Space) && in_air == false)
        {
            Debug.Log("d press");

            
           
             transform.Translate(Vector3.up * 1f);
          
            dy = 0;
            in_air = true;
        }
        // Check vertical position
        if (transform.position.y < -3.4f)
        {
            dy = 0;
            in_air = false;
        }
        else
        {
            // Gravity/Upwards motion logic
            if (dy > 2)
            {
                dy = 2;
            }
            dy++;
            transform.Translate(Vector3.up * dy * -0.001f);
        }
    }
}