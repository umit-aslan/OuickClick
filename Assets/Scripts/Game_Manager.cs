using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{
  [SerializeField]
  GameObject[] targets;
    void Start()
    {
        StartCoroutine(Spawn());
    }

 
    void Update()
    {
        
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            int random = Random.Range(0, targets.Length);
            Instantiate(targets[random], transform.position, Quaternion.identity);
        }
    }
}
