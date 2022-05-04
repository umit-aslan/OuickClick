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
    void Start()
    {
        StartCoroutine(Spawn());
    }
   


    IEnumerator Spawn()
    {
        while (!gameOver)
        {
                yield return new WaitForSeconds(1);
                int random = Random.Range(0, targets.Length);
                Instantiate(targets[random], transform.position, Quaternion.identity);
                if (objectController.counter >=3 )
                {
                    gameOver = true;
                    gameOverPanel.SetActive(true);
                }
        }
    }
    public void restartGame()
    {
        SceneManager.LoadScene(0);
    }
    
}
