using UnityEngine;

public class ObjectToggleManager : MonoBehaviour
{
    public GameObject objectA;
    public GameObject objectB;

    public void ShowA()
    {
        objectA.SetActive(true);
        objectB.SetActive(false);
    }

    public void ShowB()
    {
        objectA.SetActive(false);
        objectB.SetActive(true);
    }
}