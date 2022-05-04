using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody), typeof(BoxCollider))]
public class Target : MonoBehaviour
{
    Rigidbody rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Start()
    {
        transform.position = new Vector3(Random.Range(-2.30f, 2.30f), 0, 0);
        rb.AddForce(Vector3.up * Random.Range(7,15), ForceMode.Impulse);
        rb.AddTorque(Random.Range(-1,1), Random.Range(-1,1), Random.Range(-1,1), ForceMode.Impulse);
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
