using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Game_Manager : MonoBehaviour
{
    [SerializeField]
    GameObject[] targets;
    bool gameOver = false;
    public GameObject gameOverPanel; 
    public ObjectController objectController;

    public int score=0;
    public GameObject scoreText;
    void Start()
    {
        StartCoroutine(Spawn());//start coroutine
        scoreText = GameObject.FindGameObjectWithTag("textScore");//get score text
    }
    IEnumerator Spawn()//spawn coroutine
    {
        while (!gameOver)//while game is not over
        {
                yield return new WaitForSeconds(1);//wait for 1 second
                int random = Random.Range(0, targets.Length);//get random number
                Instantiate(targets[random], transform.position, Quaternion.identity);//instantiate target
                if (objectController.counter >=3 ||score<0 )//if counter is 3 or score is less than 0
                {
                    gameOver = true;//set gameOver to true
                    gameOverPanel.SetActive(true);//set gameOverPanel to true
                }
        }
    }
    public void restartGame()//restart game
    {
        SceneManager.LoadScene(0);//load scene 0
    }  
}
