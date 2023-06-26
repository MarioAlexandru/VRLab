using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActivateTeleportationRay : MonoBehaviour
{

    public GameObject rightTeleportation;

    public InputActionProperty rightActivate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rightTeleportation.SetActive(rightActivate.action.ReadValue<float>() > 0.1f);
    }
}
