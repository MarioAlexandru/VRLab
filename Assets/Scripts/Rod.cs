using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rod : MonoBehaviour
{
    public Transform flameSpawn;

    private Element selectedElement;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("entered");
        if (other.gameObject.CompareTag("Element"))
        {
            selectedElement = other.gameObject.GetComponent<Element>();
            if (selectedElement != null)
            {
                GameManager.Instance.ShowSelectedElement(selectedElement);
            }
        }else if (other.gameObject.CompareTag("Flame"))
        {
            if (selectedElement != null)
            {
                GameManager.Instance.ShowElementColour(selectedElement);
                foreach(Transform child in flameSpawn)
                {
                    Destroy(child.gameObject);
                }
                GameObject flame = Instantiate(selectedElement.ParticlePrefab, flameSpawn);
                flame.transform.localPosition = Vector3.zero;
                flame.transform.localRotation = Quaternion.Euler(-90f,0f,0f);

                selectedElement = null;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Flame"))
        {
            GameManager.Instance.HideElementText();
            foreach(Transform child in flameSpawn)
            {
                child.GetComponent<ParticleSystem>().Stop();
            }
        }
    }




}