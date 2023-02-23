using UnityEngine;
using UnityEngine.InputSystem;

public class WristMenu : MonoBehaviour
{
    public InputActionAsset inputActions;

    private Canvas _wristUICanvas;
    private InputAction _menu;

    //public GameObject wristUI;
    //public bool activeWristUI = true;

    void Start()
    {
       _wristUICanvas = GetComponent<Canvas>();
       _menu = inputActions.FindActionMap("XRI LeftHand Interaction").FindAction("Menu");
       _menu.Enable();
       _menu.performed += ToggleMenu;         
    }      
    private void OnDestroy()
    {
        _menu.performed -= ToggleMenu;
    }

    public void ToggleMenu(InputAction.CallbackContext context)
    {
       
        _wristUICanvas.enabled = !_wristUICanvas.enabled;
    }
}
