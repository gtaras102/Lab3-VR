using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LocomotionToggle : MonoBehaviour
{
    public GameObject leftRayTeleport;
    //public GameObject rightRayTeleport;

    private TeleportationProvider _teleportationProvider;
    private ContinuousMoveProviderBase _countiniousMoveProvider;
    private ActionBasedSnapTurnProvider _snapTurnProvider;
    private ActionBasedContinuousTurnProvider _continuousTurnProvider;

    // Start is called before the first frame update
    void Start()
    {
        _teleportationProvider = GetComponent<TeleportationProvider>();
        _countiniousMoveProvider = GetComponent<ContinuousMoveProviderBase>();  
        _continuousTurnProvider = GetComponent<ActionBasedContinuousTurnProvider>();
        _snapTurnProvider = GetComponent<ActionBasedSnapTurnProvider>();    
    }

    public void SwitchLocomotion(int locomotionValue)
    {
        if (locomotionValue == 0)
        {
            DisableContinuous();
            EnableTeleport();
        }
        else if (locomotionValue == 1)
        {
            DisableTeleport();
            EnableContinuous();
        }
    }

    private void DisableTeleport()
    {
        leftRayTeleport.SetActive(false);
        //rightRayTeleport.SetActive(false);
        _teleportationProvider.enabled = false;
        _snapTurnProvider.enabled = false;
    }

    private void EnableTeleport()
    {
        leftRayTeleport.SetActive(true);
        //rightRayTeleport.SetActive(true);
        _teleportationProvider.enabled = true;
        _snapTurnProvider.enabled = true;
    }

    private void DisableContinuous()
    {
        _countiniousMoveProvider.enabled = false;
        _continuousTurnProvider.enabled = false;
    }

    private void EnableContinuous()
    {
        _countiniousMoveProvider.enabled = true;
        _continuousTurnProvider.enabled = true;
    }
}
