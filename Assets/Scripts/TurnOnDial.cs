using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.XR.Content.Interaction
{
    public class TurnOnDial : MonoBehaviour
    {
        [SerializeField]
        private ParticleSystem particles;
        
        private float value;

        // Start is called before the first frame update
        
        private void Update()
        {
            value = GetComponent<XRKnob>().value;
            if (value ==0f)
            {
                
                particles.Stop();
            }
            else if(value==1f)
            { 
                particles.Play(); 
            }
        }
    }
}
