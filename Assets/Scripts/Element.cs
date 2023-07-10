using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Element : MonoBehaviour
{
    [SerializeField] private string elementName;
    [SerializeField] private string symbol;
    [SerializeField] private string flameColour;
    [SerializeField] private GameObject particlePrefab;



    public string Symbol { get => symbol; }
    public string ElementName { get => elementName; }

    public string FlameColour { get => flameColour; }

    public GameObject ParticlePrefab { get => particlePrefab; }
    public Material Material1;
    //in the editor this is what you would set as the object you wan't to change
    public GameObject Object;

    private void OnTriggerEnter(Collider other)
    {
        Object.GetComponent<MeshRenderer>().material = Material1;
    }

}
