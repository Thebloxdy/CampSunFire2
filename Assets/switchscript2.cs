using UnityEngine;

public class ClickShowB : MonoBehaviour
{
    public ObjectToggleManager manager;

    private void OnMouseDown()
    {
        manager.ShowB();
    }
}