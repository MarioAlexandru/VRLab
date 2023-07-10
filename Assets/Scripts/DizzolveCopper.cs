using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnitySimpleLiquid
{

    public class DizzolveCopper : MonoBehaviour
    {

        //[SerializeField] [Range(0f, 1f)] float lerpTime;
        //[SerializeField] Color color;
        public MeshRenderer liquidRenderer;
        public GameObject obiectShake;
        bool ok = false;
       
        public Material Dizzolve;
        public Material Liquid;
        public LiquidContainer liquidContainer;
        public Animator liquidAnimator;
        bool hasWater;
        float dizzolvePercent;
        bool isInCollision;
        
        public Color startColor;
        public Color targetColor;
        public float changeDuration = 0.6f;
        //public Renderer renderer;
        private float startTime;
        private bool i = false;


        private void Start()
        {
            Liquid.SetColor("Color", startColor);
            dizzolvePercent = 0;
            if (liquidContainer.fillAmountPercent > 0f)
            {
                Debug.Log("true");
                hasWater = true;
            }
            Dizzolve.SetFloat("_dizzolvePercent", dizzolvePercent);
            //Dizzolve.SetColor("_baseColor", startColor);

        }

        private void OnCollisionEnter(Collision collision)
        {

            Debug.Log("dhia");

            isInCollision = true;
        }


        void Fade()
        {
            Debug.Log(dizzolvePercent);

            if (dizzolvePercent < 1)
            {
                dizzolvePercent = dizzolvePercent + 1f * Time.deltaTime;
                Dizzolve.SetFloat("_dizzolvePercent", dizzolvePercent);
            }

        }
        void Update()
        {
            if(liquidContainer.fillAmountPercent>0 && isInCollision)
            {
                Debug.Log("Start Shake1233123");

                if ((obiectShake.transform.rotation.eulerAngles.z < 70 && obiectShake.transform.rotation.eulerAngles.z > 30) ||
             (obiectShake.transform.rotation.eulerAngles.x > -70 && obiectShake.transform.rotation.eulerAngles.x < -30))
                
                    {
                    Fade();
                    
                    Debug.Log("Start Shake");
                    startTime = Time.time;
                    i = true;
                }
                
                if (i )
                {

                    float curTime = Time.time - startTime;

                   if (curTime <= changeDuration)
                    {
                        Debug.Log("iudhbfuiu");

                        liquidAnimator.Play("New Animation");
                        //liquidRenderer.material.SetColor("_Color", Color.Lerp(startColor,targetColor, curTime/changeDuration));
                    }
                   else
                   {
                        
                       // Change the color to the target color when the duration is exceeded
                       liquidRenderer.material.SetColor("_Color",  targetColor);
                       i = false;
                   }
                }
            }
            
        }


    }
}
//Material myMaterial;
//float someValue;

//myMaterial.SetFloat("MyPropertyName", someValue);
