using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class UIZoomOnClick : MonoBehaviour, IPointerClickHandler
{
    // The target scale when clicked
    public Vector3 zoomedScale = new Vector3(1.5f, 1.5f, 1.5f);
    // The original scale (set in Start)
    private Vector3 originalScale;
    // The speed of the zoom animation
    public float zoomSpeed = 5f;

    private RectTransform rectTransform;
    private bool isZoomed = false;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        originalScale = rectTransform.localScale;
    }

    // This method is called when the UI element is clicked
    public void OnPointerClick(PointerEventData eventData)
    {
        if (isZoomed)
        {
            StartCoroutine(ScaleOverTime(originalScale));
        }
        else
        {
            StartCoroutine(ScaleOverTime(zoomedScale));
        }
        isZoomed = !isZoomed;
    }

    // Coroutine for smooth scaling over time
    IEnumerator ScaleOverTime(Vector3 targetScale)
    {
        while (Vector3.Distance(rectTransform.localScale, targetScale) > 0.01f)
        {
            rectTransform.localScale = Vector3.Lerp(rectTransform.localScale, targetScale, Time.deltaTime * zoomSpeed);
            yield return null;
        }
        rectTransform.localScale = targetScale;
    }
}
