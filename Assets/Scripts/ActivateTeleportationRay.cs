using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class ActivateTeleportationRay : MonoBehaviour
{
   
    public GameObject rightTeleportation;

    public InputActionProperty rightActivate;
    // Start is called before the first frame update
    public XRRayInteractor rightRay;

    // Update is called once per frame
    void Update()
       
    {
       
            bool isRightRayHovering = rightRay.TryGetHitInfo(out Vector3 rightPos, out Vector3 rightNormal, out int rightNumber, out bool rightValid);
            rightTeleportation.SetActive(isRightRayHovering && rightActivate.action.ReadValue<float>() > 0.1f);
       
    }
}
