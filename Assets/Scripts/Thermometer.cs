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
        string temperatureString = "16";
        temperature = cup.GetComponent<Temperature>().temperature;
        if (temperature > 16)
        {
            string[] split = temperature.ToString().Split(new char[] { '.' });
            string decimals = split[1].ToString().Substring(0,1);
            temperatureString = split[0] + '.' + decimals;
        }
        text.text = temperatureString + "C°";

    }
}
