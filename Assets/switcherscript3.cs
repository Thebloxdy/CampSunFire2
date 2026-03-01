using UnityEngine;

public class ClickShowA : MonoBehaviour
{
    public ObjectToggleManager manager;

    private void OnMouseDown()
    {
        manager.ShowA();
    }
}