using UnityEngine;


public class PlayerController : MonoBehaviour
{
    void Update()
    {
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += transform.right * 1f * -1;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("hefuei");
            transform.position += transform.right * 0.01f;
        }

    }
}