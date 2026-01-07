using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Card : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
    public Image outline;
    
    
    public void OnPointerDown(PointerEventData eventData)
    {
        Highlight(true);
    }
    
    public void OnDrag(PointerEventData eventData)
    {
        
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Highlight(false);
    }

    public void Highlight(bool highlight)
    {
        outline.color = highlight ? Color.green : Color.red;
    }
}
