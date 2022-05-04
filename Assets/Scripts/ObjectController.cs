using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
   public int counter=0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Good")
        {
            counter++;
        }    
    }
}
