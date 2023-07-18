using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marbles : MonoBehaviour
{
    public GameObject Marble;
    private float count;
    public GameObject beaker;


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("entered");
        if (other.tag == "Marble")
            count += 1;
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Marble")
            count -= 1;
        if (count == 0)
        {
            Instantiate(Marble, beaker.transform.position, Quaternion.identity);
        }

    }
    private void Update()
    {
        
    }





}
