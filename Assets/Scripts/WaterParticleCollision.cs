using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UnitySimpleLiquid
{
    public class WaterParticleCollision : MonoBehaviour
    {
        public ParticleSystem waterStream;
        private bool ok;
        public LiquidContainer liquidContainer;


        void OnParticleCollision(GameObject other)
        {
            if (other.tag == "Water")
            {
                Debug.Log("Water");
                if (liquidContainer.fillAmountPercent <= 1f)
                {
                    Debug.Log("Entered3");
                    liquidContainer.FillAmountPercent += 0.025f;
                }
            }
            
            

        }


    }
}