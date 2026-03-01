using UnityEngine;

public class RotateAroundPoint : MonoBehaviour
{
    // Assign the central point GameObject in the Inspector
    public GameObject GOODSUN;
    public float rotationSpeed = 50f;

    void Update()
    {
        // Rotate the object around the target's position
        // Vector3.up defines the axis of rotation (Y-axis in this case)
        transform.RotateAround(GOODSUN.transform.position, Vector3.up, rotationSpeed * Time.deltaTime);
        GetComponent<SpriteRenderer>().sortingOrder = 100;
    }
}
