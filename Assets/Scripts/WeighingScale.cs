using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WeighingScale : MonoBehaviour
{
    public TextMeshProUGUI weightText; 

    private float totalWeight; 
    
    void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = other.attachedRigidbody;
        if (rb != null)
        {
            totalWeight += rb.mass*4;
            UpdateWeightText();
            Debug.Log("enter");
        }
    }

    void OnTriggerExit(Collider other)
    {
        Rigidbody rb = other.attachedRigidbody;
        if (rb != null)
        {
            totalWeight -= rb.mass*4;
            UpdateWeightText();
            Debug.Log("exit");
        }
    }

    void UpdateWeightText()
    {
        weightText.text =  totalWeight.ToString() +" g" ;
    }
}