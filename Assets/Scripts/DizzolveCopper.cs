using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

namespace UnitySimpleLiquid
{

    public class DizzolveCopper : MonoBehaviour
    {

        //[SerializeField] [Range(0f, 1f)] float lerpTime;
        //[SerializeField] Color color;
        public MeshRenderer liquidRenderer;
        public GameObject obiectShake;
        public GameObject water;
        //bool ok = false;
        Temperature temp;
        public ParticleSystem aburi;


        public Material Dizzolve;
        public Material Liquid;
        Material dizzolveCopy;
        Material liquidCopy;
        public LiquidContainer liquidContainer;
        public Animator liquidAnimator;
        //bool hasWater;
        //bool isDizzolved;
        float dizzolvePercent = 0;
        bool isInCollision;
        
        public Color startColor;
        public Color targetColor;
        public float changeDuration = 0.6f;
        //public Renderer renderer;
        private float startTime;
        private bool i = false;
        private GameObject cube;
        MaterialPropertyBlock colorChange;

        private void Awake()
        {
            dizzolveCopy = new Material(Dizzolve);
            liquidCopy = new Material(Liquid);
            colorChange = new MaterialPropertyBlock();
        }
        private void Start()
        {
            temp = GetComponent<Temperature>();
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Copper")
            {
                cube = collision.gameObject;
                cube.GetComponent<Renderer>().material = dizzolveCopy;
                cube.transform.SetParent(this.transform);
                isInCollision = true;
            }
            else
                isInCollision = false;
            
        }

        private void OnCollisionExit(Collision collision)
        {
            if(collision.gameObject == cube)
            {
                cube.transform.parent = null;
            }
        }

        void Fade()
        {
            Debug.Log(dizzolvePercent);

            if (dizzolvePercent < 1)
            {
                dizzolvePercent = dizzolvePercent + 1f * Time.deltaTime;
                dizzolveCopy.SetFloat("_dizzolvePercent", dizzolvePercent);
            }

        }
        void Update()
        {
            if (liquidContainer.fillAmountPercent>0 && isInCollision)
            {
                if ((obiectShake.transform.rotation.eulerAngles.z < 70 && obiectShake.transform.rotation.eulerAngles.z > 30) ||
             (obiectShake.transform.rotation.eulerAngles.x < 70 && obiectShake.transform.rotation.eulerAngles.x > 30))
                
                 {
                    Fade();
                    Debug.Log("Start Shake");
                    startTime = Time.time;
                    i = true;
                }
                
                if (i )
                {   
                   if (dizzolvePercent<1f)
                    {
                        colorChange.SetColor("_Color", Color.Lerp(startColor, targetColor, dizzolvePercent));
                        water.GetComponent<Renderer>().SetPropertyBlock(colorChange, 0);
                    }
                }
            }

            if (dizzolvePercent >=1 && temp.temperature >= 30f)
            {
                liquidContainer.FillAmountPercent -= 0.025f * Time.deltaTime;
                if(!aburi.isPlaying)
                {
                    aburi.Play();    
                }
            }
            if(liquidContainer.fillAmountPercent == 0 && aburi.isPlaying)
            {
                aburi.Stop();

                if (cube == null)

                {
                    Instantiate(cube);
                }
                dizzolvePercent = 0f;
                dizzolveCopy.SetFloat("_dizzolvePercent", dizzolvePercent);
            }
            if(liquidContainer.fillAmountPercent == 0)
            {
                if(dizzolvePercent >= 1)
                {
                    if(cube != null)
                    {
                        Destroy(cube);
                    }
                }

               colorChange.SetColor("_Color", startColor);
               water.GetComponent<Renderer>().SetPropertyBlock(colorChange, 0);
               i = false;
            }
        }


    }
}