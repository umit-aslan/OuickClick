using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Rigidbody), typeof(BoxCollider))]
public class Target : MonoBehaviour
{
    Rigidbody rb;//rigidbody
    [SerializeField]
    ParticleSystem[] explosion;//particle system for explosion

    Game_Manager gameManager;//Game_Manager script

    
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();//get rigidbody
        gameManager=FindObjectOfType<Game_Manager>();//get Game_Manager script
    }
    
    void Start()
    {
        transform.position = new Vector3(Random.Range(-2.30f, 2.30f), 0, 0);//set random position
        rb.AddForce(Vector3.up * Random.Range(10,15), ForceMode.Impulse);//add force to rigidbody
        rb.AddTorque(Random.Range(-1,1), Random.Range(-1,1), Random.Range(-1,1), ForceMode.Impulse);//add torque to rigidbody
    }

    private void OnMouseDown()//when mouse is down
    {
        Instantiate(explosion[Random.Range(0,9)], transform.position, Quaternion.identity);//instantiate explosion
        gameManager.audioSource.Play();//play audio
        Destroy(gameObject);//destroy gameObject
        if (gameObject.tag == "Good")//if gameObject is good
        {
           gameManager.score+=100;//add 100 to score
           gameManager.scoreText.GetComponent<Text>().text = "Score: " + gameManager.score;//set score text
        } 
        else if (gameObject.tag == "Bad")//if gameObject is bad
        {
            gameManager.score-=100;//subtract 100 from score
            gameManager.scoreText.GetComponent<Text>().text = "Score: " + gameManager.score;//set score text
        }
    }
}
