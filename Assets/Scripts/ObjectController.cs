using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
   public int counter=0;
    private void OnTriggerEnter(Collider other)//when object enters collider
    {
        if (other.gameObject.tag=="Good")//if object is good
        {
            counter++;//add 1 to counter
        }    
    }
}
