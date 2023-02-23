using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ToggleInteraction : MonoBehaviour
{
    public GameObject rightHandRayInteractor;
    public GameObject rightHandDirectInteractor;

    void Start()
    {
         //rightHandRayInteractor = GetComponent<>;
        /* _teleportationProvider = GetComponent<TeleportationProvider>();
        _countiniousMoveProvider = GetComponent<ContinuousMoveProviderBase>();
        _continuousTurnProvider = GetComponent<ActionBasedContinuousTurnProvider>();
        _snapTurnProvider = GetComponent<ActionBasedSnapTurnProvider>(); */
    }
    public void SwitchInteraction(int interactionValue)
    {
        if (interactionValue == 0)
        {
            DisableRayGrab();
            EnableDirectGrab();
        }
        else if (interactionValue == 1)
        {
            DisableDirectGrab();
            EnableRayGrab();
        }
    }

    private void DisableRayGrab()
    {
        rightHandRayInteractor.SetActive(false);   
    }

    private void EnableRayGrab()
    {
        rightHandRayInteractor.SetActive(true);
    }

    private void DisableDirectGrab()
    {
        rightHandDirectInteractor.SetActive(false);
    }

    private void EnableDirectGrab()
    {
        rightHandDirectInteractor.SetActive(true);
    }
}
