using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnitySimpleLiquid
{
    public class Crystalize : MonoBehaviour
    {   
        
        private LiquidContainer liquidContainer;
        public GameObject crystal;
        
        private bool isCapp = false;
        public Animator anim;
        bool played=false;
        //private GameObject cap;


        private void Start()
        {
            liquidContainer = GetComponent<LiquidContainer>();
            
        }
        private void OnCollisionEnter(Collision collision)
        {
            
            if (collision.gameObject.tag == "Cap")
            {
                anim.SetBool("isPlay", true);
            }
        }
        private void OnCollisionExit(Collision collision)
        {
            if (collision.gameObject.tag == "Cap")
            {
                anim.SetBool("isPlay", false);
            }
        }
        private void Update()
        {
            
        }
        IEnumerator wait()
        {
            yield return new WaitForSeconds(5f * Time.deltaTime);
        }
    }
}
