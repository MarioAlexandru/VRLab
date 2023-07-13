using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temperature : MonoBehaviour


{
    //Material dizzolve;
    [SerializeField]
    public float temperature;
    //float percentDizzolve;
    

    private void Start()
    {
        temperature = 16f;
        
    }
    private void Update()
    {
        if (temperature > 16f)
        {
            temperature -= 0.1f*Time.deltaTime;
            
        }

        
    }
    

    private void OnParticleCollision(GameObject other)
    {
        if(temperature < 40f)
        {
            if (other.tag == "Flame")
            {
                temperature += 5f*Time.deltaTime;
            }
        }
        
    }

}
//daca temp >12 scade pana ajunge la 12
//mai mare decat 12 sa creasca
