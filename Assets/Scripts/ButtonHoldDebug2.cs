using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonHoldDebug2 : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool isHolding = false;
    public PlayerController rb;
    private void Update()
    {
        if (isHolding)
        {
            rb.moveInput = +1;
            Debug.Log("Button is being held.");
            // Put your debug logic here or call a method that you want to execute while the button is held.
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isHolding = true;
        Debug.Log("Button pressed.");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isHolding = false;
        rb.moveInput = 0;
        Debug.Log("Button released.");
    }
}
