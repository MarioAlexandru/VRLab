using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UnitySimpleLiquid
{
    public class WaterParticleCollisionForGlassCup : MonoBehaviour
    {
        public GameObject otherCup;
        public LiquidContainer liquidContainer;


        void OnParticleCollision(GameObject other)
        {
            if (other.tag == "Water")
            {
                Debug.Log("Water");
                if (liquidContainer.fillAmountPercent <= 1f && otherCup.GetComponent<DizzolveSulf>().dizzolvePercent>=0.95f)
                {
                    Debug.Log("Entered3");
                    liquidContainer.FillAmountPercent += 0.15f*Time.deltaTime;
                }
            }
            
            

        }


    }
}
