using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalBillboard : MonoBehaviour
{
    
    private GameObject Xrcamera;
    [SerializeField]
    Transform target;
    
    // Start is called before the first frame update
    void Start()
    {
        Xrcamera = GameObject.FindGameObjectWithTag("MainCamera");
        target = Xrcamera.transform;
       
    }

    // Update is called once per frame
    public void Update()
    {
        transform.LookAt(target, Vector3.up);
    }
}
