using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spoon : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Copper")
        {
            collision.gameObject.transform.SetParent(this.transform);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Copper")
        {
            collision.gameObject.transform.parent = null;
        }
    }
}
