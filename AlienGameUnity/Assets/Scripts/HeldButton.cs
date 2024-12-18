using UnityEngine;
using UnityEngine.UI; // Required when referring to the Button component
using UnityEngine.EventSystems; // Required when using Event data.

// This line means that this script can only be attached to 
// a GameObject that has a Button component on it
[RequireComponent(typeof(Button))]
// The additional things in this list (IPointerDownHandler etc) let us 
// respond to more mouse / touch events happening to this object
public class HeldButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerExitHandler
{
    // We'll store our Button here so we can use it
    private Button _button;

    // We'll keep track of whether or not the button is pressed here
    private bool buttonPressed = false;

    // This function is called when the script first loads, before any Start methods
    private void Awake()
    {
        // When the object first starts, 
        _button = GetComponent<Button>();
    }

    // This function is called every frame
    private void Update()
    {
        // If the button is currently pressed...
        if (buttonPressed)
            // ... Consider the button "clicked" and call the function linked on the Button component.
            _button.onClick?.Invoke();
    }

    // This function is called when the button is clicked by the mouse or a touch
    public void OnPointerDown(PointerEventData eventData)
    {
        // ignore if button not interactable
        if (!_button.interactable) return;

        // Set the button as pressed
        buttonPressed = true;

    }

    // This function is called when the mouse or touch is released
    public void OnPointerUp(PointerEventData eventData)
    {
        // Set the button as NOT pressed
        buttonPressed = false;
    }

    // This function is called when the mouse or touch move off the button
    public void OnPointerExit(PointerEventData eventData)
    {
        // Set the button as NOT pressed
        buttonPressed = false;
    }
}