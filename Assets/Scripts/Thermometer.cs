using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Thermometer : MonoBehaviour
{
    float temperature;
    TextMeshProUGUI text;
    [SerializeField]
    private GameObject cup;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        temperature = cup.GetComponent<Temperature>().temperature;
    }

    // Update is called once per frame
    void Update()
    {
        
        temperature = cup.GetComponent<Temperature>().temperature;
        text.text = temperature.ToString()+ "C°";

    }
}
